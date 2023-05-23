using Application.Dto.JobOffer;
using Application.MainModule.Interface;
using Infrastructure.CrossCutting.Wrapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Distributed.Services.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JobOfferController : CoreController
{
    private readonly IJobOfferService _jobOfferService;

    public JobOfferController(IJobOfferService jobOfferService)
    {
        _jobOfferService = jobOfferService;
    }

    [AllowAnonymous]
    [HttpGet("Get")]
    [ProducesResponseType(typeof(JsonResult<JobOfferDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetById(int jobOfferId)
    {
        var result = await _jobOfferService.GetById(jobOfferId);
        return new OkObjectResult(new JsonResult<JobOfferDto>(result));
    }


    [HttpPost(nameof(Add))]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Add([FromBody] AddJobOfferDto jobOfferDto)
    {
        var response = await _jobOfferService.Add(jobOfferDto);
        return new OkObjectResult(new JsonResult<string>(response));
    }

    [HttpPut(nameof(Update))]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update([FromBody] JobOfferDto updateJobOfferDto)
    {
        var response = await _jobOfferService.Update(updateJobOfferDto);
        return new OkObjectResult(new JsonResult<string>(response));
    }
}