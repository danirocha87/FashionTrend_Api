﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceExtensions
{
    public static void ConfigurePersistenceApp(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Sqlite");

        services.AddDbContext<AppDbContext>(options => options
        .UseSqlite(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ISupplierRepository, SupplierRepository>();
        services.AddScoped<IServiceRepository, ServiceRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IServiceOrderRepository, ServiceOrderRepository>();
        services.AddScoped<IKafkaProducer, KafkaProducer>();
        services.AddScoped<IKafkaConsumer, KafkaConsumer>();
        services.AddScoped<IDraftContractRepository, DraftContractRepository>();
        services.AddScoped<IContractRepository, ContractRepository>();

    }
}
