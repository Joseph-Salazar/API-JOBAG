using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Infrastructure.Data.MainModule.Context;

namespace Infrastructure.Data.MainModule.Repository;

public class JobLabelRepository : GenericRepository<JobLabel, int>, IJobLabelRepository
{
    public JobLabelRepository(MainContext mainContext) : base(mainContext)
    {

    }
}