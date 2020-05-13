using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Sales_Managment
{
    public partial class Frm_PaySale : DevExpress.XtraEditors.XtraForm
    {
        public Frm_PaySale()
        {
            InitializeComponent();
        }

        private void Frm_PaySale_Load(object sender, EventArgs e)
        {
            try
            {

                txtMatloub.Text = (Properties.Settings.Default.TotalOrder).ToString();

            }
            catch (Exception) { }

            txtMadfou3.Text = "0.0";
            txtBaky.Text = "0.0";
            txtMadfou3.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtMadfou3.Text == "") { MessageBox.Show("من فضلك ادخل المبلغ المدفوع", "تاكيد"); return; }

            Properties.Settings.Default.Madfou3 = Convert.ToDecimal(txtMadfou3.Text);
            Properties.Settings.Default.Bakey = Convert.ToDecimal(txtBaky.Text);

            Properties.Settings.Default.CheckButton = true;
            if (checkVisa.Checked == true)
            {
                Properties.Settings.Default.Pay_Visa =true;
            }else
            {
                Properties.Settings.Default.Pay_Visa = false;
            }

            Properties.Settings.Default.Save();

            Close();
        }

        private void Frm_PaySale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txtMadfou3.Text == "") { MessageBox.Show("من فضلك ادخل المبلغ المدفوع", "تاكيد"); return; }

                Properties.Settings.Default.Madfou3 = Convert.ToDecimal(txtMadfou3.Text);
                Properties.Settings.Default.Bakey = Convert.ToDecimal(txtBaky.Text);
                Properties.Settings.Default.CheckButton = true;

                if (checkVisa.Checked == true)
                {
                    Properties.Settings.Default.Pay_Visa = true;
                }
                else
                {
                    Properties.Settings.Default.Pay_Visa = false;
                }
                Properties.Settings.Default.Save();

                Close();
            }
            else if (e.KeyCode == Keys.F12)
            {
                Properties.Settings.Default.CheckButton = false;
                Properties.Settings.Default.Save();
                Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckButton = false;
            Properties.Settings.Default.Save();
            Close();
        }

        private void txtMadfou3_TextChanged(object sender, EventArgs e)
        {
            try
            {

                decimal baky = Convert.ToDecimal(txtMatloub.Text) - Convert.ToDecimal(txtMadfou3.Text);

                txtBaky.Text = Math.Round(baky, 2).ToString();

            }
            catch (Exception) { }
        }
    }
}