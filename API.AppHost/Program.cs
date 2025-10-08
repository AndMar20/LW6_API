var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Gateway>("gateway");

builder.AddProject<Projects.OrderService>("orderservice");

builder.AddProject<Projects.ProductService>("productservice");

builder.Build().Run();
