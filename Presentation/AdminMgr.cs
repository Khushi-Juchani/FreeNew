using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwayDayPlanner.Model;
using AwayDayPlanner.View;

namespace AwayDayPlanner.Presentation
{
    public class AdminMgr
    {
        IAdmin _admin;


        public AdminMgr(IAdmin admin)
        {
            _admin = admin;
        }

        public int Adminlogin()
        {
            AdminModel loginobj = new AdminModel();
            loginobj.AdminUsername = _admin.AdminUsername;
            loginobj.AdminPassword= _admin.AdminPassword;

            var LoggedinClient = loginobj.AdminloginUser();
            return LoggedinClient;
        }
    }
}
