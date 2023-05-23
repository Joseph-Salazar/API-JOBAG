using Domain.MainModule.Entity;
using Domain.MainModule.IRepository;
using Infrastructure.Data.MainModule.Context;

namespace Infrastructure.Data.MainModule.Repository;

public class CompanyRepository : GenericRepository<Company, int>, ICompanyRepository
{
    public CompanyRepository(MainContext mainContext) : base(mainContext)
    {

    }
}