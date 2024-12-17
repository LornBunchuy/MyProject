namespace BengMealeaDB
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAddItemOrder = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnReceipt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCustNo = new System.Windows.Forms.TextBox();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.TxtEmpNo = new System.Windows.Forms.TextBox();
            this.TxtOrdNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtGrandTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtOrdDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 6);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAddItemOrder
            // 
            this.BtnAddItemOrder.BackColor = System.Drawing.SystemColors.Window;
            this.BtnAddItemOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddItemOrder.FlatAppearance.BorderSize = 0;
            this.BtnAddItemOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddItemOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItemOrder.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddItemOrder.Image")));
            this.BtnAddItemOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAddItemOrder.Location = new System.Drawing.Point(8, 383);
            this.BtnAddItemOrder.Name = "BtnAddItemOrder";
            this.BtnAddItemOrder.Size = new System.Drawing.Size(72, 70);
            this.BtnAddItemOrder.TabIndex = 1;
            this.BtnAddItemOrder.Text = "Items";
            this.BtnAddItemOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAddItemOrder.UseVisualStyleBackColor = false;
            this.BtnAddItemOrder.Click += new System.EventHandler(this.BtnAddItemOrder_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Window;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSave.Location = new System.Drawing.Point(86, 383);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(85, 70);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.SystemColors.Window;
            this.BtnModify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnModify.FlatAppearance.BorderSize = 0;
            this.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModify.Image = ((System.Drawing.Image)(resources.GetObject("BtnModify.Image")));
            this.BtnModify.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModify.Location = new System.Drawing.Point(177, 383);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(83, 70);
            this.BtnModify.TabIndex = 3;
            this.BtnModify.Text = "Modify";
            this.BtnModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.SystemColors.Window;
            this.BtnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Image = ((System.Drawing.Image)(resources.GetObject("BtnRemove.Image")));
            this.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRemove.Location = new System.Drawing.Point(266, 383);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(69, 70);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.BtnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(341, 383);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(86, 70);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnReceipt
            // 
            this.BtnReceipt.BackColor = System.Drawing.SystemColors.Window;
            this.BtnReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReceipt.FlatAppearance.BorderSize = 0;
            this.BtnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReceipt.Image = ((System.Drawing.Image)(resources.GetObject("BtnReceipt.Image")));
            this.BtnReceipt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReceipt.Location = new System.Drawing.Point(433, 383);
            this.BtnReceipt.Name = "BtnReceipt";
            this.BtnReceipt.Size = new System.Drawing.Size(76, 70);
            this.BtnReceipt.TabIndex = 6;
            this.BtnReceipt.Text = "Receipt";
            this.BtnReceipt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReceipt.UseVisualStyleBackColor = false;
            this.BtnReceipt.Click += new System.EventHandler(this.BtnReceipt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "EmpNo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Location";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "OrdNo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Amount";
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "OrdDate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 45);
            this.label7.TabIndex = 8;
            this.label7.Text = "Status";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCustNo
            // 
            this.TxtCustNo.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.TxtCustNo, 2);
            this.TxtCustNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCustNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustNo.Location = new System.Drawing.Point(341, 293);
            this.TxtCustNo.Name = "TxtCustNo";
            this.TxtCustNo.Size = new System.Drawing.Size(168, 31);
            this.TxtCustNo.TabIndex = 9;
            // 
            // TxtStatus
            // 
            this.TxtStatus.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.TxtStatus, 2);
            this.TxtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStatus.Location = new System.Drawing.Point(341, 338);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(168, 31);
            this.TxtStatus.TabIndex = 9;
            // 
            // TxtLocation
            // 
            this.TxtLocation.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.TxtLocation, 2);
            this.TxtLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLocation.Location = new System.Drawing.Point(86, 338);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(174, 31);
            this.TxtLocation.TabIndex = 9;
            // 
            // TxtEmpNo
            // 
            this.TxtEmpNo.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.TxtEmpNo, 2);
            this.TxtEmpNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEmpNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpNo.Location = new System.Drawing.Point(86, 293);
            this.TxtEmpNo.Name = "TxtEmpNo";
            this.TxtEmpNo.Size = new System.Drawing.Size(174, 31);
            this.TxtEmpNo.TabIndex = 9;
            // 
            // TxtOrdNo
            // 
            this.TxtOrdNo.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.TxtOrdNo, 2);
            this.TxtOrdNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOrdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrdNo.Location = new System.Drawing.Point(86, 248);
            this.TxtOrdNo.Name = "TxtOrdNo";
            this.TxtOrdNo.Size = new System.Drawing.Size(174, 31);
            this.TxtOrdNo.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(8, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(501, 137);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "OrderNo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ItemNo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ItemName";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "UnitPrice";
            this.Column5.Name = "Column5";
            // 
            // TxtGrandTotal
            // 
            this.TxtGrandTotal.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.TxtGrandTotal, 2);
            this.TxtGrandTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGrandTotal.Location = new System.Drawing.Point(341, 602);
            this.TxtGrandTotal.Name = "TxtGrandTotal";
            this.TxtGrandTotal.Size = new System.Drawing.Size(168, 35);
            this.TxtGrandTotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 45);
            this.label6.TabIndex = 8;
            this.label6.Text = "CustNO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtOrdDate
            // 
            this.TxtOrdDate.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.TxtOrdDate, 2);
            this.TxtOrdDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOrdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrdDate.Location = new System.Drawing.Point(341, 248);
            this.TxtOrdDate.Name = "TxtOrdDate";
            this.TxtOrdDate.Size = new System.Drawing.Size(168, 31);
            this.TxtOrdDate.TabIndex = 9;
            this.TxtOrdDate.TextChanged += new System.EventHandler(this.TxtOrdDate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Grand Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddItemOrder, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnSave, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnModify, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnRemove, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnSearch, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnReceipt, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtOrdDate, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtCustNo, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtStatus, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtLocation, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtEmpNo, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtOrdNo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtGrandTotal, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 638);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnAddItemOrder;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtOrdDate;
        private System.Windows.Forms.TextBox TxtCustNo;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.TextBox TxtEmpNo;
        private System.Windows.Forms.TextBox TxtOrdNo;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.TextBox TxtGrandTotal;
        private System.Windows.Forms.Label label4;
    }
}