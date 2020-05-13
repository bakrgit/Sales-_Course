namespace Sales_Managment
{
    partial class Frm_EmployeeBorrowMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EmployeeBorrowMoney));
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreditor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpReminder = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.rbtnEmployee = new System.Windows.Forms.RadioButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnAdd.Location = new System.Drawing.Point(230, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(277, 46);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "حفظ العملية";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(347, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 40);
            this.label6.TabIndex = 25;
            this.label6.Text = "السلفيات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DtpDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.rbtnEmployee);
            this.groupBox1.Controls.Add(this.rbtnNormal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxEmployee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCreditor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DtpReminder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NudPrice);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(14, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 260);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات السلف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(604, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "اختر موظف:";
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(408, 174);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(195, 36);
            this.cbxEmployee.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(609, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم الدائن:";
            // 
            // txtCreditor
            // 
            this.txtCreditor.Location = new System.Drawing.Point(408, 216);
            this.txtCreditor.Name = "txtCreditor";
            this.txtCreditor.Size = new System.Drawing.Size(195, 36);
            this.txtCreditor.TabIndex = 3;
            this.txtCreditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(254, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "تاريخ الاستحقاق:";
            // 
            // DtpReminder
            // 
            this.DtpReminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReminder.Location = new System.Drawing.Point(6, 81);
            this.DtpReminder.Name = "DtpReminder";
            this.DtpReminder.Size = new System.Drawing.Size(242, 36);
            this.DtpReminder.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(257, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "المبلغ:";
            // 
            // NudPrice
            // 
            this.NudPrice.DecimalPlaces = 2;
            this.NudPrice.Location = new System.Drawing.Point(6, 131);
            this.NudPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(242, 36);
            this.NudPrice.TabIndex = 4;
            this.NudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(408, 34);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(195, 36);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(604, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم العملية:";
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Checked = true;
            this.rbtnNormal.Location = new System.Drawing.Point(494, 85);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(109, 32);
            this.rbtnNormal.TabIndex = 12;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "شخص عادى";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            this.rbtnNormal.CheckedChanged += new System.EventHandler(this.rbtnNormal_CheckedChanged);
            // 
            // rbtnEmployee
            // 
            this.rbtnEmployee.AutoSize = true;
            this.rbtnEmployee.Location = new System.Drawing.Point(421, 85);
            this.rbtnEmployee.Name = "rbtnEmployee";
            this.rbtnEmployee.Size = new System.Drawing.Size(74, 32);
            this.rbtnEmployee.TabIndex = 13;
            this.rbtnEmployee.Text = "موظف";
            this.rbtnEmployee.UseVisualStyleBackColor = true;
            this.rbtnEmployee.CheckedChanged += new System.EventHandler(this.rbtnEmployee_CheckedChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(408, 123);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(195, 36);
            this.txtname.TabIndex = 14;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(604, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "اسم الشخص:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(254, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "تاريخ السلف:";
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(6, 29);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(242, 36);
            this.DtpDate.TabIndex = 16;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(6, 177);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(242, 75);
            this.txtNotes.TabIndex = 18;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(254, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "ملاحظات:";
            // 
            // Frm_EmployeeBorrowMoney
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(732, 383);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Frm_EmployeeBorrowMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "السلفيات";
            this.Load += new System.EventHandler(this.Frm_EmployeeBorrowMoney_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreditor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpReminder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.RadioButton rbtnEmployee;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpDate;
    }
}