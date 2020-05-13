namespace Sales_Managment
{
    partial class Frm_StockBankTransfire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StockBankTransfire));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStock = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoneyStock = new System.Windows.Forms.Label();
            this.lblMoneyBank = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnFromStockTobank = new System.Windows.Forms.RadioButton();
            this.rbtnFromBankToStock = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMoneyBank);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMoneyStock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxStock);
            this.groupBox1.Location = new System.Drawing.Point(38, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(297, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "اختر خزنة:";
            // 
            // cbxStock
            // 
            this.cbxStock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStock.FormattingEnabled = true;
            this.cbxStock.Location = new System.Drawing.Point(6, 23);
            this.cbxStock.Name = "cbxStock";
            this.cbxStock.Size = new System.Drawing.Size(276, 36);
            this.cbxStock.TabIndex = 29;
            this.cbxStock.SelectionChangeCommitted += new System.EventHandler(this.cbxStock_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(222, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "رصيد الخزنة المحددة:";
            // 
            // lblMoneyStock
            // 
            this.lblMoneyStock.AutoSize = true;
            this.lblMoneyStock.ForeColor = System.Drawing.Color.Blue;
            this.lblMoneyStock.Location = new System.Drawing.Point(124, 74);
            this.lblMoneyStock.Name = "lblMoneyStock";
            this.lblMoneyStock.Size = new System.Drawing.Size(27, 28);
            this.lblMoneyStock.TabIndex = 47;
            this.lblMoneyStock.Text = "...";
            // 
            // lblMoneyBank
            // 
            this.lblMoneyBank.AutoSize = true;
            this.lblMoneyBank.ForeColor = System.Drawing.Color.Blue;
            this.lblMoneyBank.Location = new System.Drawing.Point(124, 109);
            this.lblMoneyBank.Name = "lblMoneyBank";
            this.lblMoneyBank.Size = new System.Drawing.Size(27, 28);
            this.lblMoneyBank.TabIndex = 49;
            this.lblMoneyBank.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(214, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 28);
            this.label3.TabIndex = 48;
            this.label3.Text = "رصيد البنك الحالى هو:";
            // 
            // rbtnFromStockTobank
            // 
            this.rbtnFromStockTobank.AutoSize = true;
            this.rbtnFromStockTobank.Checked = true;
            this.rbtnFromStockTobank.Location = new System.Drawing.Point(26, 162);
            this.rbtnFromStockTobank.Name = "rbtnFromStockTobank";
            this.rbtnFromStockTobank.Size = new System.Drawing.Size(199, 32);
            this.rbtnFromStockTobank.TabIndex = 1;
            this.rbtnFromStockTobank.TabStop = true;
            this.rbtnFromStockTobank.Text = "تحويل من الخزنة الى البنك";
            this.rbtnFromStockTobank.UseVisualStyleBackColor = true;
            // 
            // rbtnFromBankToStock
            // 
            this.rbtnFromBankToStock.AutoSize = true;
            this.rbtnFromBankToStock.Location = new System.Drawing.Point(234, 162);
            this.rbtnFromBankToStock.Name = "rbtnFromBankToStock";
            this.rbtnFromBankToStock.Size = new System.Drawing.Size(199, 32);
            this.rbtnFromBankToStock.TabIndex = 2;
            this.rbtnFromBankToStock.Text = "تحويل من البنك الى الخزنة";
            this.rbtnFromBankToStock.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(39, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 28);
            this.label6.TabIndex = 47;
            this.label6.Text = "اسم المسؤل عن التحويل:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(217, 295);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 36);
            this.txtName.TabIndex = 46;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(110, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "تاريخ التحويل:";
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(217, 243);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(213, 36);
            this.DtpDate.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(69, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "المبلغ المراد تحويلة:";
            // 
            // NudPrice
            // 
            this.NudPrice.DecimalPlaces = 2;
            this.NudPrice.Location = new System.Drawing.Point(217, 194);
            this.NudPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(213, 36);
            this.NudPrice.TabIndex = 42;
            this.NudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnAdd.Location = new System.Drawing.Point(217, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 53);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "اتمام عملية التحويل";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Frm_StockBankTransfire
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(451, 411);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NudPrice);
            this.Controls.Add(this.rbtnFromBankToStock);
            this.Controls.Add(this.rbtnFromStockTobank);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_StockBankTransfire";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحويل رصيد من الخزنة الى البنك والعكس";
            this.Load += new System.EventHandler(this.Frm_StockBankTransfire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoneyStock;
        private System.Windows.Forms.Label lblMoneyBank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnFromStockTobank;
        private System.Windows.Forms.RadioButton rbtnFromBankToStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}