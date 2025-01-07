
using Amusement_park;
using AmusementPark.Core.InterfaceRepository;
using AmusementPark.Core.InterfaceService;
using AmusementPark.Data;
using AmusementPark.Data.Repositories;
using AmusementPark.Service;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace AmusementPark.extesion
{
    public static class ExtesionService
    {
        public static void ServieDependency(this IServiceCollection s)
        {

            s.AddScoped<ICustomerService, CustomerService>();
            s.AddScoped<IEmployeeService, EmployeeService>();
            s.AddScoped<IFacilityService, FacilitieService>();
            s.AddScoped<IOrderService, OrderService>();
            s.AddScoped<ITicketService, TicketService>();
            s.AddScoped<IRepository<CustomerEntity>,CustomerRepository>();
            s.AddScoped<IRepository<EmployeeEntity>, EmployeeRepository>();
            s.AddScoped<IRepository<FacilitieEntity>, FacilitieRepository>();
            s.AddScoped<IRepository<OrderEntity>,OrderRepository>();
            s.AddScoped<IRepository<TicketEntity>, TicketRepository>();
            s.AddSingleton<DataContext>();
        }
    } 
}
