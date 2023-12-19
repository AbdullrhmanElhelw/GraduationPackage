using Domain.Entites;
using Infrastructure.DapperQueries.BaseQueries;
using Infrastructure.Database.DapperContext;

namespace Infrastructure.DapperQueries.PatientQueries;

public class PatientQuery(DapperDbContext context) : BaseQuery<Patient>(context), IPatientQuery
{
    private readonly DapperDbContext _context = context;
}
