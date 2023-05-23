using System.Security.Cryptography;
using Application.Core;
using Application.Dto.Company;
using Application.MainModule.Interface;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Domain.MainModule.Validations.CompanyValidations;
using Hangfire.MemoryStorage.Dto;
using Infrastructure.CrossCutting.Constants;
using Infrastructure.CrossCutting.CustomExections;
using Infrastructure.CrossCutting.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.MainModule;

public class CompanyAppService : BaseAppService, ICompanyAppService
{
    private readonly ICompanyRepository _companyRepository;

    public CompanyAppService(
        IServiceProvider serviceProvider) : base(serviceProvider)
    {
        _companyRepository = serviceProvider.GetService<ICompanyRepository>() ?? throw new InvalidOperationException();
    }

    public async Task<CompanyDto> GetById(int companyId)
    {
        if (companyId == 0)
            throw new WarningException(MessageConst.InvalidSelection);

        var companyDto = await _companyRepository
            .Find(p => p.Id == companyId)
            .ProjectTo<CompanyDto>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();

        if (companyDto is null)
            throw new WarningException(MessageConst.InvalidSelection);

        return companyDto;
    }

    public async Task<string> Add(AddCompanyDto companyDto)
    {
        var newCompany = Mapper.Map<Company>(companyDto);
        await _companyRepository.AddAsync(newCompany, new AddCompanyValidator(_companyRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }

    public async Task<string> Update(CompanyDto companyDto)
    {
        var companyDomain = await _companyRepository.GetAsync(companyDto.Id);

        if (companyDomain is null)
            throw new WarningException(MessageConst.InvalidSelection);

        Mapper.Map(companyDto, companyDomain);

        await _companyRepository.UpdateAsync(companyDomain, new AddCompanyValidator(_companyRepository));
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }

    public async Task<string> Register(RegisterCompanyDto registerCompanyDto)
    {
        if (_companyRepository.GetAll().Any(x => x.Email == registerCompanyDto.Email))
        {
            throw new WarningException(MessageConst.EmailAlreadyExists);
        }

        CreatePasswordHash(registerCompanyDto.Password,
            out byte[] passwordHash,
            out byte[] passwordSalt);

        var companyRegister = new Company
        {
            Email = registerCompanyDto.Email,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt,
            VerificationToken = CreateRandomToken()
        };

        await _companyRepository.AddAsync(companyRegister);
        await UnitOfWork.SaveChangesAsync();

        return MessageConst.ProcessSuccessfullyCompleted;
    }

    public async Task<string> Login(LoginCompanyDto registerCompanyDto)
    {
        var loginCompany =
            await _companyRepository.GetAll().FirstOrDefaultAsync(u => u.Email == registerCompanyDto.Email);

        if (loginCompany is null)
        {
            return MessageConst.InvalidLogin;
        }

        if (!VerifyPasswordHash(registerCompanyDto.Password, loginCompany.PasswordHash, loginCompany.PasswordSalt))
        {
            return MessageConst.InvalidLogin;
        }

        return MessageConst.ProcessSuccessfullyCompleted;
    }

    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash
                (System.Text.Encoding.UTF8.GetBytes(password));
        }
    }

    private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512(passwordSalt))
        {
            var computedHash = hmac.ComputeHash
                (System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }
    }

    private string CreateRandomToken()
    {
        return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
    }
}