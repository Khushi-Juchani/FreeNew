using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADPRepository;
//using ADPDataAccess;
using ADPDataAccessProj;

namespace AwayDayPlanner.Model
{
    class Availabiles
    {
        AvailabilityRepository availabilityRepository = new AvailabilityRepository();
        
        public List<Availability> GetAvailabilitiesByID(int EventID)
        {
           return  availabilityRepository.GetByEventID(EventID).ToList();

        }
        public List<Availability> GetAvailabilities()
        {
            return availabilityRepository.GetAll().ToList();

        }
    }
}
