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
    public partial class AdminFrm : Form, IEvent
    {
        public AdminFrm()
        {
            InitializeComponent();
        }

        public string EventName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EventCost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void loadGridView()
        {
            EventsMgr eventsMgr = new EventsMgr(this);

            var eventdataTable = eventsMgr.getEventDt();
            dataGridView1.DataSource = eventdataTable;
            var dgvCol = dataGridView1.Columns["EventID"];
            dgvCol.Visible = false;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Width = 100;
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);

            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.HeaderText = "";
            buttonColumn2.Width = 60;
            buttonColumn2.Name = "buttonColumn2";
            buttonColumn2.Text = "Update";
            buttonColumn2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn2);
        }
        private void AdminFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aDP_DB_New1DataSet.Events' table. You can move, or remove it, as needed.
            loadGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;

            if (e.ColumnIndex == 6)
            {
                var eventID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                EventsMgr eventsMgr = new EventsMgr(this);
                if (eventsMgr.DeleteEvent(eventID))
                {
                    this.Controls.Clear();
                    this.InitializeComponent();
                    loadGridView();
                    MessageBox.Show("Event Deleted Successfully");

                }
                else
                {
                    MessageBox.Show("Cannot delete the selected event");
                }
            }
            if (e.ColumnIndex == 7)
            {
                var event_id = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                var event_name = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                var event_dets = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                var event_cost = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                var event_number = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                var event_type = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();

                EventsMgr eventMgr = new EventsMgr(this);
                if (eventMgr.UpdateEvent(event_id, event_name, event_dets, event_cost, event_number, event_type))
                {
                    this.Controls.Clear();
                    this.InitializeComponent();
                    loadGridView();
                    MessageBox.Show("Event Updated in Database successfully");
                
                }
                else
                {
                    MessageBox.Show("Could not update selected event in the database");
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EventNameTxt.Text) && !string.IsNullOrWhiteSpace(EventCostText.Text) && !string.IsNullOrWhiteSpace(EventDetailsText.Text))
            {
                var event_name = EventNameTxt.Text.Trim();
                var event_cost = EventCostText.Text.Trim();
                var event_dets = EventDetailsText.Text.Trim();

                EventsMgr eventmgr = new EventsMgr(this);
                if (eventmgr.AddEvent(event_name, event_dets, event_cost))
                {
                    
                    this.Controls.Clear();
                    this.InitializeComponent();
                    loadGridView();
                    MessageBox.Show("Event Added in Database successfully");

                }
                else
                {
                    MessageBox.Show("Could not Add event in the database");
                }
            }  
        }

       

    }
}
