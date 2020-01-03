namespace AwayDayPlanner
{
    partial class AdminLoginFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminPwdTxt = new System.Windows.Forms.TextBox();
            this.AdminUserNameTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name";
            // 
            // AdminPwdTxt
            // 
            this.AdminPwdTxt.Location = new System.Drawing.Point(316, 200);
            this.AdminPwdTxt.Name = "AdminPwdTxt";
            this.AdminPwdTxt.PasswordChar = '*';
            this.AdminPwdTxt.Size = new System.Drawing.Size(264, 26);
            this.AdminPwdTxt.TabIndex = 7;
            // 
            // AdminUserNameTxt
            // 
            this.AdminUserNameTxt.Location = new System.Drawing.Point(316, 137);
            this.AdminUserNameTxt.Name = "AdminUserNameTxt";
            this.AdminUserNameTxt.Size = new System.Drawing.Size(264, 26);
            this.AdminUserNameTxt.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submitbtn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminLoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminPwdTxt);
            this.Controls.Add(this.AdminUserNameTxt);
            this.Controls.Add(this.button1);
            this.Name = "AdminLoginFrm";
            this.Text = "AdminLoginFrm";
            this.Load += new System.EventHandler(this.AdminLoginFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminPwdTxt;
        private System.Windows.Forms.TextBox AdminUserNameTxt;
        private System.Windows.Forms.Button button1;
    }
}