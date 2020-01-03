using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwayDayPlanner
{
    public partial class AdminFrm : Form
    {
        public AdminFrm(string adminUsername)
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test2");
        }

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aDP_Db_NewDataSet2.ClientEventView' table. You can move, or remove it, as needed.
            this.clientEventViewTableAdapter.Fill(this.aDP_Db_NewDataSet2.ClientEventView);
            // TODO: This line of code loads data into the 'aDP_Db_NewDataSet1.ClientEventView' table. You can move, or remove it, as needed.
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
