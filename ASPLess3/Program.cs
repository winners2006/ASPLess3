using ASPLess3.Abstraction;
using ASPLess3.Data;
using ASPLess3.Mapper;
using ASPLess3.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StorageContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("db")));
builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<IProductGroupRepository, ProductGroupRepository>();
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddGraphQLServer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
