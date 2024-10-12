using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MTGManager.DataAccess.Database;
using MTGManager.DataAccess.Repository;
using MTGManager.DataAccess.Repository.IRepository;
using MTGManager.DataSeed;

var host = CreateHostBuilder(args).Build();

// Start the JSON processing using DI
using (var scope = host.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var unitOfWork = services.GetRequiredService<IUnitOfWork>();

    string jsonFilePath = @"C:\Users\x5ahg\Downloads\all-cards-20241006092412.json";

    JsonSeed seed = new(unitOfWork);
    await seed.ProcessLargeJsonFile(jsonFilePath);

}

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MTGManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")) // Add your connection string here
            .AddScoped<IUnitOfWork, UnitOfWork>() // Register UnitOfWork
        );