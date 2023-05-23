using Application.Dto.Company;
using Application.Dto.Postulant;
using Application.MainModule;
using Application.MainModule.Interface;
using Hangfire.MemoryStorage.Dto;
using Infrastructure.CrossCutting.Constants;
using Infrastructure.CrossCutting.Wrapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Distributed.Services.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostulantController : CoreController
{
    private readonly IPostulantAppService _postulantAppService;

    public PostulantController(IPostulantAppService postulantAppService)
    {
        _postulantAppService = postulantAppService;
    }

    [AllowAnonymous]
    [HttpGet("Login")]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> LoginCompany(string email, string password)
    {
        var response = await _postulantAppService.GetByEmailAndPassword(email, password);
        return new OkObjectResult(new JsonResult<PostulantDto>(response));
    }

    [AllowAnonymous]
    [HttpGet("Get")]
    [ProducesResponseType(typeof(JsonResult<PostulantDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetById(int postulantId)
    {
        var result = await _postulantAppService.GetById(postulantId);
        return new OkObjectResult(new JsonResult<PostulantDto>(result));
    }

    [HttpPost(nameof(Add))]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Add([FromBody] AddPostulantDto postulantDto)
    {
        var response = await _postulantAppService.Add(postulantDto);
        return new OkObjectResult(new JsonResult<string>(response));
    }

    [HttpPost(nameof(Register))]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Register([FromBody] RegisterPostulantDto postulantDto)
    {
        var response = await _postulantAppService.Register(postulantDto);
        return new OkObjectResult(new JsonResult<string>(response));
    }

    [HttpPut(nameof(Update))]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update([FromBody] PostulantDto updatePostulantDto)
    {
        var response = await _postulantAppService.Update(updatePostulantDto);
        return new OkObjectResult(new JsonResult<string>(response));
    }
}