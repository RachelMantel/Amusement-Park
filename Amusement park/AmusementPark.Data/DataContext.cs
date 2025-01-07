using AmusementPark.Core.Entities;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Data
{
    public class DataContext: DbContext
    {

        #region csv
        //readonly string _filePath = "C:\\Users\\user1\\Desktop\\Amusement park\\AmusementPark.Data\\CsvFiles";

        //public List<CustomerEntity> customerList;

        //public List<EmployeeEntity> employeeList;

        //public List<FacilitieEntity> facilitieList;

        //public List<OrderEntity> orderlist;

        //public List<TicketEntity> ticketlist;

        //public DataContext()
        //{
        //    customerList = loadCustomers();
        //    employeeList = loadEmployees();
        //    facilitieList = loadFacilities();
        //    orderlist = loadOrders();
        //    ticketlist = loadTickets();
        //}

        //public bool SaveData()
        //{
        //    return saveCustomers() &&
        //            saveEmployees() &&
        //            saveFacilities() &&
        //            saveOrders()&&
        //            saveTickets();
        //}
        //public List<CustomerEntity> loadCustomers()
        //{
        //    string path = Path.Combine(_filePath, "customers.csv");
        //    using var reader = new StreamReader(path);
        //    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        //    return csv.GetRecords<CustomerEntity>().ToList();
        //}
        //public List<EmployeeEntity> loadEmployees()
        //{
        //    string path = Path.Combine(_filePath, "employee.csv");
        //    using var reader = new StreamReader(path);
        //    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        //    return csv.GetRecords<EmployeeEntity>().ToList();
        //}

        //public List<FacilitieEntity> loadFacilities()
        //{
        //    string path = Path.Combine(_filePath, "facilities.csv");
        //    using var reader = new StreamReader(path);
        //    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        //    return csv.GetRecords<FacilitieEntity>().ToList();
        //}
        //public List<OrderEntity> loadOrders()
        //{
        //    string path = Path.Combine(_filePath, "orders.csv");
        //    using var reader = new StreamReader(path);
        //    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        //    return csv.GetRecords<OrderEntity>().ToList();
        //}
        //public List<TicketEntity> loadTickets()
        //{
        //    string path = Path.Combine(_filePath, "tickets.csv");
        //    using var reader = new StreamReader(path);
        //    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        //    return csv.GetRecords<TicketEntity>().ToList();
        //}
        //public bool saveCustomers()
        //{
        //    try
        //    {
        //        string path = Path.Combine(_filePath, "customers.csv");
        //        using var writer = new StreamWriter(path);
        //        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        //        csv.WriteRecords(this.customerList);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        //public bool saveEmployees()
        //{
        //    try
        //    {
        //        string path = Path.Combine(_filePath, "employee.csv");
        //        using var writer = new StreamWriter(path);
        //        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        //        csv.WriteRecords(this.employeeList);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        return false;
        //    }
        //}
        //public bool saveFacilities()
        //{
        //    try
        //    {
        //        string path = Path.Combine(_filePath, "facilities.csv");
        //        using var writer = new StreamWriter(path);
        //        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        //        csv.WriteRecords(this.facilitieList);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        //public bool saveOrders()
        //{
        //    try
        //    {
        //        string path = Path.Combine(_filePath, "orders.csv");
        //        using var writer = new StreamWriter(path);
        //        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        //        csv.WriteRecords(this.orderlist);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        return false;
        //    }
        //}

        //public bool saveTickets()
        //{
        //    try
        //    {
        //        string path = Path.Combine(_filePath, "tickets.csv");
        //        using var writer = new StreamWriter(path);
        //        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        //        csv.WriteRecords(this.ticketlist);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        return false;
        //    }
        //}
        #endregion

        public DbSet<CustomerEntity> customerList { get; set; }
        public DbSet<EmployeeEntity> employeeList { get; set; }
        public DbSet<FacilitieEntity> facilitieList { get; set; }
        public DbSet<OrderEntity> orderList { get; set; }
        public DbSet<TicketEntity> ticketList { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(mesege => Console.Write(mesege));
        }

    }
}

