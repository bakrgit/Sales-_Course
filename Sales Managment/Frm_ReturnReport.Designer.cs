namespace Sales_Managment
{
    partial class Frm_ReturnReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReturnReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBuyReturn = new System.Windows.Forms.RadioButton();
            this.rbtnSalesReturn = new System.Windows.Forms.RadioButton();
            this.rbtnAllReturn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpTo = new System.Windows.Forms.DateTimePicker();
            this.DtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.DgvSearch = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
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
            this.label2.Location = new System.Drawing.Point(370, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "تقارير المرتجعات فى فترة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnBuyReturn);
            this.groupBox1.Controls.Add(this.rbtnSalesReturn);
            this.groupBox1.Controls.Add(this.rbtnAllReturn);
            this.groupBox1.Location = new System.Drawing.Point(15, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 73);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فلترة البحث";
            // 
            // rbtnBuyReturn
            // 
            this.rbtnBuyReturn.AutoSize = true;
            this.rbtnBuyReturn.ForeColor = System.Drawing.Color.Blue;
            this.rbtnBuyReturn.Location = new System.Drawing.Point(4, 29);
            this.rbtnBuyReturn.Name = "rbtnBuyReturn";
            this.rbtnBuyReturn.Size = new System.Drawing.Size(147, 32);
            this.rbtnBuyReturn.TabIndex = 12;
            this.rbtnBuyReturn.Text = "مرتجعات مشتريات";
            this.rbtnBuyReturn.UseVisualStyleBackColor = true;
            // 
            // rbtnSalesReturn
            // 
            this.rbtnSalesReturn.AutoSize = true;
            this.rbtnSalesReturn.ForeColor = System.Drawing.Color.Blue;
            this.rbtnSalesReturn.Location = new System.Drawing.Point(153, 29);
            this.rbtnSalesReturn.Name = "rbtnSalesReturn";
            this.rbtnSalesReturn.Size = new System.Drawing.Size(136, 32);
            this.rbtnSalesReturn.TabIndex = 11;
            this.rbtnSalesReturn.Text = "مرتجعات مبيعات";
            this.rbtnSalesReturn.UseVisualStyleBackColor = true;
            // 
            // rbtnAllReturn
            // 
            this.rbtnAllReturn.AutoSize = true;
            this.rbtnAllReturn.Checked = true;
            this.rbtnAllReturn.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAllReturn.Location = new System.Drawing.Point(295, 29);
            this.rbtnAllReturn.Name = "rbtnAllReturn";
            this.rbtnAllReturn.Size = new System.Drawing.Size(118, 32);
            this.rbtnAllReturn.TabIndex = 10;
            this.rbtnAllReturn.TabStop = true;
            this.rbtnAllReturn.Text = "كل المرتجعات";
            this.rbtnAllReturn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DtpTo);
            this.groupBox2.Controls.Add(this.DtpFrom);
            this.groupBox2.Location = new System.Drawing.Point(457, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 73);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حدد فترة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(127, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "الى:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(295, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "من:";
            // 
            // DtpTo
            // 
            this.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTo.Location = new System.Drawing.Point(6, 28);
            this.DtpTo.Name = "DtpTo";
            this.DtpTo.Size = new System.Drawing.Size(115, 36);
            this.DtpTo.TabIndex = 34;
            // 
            // DtpFrom
            // 
            this.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFrom.Location = new System.Drawing.Point(174, 28);
            this.DtpFrom.Name = "DtpFrom";
            this.DtpFrom.Size = new System.Drawing.Size(115, 36);
            this.DtpFrom.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSearch.Location = new System.Drawing.Point(805, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(206, 46);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.DgvSearch.Location = new System.Drawing.Point(15, 132);
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
            this.DgvSearch.Size = new System.Drawing.Size(996, 298);
            this.DgvSearch.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(723, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "اجمالى المرتجعات:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(861, 441);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 36);
            this.txtTotal.TabIndex = 36;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnDelete.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnDelete.Location = new System.Drawing.Point(15, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 46);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(444, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 38;
            this.label5.Text = "اجمالى الضرايب:";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTax.Location = new System.Drawing.Point(567, 441);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(150, 36);
            this.txtTotalTax.TabIndex = 39;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_ReturnReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1023, 486);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.DgvSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_ReturnReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير المرتجعات";
            this.Load += new System.EventHandler(this.Frm_ReturnReport_Load);
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
        private System.Windows.Forms.RadioButton rbtnBuyReturn;
        private System.Windows.Forms.RadioButton rbtnSalesReturn;
        private System.Windows.Forms.RadioButton rbtnAllReturn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpTo;
        private System.Windows.Forms.DateTimePicker DtpFrom;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.DataGridView DgvSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalTax;
    }
}