namespace Sales_Managment
{
    partial class Frm_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Return));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBuy = new System.Windows.Forms.RadioButton();
            this.rbtnSales = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalOrderAfterTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbaky = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMadfou3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxStore1 = new System.Windows.Forms.ComboBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.btnReturnAll = new DevExpress.XtraEditors.SimpleButton();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReturnItemOnly = new DevExpress.XtraEditors.SimpleButton();
            this.cbxStore2 = new System.Windows.Forms.ComboBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.NudQty = new System.Windows.Forms.NumericUpDown();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.rbtnReturnQtyonly = new System.Windows.Forms.RadioButton();
            this.rbtnReturnItemOnly = new System.Windows.Forms.RadioButton();
            this.DgvSearch = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(353, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "ادارة المرتجعات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnBuy);
            this.groupBox1.Controls.Add(this.rbtnSales);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 65);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // rbtnBuy
            // 
            this.rbtnBuy.AutoSize = true;
            this.rbtnBuy.ForeColor = System.Drawing.Color.Blue;
            this.rbtnBuy.Location = new System.Drawing.Point(6, 23);
            this.rbtnBuy.Name = "rbtnBuy";
            this.rbtnBuy.Size = new System.Drawing.Size(147, 32);
            this.rbtnBuy.TabIndex = 11;
            this.rbtnBuy.Text = "مرتجعات مشتريات";
            this.rbtnBuy.UseVisualStyleBackColor = true;
            this.rbtnBuy.CheckedChanged += new System.EventHandler(this.rbtnBuy_CheckedChanged);
            // 
            // rbtnSales
            // 
            this.rbtnSales.AutoSize = true;
            this.rbtnSales.Checked = true;
            this.rbtnSales.ForeColor = System.Drawing.Color.Blue;
            this.rbtnSales.Location = new System.Drawing.Point(159, 23);
            this.rbtnSales.Name = "rbtnSales";
            this.rbtnSales.Size = new System.Drawing.Size(136, 32);
            this.rbtnSales.TabIndex = 10;
            this.rbtnSales.TabStop = true;
            this.rbtnSales.Text = "مرتجعات مبيعات";
            this.rbtnSales.UseVisualStyleBackColor = true;
            this.rbtnSales.CheckedChanged += new System.EventHandler(this.rbtnSales_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(327, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "تاريخ المرتجع:";
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(433, 40);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(115, 36);
            this.DtpDate.TabIndex = 35;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(730, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 36);
            this.txtID.TabIndex = 36;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(591, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "بحث برقم الفاتورة:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTotalOrderAfterTax);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotalTax);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtbaky);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotalOrder);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMadfou3);
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 106);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(162, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 28);
            this.label8.TabIndex = 47;
            this.label8.Text = "الاجمالى بعد الضرائب:";
            // 
            // txtTotalOrderAfterTax
            // 
            this.txtTotalOrderAfterTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalOrderAfterTax.Location = new System.Drawing.Point(6, 65);
            this.txtTotalOrderAfterTax.Name = "txtTotalOrderAfterTax";
            this.txtTotalOrderAfterTax.ReadOnly = true;
            this.txtTotalOrderAfterTax.Size = new System.Drawing.Size(150, 36);
            this.txtTotalOrderAfterTax.TabIndex = 46;
            this.txtTotalOrderAfterTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(162, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 28);
            this.label7.TabIndex = 45;
            this.label7.Text = "اجمالى الضرائب:";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTax.Location = new System.Drawing.Point(6, 21);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(150, 36);
            this.txtTotalTax.TabIndex = 44;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(751, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 28);
            this.label6.TabIndex = 43;
            this.label6.Text = "المبلغ المتبقى:";
            // 
            // txtbaky
            // 
            this.txtbaky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbaky.Location = new System.Drawing.Point(332, 63);
            this.txtbaky.Name = "txtbaky";
            this.txtbaky.ReadOnly = true;
            this.txtbaky.Size = new System.Drawing.Size(418, 36);
            this.txtbaky.TabIndex = 42;
            this.txtbaky.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(483, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "اجمالى الفاتورة:";
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalOrder.Location = new System.Drawing.Point(332, 21);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.ReadOnly = true;
            this.txtTotalOrder.Size = new System.Drawing.Size(150, 36);
            this.txtTotalOrder.TabIndex = 40;
            this.txtTotalOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(751, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 39;
            this.label4.Text = "المبلغ المدفوع:";
            // 
            // txtMadfou3
            // 
            this.txtMadfou3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMadfou3.Location = new System.Drawing.Point(622, 21);
            this.txtMadfou3.Name = "txtMadfou3";
            this.txtMadfou3.ReadOnly = true;
            this.txtMadfou3.Size = new System.Drawing.Size(128, 36);
            this.txtMadfou3.TabIndex = 35;
            this.txtMadfou3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbxStore1);
            this.groupBox3.Controls.Add(this.lblName1);
            this.groupBox3.Controls.Add(this.btnReturnAll);
            this.groupBox3.Controls.Add(this.txtName1);
            this.groupBox3.Location = new System.Drawing.Point(12, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 174);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(200, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 28);
            this.label10.TabIndex = 51;
            this.label10.Text = "الى المخزن:";
            // 
            // cbxStore1
            // 
            this.cbxStore1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStore1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStore1.FormattingEnabled = true;
            this.cbxStore1.Location = new System.Drawing.Point(35, 75);
            this.cbxStore1.Name = "cbxStore1";
            this.cbxStore1.Size = new System.Drawing.Size(162, 36);
            this.cbxStore1.TabIndex = 50;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.ForeColor = System.Drawing.Color.Red;
            this.lblName1.Location = new System.Drawing.Point(198, 28);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(92, 28);
            this.lblName1.TabIndex = 49;
            this.lblName1.Text = "اسم العميل:";
            // 
            // btnReturnAll
            // 
            this.btnReturnAll.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnAll.Appearance.Options.UseFont = true;
            this.btnReturnAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnAll.ImageOptions.Image")));
            this.btnReturnAll.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnReturnAll.Location = new System.Drawing.Point(35, 118);
            this.btnReturnAll.Name = "btnReturnAll";
            this.btnReturnAll.Size = new System.Drawing.Size(247, 46);
            this.btnReturnAll.TabIndex = 14;
            this.btnReturnAll.Text = "ارجاع الفاتورة بالكامل";
            this.btnReturnAll.Click += new System.EventHandler(this.btnReturnAll_Click);
            // 
            // txtName1
            // 
            this.txtName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName1.Location = new System.Drawing.Point(35, 26);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(162, 36);
            this.txtName1.TabIndex = 48;
            this.txtName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnReturnItemOnly);
            this.groupBox4.Controls.Add(this.cbxStore2);
            this.groupBox4.Controls.Add(this.lblName2);
            this.groupBox4.Controls.Add(this.NudQty);
            this.groupBox4.Controls.Add(this.txtName2);
            this.groupBox4.Controls.Add(this.rbtnReturnQtyonly);
            this.groupBox4.Controls.Add(this.rbtnReturnItemOnly);
            this.groupBox4.Location = new System.Drawing.Point(371, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(509, 174);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(355, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 28);
            this.label12.TabIndex = 53;
            this.label12.Text = "الى المخزن:";
            // 
            // btnReturnItemOnly
            // 
            this.btnReturnItemOnly.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnItemOnly.Appearance.Options.UseFont = true;
            this.btnReturnItemOnly.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnItemOnly.ImageOptions.Image")));
            this.btnReturnItemOnly.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnReturnItemOnly.Location = new System.Drawing.Point(22, 68);
            this.btnReturnItemOnly.Name = "btnReturnItemOnly";
            this.btnReturnItemOnly.Size = new System.Drawing.Size(218, 46);
            this.btnReturnItemOnly.TabIndex = 52;
            this.btnReturnItemOnly.Text = "ارجاع الصنف المحدد فقط";
            this.btnReturnItemOnly.Click += new System.EventHandler(this.btnReturnItemOnly_Click);
            // 
            // cbxStore2
            // 
            this.cbxStore2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStore2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStore2.FormattingEnabled = true;
            this.cbxStore2.Location = new System.Drawing.Point(22, 130);
            this.cbxStore2.Name = "cbxStore2";
            this.cbxStore2.Size = new System.Drawing.Size(327, 36);
            this.cbxStore2.TabIndex = 52;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.ForeColor = System.Drawing.Color.Red;
            this.lblName2.Location = new System.Drawing.Point(185, 28);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(92, 28);
            this.lblName2.TabIndex = 53;
            this.lblName2.Text = "اسم العميل:";
            // 
            // NudQty
            // 
            this.NudQty.DecimalPlaces = 2;
            this.NudQty.Location = new System.Drawing.Point(273, 71);
            this.NudQty.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.NudQty.Name = "NudQty";
            this.NudQty.Size = new System.Drawing.Size(63, 36);
            this.NudQty.TabIndex = 14;
            this.NudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtName2
            // 
            this.txtName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName2.Location = new System.Drawing.Point(22, 26);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(162, 36);
            this.txtName2.TabIndex = 52;
            this.txtName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtnReturnQtyonly
            // 
            this.rbtnReturnQtyonly.AutoSize = true;
            this.rbtnReturnQtyonly.ForeColor = System.Drawing.Color.Blue;
            this.rbtnReturnQtyonly.Location = new System.Drawing.Point(342, 73);
            this.rbtnReturnQtyonly.Name = "rbtnReturnQtyonly";
            this.rbtnReturnQtyonly.Size = new System.Drawing.Size(160, 32);
            this.rbtnReturnQtyonly.TabIndex = 13;
            this.rbtnReturnQtyonly.Text = "ارجاع جزء من المحدد";
            this.rbtnReturnQtyonly.UseVisualStyleBackColor = true;
            // 
            // rbtnReturnItemOnly
            // 
            this.rbtnReturnItemOnly.AutoSize = true;
            this.rbtnReturnItemOnly.Checked = true;
            this.rbtnReturnItemOnly.ForeColor = System.Drawing.Color.Blue;
            this.rbtnReturnItemOnly.Location = new System.Drawing.Point(283, 35);
            this.rbtnReturnItemOnly.Name = "rbtnReturnItemOnly";
            this.rbtnReturnItemOnly.Size = new System.Drawing.Size(219, 32);
            this.rbtnReturnItemOnly.TabIndex = 12;
            this.rbtnReturnItemOnly.TabStop = true;
            this.rbtnReturnItemOnly.Text = "ارجاع الكمية المحدده بالكامل";
            this.rbtnReturnItemOnly.UseVisualStyleBackColor = true;
            // 
            // DgvSearch
            // 
            this.DgvSearch.AllowUserToAddRows = false;
            this.DgvSearch.AllowUserToDeleteRows = false;
            this.DgvSearch.AllowUserToResizeColumns = false;
            this.DgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSearch.BackgroundColor = System.Drawing.Color.White;
            this.DgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearch.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearch.Location = new System.Drawing.Point(12, 92);
            this.DgvSearch.Name = "DgvSearch";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.DgvSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DgvSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.DgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearch.Size = new System.Drawing.Size(868, 218);
            this.DgvSearch.TabIndex = 53;
            // 
            // Frm_Return
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(887, 592);
            this.Controls.Add(this.DgvSearch);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_Return";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المرتجعات";
            this.Load += new System.EventHandler(this.Frm_Return_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnBuy;
        private System.Windows.Forms.RadioButton rbtnSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbaky;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMadfou3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalOrderAfterTax;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblName1;
        private DevExpress.XtraEditors.SimpleButton btnReturnAll;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxStore1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnReturnQtyonly;
        private System.Windows.Forms.RadioButton rbtnReturnItemOnly;
        private System.Windows.Forms.NumericUpDown NudQty;
        private DevExpress.XtraEditors.SimpleButton btnReturnItemOnly;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxStore2;
        private System.Windows.Forms.DataGridView DgvSearch;
    }
}