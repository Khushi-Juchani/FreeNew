using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwayDayPlanner.View;
using AwayDayPlanner.Presentation;
namespace AwayDayPlanner
{
    public partial class AdminLoginFrm : Form, IAdmin
    {
        public string AdminUsername { get => AdminUserNameTxt.Text; set => AdminUserNameTxt.Text = value; }
        public string AdminPassword { get =>  AdminPwdTxt.Text; set => AdminPwdTxt.Text = value; }
     
    
        public AdminLoginFrm()
        {
            InitializeComponent();
        }

        private void AdminLoginFrm_Load(object sender, EventArgs e)
        {

        }    

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMgr adminMgr = new AdminMgr(this);
            var islogin = adminMgr.Adminlogin();

            if (islogin > 0)
            {
                AdminFrm adminFrm = new AdminFrm(AdminUsername);
                adminFrm.Tag = this;
                adminFrm.Show(this);
                Hide();
            }
        }


    }
}
