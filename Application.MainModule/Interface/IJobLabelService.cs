using Application.Dto.JobLabel;

namespace Application.MainModule.Interface;

public interface IJobLabelService
{
    Task<JobLabelDto> GetById(int jobLabelId);
    Task<string> Add(AddJobLabelDto jobLabelDto);
    Task<string> Update(JobLabelDto updateJobLabelDto);
}