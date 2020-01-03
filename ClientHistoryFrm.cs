using AwayDayPlanner.Presentation;
using AwayDayPlanner.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace AwayDayPlanner
{
    public partial class ClientHistoryFrm : Form, IBooking
    {
        string client_id_frm = string.Empty;
        public ClientHistoryFrm(string client_frm_ID)
        {
            InitializeComponent();
            client_id_frm = client_frm_ID;

        }

        public string ClientName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime AvailabilityDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void ClientHistoryFrm_Load(object sender, EventArgs e)
        {
            Booking booking = new Booking(this);
            var dataTable = booking.GetClientEvent(Convert.ToInt32(client_id_frm));
            ClientHistoryDGV.DataSource = dataTable;
        }
    }
}
