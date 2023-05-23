using System.Reflection;
using Application.IoC;
using Application.MainModule.AutoMapper;
using Application.MainModule.Hangfire;
using Application.Security.JsonWebToken;
using FluentValidation.AspNetCore;
using Infrastructure.CrossCutting.JsonConverter;
using Infrastructure.CrossCutting.Logging;
using Infrastructure.CrossCutting.Wrapper;
using Infrastructure.Data.MainModule.Context;
using Infrastructure.Email;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using Stimulsoft.Base;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration
    .ReadFrom.Configuration(builder.Configuration));

// Add services to the container.
builder.Services.AddDbContext<MainContext>(opts =>
    //opts.UseInMemoryDatabase("jobagapi"));
    opts.UseMySql("server=localhost;database=jobag;user=root;password=root;port=3306",
        new MySqlServerVersion(new Version()), b => b.MigrationsAssembly("Distributed.Services")));
    //opts.UseSqlServer("server=bmoiiwtntdi7cbmqd02u-mysql.services.clever-cloud.com;port=3306;database=bmoiiwtntdi7cbmqd02u;uid=usrgzcojkoczyrt2;password=QRd8zHCQlP2U8CSeTkX3", b=>b.MigrationsAssembly("Distributed.Services")));

builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration).GetTypeInfo().Assembly);
builder.Services.Configure<JwtIssuerOptions>(builder.Configuration.GetSection("JwtIssuerOptions"));
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.AddDependencyInjectionInterfaces();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new DateTimeConverter());
        options.JsonSerializerOptions.Converters.Add(new TrimStringConverter());
    })
    .ConfigureApiBehaviorOptions(options =>
    {
        options.InvalidModelStateResponseFactory = context =>
        {
            var errors = context.ModelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage)).ToList();

            return new BadRequestObjectResult(new JsonResult<string> { Message = errors[0] });
        };
    });

builder.Services.AddFluentValidationAutoValidation().AddHangfireConfig().AddHttpContextAccessor();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options =>
{
    var urlList = builder.Configuration.GetSection("AllowedOrigin").GetChildren().ToArray()
        .Select(c => c.Value.TrimEnd('/'))
        .ToArray();
    options.AddPolicy("CorsPolicy",
        p => p.WithOrigins(urlList)
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo {Title = "Jobag", Version = "v1"});
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

EmailTemplates.Initialize(app.Environment);

app.UseCors("CorsPolicy");

app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();