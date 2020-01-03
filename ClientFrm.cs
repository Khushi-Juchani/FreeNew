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


namespace AwayDayPlanner
{
    public partial class ClientFrm : MaterialForm, IBooking, IEvent
    {


        public string ClientName 
        {
            get { return EventDrpDown.SelectedItem.ToString(); }
            set { EventDrpDown.SelectedItem = value; }
        }
        public DateTime AvailabilityDate 
        {
            get { return Convert.ToDateTime(AvailableDatesDrpDown.SelectedItem.ToString()); }
            set { AvailabilityDate = value; }
        }
        
        public string EventName { get =>  EventDrpDown.SelectedText; set => EventDrpDown.SelectedText = value; }
        public string EventCost
        {
            get { return EventCostlbl.Text; }
            set { EventCostlbl.Text = value; }
        }


        public ClientFrm(int clientID, string clientName)
        {
            InitializeComponent();
            EventDrpDown.SelectedIndexChanged += EventDrpDown_SelectedIndexChanged;
            ClientIDlbl.Text = clientID.ToString();
            ClientNamelbl.Text = clientName;

        }

        private void EventDrpDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEvent = EventDrpDown.SelectedItem.ToString();
            EventsMgr events = new EventsMgr(this);
            var myEvents = events.getAllEvents();
            var current_event = myEvents.Where(x => x.EventName.Contains(selectedEvent)).FirstOrDefault();
            var evntId = current_event.EventID;
            EventIDlbl.Text = evntId.ToString();
            AvailabilityMgr availabilityMgr = new AvailabilityMgr();
            var cur_availabilities = availabilityMgr.GetAvailabilitiesByID(evntId);
            AvailableDatesDrpDown.Items.Clear();
            foreach (var item in cur_availabilities)
            {
                AvailableDatesDrpDown.Items.Add(item.Availability1.ToString());
            }
            EventCostlbl.Text = current_event.EventCost.ToString();
            var event_details_list = current_event.EventDetails.ToString().Split(';');
            DataTable table = new DataTable();
            table.Columns.Add("Details", typeof(string));
            foreach (var item in event_details_list)
            {
                table.Rows.Add(item);
            }
            dataGridView1.DataSource = table;
            dataGridView1.AutoResizeColumns();

        }

        private void EventDetailsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {


        }



        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            bool allfilled = true;
            if (string.IsNullOrWhiteSpace(AvailableDatesDrpDown.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select an Event");
                allfilled = false;
            }
            if (string.IsNullOrWhiteSpace(EventDrpDown.SelectedItem.ToString()))
            {
                MessageBox.Show("Please Select the Available dates corresponding to the SelectedEvents");
                allfilled = false;
            }
            if (allfilled == true)
            {
                Booking booking = new Booking(this);
                var bookingClientID = Convert.ToInt32(ClientIDlbl.Text); 
                var bookingEventID = Convert.ToInt32(EventIDlbl.Text);
                var EventDate = AvailabilityDate;
                var isComplete = false;
                var AdditionalCost = 0;
                var Addtionalcomments = richTextBox1.Text;

                var isbooked = booking.BookEvent(bookingClientID, bookingEventID, AdditionalCost, EventDate, isComplete, Addtionalcomments);

                if(isbooked)
                {
                    MessageBox.Show("Event Booked Successfully");
                    AvailableDatesDrpDown.SelectedIndex = -1;
                    richTextBox1.Text = string.Empty;
                    EventCostlbl.Text = "----";
                    dataGridView1.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Error Booking the Event");
                }
            }

        }
        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }
        private void ClientFrm_Load(object sender, EventArgs e)
        {
            Booking register = new Booking(this);
            EventsMgr eventsMgr = new EventsMgr(this);

            var eventslist = eventsMgr.getAllEvents();
            foreach (var evnts in eventslist)
            {

                EventDrpDown.Items.Add(evnts.EventName);

            }



        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            ClientHistoryFrm clientHistoryFrm = new ClientHistoryFrm(ClientIDlbl.Text);
            clientHistoryFrm.ShowDialog();
        }
    }
}
