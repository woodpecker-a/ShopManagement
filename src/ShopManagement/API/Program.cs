using Autofac.Extensions.DependencyInjection;
using Autofac;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using System.Reflection;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) => lc
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .ReadFrom.Configuration(builder.Configuration));

try
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    var assemblyName = Assembly.GetExecutingAssembly().FullName;

    builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
    builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => {
        containerBuilder.RegisterModule(new InfrastructureModule(connectionString,
            assemblyName));
        containerBuilder.RegisterModule(new APIModulle());
    });

    //DB = "GTR"
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(connectionString, m => m.MigrationsAssembly(assemblyName)));

    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}

catch(Exception ex)
{

}

finally
{
    
}