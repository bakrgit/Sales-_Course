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
    public partial class Frm_SaleQty : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SaleQty()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void Frm_SaleQty_Load(object sender, EventArgs e)
        {
            txtQty.Text = (Properties.Settings.Default.Item_Qty).ToString();
            txtSalePrice.Text = (Properties.Settings.Default.Item_SalePrice).ToString();
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
            if (txtQty.Text == "") { MessageBox.Show("من فضلك ادخل الكمية", "تاكيد"); return; }
            if (txtSalePrice.Text == "") { MessageBox.Show("من فضلك ادخل سعر البيع", "تاكيد"); return; }
            if (txtDiscount.Text == "") { MessageBox.Show("من فضلك ادخل  الخصم", "تاكيد"); return; }

            Properties.Settings.Default.Item_Qty = Convert.ToDecimal(txtQty.Text);

            Properties.Settings.Default.Item_SalePrice = Convert.ToDecimal(txtSalePrice.Text);
            Properties.Settings.Default.Pro_Unit = cbxUnit.Text;
            if (Properties.Settings.Default.SaleDiscountForCasher == true)
            {
                try
                {
                    if (Properties.Settings.Default.ItemDiscount == "Value")
                    {
                        Properties.Settings.Default.Item_Discount = Convert.ToDecimal(txtDiscount.Text);
                        Properties.Settings.Default.Save();
                    }
                    else if (Properties.Settings.Default.ItemDiscount == "Present")
                    {
                        decimal presentValue = 0;
                        presentValue = (Convert.ToDecimal(txtSalePrice.Text) / 100) * Convert.ToDecimal(txtDiscount.Text);
                        Properties.Settings.Default.Item_Discount = presentValue;
                        Properties.Settings.Default.Save();

                    }
                }
                catch (Exception) { }
            }
            else
            {
                if (Convert.ToDecimal(txtDiscount.Text) >= 1)
                {
                    MessageBox.Show("غير مسموح لك بعمل خصم على المنتج", "تاكيد");
                    txtDiscount.Text = "0";
                    return;
                }
                
            }

            Properties.Settings.Default.Save();

            Close();
        }

        private void Frm_SaleQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txtQty.Text == "") { MessageBox.Show("من فضلك ادخل الكمية", "تاكيد"); return; }
                if (txtSalePrice.Text == "") { MessageBox.Show("من فضلك ادخل سعر البيع", "تاكيد"); return; }
                if (txtDiscount.Text == "") { MessageBox.Show("من فضلك ادخل  الخصم", "تاكيد"); return; }
                Properties.Settings.Default.Item_Qty = Convert.ToDecimal(txtQty.Text);
                Properties.Settings.Default.Pro_Unit = cbxUnit.Text;
                
                Properties.Settings.Default.Item_SalePrice = Convert.ToDecimal(txtSalePrice.Text);
                if (Properties.Settings.Default.SaleDiscountForCasher == true)
                {
                    try
                    {
                        if (Properties.Settings.Default.ItemDiscount == "Value")
                        {
                            Properties.Settings.Default.Item_Discount = Convert.ToDecimal(txtDiscount.Text);
                            Properties.Settings.Default.Save();
                        }
                        else if (Properties.Settings.Default.ItemDiscount == "Present")
                        {
                            decimal presentValue = 0;
                            presentValue = (Convert.ToDecimal(txtSalePrice.Text) / 100) * Convert.ToDecimal(txtDiscount.Text);
                            Properties.Settings.Default.Item_Discount = presentValue;
                            Properties.Settings.Default.Save();

                        }
                    }
                    catch (Exception) { }
                }
                else
                {
                    if (Convert.ToDecimal(txtDiscount.Text) >= 1)
                    {
                        MessageBox.Show("غير مسموح لك بعمل خصم على المنتج", "تاكيد");
                        txtDiscount.Text = "0";
                        return;
                    }

                }
                Properties.Settings.Default.Save();

                Close();
            }
        }

        private void Frm_SaleQty_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                int index = Frm_Sales.GetFormSales.DgvSale.SelectedRows[0].Index;
                Frm_Sales.GetFormSales.DgvSale.Rows[index].Cells[2].Value = Properties.Settings.Default.Pro_Unit;
                Frm_Sales.GetFormSales.DgvSale.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_Qty;
                Frm_Sales.GetFormSales.DgvSale.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_SalePrice;
                Frm_Sales.GetFormSales.DgvSale.Rows[index].Cells[5].Value = Properties.Settings.Default.Item_Discount;

            }
            catch (Exception) { }
        }

        private void cbxUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tblItems = new DataTable();
            tblItems.Clear();
            DataTable tblunit = new DataTable();
            tblunit.Clear();
            try
            {
                tblunit = db.readData("select * from Products_Unit where Pro_ID=" + Properties.Settings.Default.Pro_ID + " and Unit_ID=" + cbxUnit.SelectedValue + "", "");
                decimal realPrice = 0;
                try
                {
                    realPrice = Convert.ToDecimal(tblunit.Rows[0][5]) / Convert.ToDecimal(tblunit.Rows[0][3]);
                }
                catch (Exception) { }
                txtSalePrice.Text = Math.Round(realPrice, 2) + "";
            }
            catch (Exception) { }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}