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
        readonly IRepositoryManager _repositoryManager;
        public EmployeeService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public IEnumerable<EmployeeEntity> getall()
        {
            return _repositoryManager._employeeRepository.GetFull();
        }

        public EmployeeEntity getById(int id)
        {
            return _repositoryManager._employeeRepository.GetById(id);
        }

        public EmployeeEntity add(EmployeeEntity employee )
        {
            if (employee == null)
                return null;

           var help=_repositoryManager._employeeRepository.Add(employee);
            _repositoryManager.save();
            return help;
        }

        public EmployeeEntity update(int id,EmployeeEntity employee)
        {
            var help = _repositoryManager._employeeRepository.Update(id,employee);
            _repositoryManager.save();
            return help;
        }

        public bool delete(int id)
        {
            var help = _repositoryManager._employeeRepository.Delete(id);
            _repositoryManager.save();
            return help;
        }
    }
}
