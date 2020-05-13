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
    public partial class Frm_BuyQty : DevExpress.XtraEditors.XtraForm
    {
        public Frm_BuyQty()
        {
            InitializeComponent();
        }
        Database db = new Database();


        private void Frm_BuyQty_Load(object sender, EventArgs e)
        {

            txtQty.Text =( Properties.Settings.Default.Item_Qty).ToString();
            txtBuyPrice.Text = (Properties.Settings.Default.Item_BuyPrice).ToString();
            txtDiscount.Text = (Properties.Settings.Default.Item_Discount).ToString();

            try
            {
                cbxUnit.DataSource = db.readData("select * from Products_Unit where Pro_ID=" + Properties.Settings.Default.Pro_ID + "", "");
                cbxUnit.DisplayMember = "Unit_Name";
                cbxUnit.ValueMember = "Unit_ID";
            }
            catch (Exception) { }

            cbxUnit.Text = (Properties.Settings.Default.Pro_Unit).ToString();
            txtQty.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtQty.Text == "") { MessageBox.Show("من فضلك ادخل الكمية","تاكيد"); return; }
            if (txtBuyPrice.Text == "") { MessageBox.Show("من فضلك ادخل سعر الشراء", "تاكيد"); return; }
            if (txtDiscount.Text == "") { MessageBox.Show("من فضلك ادخل  الخصم", "تاكيد"); return; }
            Properties.Settings.Default.Item_Qty =Convert.ToDecimal( txtQty.Text);
            Properties.Settings.Default.Item_Discount = Convert.ToDecimal(txtDiscount.Text);
            Properties.Settings.Default.Item_BuyPrice= Convert.ToDecimal(txtBuyPrice.Text);
            Properties.Settings.Default.Pro_Unit = Convert.ToString(cbxUnit.Text);
            Properties.Settings.Default.Save();

            Close();
        }

        private void Frm_BuyQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                if (txtQty.Text == "") { MessageBox.Show("من فضلك ادخل الكمية", "تاكيد"); return; }
                if (txtBuyPrice.Text == "") { MessageBox.Show("من فضلك ادخل سعر الشراء", "تاكيد"); return; }
                if (txtDiscount.Text == "") { MessageBox.Show("من فضلك ادخل  الخصم", "تاكيد"); return; }
                Properties.Settings.Default.Item_Qty = Convert.ToDecimal(txtQty.Text);
                Properties.Settings.Default.Item_Discount = Convert.ToDecimal(txtDiscount.Text);
                Properties.Settings.Default.Item_BuyPrice = Convert.ToDecimal(txtBuyPrice.Text);
                Properties.Settings.Default.Pro_Unit = Convert.ToString(cbxUnit.Text);
                Properties.Settings.Default.Save();

                Close();

            }
        }

        private void Frm_BuyQty_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {

                int index = Frm_Buy.GetFormBuy.DgvBuy.SelectedRows[0].Index;
                Frm_Buy.GetFormBuy.DgvBuy.Rows[index].Cells[2].Value = Properties.Settings.Default.Pro_Unit;
                Frm_Buy.GetFormBuy.DgvBuy.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_Qty;
                Frm_Buy.GetFormBuy.DgvBuy.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_BuyPrice;
                Frm_Buy.GetFormBuy.DgvBuy.Rows[index].Cells[5].Value = Properties.Settings.Default.Item_Discount;

            } catch(Exception) { }
        }

        private void cbxUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tblItems = new DataTable();
            tblItems.Clear();
            DataTable tblPrice = new DataTable();
            tblPrice.Clear();
            DataTable tblunit = new DataTable();
            tblunit.Clear();
            try {
                int countQty = 0;
                try
                {
                    countQty = Convert.ToInt32(db.readData("select sum (Pro_ID) from Products_Qty where Pro_ID=" + Properties.Settings.Default.Pro_ID + "", "").Rows[0][0]);
                }
                catch (Exception) { }


                tblPrice = db.readData("select * from Products_Qty where Pro_ID=" + Properties.Settings.Default.Pro_ID + "", "");
                string Product_Price = tblPrice.Rows[countQty - 1][4].ToString();

                tblunit = db.readData("select * from Products_Unit where Pro_ID=" + Properties.Settings.Default.Pro_ID + " and Unit_ID=" + cbxUnit.SelectedValue+ "", "");
                decimal realPrice = 0;
                try
                {
                    realPrice = Convert.ToDecimal(Product_Price) / Convert.ToDecimal(tblunit.Rows[0][3]);
                }
                catch (Exception) { }
                txtBuyPrice.Text = Math.Round(realPrice, 2) + "";
            }
            catch (Exception) { }
        }

        private void cbxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}