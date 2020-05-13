namespace Sales_Managment
{
    partial class Frm_Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sales));
            this.DgvSale = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.btnItems = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.btnCustomerBrowes = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnCustAagel = new System.Windows.Forms.RadioButton();
            this.rbtnCustNakdy = new System.Windows.Forms.RadioButton();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpReminder = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtpTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSale
            // 
            this.DgvSale.AllowUserToAddRows = false;
            this.DgvSale.AllowUserToDeleteRows = false;
            this.DgvSale.AllowUserToResizeColumns = false;
            this.DgvSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSale.BackgroundColor = System.Drawing.Color.White;
            this.DgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSale.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvSale.Location = new System.Drawing.Point(10, 130);
            this.DgvSale.Name = "DgvSale";
            this.DgvSale.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSale.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvSale.RowHeadersVisible = false;
            this.DgvSale.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvSale.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.DgvSale.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DgvSale.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.DgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSale.Size = new System.Drawing.Size(1174, 392);
            this.DgvSale.TabIndex = 45;
            this.DgvSale.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSale_CellValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(934, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 27);
            this.label9.TabIndex = 44;
            this.label9.Text = "لتعديل الكمية او الخصم اضغط F11         ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(935, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 27);
            this.label8.TabIndex = 43;
            this.label8.Text = "لدفع وحفظ وطباعة الفاتورة استخدم F12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(282, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 27);
            this.label7.TabIndex = 42;
            this.label7.Text = "F1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(721, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 27);
            this.label6.TabIndex = 41;
            this.label6.Text = "Delete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(636, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 27);
            this.label4.TabIndex = 40;
            this.label4.Text = "F2";
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(793, 83);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(111, 32);
            this.DtpDate.TabIndex = 39;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Appearance.Options.UseFont = true;
            this.btnDeleteItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.ImageOptions.Image")));
            this.btnDeleteItem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDeleteItem.Location = new System.Drawing.Point(674, 82);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(41, 33);
            this.btnDeleteItem.TabIndex = 38;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnItems
            // 
            this.btnItems.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Appearance.Options.UseFont = true;
            this.btnItems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItems.ImageOptions.Image")));
            this.btnItems.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnItems.Location = new System.Drawing.Point(593, 82);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(41, 33);
            this.btnItems.TabIndex = 37;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(316, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "اختر منتج:";
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(392, 82);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(195, 33);
            this.cbxItems.TabIndex = 35;
            // 
            // btnCustomerBrowes
            // 
            this.btnCustomerBrowes.Location = new System.Drawing.Point(721, 7);
            this.btnCustomerBrowes.Name = "btnCustomerBrowes";
            this.btnCustomerBrowes.Size = new System.Drawing.Size(41, 33);
            this.btnCustomerBrowes.TabIndex = 34;
            this.btnCustomerBrowes.Text = "...";
            this.btnCustomerBrowes.Click += new System.EventHandler(this.btnCustomerBrowes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(485, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "العميل:";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(547, 7);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(168, 33);
            this.cbxCustomer.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(2, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "رقم الباركود:";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(91, 80);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(185, 32);
            this.txtbarcode.TabIndex = 30;
            this.txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarcode_KeyPress);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(99, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(178, 32);
            this.txtID.TabIndex = 29;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // rbtnCustAagel
            // 
            this.rbtnCustAagel.AutoSize = true;
            this.rbtnCustAagel.Location = new System.Drawing.Point(392, 11);
            this.rbtnCustAagel.Name = "rbtnCustAagel";
            this.rbtnCustAagel.Size = new System.Drawing.Size(84, 29);
            this.rbtnCustAagel.TabIndex = 47;
            this.rbtnCustAagel.Text = "عميل أجل";
            this.rbtnCustAagel.UseVisualStyleBackColor = true;
            this.rbtnCustAagel.CheckedChanged += new System.EventHandler(this.rbtnCustAagel_CheckedChanged);
            // 
            // rbtnCustNakdy
            // 
            this.rbtnCustNakdy.AutoSize = true;
            this.rbtnCustNakdy.Checked = true;
            this.rbtnCustNakdy.Location = new System.Drawing.Point(283, 11);
            this.rbtnCustNakdy.Name = "rbtnCustNakdy";
            this.rbtnCustNakdy.Size = new System.Drawing.Size(93, 29);
            this.rbtnCustNakdy.TabIndex = 46;
            this.rbtnCustNakdy.TabStop = true;
            this.rbtnCustNakdy.Text = "عميل نقدى";
            this.rbtnCustNakdy.UseVisualStyleBackColor = true;
            this.rbtnCustNakdy.CheckedChanged += new System.EventHandler(this.rbtnCustNakdy_CheckedChanged);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(282, 40);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(178, 32);
            this.txtCustomer.TabIndex = 48;
            this.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(186, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 49;
            this.label10.Text = "عميل نقدي:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(808, 530);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 25);
            this.label14.TabIndex = 51;
            this.label14.Text = "اجمالى المطلوب:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(938, 528);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(248, 65);
            this.txtTotal.TabIndex = 50;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemsCount.Location = new System.Drawing.Point(359, 530);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(26, 27);
            this.lblItemsCount.TabIndex = 55;
            this.lblItemsCount.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(275, 530);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 27);
            this.label13.TabIndex = 54;
            this.label13.Text = "عدد الاصناف";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsername.Location = new System.Drawing.Point(107, 528);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(26, 27);
            this.lblUsername.TabIndex = 53;
            this.lblUsername.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(10, 528);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 27);
            this.label11.TabIndex = 52;
            this.label11.Text = "اسم المستخدم";
            // 
            // DtpReminder
            // 
            this.DtpReminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReminder.Location = new System.Drawing.Point(880, 7);
            this.DtpReminder.Name = "DtpReminder";
            this.DtpReminder.Size = new System.Drawing.Size(124, 32);
            this.DtpReminder.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(768, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 57;
            this.label12.Text = "تاريخ الاستحقاق:";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "اسم المنتج";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 25F;
            this.Column7.HeaderText = "الوحدة";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 25F;
            this.Column3.HeaderText = "الكمية";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 40F;
            this.Column4.HeaderText = "السعر شامل الضريبة";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 40F;
            this.Column5.HeaderText = "الخصم";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "الاجمالى";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1092, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 50);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // DtpTime
            // 
            this.DtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpTime.Location = new System.Drawing.Point(1111, 19);
            this.DtpTime.Name = "DtpTime";
            this.DtpTime.Size = new System.Drawing.Size(111, 32);
            this.DtpTime.TabIndex = 58;
            // 
            // Frm_Sales
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1261, 597);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtpTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DtpReminder);
            this.Controls.Add(this.lblItemsCount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.rbtnCustAagel);
            this.Controls.Add(this.rbtnCustNakdy);
            this.Controls.Add(this.DgvSale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.btnCustomerBrowes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_Sales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المبيعات (باركود)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Sales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Sales_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DgvSale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private DevExpress.XtraEditors.SimpleButton btnDeleteItem;
        private DevExpress.XtraEditors.SimpleButton btnItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxItems;
        private DevExpress.XtraEditors.SimpleButton btnCustomerBrowes;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnCustAagel;
        private System.Windows.Forms.RadioButton rbtnCustNakdy;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DtpReminder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DtpTime;
    }
}