using HireMeApi.Data;
using Microsoft.EntityFrameworkCore;

namespace HireMeApi.IntegrationTests;

public class BaseTest
{
    protected readonly HireMeApiDbContext DbContext;
    
    public BaseTest()
    {
        var options = new DbContextOptionsBuilder<HireMeApiDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Use unique DB name so it doesn't interfere with other tests
            .Options;

        DbContext = new HireMeApiDbContext(options);
    }
}
