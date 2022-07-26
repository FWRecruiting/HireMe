using System.Data.Common;
using HireMeApi.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace HireMeApi.IntegrationTests;

public class TestDbFixture : IDisposable
{
    public DbConnection Connection { get; }

    public TestDbFixture()
    {
        Connection = new SqliteConnection("Filename=:memory:");

        InitDb();

        Connection.Open();
    }

    public HireMeApiDbContext CreateContext(DbTransaction? transaction = null)
    {
        var context = CreateContextInternal();

        if (transaction != null)
        {
            context.Database.UseTransaction(transaction);
        }

        return context;
    }

    public async Task<HireMeApiDbContext> CreateContextAsync(DbTransaction? transaction = null)
    {
        var context = CreateContextInternal();

        if (transaction != null)
        {
            await context.Database.UseTransactionAsync(transaction);
        }

        return context;
    }

    private HireMeApiDbContext CreateContextInternal()
    {
        var optionsBuilder = new DbContextOptionsBuilder<HireMeApiDbContext>().UseSqlite(Connection);
        return new HireMeApiDbContext(optionsBuilder.Options);
    }

    public void Dispose()
    {
        Connection.Dispose();
    }

    private void InitDb()
    {
        using var context = CreateContext();

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
    }
}
