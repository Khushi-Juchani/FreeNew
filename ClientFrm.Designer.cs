namespace AwayDayPlanner
{
    partial class ClientFrm
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
            this.EventDrpDown = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AvailableDatesDrpDown = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.BookButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.EventCostlbl = new System.Windows.Forms.Label();
            this.ClientIDlbl = new System.Windows.Forms.Label();
            this.EventIDlbl = new System.Windows.Forms.Label();
            this.ClientNamelbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EventDrpDown
            // 
            this.EventDrpDown.FormattingEnabled = true;
            this.EventDrpDown.Location = new System.Drawing.Point(378, 189);
            this.EventDrpDown.Name = "EventDrpDown";
            this.EventDrpDown.Size = new System.Drawing.Size(414, 28);
            this.EventDrpDown.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(135, 190);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 27);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Event List";
            // 
            // AvailableDatesDrpDown
            // 
            this.AvailableDatesDrpDown.FormattingEnabled = true;
            this.AvailableDatesDrpDown.Location = new System.Drawing.Point(378, 243);
            this.AvailableDatesDrpDown.Name = "AvailableDatesDrpDown";
            this.AvailableDatesDrpDown.Size = new System.Drawing.Size(414, 28);
            this.AvailableDatesDrpDown.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(135, 244);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(161, 27);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Available Dates";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(135, 525);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(230, 27);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Total Estimated Cost   ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(287, 288);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(0, 27);
            this.materialLabel4.TabIndex = 5;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(135, 312);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(221, 27);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Additional Comments";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(715, 525);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(25, 27);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "£";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(415, 380);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(0, 27);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // BookButton
            // 
            this.BookButton.AutoSize = true;
            this.BookButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BookButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BookButton.Depth = 0;
            this.BookButton.Location = new System.Drawing.Point(368, 637);
            this.BookButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BookButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookButton.Name = "BookButton";
            this.BookButton.Primary = false;
            this.BookButton.Size = new System.Drawing.Size(227, 36);
            this.BookButton.TabIndex = 9;
            this.BookButton.Text = "Submit for Booking";
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.materialLabel9);
            this.panel1.Location = new System.Drawing.Point(897, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 497);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(597, 313);
            this.dataGridView1.TabIndex = 3;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(42, 54);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(138, 27);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "Event Details";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(378, 288);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(414, 200);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // EventCostlbl
            // 
            this.EventCostlbl.AutoSize = true;
            this.EventCostlbl.Location = new System.Drawing.Point(416, 530);
            this.EventCostlbl.Name = "EventCostlbl";
            this.EventCostlbl.Size = new System.Drawing.Size(34, 20);
            this.EventCostlbl.TabIndex = 14;
            this.EventCostlbl.Text = "-----";
            // 
            // ClientIDlbl
            // 
            this.ClientIDlbl.AutoSize = true;
            this.ClientIDlbl.Location = new System.Drawing.Point(543, 115);
            this.ClientIDlbl.Name = "ClientIDlbl";
            this.ClientIDlbl.Size = new System.Drawing.Size(51, 20);
            this.ClientIDlbl.TabIndex = 17;
            this.ClientIDlbl.Text = "label1";
            this.ClientIDlbl.Visible = false;
            // 
            // EventIDlbl
            // 
            this.EventIDlbl.AutoSize = true;
            this.EventIDlbl.Location = new System.Drawing.Point(811, 195);
            this.EventIDlbl.Name = "EventIDlbl";
            this.EventIDlbl.Size = new System.Drawing.Size(51, 20);
            this.EventIDlbl.TabIndex = 18;
            this.EventIDlbl.Text = "label1";
            this.EventIDlbl.Visible = false;
            // 
            // ClientNamelbl
            // 
            this.ClientNamelbl.AutoSize = true;
            this.ClientNamelbl.Depth = 0;
            this.ClientNamelbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.ClientNamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientNamelbl.Location = new System.Drawing.Point(439, 110);
            this.ClientNamelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClientNamelbl.Name = "ClientNamelbl";
            this.ClientNamelbl.Size = new System.Drawing.Size(66, 27);
            this.ClientNamelbl.TabIndex = 16;
            this.ClientNamelbl.Text = "---------";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(1139, 115);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(222, 36);
            this.materialFlatButton1.TabIndex = 19;
            this.materialFlatButton1.Text = "View Event History";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // ClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1946, 866);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.EventIDlbl);
            this.Controls.Add(this.ClientIDlbl);
            this.Controls.Add(this.ClientNamelbl);
            this.Controls.Add(this.EventCostlbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.AvailableDatesDrpDown);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.EventDrpDown);
            this.Name = "ClientFrm";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.ClientFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EventDrpDown;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox AvailableDatesDrpDown;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialFlatButton BookButton;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label EventCostlbl;
        private System.Windows.Forms.Label ClientIDlbl;
        private System.Windows.Forms.Label EventIDlbl;
        private MaterialSkin.Controls.MaterialLabel ClientNamelbl;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}