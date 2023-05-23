using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Infrastructure.Data.MainModule.Context;

namespace Infrastructure.Data.MainModule.Repository;

public class JobOfferRepository : GenericRepository<JobOffer, int>, IJobOfferRepository
{
    public JobOfferRepository(MainContext mainContext) : base(mainContext)
    {

    }
}