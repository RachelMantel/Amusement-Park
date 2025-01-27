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
    public class FacilitieService : Iservice<FacilitieDto>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public FacilitieService(IRepositoryManager repositoryManager,IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public IEnumerable<FacilitieDto> getall()
        {
            var facilities = _repositoryManager._facilitieRepository.GetFull();
            //map to dto
            var facilitieD = _mapper.Map<List<FacilitieDto>>(facilities);
            return facilitieD;
        }

        public FacilitieDto getById(int id)
        {
            var facilitie = _repositoryManager._facilitieRepository.GetById(id);
            var facilitieDto = _mapper.Map<FacilitieDto>(facilitie);

            return facilitieDto;
        }

        public FacilitieDto add(FacilitieDto facilitie)
        {
            if (facilitie == null)
                return null;

            var facilitieD = _mapper.Map<FacilitieEntity>(facilitie);
            _repositoryManager._facilitieRepository.Add(facilitieD);
            _repositoryManager.save();

            return _mapper.Map<FacilitieDto>(facilitie);
        }

        public FacilitieDto update(int id,FacilitieDto facilitie)
        {
            var facilitieModel = _mapper.Map<FacilitieEntity>(facilitie);
            var help = _repositoryManager._facilitieRepository.Update(id, facilitieModel);
            if (help == null)
                return null;
            _repositoryManager.save();
            facilitie = _mapper.Map<FacilitieDto>(help);
            return facilitie;
        }

        public bool delete(int id)
        {

            var help = _repositoryManager._facilitieRepository.Delete(id);
            _repositoryManager.save();
            return help;
        }
    }
}
