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
    public partial class Frm_StoreGard : DevExpress.XtraEditors.XtraForm
    {
        public Frm_StoreGard()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();


        private void FillStore()
        {

            cbxStore.DataSource = db.readData("select * from Store", "");
            cbxStore.DisplayMember = "Store_Name";
            cbxStore.ValueMember = "Store_ID";
        }
        private void Frm_StoreGard_Load(object sender, EventArgs e)
        {
            FillStore();
        }
        private void showTotal()
        {
            decimal totalRb7h = 0 ,totalBuy=0,totalSale=0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalRb7h += (Convert.ToDecimal(DgvSearch.Rows[i].Cells[5].Value) - Convert.ToDecimal(DgvSearch.Rows[i].Cells[4].Value)) * Convert.ToDecimal(DgvSearch.Rows[i].Cells[3].Value);
                totalBuy += Convert.ToDecimal(DgvSearch.Rows[i].Cells[4].Value);
                totalSale += Convert.ToDecimal(DgvSearch.Rows[i].Cells[5].Value);
            }
            txtRb7h.Text = Math.Round(totalRb7h, 2).ToString();
            txtTotalBuy.Text = Math.Round(totalBuy, 2).ToString();
            txtTotalSale.Text = Math.Round(totalSale, 2).ToString();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            if(rbtnAllStore.Checked==true)
                tbl = db.readData("SELECT [Products_Qty].[Pro_ID] as 'رقم المنتج',Products.Pro_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن',[Products_Qty].[Qty] as 'الكمية' ,[Buy_Price] as 'سعر الشراء',[Products_Qty].[Sale_PriceTax] as 'سعر البيع' FROM [dbo].[Products_Qty],Products where Products.Pro_ID =[Products_Qty].Pro_ID", "");
            else
                tbl = db.readData("SELECT [Products_Qty].[Pro_ID] as 'رقم المنتج',Products.Pro_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن',[Products_Qty].[Qty] as 'الكمية' ,[Buy_Price] as 'سعر الشراء',[Products_Qty].[Sale_PriceTax] as 'سعر البيع' FROM [dbo].[Products_Qty],Products where Products.Pro_ID =[Products_Qty].Pro_ID and Products_Qty.Store_ID="+cbxStore.SelectedValue+"", "");


            DgvSearch.DataSource = tbl;
            if(tbl.Rows.Count >= 1)
            {
                showTotal();
            }

        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                if (txtBarcode.Text != "")
                {
                    tbl.Clear();
                    tbl = db.readData("SELECT [Products_Qty].[Pro_ID] as 'رقم المنتج',Products.Pro_Name as 'اسم المنتج',[Store_Name] as 'اسم المخزن',[Products_Qty].[Qty] as 'الكمية' ,[Buy_Price] as 'سعر الشراء',[Products_Qty].[Sale_PriceTax] as 'سعر البيع' FROM [dbo].[Products_Qty],Products where Products.Pro_ID =[Products_Qty].Pro_ID and Products.Barcode=N'" + txtBarcode.Text + "'", "");

                    DgvSearch.DataSource = tbl;
                    if (tbl.Rows.Count >= 1)
                    {
                        showTotal();
                    }
                }
            }
        }
    }
}