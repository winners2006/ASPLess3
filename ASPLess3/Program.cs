using ASPLess3.Abstraction;
using ASPLess3.Data;
using ASPLess3.Graph.Mutation;
using ASPLess3.Graph.Query;
using ASPLess3.Mapper;
using ASPLess3.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<StorageContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("db")));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductGroupRepository, ProductGroupRepository>();
builder.Services.AddScoped<IStorageRepository, StorageRepository>();
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddMemoryCache();
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapGraphQL();
app.Run();
