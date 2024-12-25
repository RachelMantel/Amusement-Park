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
        readonly IFacilitieRepository _facilitieRepository;

        public FacilitieService(IFacilitieRepository facilitieRepository)
        {
            _facilitieRepository = facilitieRepository;
        }
        public IEnumerable<FacilitieEntity> getall()
        {
            return _facilitieRepository.GetFull();
        }

        public FacilitieEntity getById(int id)
        {

            return _facilitieRepository.GetById(id);
        }

        public FacilitieEntity add(FacilitieEntity facilitie)
        {
            if (facilitie == null)
                return null;

            return _facilitieRepository.Add(facilitie);
        }

        public FacilitieEntity update(int id,FacilitieEntity facilitie)
        {
            return _facilitieRepository.Update(id,facilitie);
        }

        public bool delete(int id)
        {

          return _facilitieRepository.Delete(id);
        }
    }
}
