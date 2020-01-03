using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwayDayPlanner.View;
using AwayDayPlanner.Model;


namespace AwayDayPlanner.Presentation
{
    public class DayPlannerPresentation
    {
        IDayPlannerView loginview;

        public DayPlannerPresentation(IDayPlannerView view)
        {
            loginview = view;
        }

        public int login()
        {
            Login loginobj = new Login();
            loginobj.LoginUsername = loginview.username;
            loginobj.LoginPassword = loginview.password;

            var LoggedinClient = loginobj.loginUser();
            return LoggedinClient;
        }


    }
}
