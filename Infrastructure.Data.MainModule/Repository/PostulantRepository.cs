using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Infrastructure.Data.MainModule.Context;

namespace Infrastructure.Data.MainModule.Repository;

public class PostulantRepository : GenericRepository<Postulant, int>, IPostulantRepository
{
    public PostulantRepository(MainContext mainContext) : base(mainContext)
    {

    }
}