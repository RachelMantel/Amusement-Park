using AmusementPark.Core.DTOs;
using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceRepository;
using AmusementPark.Core.InterfaceService;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Service
{
    public class EmployeeService : Iservice<EmployeeDto>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public EmployeeService(IRepositoryManager repositoryManager,IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public IEnumerable<EmployeeDto> getall()
        {
            var employee = _repositoryManager._employeeRepository.GetFull();
            //map to dto
            var employeeDtos = _mapper.Map<List<EmployeeDto>>(employee);
            return employeeDtos;

        }

        public EmployeeDto getById(int id)
        {
            var employee = _repositoryManager._employeeRepository.GetById(id);
            var employeeDto = _mapper.Map<EmployeeDto>(employee);

            return employeeDto;
        }

        public EmployeeDto add(EmployeeDto employee )
        {
            if (employee == null)
                return null;

            var employeeD = _mapper.Map<EmployeeEntity>(employee);
            _repositoryManager._employeeRepository.Add(employeeD);
            _repositoryManager.save();

            return _mapper.Map<EmployeeDto>(employeeD);
        }

        public EmployeeDto update(int id,EmployeeDto employee)
        {
            var employeeModel = _mapper.Map<EmployeeEntity>(employee);
            var help = _repositoryManager._employeeRepository.Update(id, employeeModel);
            if (help == null)
                return null;
            _repositoryManager.save();
            employee = _mapper.Map<EmployeeDto>(help);
            return employee;
        }

        public bool delete(int id)
        {
            var help = _repositoryManager._employeeRepository.Delete(id);
            _repositoryManager.save();
            return help;
        }
    }
}
