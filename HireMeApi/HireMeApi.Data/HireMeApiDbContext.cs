using HireMeApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HireMeApi.Data;

public class HireMeApiDbContext : DbContext
{
    public DbSet<IotDevice> IotDevices => Set<IotDevice>();
    
    public HireMeApiDbContext(DbContextOptions<HireMeApiDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IotDevice>(
            entity =>
            {
                entity.HasKey(i => i.Id);

                var existingDevices = new List<IotDevice>();
                for (var i = 0; i < 10; i++)
                {
                    existingDevices.Add(new IotDevice(Guid.NewGuid(), $"Device {i + 1}")
                    {
                        Description = $"This is a very long description about device {i + 1}"
                    });
                }

                entity.HasData(existingDevices);
            }
        );
    }
}
