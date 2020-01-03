namespace AwayDayPlanner
{
    partial class AdminFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDP_Db_NewDataSet2 = new AwayDayPlanner.ADP_Db_NewDataSet2();
            this.clientEventViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientEventViewTableAdapter = new AwayDayPlanner.ADP_Db_NewDataSet2TableAdapters.ClientEventViewTableAdapter();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.additionalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDP_Db_NewDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientEventViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventID,
            this.EID,
            this.ClientID,
            this.clientIDDataGridViewTextBoxColumn,
            this.eventIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.isCompletedDataGridViewCheckBoxColumn,
            this.additionalCostDataGridViewTextBoxColumn,
            this.additionalCommentDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.eventDetailsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientEventViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(103, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EventID
            // 
            this.EventID.DataPropertyName = "EventID";
            this.EventID.HeaderText = "EventID";
            this.EventID.MinimumWidth = 8;
            this.EventID.Name = "EventID";
            this.EventID.Visible = false;
            this.EventID.Width = 150;
            // 
            // EID
            // 
            this.EID.DataPropertyName = "EID";
            this.EID.HeaderText = "EID";
            this.EID.MinimumWidth = 8;
            this.EID.Name = "EID";
            this.EID.Visible = false;
            this.EID.Width = 150;
            // 
            // ClientID
            // 
            this.ClientID.DataPropertyName = "ClientID";
            this.ClientID.HeaderText = "ClientID";
            this.ClientID.MinimumWidth = 8;
            this.ClientID.Name = "ClientID";
            this.ClientID.Visible = false;
            this.ClientID.Width = 150;
            // 
            // aDP_Db_NewDataSet2
            // 
            this.aDP_Db_NewDataSet2.DataSetName = "ADP_Db_NewDataSet2";
            this.aDP_Db_NewDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientEventViewBindingSource
            // 
            this.clientEventViewBindingSource.DataMember = "ClientEventView";
            this.clientEventViewBindingSource.DataSource = this.aDP_Db_NewDataSet2;
            // 
            // clientEventViewTableAdapter
            // 
            this.clientEventViewTableAdapter.ClearBeforeFill = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "Event_ID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "Event_ID";
            this.eventIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            this.eventIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            this.eventDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // isCompletedDataGridViewCheckBoxColumn
            // 
            this.isCompletedDataGridViewCheckBoxColumn.DataPropertyName = "isCompleted";
            this.isCompletedDataGridViewCheckBoxColumn.HeaderText = "isCompleted";
            this.isCompletedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isCompletedDataGridViewCheckBoxColumn.Name = "isCompletedDataGridViewCheckBoxColumn";
            this.isCompletedDataGridViewCheckBoxColumn.Width = 150;
            // 
            // additionalCostDataGridViewTextBoxColumn
            // 
            this.additionalCostDataGridViewTextBoxColumn.DataPropertyName = "AdditionalCost";
            this.additionalCostDataGridViewTextBoxColumn.HeaderText = "AdditionalCost";
            this.additionalCostDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.additionalCostDataGridViewTextBoxColumn.Name = "additionalCostDataGridViewTextBoxColumn";
            this.additionalCostDataGridViewTextBoxColumn.Width = 150;
            // 
            // additionalCommentDataGridViewTextBoxColumn
            // 
            this.additionalCommentDataGridViewTextBoxColumn.DataPropertyName = "AdditionalComment";
            this.additionalCommentDataGridViewTextBoxColumn.HeaderText = "AdditionalComment";
            this.additionalCommentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.additionalCommentDataGridViewTextBoxColumn.Name = "additionalCommentDataGridViewTextBoxColumn";
            this.additionalCommentDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            this.eventNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventDetailsDataGridViewTextBoxColumn
            // 
            this.eventDetailsDataGridViewTextBoxColumn.DataPropertyName = "EventDetails";
            this.eventDetailsDataGridViewTextBoxColumn.HeaderText = "EventDetails";
            this.eventDetailsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventDetailsDataGridViewTextBoxColumn.Name = "eventDetailsDataGridViewTextBoxColumn";
            this.eventDetailsDataGridViewTextBoxColumn.Width = 150;
            // 
            // AdminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 484);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminFrm";
            this.Text = "AdminFrm";
            this.Load += new System.EventHandler(this.AdminFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDP_Db_NewDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientEventViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private ADP_Db_NewDataSet2 aDP_Db_NewDataSet2;
        private System.Windows.Forms.BindingSource clientEventViewBindingSource;
        private ADP_Db_NewDataSet2TableAdapters.ClientEventViewTableAdapter clientEventViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDetailsDataGridViewTextBoxColumn;
    }
}