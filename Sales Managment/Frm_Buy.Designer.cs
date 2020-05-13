namespace Sales_Managment
{
    partial class Frm_Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Buy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.btnSupplierbrowse = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.btnItems = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvBuy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.rbtnAagel = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.DtpAagel = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.DtpTime = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(101, 15);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(178, 32);
            this.txtID.TabIndex = 3;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "رقم الباركود:";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(101, 91);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(178, 32);
            this.txtbarcode.TabIndex = 12;
            this.txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarcode_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(338, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "المورد:";
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(395, 14);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(195, 33);
            this.cbxSupplier.TabIndex = 14;
            // 
            // btnSupplierbrowse
            // 
            this.btnSupplierbrowse.Location = new System.Drawing.Point(596, 14);
            this.btnSupplierbrowse.Name = "btnSupplierbrowse";
            this.btnSupplierbrowse.Size = new System.Drawing.Size(41, 33);
            this.btnSupplierbrowse.TabIndex = 16;
            this.btnSupplierbrowse.Text = "...";
            this.btnSupplierbrowse.Click += new System.EventHandler(this.btnSupplierbrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(322, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "اختر منتج:";
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(395, 93);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(195, 33);
            this.cbxItems.TabIndex = 17;
            // 
            // btnItems
            // 
            this.btnItems.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Appearance.Options.UseFont = true;
            this.btnItems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItems.ImageOptions.Image")));
            this.btnItems.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnItems.Location = new System.Drawing.Point(596, 93);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(41, 33);
            this.btnItems.TabIndex = 19;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Appearance.Options.UseFont = true;
            this.btnDeleteItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.ImageOptions.Image")));
            this.btnDeleteItem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDeleteItem.Location = new System.Drawing.Point(677, 93);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(41, 33);
            this.btnDeleteItem.TabIndex = 20;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(639, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "F2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(724, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "Delete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(285, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "F1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(656, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 27);
            this.label8.TabIndex = 25;
            this.label8.Text = "لدفع وحفظ وطباعة الفاتورة استخدم F12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(655, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 27);
            this.label9.TabIndex = 26;
            this.label9.Text = "لتعديل الكمية او الخصم اضغط F11         ";
            // 
            // DgvBuy
            // 
            this.DgvBuy.AllowUserToAddRows = false;
            this.DgvBuy.AllowUserToDeleteRows = false;
            this.DgvBuy.AllowUserToResizeColumns = false;
            this.DgvBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvBuy.BackgroundColor = System.Drawing.Color.White;
            this.DgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBuy.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBuy.Location = new System.Drawing.Point(13, 141);
            this.DgvBuy.Name = "DgvBuy";
            this.DgvBuy.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBuy.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBuy.RowHeadersVisible = false;
            this.DgvBuy.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvBuy.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.DgvBuy.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DgvBuy.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.DgvBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBuy.Size = new System.Drawing.Size(1174, 392);
            this.DgvBuy.TabIndex = 27;
            this.DgvBuy.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBuy_CellValueChanged);
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
            this.Column7.FillWeight = 40F;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(15, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 27);
            this.label10.TabIndex = 28;
            this.label10.Text = "اسم المستخدم";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsername.Location = new System.Drawing.Point(111, 536);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(26, 27);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "...";
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemsCount.Location = new System.Drawing.Point(98, 567);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(26, 27);
            this.lblItemsCount.TabIndex = 31;
            this.lblItemsCount.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(15, 567);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 27);
            this.label13.TabIndex = 30;
            this.label13.Text = "عدد الاصناف";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(941, 542);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(248, 65);
            this.txtTotal.TabIndex = 32;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(826, 545);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "اجمالى المطلوب:";
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Checked = true;
            this.rbtnCash.Location = new System.Drawing.Point(272, 545);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(132, 29);
            this.rbtnCash.TabIndex = 34;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "دفع الفاتورة كاش";
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // rbtnAagel
            // 
            this.rbtnAagel.AutoSize = true;
            this.rbtnAagel.Location = new System.Drawing.Point(272, 578);
            this.rbtnAagel.Name = "rbtnAagel";
            this.rbtnAagel.Size = new System.Drawing.Size(78, 29);
            this.rbtnAagel.TabIndex = 35;
            this.rbtnAagel.Text = "دفع أجل";
            this.rbtnAagel.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(356, 580);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "تاريخ الاستحقاق:";
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(796, 94);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(111, 32);
            this.DtpDate.TabIndex = 21;
            // 
            // DtpAagel
            // 
            this.DtpAagel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpAagel.Location = new System.Drawing.Point(466, 575);
            this.DtpAagel.Name = "DtpAagel";
            this.DtpAagel.Size = new System.Drawing.Size(111, 32);
            this.DtpAagel.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(591, 577);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "اختر مخزن:";
            // 
            // cbxStore
            // 
            this.cbxStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(664, 574);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(168, 33);
            this.cbxStore.TabIndex = 38;
            // 
            // DtpTime
            // 
            this.DtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpTime.Location = new System.Drawing.Point(1118, 12);
            this.DtpTime.Name = "DtpTime";
            this.DtpTime.Size = new System.Drawing.Size(111, 32);
            this.DtpTime.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1099, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 50);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Buy
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1325, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtpTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxStore);
            this.Controls.Add(this.DtpAagel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rbtnAagel);
            this.Controls.Add(this.rbtnCash);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblItemsCount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvBuy);
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
            this.Controls.Add(this.btnSupplierbrowse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Frm_Buy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عمليات الشراء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Buy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Buy_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnSupplierbrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxItems;
        private DevExpress.XtraEditors.SimpleButton btnItems;
        private DevExpress.XtraEditors.SimpleButton btnDeleteItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.RadioButton rbtnAagel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.DateTimePicker DtpAagel;
        public System.Windows.Forms.ComboBox cbxSupplier;
        public System.Windows.Forms.DataGridView DgvBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.DateTimePicker DtpTime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}