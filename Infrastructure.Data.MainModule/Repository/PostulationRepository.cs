using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Infrastructure.Data.MainModule.Context;

namespace Infrastructure.Data.MainModule.Repository;

public class PostulationRepository : GenericRepository<Postulation, int>, IPostulationRepository
{
    public PostulationRepository(MainContext mainContext) : base(mainContext)
    {

    }
}