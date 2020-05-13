namespace Sales_Managment
{
    partial class Frm_ProductsOutStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProductsOutStore));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NudQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStoreFrom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtReason);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.DtpDate);
            this.groupBox3.Location = new System.Drawing.Point(497, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 253);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات العملية";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnAdd.Location = new System.Drawing.Point(6, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(242, 46);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "اتمام العملية";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(6, 121);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(242, 70);
            this.txtReason.TabIndex = 25;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(254, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 28);
            this.label11.TabIndex = 24;
            this.label11.Text = "الاسباب:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 36);
            this.txtName.TabIndex = 19;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(254, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "المسؤل عن الاخراج:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(254, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "التاريخ:";
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(6, 27);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(242, 36);
            this.DtpDate.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxUnit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NudQty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxStoreFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxProducts);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 253);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المخزن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(305, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "الوحدة:";
            // 
            // cbxUnit
            // 
            this.cbxUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Location = new System.Drawing.Point(61, 205);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(242, 36);
            this.cbxUnit.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(305, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "الكمية:";
            // 
            // NudQty
            // 
            this.NudQty.DecimalPlaces = 2;
            this.NudQty.Location = new System.Drawing.Point(61, 163);
            this.NudQty.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.NudQty.Name = "NudQty";
            this.NudQty.Size = new System.Drawing.Size(242, 36);
            this.NudQty.TabIndex = 14;
            this.NudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(304, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "اسم المخزن :";
            // 
            // cbxStoreFrom
            // 
            this.cbxStoreFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStoreFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStoreFrom.FormattingEnabled = true;
            this.cbxStoreFrom.Location = new System.Drawing.Point(61, 119);
            this.cbxStoreFrom.Name = "cbxStoreFrom";
            this.cbxStoreFrom.Size = new System.Drawing.Size(242, 36);
            this.cbxStoreFrom.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(305, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "المنتج:";
            // 
            // cbxProducts
            // 
            this.cbxProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(61, 77);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(242, 36);
            this.cbxProducts.TabIndex = 10;
            this.cbxProducts.SelectionChangeCommitted += new System.EventHandler(this.cbxProducts_SelectionChangeCommitted);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(61, 30);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(242, 36);
            this.txtBarcode.TabIndex = 5;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(305, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "الباركود:";
            // 
            // Frm_ProductsOutStore
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(942, 276);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Frm_ProductsOutStore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اخراج المنتجات التالفه من المخزن";
            this.Load += new System.EventHandler(this.Frm_ProductsOutStore_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStoreFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
    }
}