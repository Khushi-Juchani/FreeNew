using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwayDayPlanner;
using ADPRepository;
//using ADPDataAccess;
using ADPDataAccessProj;

namespace AwayDayPlanner.View
{
    public interface IBooking
    {


        string ClientName { get; set; }
        DateTime AvailabilityDate { get; set; }


    }
}
