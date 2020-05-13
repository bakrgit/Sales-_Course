namespace Sales_Managment
{
    partial class Frm_SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SalesReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpTo = new System.Windows.Forms.DateTimePicker();
            this.DtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.checkOrderNumber = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnOneUser = new System.Windows.Forms.RadioButton();
            this.rbtnAllUser = new System.Windows.Forms.RadioButton();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.btnPtintOrderAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.DgvSearch = new System.Windows.Forms.DataGridView();
            this.btnOrderPrint = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPriceTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserRb7h = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(357, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "اجمالى المبيعات فى فترة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DtpTo);
            this.groupBox2.Controls.Add(this.DtpFrom);
            this.groupBox2.Controls.Add(this.txtOrderNumber);
            this.groupBox2.Controls.Add(this.checkOrderNumber);
            this.groupBox2.Location = new System.Drawing.Point(60, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 78);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSearch.Location = new System.Drawing.Point(29, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(192, 36);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(376, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "الى:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(544, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "من:";
            // 
            // DtpTo
            // 
            this.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTo.Location = new System.Drawing.Point(255, 24);
            this.DtpTo.Name = "DtpTo";
            this.DtpTo.Size = new System.Drawing.Size(115, 36);
            this.DtpTo.TabIndex = 34;
            // 
            // DtpFrom
            // 
            this.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFrom.Location = new System.Drawing.Point(423, 24);
            this.DtpFrom.Name = "DtpFrom";
            this.DtpFrom.Size = new System.Drawing.Size(115, 36);
            this.DtpFrom.TabIndex = 33;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNumber.Location = new System.Drawing.Point(596, 24);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(73, 36);
            this.txtOrderNumber.TabIndex = 32;
            this.txtOrderNumber.Text = "1";
            this.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkOrderNumber
            // 
            this.checkOrderNumber.AutoSize = true;
            this.checkOrderNumber.Location = new System.Drawing.Point(675, 25);
            this.checkOrderNumber.Name = "checkOrderNumber";
            this.checkOrderNumber.Size = new System.Drawing.Size(111, 32);
            this.checkOrderNumber.TabIndex = 0;
            this.checkOrderNumber.Text = "رقم الفاتورة";
            this.checkOrderNumber.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnOneUser);
            this.groupBox1.Controls.Add(this.rbtnAllUser);
            this.groupBox1.Controls.Add(this.cbxUser);
            this.groupBox1.Location = new System.Drawing.Point(60, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 72);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // rbtnOneUser
            // 
            this.rbtnOneUser.AutoSize = true;
            this.rbtnOneUser.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOneUser.Location = new System.Drawing.Point(164, 29);
            this.rbtnOneUser.Name = "rbtnOneUser";
            this.rbtnOneUser.Size = new System.Drawing.Size(127, 32);
            this.rbtnOneUser.TabIndex = 11;
            this.rbtnOneUser.Text = "مستخدم محدد";
            this.rbtnOneUser.UseVisualStyleBackColor = true;
            // 
            // rbtnAllUser
            // 
            this.rbtnAllUser.AutoSize = true;
            this.rbtnAllUser.Checked = true;
            this.rbtnAllUser.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAllUser.Location = new System.Drawing.Point(297, 28);
            this.rbtnAllUser.Name = "rbtnAllUser";
            this.rbtnAllUser.Size = new System.Drawing.Size(135, 32);
            this.rbtnAllUser.TabIndex = 10;
            this.rbtnAllUser.TabStop = true;
            this.rbtnAllUser.Text = "كل المستخدمين";
            this.rbtnAllUser.UseVisualStyleBackColor = true;
            // 
            // cbxUser
            // 
            this.cbxUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(6, 28);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(152, 36);
            this.cbxUser.TabIndex = 9;
            // 
            // btnPtintOrderAll
            // 
            this.btnPtintOrderAll.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPtintOrderAll.Appearance.Options.UseFont = true;
            this.btnPtintOrderAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPtintOrderAll.ImageOptions.Image")));
            this.btnPtintOrderAll.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnPtintOrderAll.Location = new System.Drawing.Point(516, 139);
            this.btnPtintOrderAll.Name = "btnPtintOrderAll";
            this.btnPtintOrderAll.Size = new System.Drawing.Size(176, 45);
            this.btnPtintOrderAll.TabIndex = 30;
            this.btnPtintOrderAll.Text = "طباعة تقرير مفصل";
            this.btnPtintOrderAll.Click += new System.EventHandler(this.btnPtintOrderAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnDelete.Location = new System.Drawing.Point(698, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(238, 45);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "مسح البيانات فى هذه الفترة";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.DgvSearch.Location = new System.Drawing.Point(12, 202);
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
            this.DgvSearch.Size = new System.Drawing.Size(972, 287);
            this.DgvSearch.TabIndex = 32;
            // 
            // btnOrderPrint
            // 
            this.btnOrderPrint.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPrint.Appearance.Options.UseFont = true;
            this.btnOrderPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderPrint.ImageOptions.Image")));
            this.btnOrderPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnOrderPrint.Location = new System.Drawing.Point(12, 561);
            this.btnOrderPrint.Name = "btnOrderPrint";
            this.btnOrderPrint.Size = new System.Drawing.Size(197, 45);
            this.btnOrderPrint.TabIndex = 33;
            this.btnOrderPrint.Text = "طباعة الفاتورة المحددة";
            this.btnOrderPrint.Click += new System.EventHandler(this.btnOrderPrint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(10, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "اجمالى مبلغ المبيعات:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(172, 504);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 36);
            this.txtTotal.TabIndex = 36;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(334, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 37;
            this.label5.Text = "اجمالى الضريبة:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTax.Location = new System.Drawing.Point(454, 504);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(150, 36);
            this.txtTotalTax.TabIndex = 38;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(651, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 28);
            this.label6.TabIndex = 39;
            this.label6.Text = "اجمالى البيع بعد الضريبة:";
            // 
            // txtPriceTax
            // 
            this.txtPriceTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceTax.Location = new System.Drawing.Point(834, 504);
            this.txtPriceTax.Name = "txtPriceTax";
            this.txtPriceTax.ReadOnly = true;
            this.txtPriceTax.Size = new System.Drawing.Size(150, 36);
            this.txtPriceTax.TabIndex = 40;
            this.txtPriceTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(225, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 28);
            this.label7.TabIndex = 41;
            this.label7.Text = "اجمالى نسبه الربح للبائع المحدد:";
            // 
            // txtUserRb7h
            // 
            this.txtUserRb7h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserRb7h.Location = new System.Drawing.Point(454, 561);
            this.txtUserRb7h.Name = "txtUserRb7h";
            this.txtUserRb7h.ReadOnly = true;
            this.txtUserRb7h.Size = new System.Drawing.Size(150, 36);
            this.txtUserRb7h.TabIndex = 42;
            this.txtUserRb7h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(605, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 28);
            this.label8.TabIndex = 43;
            this.label8.Text = "%";
            // 
            // Frm_SalesReport
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(996, 613);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUserRb7h);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPriceTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnOrderPrint);
            this.Controls.Add(this.DgvSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPtintOrderAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_SalesReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير المبيعات";
            this.Load += new System.EventHandler(this.Frm_SalesReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpTo;
        private System.Windows.Forms.DateTimePicker DtpFrom;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.CheckBox checkOrderNumber;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnOneUser;
        private System.Windows.Forms.RadioButton rbtnAllUser;
        private System.Windows.Forms.ComboBox cbxUser;
        private DevExpress.XtraEditors.SimpleButton btnPtintOrderAll;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.DataGridView DgvSearch;
        private DevExpress.XtraEditors.SimpleButton btnOrderPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPriceTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserRb7h;
        private System.Windows.Forms.Label label8;
    }
}