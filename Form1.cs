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
using MaterialSkin;
using MaterialSkin.Controls;

namespace AwayDayPlanner
{
    public partial class Form1 : MaterialForm, IDayPlannerView
    {

        public Form1()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        public string username 
        { 
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string usertype 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string password 
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DayPlannerPresentation dayPlanner = new DayPlannerPresentation(this);
            if (!(string.IsNullOrWhiteSpace(username)) && !string.IsNullOrEmpty(password))
            {
                var loggedClient = dayPlanner.login();
                if (loggedClient >= 0)
                {
                    var clientfrm = new ClientFrm(loggedClient, username);
                    clientfrm.Tag = this;
                    clientfrm.Show(this);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password, please type correct credentials or Register yourself if you haven't yet");
                }
            }
            else
            {
                MessageBox.Show("Please enter Username and password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var regfrm = new RegisterFrm();
            regfrm.Tag = this;
            regfrm.Show(this);
            Hide();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            var regfrm = new AdminLoginFrm();
            regfrm.Tag = this;
            regfrm.Show(this);
            Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
