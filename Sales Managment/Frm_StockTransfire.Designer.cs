namespace Sales_Managment
{
    partial class Frm_StockTransfire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StockTransfire));
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStockFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStockTo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtreason = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMoney1 = new System.Windows.Forms.Label();
            this.lblMoney2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(69, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "تحويل من خزنة:";
            // 
            // cbxStockFrom
            // 
            this.cbxStockFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStockFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStockFrom.FormattingEnabled = true;
            this.cbxStockFrom.Location = new System.Drawing.Point(188, 12);
            this.cbxStockFrom.Name = "cbxStockFrom";
            this.cbxStockFrom.Size = new System.Drawing.Size(213, 36);
            this.cbxStockFrom.TabIndex = 27;
            this.cbxStockFrom.SelectionChangeCommitted += new System.EventHandler(this.cbxStockFrom_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(65, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "تحويل الى خزنة:";
            // 
            // cbxStockTo
            // 
            this.cbxStockTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStockTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStockTo.FormattingEnabled = true;
            this.cbxStockTo.Location = new System.Drawing.Point(188, 89);
            this.cbxStockTo.Name = "cbxStockTo";
            this.cbxStockTo.Size = new System.Drawing.Size(213, 36);
            this.cbxStockTo.TabIndex = 29;
            this.cbxStockTo.SelectionChangeCommitted += new System.EventHandler(this.cbxStockTo_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(85, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 42;
            this.label7.Text = "سبب التحويل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(10, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 28);
            this.label6.TabIndex = 41;
            this.label6.Text = "اسم المسؤل عن التحويل:";
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(188, 313);
            this.txtreason.Multiline = true;
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(213, 40);
            this.txtreason.TabIndex = 40;
            this.txtreason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 268);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 36);
            this.txtName.TabIndex = 39;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(81, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "تاريخ التحويل:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(188, 216);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(213, 36);
            this.DtpDate.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(40, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "المبلغ المراد تحويلة:";
            // 
            // NudPrice
            // 
            this.NudPrice.DecimalPlaces = 2;
            this.NudPrice.Location = new System.Drawing.Point(188, 167);
            this.NudPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(213, 36);
            this.NudPrice.TabIndex = 35;
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
            this.btnAdd.Location = new System.Drawing.Point(188, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 53);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "تحويل";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(130, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 44;
            this.label3.Text = "الرصيد:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(130, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 28);
            this.label8.TabIndex = 45;
            this.label8.Text = "الرصيد:";
            // 
            // lblMoney1
            // 
            this.lblMoney1.AutoSize = true;
            this.lblMoney1.ForeColor = System.Drawing.Color.Blue;
            this.lblMoney1.Location = new System.Drawing.Point(187, 56);
            this.lblMoney1.Name = "lblMoney1";
            this.lblMoney1.Size = new System.Drawing.Size(27, 28);
            this.lblMoney1.TabIndex = 46;
            this.lblMoney1.Text = "...";
            // 
            // lblMoney2
            // 
            this.lblMoney2.AutoSize = true;
            this.lblMoney2.ForeColor = System.Drawing.Color.Blue;
            this.lblMoney2.Location = new System.Drawing.Point(187, 132);
            this.lblMoney2.Name = "lblMoney2";
            this.lblMoney2.Size = new System.Drawing.Size(27, 28);
            this.lblMoney2.TabIndex = 47;
            this.lblMoney2.Text = "...";
            // 
            // Frm_StockTransfire
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(415, 425);
            this.Controls.Add(this.lblMoney2);
            this.Controls.Add(this.lblMoney1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtreason);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NudPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxStockTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxStockFrom);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_StockTransfire";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحويل رصيد بين الخزنات";
            this.Load += new System.EventHandler(this.Frm_StockTransfire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxStockFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStockTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtreason;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMoney1;
        private System.Windows.Forms.Label lblMoney2;
    }
}