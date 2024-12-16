
namespace Dashboard
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbWelcom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LbLogOut = new System.Windows.Forms.Label();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnSystemLog = new System.Windows.Forms.Button();
            this.BtnUserManagement = new System.Windows.Forms.Button();
            this.BtnApproval = new System.Windows.Forms.Button();
            this.BtnRequest = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelShow = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LbWelcom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 44);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1270, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(133, 44);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Leave System";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LbWelcom
            // 
            this.LbWelcom.AutoSize = true;
            this.LbWelcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWelcom.ForeColor = System.Drawing.SystemColors.Window;
            this.LbWelcom.Location = new System.Drawing.Point(33, 15);
            this.LbWelcom.Name = "LbWelcom";
            this.LbWelcom.Size = new System.Drawing.Size(66, 20);
            this.LbWelcom.TabIndex = 0;
            this.LbWelcom.Text = "Welcom";
            this.LbWelcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.BtnAbout);
            this.panel2.Controls.Add(this.BtnSystemLog);
            this.panel2.Controls.Add(this.BtnUserManagement);
            this.panel2.Controls.Add(this.BtnApproval);
            this.panel2.Controls.Add(this.BtnRequest);
            this.panel2.Controls.Add(this.BtnDashboard);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 667);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LbLogOut, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 612);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(195, 55);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // LbLogOut
            // 
            this.LbLogOut.AutoSize = true;
            this.LbLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbLogOut.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogOut.ForeColor = System.Drawing.SystemColors.Window;
            this.LbLogOut.Location = new System.Drawing.Point(3, 0);
            this.LbLogOut.Name = "LbLogOut";
            this.LbLogOut.Size = new System.Drawing.Size(189, 25);
            this.LbLogOut.TabIndex = 3;
            this.LbLogOut.Text = "Log Out";
            this.LbLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbLogOut.Click += new System.EventHandler(this.LbLogOut_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbout.Image")));
            this.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.Location = new System.Drawing.Point(0, 220);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(195, 44);
            this.BtnAbout.TabIndex = 6;
            this.BtnAbout.Text = "                 About";
            this.BtnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnSystemLog
            // 
            this.BtnSystemLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSystemLog.FlatAppearance.BorderSize = 0;
            this.BtnSystemLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSystemLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSystemLog.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnSystemLog.Image = ((System.Drawing.Image)(resources.GetObject("BtnSystemLog.Image")));
            this.BtnSystemLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSystemLog.Location = new System.Drawing.Point(0, 176);
            this.BtnSystemLog.Name = "BtnSystemLog";
            this.BtnSystemLog.Size = new System.Drawing.Size(195, 44);
            this.BtnSystemLog.TabIndex = 5;
            this.BtnSystemLog.Text = "                 System Log";
            this.BtnSystemLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSystemLog.UseVisualStyleBackColor = true;
            this.BtnSystemLog.Click += new System.EventHandler(this.BtnSystemLog_Click);
            // 
            // BtnUserManagement
            // 
            this.BtnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUserManagement.FlatAppearance.BorderSize = 0;
            this.BtnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserManagement.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnUserManagement.Image = ((System.Drawing.Image)(resources.GetObject("BtnUserManagement.Image")));
            this.BtnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUserManagement.Location = new System.Drawing.Point(0, 132);
            this.BtnUserManagement.Name = "BtnUserManagement";
            this.BtnUserManagement.Size = new System.Drawing.Size(195, 44);
            this.BtnUserManagement.TabIndex = 4;
            this.BtnUserManagement.Text = "                 User Management";
            this.BtnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUserManagement.UseVisualStyleBackColor = true;
            this.BtnUserManagement.Click += new System.EventHandler(this.BtnUserManagement_Click);
            // 
            // BtnApproval
            // 
            this.BtnApproval.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnApproval.FlatAppearance.BorderSize = 0;
            this.BtnApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApproval.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnApproval.Image = ((System.Drawing.Image)(resources.GetObject("BtnApproval.Image")));
            this.BtnApproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApproval.Location = new System.Drawing.Point(0, 88);
            this.BtnApproval.Name = "BtnApproval";
            this.BtnApproval.Size = new System.Drawing.Size(195, 44);
            this.BtnApproval.TabIndex = 3;
            this.BtnApproval.Text = "                 My Approval";
            this.BtnApproval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApproval.UseVisualStyleBackColor = true;
            this.BtnApproval.Click += new System.EventHandler(this.BtnApproval_Click);
            // 
            // BtnRequest
            // 
            this.BtnRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRequest.FlatAppearance.BorderSize = 0;
            this.BtnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnRequest.Image = ((System.Drawing.Image)(resources.GetObject("BtnRequest.Image")));
            this.BtnRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRequest.Location = new System.Drawing.Point(0, 44);
            this.BtnRequest.Name = "BtnRequest";
            this.BtnRequest.Size = new System.Drawing.Size(195, 44);
            this.BtnRequest.TabIndex = 2;
            this.BtnRequest.Text = "                 New Request";
            this.BtnRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRequest.UseVisualStyleBackColor = true;
            this.BtnRequest.Click += new System.EventHandler(this.BtnRequest_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 0);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(195, 44);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "                 Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PanelShow
            // 
            this.PanelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelShow.Location = new System.Drawing.Point(195, 44);
            this.PanelShow.Name = "PanelShow";
            this.PanelShow.Size = new System.Drawing.Size(1208, 667);
            this.PanelShow.TabIndex = 5;
            this.PanelShow.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelShow_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1234, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 711);
            this.Controls.Add(this.PanelShow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbWelcom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbLogOut;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnSystemLog;
        private System.Windows.Forms.Button BtnUserManagement;
        private System.Windows.Forms.Button BtnApproval;
        private System.Windows.Forms.Button BtnRequest;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel PanelShow;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}