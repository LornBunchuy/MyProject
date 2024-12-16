
namespace Dashboard
{
    partial class Request
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttLeaveH = new System.Windows.Forms.Button();
            this.bttLeaveR = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bttLeaveH, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttLeaveR, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1247, 655);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // bttLeaveH
            // 
            this.bttLeaveH.BackColor = System.Drawing.Color.Silver;
            this.bttLeaveH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttLeaveH.FlatAppearance.BorderSize = 0;
            this.bttLeaveH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttLeaveH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLeaveH.Location = new System.Drawing.Point(225, 42);
            this.bttLeaveH.Margin = new System.Windows.Forms.Padding(2);
            this.bttLeaveH.Name = "bttLeaveH";
            this.bttLeaveH.Size = new System.Drawing.Size(116, 32);
            this.bttLeaveH.TabIndex = 0;
            this.bttLeaveH.Text = "Leave History";
            this.bttLeaveH.UseVisualStyleBackColor = false;
            this.bttLeaveH.Click += new System.EventHandler(this.bttLeaveH_Click);
            // 
            // bttLeaveR
            // 
            this.bttLeaveR.BackColor = System.Drawing.Color.Silver;
            this.bttLeaveR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttLeaveR.FlatAppearance.BorderSize = 0;
            this.bttLeaveR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttLeaveR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLeaveR.Location = new System.Drawing.Point(105, 42);
            this.bttLeaveR.Margin = new System.Windows.Forms.Padding(2);
            this.bttLeaveR.Name = "bttLeaveR";
            this.bttLeaveR.Size = new System.Drawing.Size(116, 32);
            this.bttLeaveR.TabIndex = 0;
            this.bttLeaveR.Text = "New Request";
            this.bttLeaveR.UseVisualStyleBackColor = false;
            this.bttLeaveR.Click += new System.EventHandler(this.bttLeaveR_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(105, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 540);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 655);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Request";
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bttLeaveH;
        private System.Windows.Forms.Button bttLeaveR;
        private System.Windows.Forms.Panel panel3;
    }
}