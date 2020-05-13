namespace Sales_Managment
{
    partial class Frm_PayBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PayBuy));
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatloub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaky = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMadfou3 = new System.Windows.Forms.TextBox();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Appearance.Options.UseFont = true;
            this.btnEnter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.ImageOptions.Image")));
            this.btnEnter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnEnter.Location = new System.Drawing.Point(88, 256);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(185, 46);
            this.btnEnter.TabIndex = 31;
            this.btnEnter.Text = "للحفظ والطباعة انتر";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "المطلوب:";
            // 
            // txtMatloub
            // 
            this.txtMatloub.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatloub.Location = new System.Drawing.Point(88, 12);
            this.txtMatloub.Multiline = true;
            this.txtMatloub.Name = "txtMatloub";
            this.txtMatloub.ReadOnly = true;
            this.txtMatloub.Size = new System.Drawing.Size(304, 55);
            this.txtMatloub.TabIndex = 29;
            this.txtMatloub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "المدفوع:";
            // 
            // txtBaky
            // 
            this.txtBaky.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaky.Location = new System.Drawing.Point(88, 182);
            this.txtBaky.Multiline = true;
            this.txtBaky.Name = "txtBaky";
            this.txtBaky.ReadOnly = true;
            this.txtBaky.Size = new System.Drawing.Size(304, 55);
            this.txtBaky.TabIndex = 27;
            this.txtBaky.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "الباقى:";
            // 
            // txtMadfou3
            // 
            this.txtMadfou3.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadfou3.Location = new System.Drawing.Point(88, 98);
            this.txtMadfou3.Multiline = true;
            this.txtMadfou3.Name = "txtMadfou3";
            this.txtMadfou3.Size = new System.Drawing.Size(304, 55);
            this.txtMadfou3.TabIndex = 25;
            this.txtMadfou3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMadfou3.TextChanged += new System.EventHandler(this.txtMadfou3_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Appearance.Options.UseFont = true;
            this.btnReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnReturn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnReturn.Location = new System.Drawing.Point(279, 256);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 46);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "رجوع";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(323, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "F12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(160, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 30);
            this.label5.TabIndex = 34;
            this.label5.Text = "Enter";
            // 
            // Frm_PayBuy
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(431, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatloub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaky);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMadfou3);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_PayBuy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_PayBuy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_PayBuy_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatloub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaky;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMadfou3;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}