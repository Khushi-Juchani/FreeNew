using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwayDayPlanner.View;
using AwayDayPlanner.Model;
using System.Data;


namespace AwayDayPlanner.Presentation
{
    class Booking
    {
        IBooking bookingView;

        public Booking(IBooking view)
        {
            bookingView = view;
        }

        public bool BookEvent(int ClientID, int EventID, int AdditionalCost, DateTime eventdate, bool iscomplete, string AdditionalComments)
        {
            Book bookevent = new Book();
            return bookevent.BookEvent(ClientID, EventID, eventdate, iscomplete, AdditionalCost, AdditionalComments);
        }

        public DataTable GetClientEvent(int Client_ID)
        {
            Book bkg = new Book();
            Register register = new Register();
            EventModel eventsMgr = new EventModel();

            var events = eventsMgr.GetEvents();
            var clientEventList = bkg.GetClientEvent(Client_ID);
            var clients = register.GetClients();

            var eventResults = events.Join(clientEventList, evt => evt.EventID, cvt => cvt.Event_ID, (evt, cvt) => new
            {
                EventName = evt.EventName,
                EventID = evt.EventID,
                ClientID = cvt.Client_ID,
                cvtID = cvt.ID
            });

            var res = from evts in events
                      join cvt in clientEventList
                      on evts.EventID equals cvt.Event_ID
                      join clt in clients
                      on cvt.Client_ID equals clt.ClientID
                      where cvt.isCompleted == true & clt.ClientID == Client_ID
                      select new
                      {
                          clt.ClientName,
                          clt.Email,
                          evts.EventName,
                          evts.EventDetails,
                          evts.Cost,
                          cvt.AdditionalComment,
                          cvt.EventDate,
                          cvt.isCompleted
                      } ;

            DataTable dt = new DataTable();
            DataColumn clientNameCol = new DataColumn("ClientName");
            DataColumn clientEmail = new DataColumn("Email");
            DataColumn EventNameCol = new DataColumn("Event_Name");
            DataColumn EventDetailsCol = new DataColumn("Event_Details");
            DataColumn EventCostCol = new DataColumn("Event_Cost");
            DataColumn EventComplete = new DataColumn("Completed");

            DataColumn AddtionalCommentCol = new DataColumn("Addtional_Comments");
            DataColumn EventDateCol = new DataColumn("Event_Details");

            dt.Columns.Add("ClientName");
            dt.Columns.Add("Email");
            dt.Columns.Add("Event_Name");
            dt.Columns.Add("Event_Details");
            dt.Columns.Add("Event_Cost");
            dt.Columns.Add("Complete?");
            dt.Columns.Add("AddtionalComments");
            dt.Columns.Add("Event_Dates");

            foreach (var item in res)
            {
                var iscmplted = item.isCompleted == true ? "Yes" : "No";
                dt.Rows.Add(item.ClientName, item.Email, item.EventName, item.EventDetails, item.Cost, iscmplted , item.AdditionalComment, item.EventDate);
              
            }
            return dt;
        }

    }
}
