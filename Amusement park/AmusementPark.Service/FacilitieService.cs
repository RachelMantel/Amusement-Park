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
    public class FacilitieService : Iservice<FacilitieEntity>
    {
        readonly IRepositoryManager _repositoryManager;
        public FacilitieService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public IEnumerable<FacilitieEntity> getall()
        {
            return _repositoryManager._facilitieRepository.GetFull();
        }

        public FacilitieEntity getById(int id)
        {

            return _repositoryManager._facilitieRepository.GetById(id);
        }

        public FacilitieEntity add(FacilitieEntity facilitie)
        {
            if (facilitie == null)
                return null;

           var help =_repositoryManager._facilitieRepository.Add(facilitie);
            _repositoryManager.save();
            return help;
        }

        public FacilitieEntity update(int id,FacilitieEntity facilitie)
        {
            var help = _repositoryManager._facilitieRepository.Update(id,facilitie);
            _repositoryManager.save();
            return help;
        }

        public bool delete(int id)
        {

            var help = _repositoryManager._facilitieRepository.Delete(id);
            _repositoryManager.save();
            return help;
        }
    }
}
