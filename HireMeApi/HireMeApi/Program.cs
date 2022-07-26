using HireMeApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

const string corsPolicy = "OfCors";
builder.Services.AddCors(p => p.AddPolicy(corsPolicy, builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

const Environment.SpecialFolder localFolder = Environment.SpecialFolder.LocalApplicationData;
var localPath = Environment.GetFolderPath(localFolder);
var dbPath = Path.Join(localPath, "hireme.db");
builder.Services.AddDbContext<HireMeApiDbContext>(
    options =>
    {
        options.UseSqlite($"Data Source={dbPath}")
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(corsPolicy);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();
await using var dbContext = scope.ServiceProvider.GetRequiredService<HireMeApiDbContext>();
await dbContext.Database.MigrateAsync();

app.Run();

