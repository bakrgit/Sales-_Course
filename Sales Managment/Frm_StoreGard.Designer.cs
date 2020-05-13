namespace Sales_Managment
{
    partial class Frm_StoreGard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StoreGard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnOneStore = new System.Windows.Forms.RadioButton();
            this.rbtnAllStore = new System.Windows.Forms.RadioButton();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvSearch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRb7h = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalBuy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSearch.Location = new System.Drawing.Point(402, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(211, 46);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "جرد";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnOneStore);
            this.groupBox1.Controls.Add(this.rbtnAllStore);
            this.groupBox1.Controls.Add(this.cbxStore);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 80);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // rbtnOneStore
            // 
            this.rbtnOneStore.AutoSize = true;
            this.rbtnOneStore.ForeColor = System.Drawing.Color.Blue;
            this.rbtnOneStore.Location = new System.Drawing.Point(167, 35);
            this.rbtnOneStore.Name = "rbtnOneStore";
            this.rbtnOneStore.Size = new System.Drawing.Size(103, 32);
            this.rbtnOneStore.TabIndex = 11;
            this.rbtnOneStore.Text = "مخزن محدد";
            this.rbtnOneStore.UseVisualStyleBackColor = true;
            // 
            // rbtnAllStore
            // 
            this.rbtnAllStore.AutoSize = true;
            this.rbtnAllStore.Checked = true;
            this.rbtnAllStore.ForeColor = System.Drawing.Color.Blue;
            this.rbtnAllStore.Location = new System.Drawing.Point(267, 35);
            this.rbtnAllStore.Name = "rbtnAllStore";
            this.rbtnAllStore.Size = new System.Drawing.Size(101, 32);
            this.rbtnAllStore.TabIndex = 10;
            this.rbtnAllStore.TabStop = true;
            this.rbtnAllStore.Text = "كل المخازن";
            this.rbtnAllStore.UseVisualStyleBackColor = true;
            // 
            // cbxStore
            // 
            this.cbxStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(9, 34);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(152, 36);
            this.cbxStore.TabIndex = 9;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Location = new System.Drawing.Point(811, 105);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(183, 36);
            this.txtBarcode.TabIndex = 35;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(702, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "بحث بالباركود:";
            // 
            // DgvSearch
            // 
            this.DgvSearch.AllowUserToAddRows = false;
            this.DgvSearch.AllowUserToDeleteRows = false;
            this.DgvSearch.AllowUserToResizeColumns = false;
            this.DgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSearch.BackgroundColor = System.Drawing.Color.White;
            this.DgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvSearch.Location = new System.Drawing.Point(12, 156);
            this.DgvSearch.Name = "DgvSearch";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.DgvSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DgvSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.DgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearch.Size = new System.Drawing.Size(982, 298);
            this.DgvSearch.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "الارباح المتوقعة:";
            // 
            // txtRb7h
            // 
            this.txtRb7h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRb7h.Location = new System.Drawing.Point(133, 462);
            this.txtRb7h.Name = "txtRb7h";
            this.txtRb7h.ReadOnly = true;
            this.txtRb7h.Size = new System.Drawing.Size(150, 36);
            this.txtRb7h.TabIndex = 39;
            this.txtRb7h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(298, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "مبالغ البيع (مبلغ الشراء):";
            // 
            // txtTotalBuy
            // 
            this.txtTotalBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBuy.Location = new System.Drawing.Point(477, 462);
            this.txtTotalBuy.Name = "txtTotalBuy";
            this.txtTotalBuy.ReadOnly = true;
            this.txtTotalBuy.Size = new System.Drawing.Size(150, 36);
            this.txtTotalBuy.TabIndex = 41;
            this.txtTotalBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(675, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 42;
            this.label3.Text = "مبالغ البيع (مبلغ البيع):";
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSale.Location = new System.Drawing.Point(844, 462);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.Size = new System.Drawing.Size(150, 36);
            this.txtTotalSale.TabIndex = 43;
            this.txtTotalSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_StoreGard
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1006, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRb7h);
            this.Controls.Add(this.DgvSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Frm_StoreGard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جرد المخازن";
            this.Load += new System.EventHandler(this.Frm_StoreGard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnOneStore;
        private System.Windows.Forms.RadioButton rbtnAllStore;
        private System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRb7h;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalSale;
    }
}