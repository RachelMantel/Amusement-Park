using AmusementPark.Core;
using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceRepository;
using AmusementPark.Core.InterfaceService;
using AmusementPark.Data.Repositories;
using AmusementPark.Data;
using AmusementPark.Extesion;
using AmusementPark.Service;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

//builder.Services.AddDbContext<DataContext>(option =>
//{
//    option.UseSqlServer("Data Source = DESKTOP-SSNMLFD; Initial Catalog = AmusementPark; Integrated Security = true; ");
//});

//builder.Services.AddScoped<Iservice<CustomerEntity>, CustomerService>();
//builder.Services.AddScoped<Iservice<EmployeeEntity>, EmployeeService>();
//builder.Services.AddScoped<Iservice<FacilitieEntity>, FacilitieService>();
//builder.Services.AddScoped<Iservice<OrderEntity>, OrderService>();
//builder.Services.AddScoped<Iservice<TicketEntity>, TicketService>();

//builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
//builder.Services.AddScoped<IFacilitieRepository,FacilitieRepository>();
//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddScoped<IOrderRepository, OrderRepository>();
//builder.Services.AddScoped<ITicketRepository, TicketRepository>();
//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();



builder.Services.ServiceDependency();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseAuthorization();

app.MapControllers();

app.Run();
