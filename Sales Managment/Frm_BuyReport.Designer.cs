namespace Sales_Managment
{
    partial class Frm_BuyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuyReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnOneSupplier = new System.Windows.Forms.RadioButton();
            this.rbtnAllSup = new System.Windows.Forms.RadioButton();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpTo = new System.Windows.Forms.DateTimePicker();
            this.DtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.checkOrderNumber = new System.Windows.Forms.CheckBox();
            this.DgvSearch = new System.Windows.Forms.DataGridView();
            this.btnPtintOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintAll = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(356, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 36);
            this.label2.TabIndex = 25;
            this.label2.Text = "تقارير المشتريات فى فترة محددة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rbtnOneSupplier);
            this.groupBox1.Controls.Add(this.rbtnAllSup);
            this.groupBox1.Controls.Add(this.cbxSupplier);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 80);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSearch.Location = new System.Drawing.Point(6, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 46);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbtnOneSupplier
            // 
            this.rbtnOneSupplier.AutoSize = true;
            this.rbtnOneSupplier.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOneSupplier.Location = new System.Drawing.Point(264, 35);
            this.rbtnOneSupplier.Name = "rbtnOneSupplier";
            this.rbtnOneSupplier.Size = new System.Drawing.Size(100, 32);
            this.rbtnOneSupplier.TabIndex = 11;
            this.rbtnOneSupplier.Text = "مورد محدد";
            this.rbtnOneSupplier.UseVisualStyleBackColor = true;
            // 
            // rbtnAllSup
            // 
            this.rbtnAllSup.AutoSize = true;
            this.rbtnAllSup.Checked = true;
            this.rbtnAllSup.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAllSup.Location = new System.Drawing.Point(364, 35);
            this.rbtnAllSup.Name = "rbtnAllSup";
            this.rbtnAllSup.Size = new System.Drawing.Size(109, 32);
            this.rbtnAllSup.TabIndex = 10;
            this.rbtnAllSup.TabStop = true;
            this.rbtnAllSup.Text = "كل الموردين";
            this.rbtnAllSup.UseVisualStyleBackColor = true;
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(106, 34);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(152, 36);
            this.cbxSupplier.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DtpTo);
            this.groupBox2.Controls.Add(this.DtpFrom);
            this.groupBox2.Controls.Add(this.txtOrderNumber);
            this.groupBox2.Controls.Add(this.checkOrderNumber);
            this.groupBox2.Location = new System.Drawing.Point(503, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 80);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(127, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "الى:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(295, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "من:";
            // 
            // DtpTo
            // 
            this.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTo.Location = new System.Drawing.Point(6, 25);
            this.DtpTo.Name = "DtpTo";
            this.DtpTo.Size = new System.Drawing.Size(115, 36);
            this.DtpTo.TabIndex = 34;
            // 
            // DtpFrom
            // 
            this.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFrom.Location = new System.Drawing.Point(174, 25);
            this.DtpFrom.Name = "DtpFrom";
            this.DtpFrom.Size = new System.Drawing.Size(115, 36);
            this.DtpFrom.TabIndex = 33;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNumber.Location = new System.Drawing.Point(337, 25);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(45, 36);
            this.txtOrderNumber.TabIndex = 32;
            this.txtOrderNumber.Text = "1";
            this.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkOrderNumber
            // 
            this.checkOrderNumber.AutoSize = true;
            this.checkOrderNumber.Location = new System.Drawing.Point(393, 29);
            this.checkOrderNumber.Name = "checkOrderNumber";
            this.checkOrderNumber.Size = new System.Drawing.Size(111, 32);
            this.checkOrderNumber.TabIndex = 0;
            this.checkOrderNumber.Text = "رقم الفاتورة";
            this.checkOrderNumber.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearch.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearch.Location = new System.Drawing.Point(12, 134);
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
            this.DgvSearch.Size = new System.Drawing.Size(1010, 298);
            this.DgvSearch.TabIndex = 29;
            this.DgvSearch.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearch_CellEndEdit);
            // 
            // btnPtintOrder
            // 
            this.btnPtintOrder.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPtintOrder.Appearance.Options.UseFont = true;
            this.btnPtintOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPtintOrder.ImageOptions.Image")));
            this.btnPtintOrder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnPtintOrder.Location = new System.Drawing.Point(12, 438);
            this.btnPtintOrder.Name = "btnPtintOrder";
            this.btnPtintOrder.Size = new System.Drawing.Size(151, 46);
            this.btnPtintOrder.TabIndex = 13;
            this.btnPtintOrder.Text = "طباعة الفاتورة";
            this.btnPtintOrder.Click += new System.EventHandler(this.btnPtintOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnDelete.Location = new System.Drawing.Point(168, 438);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 46);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "مسح فاتورة";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAll.Appearance.Options.UseFont = true;
            this.btnPrintAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintAll.ImageOptions.Image")));
            this.btnPrintAll.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnPrintAll.Location = new System.Drawing.Point(325, 438);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(174, 46);
            this.btnPrintAll.TabIndex = 32;
            this.btnPrintAll.Text = "طباعة كل الفواتير";
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(694, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "اجمالى مبالغ المشتريات:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(872, 444);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 36);
            this.txtTotal.TabIndex = 34;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(657, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 28);
            this.label5.TabIndex = 35;
            this.label5.Text = "اجمالى الضرائب على العمليات:";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTax.Location = new System.Drawing.Point(872, 486);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(150, 36);
            this.txtTotalTax.TabIndex = 36;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_BuyReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1034, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPtintOrder);
            this.Controls.Add(this.DgvSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_BuyReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة تقارير المشتريات";
            this.Load += new System.EventHandler(this.Frm_BuyReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.RadioButton rbtnOneSupplier;
        private System.Windows.Forms.RadioButton rbtnAllSup;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkOrderNumber;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.DateTimePicker DtpTo;
        private System.Windows.Forms.DateTimePicker DtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvSearch;
        private DevExpress.XtraEditors.SimpleButton btnPtintOrder;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnPrintAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalTax;
    }
}