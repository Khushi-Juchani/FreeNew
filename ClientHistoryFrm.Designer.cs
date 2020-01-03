namespace AwayDayPlanner
{
    partial class ClientHistoryFrm
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
            this.ClientHistoryDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClientHistoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientHistoryDGV
            // 
            this.ClientHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientHistoryDGV.Location = new System.Drawing.Point(53, 34);
            this.ClientHistoryDGV.Name = "ClientHistoryDGV";
            this.ClientHistoryDGV.RowHeadersWidth = 62;
            this.ClientHistoryDGV.RowTemplate.Height = 28;
            this.ClientHistoryDGV.Size = new System.Drawing.Size(1303, 431);
            this.ClientHistoryDGV.TabIndex = 0;
            // 
            // ClientHistoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 600);
            this.Controls.Add(this.ClientHistoryDGV);
            this.Name = "ClientHistoryFrm";
            this.Text = "ClientHistoryFrm";
            this.Load += new System.EventHandler(this.ClientHistoryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientHistoryDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientHistoryDGV;
    }
}