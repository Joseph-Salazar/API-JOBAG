using Application.Dto.JobLabel;
using Application.MainModule.Interface;
using Infrastructure.CrossCutting.Wrapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Distributed.Services.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JobLabelController : CoreController
{
    private readonly IJobLabelService _jobLabelService;

    public JobLabelController(IJobLabelService jobLabelService)
    {
        _jobLabelService = jobLabelService;
    }

    [AllowAnonymous]
    [HttpGet("Get")]
    [ProducesResponseType(typeof(JsonResult<JobLabelDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetById(int jobLabelId)
    {
        var result = await _jobLabelService.GetById(jobLabelId);
        return new OkObjectResult(new JsonResult<JobLabelDto>(result));
    }

    [HttpPost(nameof(Add))]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Add([FromBody] AddJobLabelDto jobLabelDto)
    {
        var response = await _jobLabelService.Add(jobLabelDto);
        return new OkObjectResult(new JsonResult<string>(response));
    }

    [HttpPut(nameof(Update))]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(JsonResult<string>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update([FromBody] JobLabelDto updateJobLabelDto)
    {
        var response = await _jobLabelService.Update(updateJobLabelDto);
        return new OkObjectResult(new JsonResult<string>(response));
    }
}