using AmusementPark.Core.InterfaceRepository;
using AmusementPark.Core.InterfaceService;
using AmusementPark.Core.Entities;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using AmusementPark.Service;
using AmusementPark.Data.Repositories;
using AmusementPark.Data;
using Microsoft.EntityFrameworkCore;
using AmusementPark.Core;
using AmusementPark.Core.DTOs;


namespace AmusementPark.Extesion
{
    public static class ExtesionService
    {
        public static void ServiceDependency(this IServiceCollection s)
        {
            s.AddDbContext<DataContext>(option =>
            {
                option.UseSqlServer("Data Source = DESKTOP-SSNMLFD; Initial Catalog = AmusementPark; Integrated Security = true; ");
            });

            s.AddScoped<Iservice<CustomerDto>, CustomerService>();
            s.AddScoped<Iservice<EmployeeDto>, EmployeeService>();
            s.AddScoped<Iservice<FacilitieDto>, FacilitieService>();
            s.AddScoped<Iservice<OrderDto>, OrderService>();
            s.AddScoped<Iservice<TicketDto>,TicketService>();

            s.AddScoped<ICustomerRepository, CustomerRepository>();
            s.AddScoped<IFacilitieRepository, FacilitieRepository>();
            s.AddScoped<IEmployeeRepository, EmployeeRepository>();
            s.AddScoped<IOrderRepository, OrderRepository>();
            s.AddScoped<ITicketRepository, TicketRepository>();

            s.AddScoped<IRepositoryManager, RepositoryManager>();
            s.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            s.AddAutoMapper(typeof(MappingProfile));
        }
    }
}

