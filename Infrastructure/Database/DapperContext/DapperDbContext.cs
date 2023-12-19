using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Infrastructure.Database.DapperContext;

public class DapperDbContext
{
    private readonly IConfiguration _configuration;

    private readonly string _connectionString;

    public DapperDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("HospitalManagementDb") ??
            throw new("Connection string is null");
    }

    public IDbConnection Connection =>
        new SqlConnection(_configuration.GetConnectionString("HospitalManagementDb"));

}
