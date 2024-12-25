using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmusementPark.Core.Entities
{
    [Table("Facilities")]
    public class FacilitieEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumVisitorsForDay { get; set; }

        public int MinimalAge { get; set; }

        public int NumofWorkers { get; set; }

        public bool Status { get; set;}

        public int RoundDuration { get; set; }

        public List<EmployeeEntity> employees { get; set; }

        public FacilitieEntity()
        {
            
        }
        public void Copy(FacilitieEntity f)
        {
            Id = f.Id;
            Name = f.Name;
            Description = f.Description;
            NumVisitorsForDay = f.NumVisitorsForDay;
            MinimalAge = f.MinimalAge;
            NumofWorkers = f.NumofWorkers;
            Status = f.Status;
            RoundDuration = f.RoundDuration;
        }


        //public FacilitieEntity(int id,string name, string description, int numVisitorsForDay, int minimalAge, int numofWorkers, bool status, int roundDuration)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //    NumVisitorsForDay = numVisitorsForDay;
        //    MinimalAge = minimalAge;
        //    NumofWorkers = numofWorkers;
        //    Status = status;
        //    RoundDuration = roundDuration;
        //}
    }
}
