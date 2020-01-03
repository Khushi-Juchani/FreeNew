using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ADPDataAccess;
using ADPRepository;
using ADPDataAccessProj;

using AwayDayPlanner.Model;

namespace AwayDayPlanner.Presentation
{
    class AvailabilityMgr
    {
        public List<Availability> GetAvailabilitiesByID(int EventID)
        {
            Availabiles availabiles = new Availabiles();
            var avl = availabiles.GetAvailabilitiesByID(EventID);
            return avl;
        }
    }
}
