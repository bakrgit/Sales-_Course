namespace Sales_Managment
{
    partial class Frm_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Setting));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSavePrinter = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPrinter = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveOrder = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnA4Buy = new System.Windows.Forms.RadioButton();
            this.rbtn8cmBuy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnA4Sales = new System.Windows.Forms.RadioButton();
            this.rbtn8cmSales = new System.Windows.Forms.RadioButton();
            this.checkBuyPrint = new System.Windows.Forms.CheckBox();
            this.checkSalePrint = new System.Windows.Forms.CheckBox();
            this.checkdiscount = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NudBuyNumber = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnVale = new System.Windows.Forms.RadioButton();
            this.rbtnPresent = new System.Windows.Forms.RadioButton();
            this.checkTaxes = new System.Windows.Forms.CheckBox();
            this.NudSaleNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSaveGenralSetting = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudBuyNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSaleNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSavePrinter);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbxPrinter);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اعدادت الطابعات";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSavePrinter
            // 
            this.btnSavePrinter.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrinter.Appearance.Options.UseFont = true;
            this.btnSavePrinter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePrinter.ImageOptions.Image")));
            this.btnSavePrinter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSavePrinter.Location = new System.Drawing.Point(243, 136);
            this.btnSavePrinter.Name = "btnSavePrinter";
            this.btnSavePrinter.Size = new System.Drawing.Size(398, 46);
            this.btnSavePrinter.TabIndex = 12;
            this.btnSavePrinter.Text = "حفظ بيانات الطابعة";
            this.btnSavePrinter.Click += new System.EventHandler(this.btnSavePrinter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(275, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "اختر طابعة لكى تكون هى الطابعة الرئيسية للبرنامج";
            // 
            // cbxPrinter
            // 
            this.cbxPrinter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPrinter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPrinter.FormattingEnabled = true;
            this.cbxPrinter.Location = new System.Drawing.Point(243, 94);
            this.cbxPrinter.Name = "cbxPrinter";
            this.cbxPrinter.Size = new System.Drawing.Size(398, 36);
            this.cbxPrinter.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveOrder);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtPhone2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtPhone1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.btndelete);
            this.tabPage2.Controls.Add(this.btnChoose);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureLogo);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "اعدادت الفاتورة";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Appearance.Options.UseFont = true;
            this.btnSaveOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveOrder.ImageOptions.Image")));
            this.btnSaveOrder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSaveOrder.Location = new System.Drawing.Point(19, 191);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(207, 46);
            this.btnSaveOrder.TabIndex = 23;
            this.btnSaveOrder.Text = "حفظ بيانات الفاتورة";
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(232, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "تليفون 2:";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(19, 138);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(207, 36);
            this.txtPhone2.TabIndex = 21;
            this.txtPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(232, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "تليفون1:";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(19, 75);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(207, 36);
            this.txtPhone1.TabIndex = 19;
            this.txtPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(232, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "جملة فى اسفل الفاتورة:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(19, 20);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(207, 36);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(723, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "عنوان المحل:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(510, 246);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(207, 36);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(723, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "اسم المحل:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(510, 191);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 36);
            this.txtName.TabIndex = 13;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndelete
            // 
            this.btndelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btndelete.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btndelete.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btndelete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btndelete.Appearance.Options.UseBackColor = true;
            this.btndelete.Appearance.Options.UseBorderColor = true;
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.Appearance.Options.UseForeColor = true;
            this.btndelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btndelete.Location = new System.Drawing.Point(510, 144);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(83, 30);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "مسح الصورة";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnChoose.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnChoose.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnChoose.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Appearance.Options.UseBackColor = true;
            this.btnChoose.Appearance.Options.UseBorderColor = true;
            this.btnChoose.Appearance.Options.UseFont = true;
            this.btnChoose.Appearance.Options.UseForeColor = true;
            this.btnChoose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnChoose.Location = new System.Drawing.Point(614, 144);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(103, 30);
            this.btnChoose.TabIndex = 11;
            this.btnChoose.Text = "اختر صورة";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(723, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "لوجو المحل:";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Location = new System.Drawing.Point(510, 28);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(207, 110);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.checkBuyPrint);
            this.tabPage3.Controls.Add(this.checkSalePrint);
            this.tabPage3.Controls.Add(this.checkdiscount);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.NudBuyNumber);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.rbtnVale);
            this.tabPage3.Controls.Add(this.rbtnPresent);
            this.tabPage3.Controls.Add(this.checkTaxes);
            this.tabPage3.Controls.Add(this.NudSaleNumber);
            this.tabPage3.Controls.Add(this.btnSaveGenralSetting);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(839, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "اعدادت عامة";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnA4Buy);
            this.groupBox2.Controls.Add(this.rbtn8cmBuy);
            this.groupBox2.Location = new System.Drawing.Point(23, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 89);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "طباعة فواتير المشتريات";
            // 
            // rbtnA4Buy
            // 
            this.rbtnA4Buy.AutoSize = true;
            this.rbtnA4Buy.Location = new System.Drawing.Point(6, 46);
            this.rbtnA4Buy.Name = "rbtnA4Buy";
            this.rbtnA4Buy.Size = new System.Drawing.Size(97, 32);
            this.rbtnA4Buy.TabIndex = 38;
            this.rbtnA4Buy.Text = "طباعة A4";
            this.rbtnA4Buy.UseVisualStyleBackColor = true;
            // 
            // rbtn8cmBuy
            // 
            this.rbtn8cmBuy.AutoSize = true;
            this.rbtn8cmBuy.Checked = true;
            this.rbtn8cmBuy.Location = new System.Drawing.Point(130, 46);
            this.rbtn8cmBuy.Name = "rbtn8cmBuy";
            this.rbtn8cmBuy.Size = new System.Drawing.Size(180, 32);
            this.rbtn8cmBuy.TabIndex = 37;
            this.rbtn8cmBuy.TabStop = true;
            this.rbtn8cmBuy.Text = "طباعة حراري (8 سنتى)";
            this.rbtn8cmBuy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnA4Sales);
            this.groupBox1.Controls.Add(this.rbtn8cmSales);
            this.groupBox1.Location = new System.Drawing.Point(23, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 100);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "طباعة فواتير المبيعات";
            // 
            // rbtnA4Sales
            // 
            this.rbtnA4Sales.AutoSize = true;
            this.rbtnA4Sales.Location = new System.Drawing.Point(6, 46);
            this.rbtnA4Sales.Name = "rbtnA4Sales";
            this.rbtnA4Sales.Size = new System.Drawing.Size(97, 32);
            this.rbtnA4Sales.TabIndex = 38;
            this.rbtnA4Sales.Text = "طباعة A4";
            this.rbtnA4Sales.UseVisualStyleBackColor = true;
            // 
            // rbtn8cmSales
            // 
            this.rbtn8cmSales.AutoSize = true;
            this.rbtn8cmSales.Checked = true;
            this.rbtn8cmSales.Location = new System.Drawing.Point(130, 46);
            this.rbtn8cmSales.Name = "rbtn8cmSales";
            this.rbtn8cmSales.Size = new System.Drawing.Size(180, 32);
            this.rbtn8cmSales.TabIndex = 37;
            this.rbtn8cmSales.TabStop = true;
            this.rbtn8cmSales.Text = "طباعة حراري (8 سنتى)";
            this.rbtn8cmSales.UseVisualStyleBackColor = true;
            this.rbtn8cmSales.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // checkBuyPrint
            // 
            this.checkBuyPrint.AutoSize = true;
            this.checkBuyPrint.Location = new System.Drawing.Point(592, 271);
            this.checkBuyPrint.Name = "checkBuyPrint";
            this.checkBuyPrint.Size = new System.Drawing.Size(229, 32);
            this.checkBuyPrint.TabIndex = 35;
            this.checkBuyPrint.Text = "تفعيل طباعة فواتير المشتريات";
            this.checkBuyPrint.UseVisualStyleBackColor = true;
            // 
            // checkSalePrint
            // 
            this.checkSalePrint.AutoSize = true;
            this.checkSalePrint.Location = new System.Drawing.Point(603, 235);
            this.checkSalePrint.Name = "checkSalePrint";
            this.checkSalePrint.Size = new System.Drawing.Size(218, 32);
            this.checkSalePrint.TabIndex = 34;
            this.checkSalePrint.Text = "تفعيل طباعة فواتير المبيعات";
            this.checkSalePrint.UseVisualStyleBackColor = true;
            // 
            // checkdiscount
            // 
            this.checkdiscount.AutoSize = true;
            this.checkdiscount.Location = new System.Drawing.Point(464, 197);
            this.checkdiscount.Name = "checkdiscount";
            this.checkdiscount.Size = new System.Drawing.Size(357, 32);
            this.checkdiscount.TabIndex = 33;
            this.checkdiscount.Text = "تفعيل امكانيه الخصم على فواتير المبيعات للكاشير";
            this.checkdiscount.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(594, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 28);
            this.label10.TabIndex = 32;
            this.label10.Text = "عدد طباعة نسخه فواتير المشتريات:";
            // 
            // NudBuyNumber
            // 
            this.NudBuyNumber.DecimalPlaces = 2;
            this.NudBuyNumber.Location = new System.Drawing.Point(501, 122);
            this.NudBuyNumber.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.NudBuyNumber.Name = "NudBuyNumber";
            this.NudBuyNumber.Size = new System.Drawing.Size(85, 36);
            this.NudBuyNumber.TabIndex = 31;
            this.NudBuyNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudBuyNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(595, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 28);
            this.label9.TabIndex = 30;
            this.label9.Text = "عدد طباعة نسخه فواتير المبيعات:";
            // 
            // rbtnVale
            // 
            this.rbtnVale.AutoSize = true;
            this.rbtnVale.Location = new System.Drawing.Point(520, 34);
            this.rbtnVale.Name = "rbtnVale";
            this.rbtnVale.Size = new System.Drawing.Size(125, 32);
            this.rbtnVale.TabIndex = 29;
            this.rbtnVale.Text = "قيمة من المال";
            this.rbtnVale.UseVisualStyleBackColor = true;
            // 
            // rbtnPresent
            // 
            this.rbtnPresent.AutoSize = true;
            this.rbtnPresent.Checked = true;
            this.rbtnPresent.Location = new System.Drawing.Point(651, 34);
            this.rbtnPresent.Name = "rbtnPresent";
            this.rbtnPresent.Size = new System.Drawing.Size(100, 32);
            this.rbtnPresent.TabIndex = 28;
            this.rbtnPresent.TabStop = true;
            this.rbtnPresent.Text = "نسبه مؤيه";
            this.rbtnPresent.UseVisualStyleBackColor = true;
            this.rbtnPresent.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkTaxes
            // 
            this.checkTaxes.AutoSize = true;
            this.checkTaxes.Location = new System.Drawing.Point(602, 166);
            this.checkTaxes.Name = "checkTaxes";
            this.checkTaxes.Size = new System.Drawing.Size(219, 32);
            this.checkTaxes.TabIndex = 27;
            this.checkTaxes.Text = "تفعيل ضريبة القيمة المضافه";
            this.checkTaxes.UseVisualStyleBackColor = true;
            // 
            // NudSaleNumber
            // 
            this.NudSaleNumber.DecimalPlaces = 2;
            this.NudSaleNumber.Location = new System.Drawing.Point(501, 80);
            this.NudSaleNumber.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.NudSaleNumber.Name = "NudSaleNumber";
            this.NudSaleNumber.Size = new System.Drawing.Size(85, 36);
            this.NudSaleNumber.TabIndex = 26;
            this.NudSaleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudSaleNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSaveGenralSetting
            // 
            this.btnSaveGenralSetting.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGenralSetting.Appearance.Options.UseFont = true;
            this.btnSaveGenralSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveGenralSetting.ImageOptions.Image")));
            this.btnSaveGenralSetting.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSaveGenralSetting.Location = new System.Drawing.Point(23, 255);
            this.btnSaveGenralSetting.Name = "btnSaveGenralSetting";
            this.btnSaveGenralSetting.Size = new System.Drawing.Size(329, 46);
            this.btnSaveGenralSetting.TabIndex = 25;
            this.btnSaveGenralSetting.Text = "حفظ بيانات الاعدادات";
            this.btnSaveGenralSetting.Click += new System.EventHandler(this.btnSaveGenralSetting_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(388, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(444, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "هل تريد ان يكون الخصم على المنتج نسبه مؤيه ام قيمه من المال؟";
            // 
            // Frm_Setting
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(849, 395);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_Setting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادت البرنامج";
            this.Load += new System.EventHandler(this.Frm_Setting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudBuyNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSaleNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPrinter;
        private DevExpress.XtraEditors.SimpleButton btnSavePrinter;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private DevExpress.XtraEditors.SimpleButton btnSaveOrder;
        private DevExpress.XtraEditors.SimpleButton btnSaveGenralSetting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkTaxes;
        private System.Windows.Forms.NumericUpDown NudSaleNumber;
        private System.Windows.Forms.RadioButton rbtnVale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NudBuyNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkdiscount;
        private System.Windows.Forms.CheckBox checkBuyPrint;
        private System.Windows.Forms.CheckBox checkSalePrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnA4Sales;
        private System.Windows.Forms.RadioButton rbtn8cmSales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnA4Buy;
        private System.Windows.Forms.RadioButton rbtn8cmBuy;
        private System.Windows.Forms.RadioButton rbtnPresent;
    }
}