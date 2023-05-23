using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Infrastructure.Data.MainModule.Context;

namespace Infrastructure.Data.MainModule.Repository;

public class SavedJobOfferRepository : GenericRepository<SavedJobOffers, int>, ISavedJobOfferRepository
{
    public SavedJobOfferRepository(MainContext mainContext) : base(mainContext)
    {

    }
}