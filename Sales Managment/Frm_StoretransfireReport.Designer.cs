namespace Sales_Managment
{
    partial class Frm_StoretransfireReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StoretransfireReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnOneStoreFrom = new System.Windows.Forms.RadioButton();
            this.rbtnAllStoreFrom = new System.Windows.Forms.RadioButton();
            this.cbxStoreFrom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnOneStoreTo = new System.Windows.Forms.RadioButton();
            this.rbtnAllStoreTo = new System.Windows.Forms.RadioButton();
            this.cbxStoreTo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpTo = new System.Windows.Forms.DateTimePicker();
            this.DtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.DgvSearch = new System.Windows.Forms.DataGridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(494, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "اجمالى المنتجات المحولة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnOneStoreFrom);
            this.groupBox1.Controls.Add(this.rbtnAllStoreFrom);
            this.groupBox1.Controls.Add(this.cbxStoreFrom);
            this.groupBox1.Location = new System.Drawing.Point(9, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 80);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المخازن المحول منها";
            // 
            // rbtnOneStoreFrom
            // 
            this.rbtnOneStoreFrom.AutoSize = true;
            this.rbtnOneStoreFrom.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOneStoreFrom.Location = new System.Drawing.Point(168, 31);
            this.rbtnOneStoreFrom.Name = "rbtnOneStoreFrom";
            this.rbtnOneStoreFrom.Size = new System.Drawing.Size(103, 32);
            this.rbtnOneStoreFrom.TabIndex = 11;
            this.rbtnOneStoreFrom.Text = "مخزن محدد";
            this.rbtnOneStoreFrom.UseVisualStyleBackColor = true;
            // 
            // rbtnAllStoreFrom
            // 
            this.rbtnAllStoreFrom.AutoSize = true;
            this.rbtnAllStoreFrom.Checked = true;
            this.rbtnAllStoreFrom.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAllStoreFrom.Location = new System.Drawing.Point(268, 31);
            this.rbtnAllStoreFrom.Name = "rbtnAllStoreFrom";
            this.rbtnAllStoreFrom.Size = new System.Drawing.Size(101, 32);
            this.rbtnAllStoreFrom.TabIndex = 10;
            this.rbtnAllStoreFrom.TabStop = true;
            this.rbtnAllStoreFrom.Text = "كل المخازن";
            this.rbtnAllStoreFrom.UseVisualStyleBackColor = true;
            // 
            // cbxStoreFrom
            // 
            this.cbxStoreFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStoreFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStoreFrom.FormattingEnabled = true;
            this.cbxStoreFrom.Location = new System.Drawing.Point(6, 31);
            this.cbxStoreFrom.Name = "cbxStoreFrom";
            this.cbxStoreFrom.Size = new System.Drawing.Size(152, 36);
            this.cbxStoreFrom.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnOneStoreTo);
            this.groupBox2.Controls.Add(this.rbtnAllStoreTo);
            this.groupBox2.Controls.Add(this.cbxStoreTo);
            this.groupBox2.Location = new System.Drawing.Point(400, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 80);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المخازن المحول لها";
            // 
            // rbtnOneStoreTo
            // 
            this.rbtnOneStoreTo.AutoSize = true;
            this.rbtnOneStoreTo.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOneStoreTo.Location = new System.Drawing.Point(168, 31);
            this.rbtnOneStoreTo.Name = "rbtnOneStoreTo";
            this.rbtnOneStoreTo.Size = new System.Drawing.Size(103, 32);
            this.rbtnOneStoreTo.TabIndex = 11;
            this.rbtnOneStoreTo.Text = "مخزن محدد";
            this.rbtnOneStoreTo.UseVisualStyleBackColor = true;
            // 
            // rbtnAllStoreTo
            // 
            this.rbtnAllStoreTo.AutoSize = true;
            this.rbtnAllStoreTo.Checked = true;
            this.rbtnAllStoreTo.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAllStoreTo.Location = new System.Drawing.Point(268, 31);
            this.rbtnAllStoreTo.Name = "rbtnAllStoreTo";
            this.rbtnAllStoreTo.Size = new System.Drawing.Size(101, 32);
            this.rbtnAllStoreTo.TabIndex = 10;
            this.rbtnAllStoreTo.TabStop = true;
            this.rbtnAllStoreTo.Text = "كل المخازن";
            this.rbtnAllStoreTo.UseVisualStyleBackColor = true;
            // 
            // cbxStoreTo
            // 
            this.cbxStoreTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStoreTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStoreTo.FormattingEnabled = true;
            this.cbxStoreTo.Location = new System.Drawing.Point(6, 31);
            this.cbxStoreTo.Name = "cbxStoreTo";
            this.cbxStoreTo.Size = new System.Drawing.Size(152, 36);
            this.cbxStoreTo.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.DtpTo);
            this.groupBox3.Controls.Add(this.DtpFrom);
            this.groupBox3.Location = new System.Drawing.Point(791, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 80);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
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
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSearch.Location = new System.Drawing.Point(488, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(257, 45);
            this.btnSearch.TabIndex = 30;
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearch.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearch.Location = new System.Drawing.Point(9, 175);
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
            this.DgvSearch.Size = new System.Drawing.Size(1119, 281);
            this.DgvSearch.TabIndex = 31;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnDelete.Location = new System.Drawing.Point(9, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(257, 45);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "مسح البيانات";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalQty.Location = new System.Drawing.Point(978, 471);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.ReadOnly = true;
            this.txtTotalQty.Size = new System.Drawing.Size(150, 36);
            this.txtTotalQty.TabIndex = 36;
            this.txtTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(800, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "اجمالى الكميات المحولة:";
            // 
            // Frm_StoretransfireReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1146, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalQty);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.DgvSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_StoretransfireReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير تحويل المنتجات بين المخازن";
            this.Load += new System.EventHandler(this.Frm_StoretransfireReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnOneStoreFrom;
        private System.Windows.Forms.RadioButton rbtnAllStoreFrom;
        private System.Windows.Forms.ComboBox cbxStoreFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnOneStoreTo;
        private System.Windows.Forms.RadioButton rbtnAllStoreTo;
        private System.Windows.Forms.ComboBox cbxStoreTo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpTo;
        private System.Windows.Forms.DateTimePicker DtpFrom;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.DataGridView DgvSearch;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.Label label4;
    }
}