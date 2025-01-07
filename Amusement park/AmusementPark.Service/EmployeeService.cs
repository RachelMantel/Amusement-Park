using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceRepository;
using AmusementPark.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Service
{
    public class EmployeeService : Iservice<EmployeeEntity>
    {
        readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<EmployeeEntity> getall()
        {
            return _employeeRepository.GetFull();
        }

        public EmployeeEntity getById(int id)
        {

            return _employeeRepository.GetById(id);
        }

        public EmployeeEntity add(EmployeeEntity employee )
        {
            if (employee == null)
                return null;

            return _employeeRepository.Add(employee);
        }

        public EmployeeEntity update(int id,EmployeeEntity employee)
        {
            return _employeeRepository.Update(id,employee);
        }

        public bool delete(int id)
        {

          return _employeeRepository.Delete(id);
        }
    }
}
