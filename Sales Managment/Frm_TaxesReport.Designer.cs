namespace Sales_Managment
{
    partial class Frm_TaxesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TaxesReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpTo = new System.Windows.Forms.DateTimePicker();
            this.DtpFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.checkSale = new System.Windows.Forms.CheckBox();
            this.checkBuy = new System.Windows.Forms.CheckBox();
            this.checkSaleReturn = new System.Windows.Forms.CheckBox();
            this.checkBuyReturn = new System.Windows.Forms.CheckBox();
            this.DgvSearch = new System.Windows.Forms.DataGridView();
            this.btnPrintSummary = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnPtintReport = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalAfterTax = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DtpTo);
            this.groupBox2.Controls.Add(this.DtpFrom);
            this.groupBox2.Location = new System.Drawing.Point(499, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 87);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(127, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "الى:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(295, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "من:";
            // 
            // DtpTo
            // 
            this.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTo.Location = new System.Drawing.Point(6, 35);
            this.DtpTo.Name = "DtpTo";
            this.DtpTo.Size = new System.Drawing.Size(115, 32);
            this.DtpTo.TabIndex = 34;
            // 
            // DtpFrom
            // 
            this.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFrom.Location = new System.Drawing.Point(174, 35);
            this.DtpFrom.Name = "DtpFrom";
            this.DtpFrom.Size = new System.Drawing.Size(115, 32);
            this.DtpFrom.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBuyReturn);
            this.groupBox1.Controls.Add(this.checkSaleReturn);
            this.groupBox1.Controls.Add(this.checkBuy);
            this.groupBox1.Controls.Add(this.checkSale);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 87);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSearch.Location = new System.Drawing.Point(865, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 46);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "عرض التقرير";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(362, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "الاقرار الضريبي فى فترة محددة";
            // 
            // checkSale
            // 
            this.checkSale.AutoSize = true;
            this.checkSale.Location = new System.Drawing.Point(253, 23);
            this.checkSale.Name = "checkSale";
            this.checkSale.Size = new System.Drawing.Size(116, 29);
            this.checkSale.TabIndex = 36;
            this.checkSale.Text = "فواتير المبيعات";
            this.checkSale.UseVisualStyleBackColor = true;
            this.checkSale.CheckedChanged += new System.EventHandler(this.checkSale_CheckedChanged);
            // 
            // checkBuy
            // 
            this.checkBuy.AutoSize = true;
            this.checkBuy.Location = new System.Drawing.Point(252, 50);
            this.checkBuy.Name = "checkBuy";
            this.checkBuy.Size = new System.Drawing.Size(117, 29);
            this.checkBuy.TabIndex = 37;
            this.checkBuy.Text = "فواتير مشتريات";
            this.checkBuy.UseVisualStyleBackColor = true;
            // 
            // checkSaleReturn
            // 
            this.checkSaleReturn.AutoSize = true;
            this.checkSaleReturn.Location = new System.Drawing.Point(97, 23);
            this.checkSaleReturn.Name = "checkSaleReturn";
            this.checkSaleReturn.Size = new System.Drawing.Size(119, 29);
            this.checkSaleReturn.TabIndex = 38;
            this.checkSaleReturn.Text = "مرتجعات مبيعات";
            this.checkSaleReturn.UseVisualStyleBackColor = true;
            // 
            // checkBuyReturn
            // 
            this.checkBuyReturn.AutoSize = true;
            this.checkBuyReturn.Location = new System.Drawing.Point(87, 50);
            this.checkBuyReturn.Name = "checkBuyReturn";
            this.checkBuyReturn.Size = new System.Drawing.Size(129, 29);
            this.checkBuyReturn.TabIndex = 39;
            this.checkBuyReturn.Text = "مرتجعات مشتريات";
            this.checkBuyReturn.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearch.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgvSearch.Location = new System.Drawing.Point(12, 133);
            this.DgvSearch.Name = "DgvSearch";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.DgvSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DgvSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.DgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearch.Size = new System.Drawing.Size(1029, 298);
            this.DgvSearch.TabIndex = 31;
            // 
            // btnPrintSummary
            // 
            this.btnPrintSummary.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSummary.Appearance.Options.UseFont = true;
            this.btnPrintSummary.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintAll.ImageOptions.Image")));
            this.btnPrintSummary.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnPrintSummary.Location = new System.Drawing.Point(252, 437);
            this.btnPrintSummary.Name = "btnPrintSummary";
            this.btnPrintSummary.Size = new System.Drawing.Size(118, 46);
            this.btnPrintSummary.TabIndex = 35;
            this.btnPrintSummary.Text = "طباعة ملخص";
            this.btnPrintSummary.Click += new System.EventHandler(this.btnPrintSummary_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnDelete.Location = new System.Drawing.Point(12, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 46);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "مسح البيانات";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPtintReport
            // 
            this.btnPtintReport.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPtintReport.Appearance.Options.UseFont = true;
            this.btnPtintReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPtintOrder.ImageOptions.Image")));
            this.btnPtintReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnPtintReport.Location = new System.Drawing.Point(132, 437);
            this.btnPtintReport.Name = "btnPtintReport";
            this.btnPtintReport.Size = new System.Drawing.Size(117, 46);
            this.btnPtintReport.TabIndex = 33;
            this.btnPtintReport.Text = "طباعة تقرير";
            this.btnPtintReport.Click += new System.EventHandler(this.btnPtintReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(371, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "اجمالى الفواتير:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(476, 446);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(118, 32);
            this.txtTotal.TabIndex = 37;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(602, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "اجمالى الضرايب:";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTax.Location = new System.Drawing.Point(712, 446);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(96, 32);
            this.txtTotalTax.TabIndex = 39;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(808, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "الاجمالى بعد الضرايب:";
            // 
            // txtTotalAfterTax
            // 
            this.txtTotalAfterTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAfterTax.Location = new System.Drawing.Point(945, 448);
            this.txtTotalAfterTax.Name = "txtTotalAfterTax";
            this.txtTotalAfterTax.ReadOnly = true;
            this.txtTotalAfterTax.Size = new System.Drawing.Size(96, 32);
            this.txtTotalAfterTax.TabIndex = 41;
            this.txtTotalAfterTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_TaxesReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1053, 493);
            this.Controls.Add(this.txtTotalAfterTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnPrintSummary);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPtintReport);
            this.Controls.Add(this.DgvSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Frm_TaxesReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاقرار الضريبي";
            this.Load += new System.EventHandler(this.Frm_TaxesReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpTo;
        private System.Windows.Forms.DateTimePicker DtpFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBuyReturn;
        private System.Windows.Forms.CheckBox checkSaleReturn;
        private System.Windows.Forms.CheckBox checkBuy;
        private System.Windows.Forms.CheckBox checkSale;
        private System.Windows.Forms.DataGridView DgvSearch;
        private DevExpress.XtraEditors.SimpleButton btnPrintSummary;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnPtintReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalAfterTax;
    }
}