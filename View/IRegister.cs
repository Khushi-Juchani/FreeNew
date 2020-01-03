using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner.View
{
    public interface IRegister
    {
        string ClientName { get; set; }
        string ClientNumber { get; set; }
        string ClientType { get; set; }
        string Password { get; set; }
        string Email { get; set; }

    }
}
