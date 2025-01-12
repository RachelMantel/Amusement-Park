using AmusementPark.Core.InterfaceRepository;
using AmusementPark.Core.InterfaceService;
using AmusementPark.Core.Entities;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using AmusementPark.Service;
using AmusementPark.Data.Repositories;
using AmusementPark.Data;
using Microsoft.EntityFrameworkCore;


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

            s.AddScoped<Iservice<CustomerEntity>, CustomerService>();
            s.AddScoped<Iservice<EmployeeEntity>, EmployeeService>();
            s.AddScoped<Iservice<FacilitieEntity>, FacilitieService>();
            s.AddScoped<Iservice<OrderEntity>, OrderService>();
            s.AddScoped<Iservice<TicketEntity>,TicketService>();

            s.AddScoped<ICustomerRepository, CustomerRepository>();
            s.AddScoped<IFacilitieRepository, FacilitieRepository>();
            s.AddScoped<IEmployeeRepository, EmployeeRepository>();
            s.AddScoped<IOrderRepository, OrderRepository>();
            s.AddScoped<ITicketRepository, TicketRepository>();

            s.AddScoped<IRepositoryManager, RepositoryManager>();
            s.AddScoped(typeof(IRepository<>), typeof(Repository<>));

          
        }
    }
}

