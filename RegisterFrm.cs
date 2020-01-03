using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using AwayDayPlanner.View;
using AwayDayPlanner.Presentation;
using AwayDayPlanner.Entities;

namespace AwayDayPlanner
{
    public partial class RegisterFrm : MaterialForm, IRegister
    {
        public RegisterFrm()
        {
            InitializeComponent();
        }

        public string ClientName
        {
            get { return ClientNametxt.Text; }
            set { ClientNametxt.Text = value; }
        }
        public string ClientNumber
        {
            get { return ClientNametxt.Text; }
            set { ClientNametxt.Text = value; }
        }
        public string ClientType
        {
            get
            {
                if (radioButton1.Checked)
                {
                    return radioButton1.Text;
                }
                else
                {
                    return radioButton2.Text;
                }
            }
            set
            {
                radioButton1.Text = value;

            }

        }
        public string Password
        {
            get { return Passwordtxt.Text; }
            set { Passwordtxt.Text = value; }
        }
        public string confirmPassword
        {
            get { return confPwdtxt.Text; }
            set { confPwdtxt.Text = value; }
        }
        public string Email
        {
            get { return emailTxt.Text; }
            set { emailTxt.Text = value; }
        }


        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var registermsg = false;
            RegisterClient register = new RegisterClient(this);
            ClientEntity entity = new ClientEntity();
            if (string.IsNullOrEmpty(ClientName))
            {
                MessageBox.Show("Please Enter Client Name");
            }
            else
            {
                entity.ADPClientName = ClientName;

            }
            if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Please Enter Email Address");
            }
            else
            {
                entity.ADPEmail = Email;

            }

            entity.ADPClientType = ClientType;
            if (Password == confirmPassword)
            {
                entity.ADPPassword = Password;
                if (entity.ADPClientName != null && entity.ADPClientType != null && entity.ADPEmail != null && entity.ADPPassword != null)
                {
                    registermsg = register.RegisterADPClient(entity);
                    if (registermsg)
                    {
                        var currentClientID = register.getClientIDbyName(entity.ADPClientName);
                        MessageBox.Show("Registration Successfull");

                        var clientfrm = new ClientFrm(currentClientID, entity.ADPClientName);
                        clientfrm.Tag = this;
                        clientfrm.Show(this);
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration not successful, please try again");
                    }
                }


            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }



        }
    }
}
