using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Infrastructure.Data.MainModule.Context;

namespace Infrastructure.Data.MainModule.Repository;

public class RoleRepository : GenericRepository<Role, int>, IRoleRepository
{
    public RoleRepository(MainContext mainContext) : base(mainContext)
    {

    }
}