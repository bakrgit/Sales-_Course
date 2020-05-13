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
    public partial class Frm_ViewItem : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ViewItem()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();


        private void FillGroup()
        {

            cbxGroup.DataSource = db.readData("select * from Products_Group", "");
            cbxGroup.DisplayMember = "Group_Name";
            cbxGroup.ValueMember = "Group_ID";
        }
        private void showAllItems()
        {
            tbl.Clear();
            tbl = db.readData("SELECT [Pro_ID] as ' رقم المنتج',[Pro_Name] as 'اسم المنتج',[Main_UnitName] as 'الوحدة الرئيسية',[Qty] as 'الكمية الكلية',[Gomla_Price] as 'سعر الجملة',[Sale_Price] as 'سعر التجزئه',[Tax_Value] as 'الضريبة',[Sale_PriceTax] as 'السعر بعد الضريبة',[Sale_UnitName]as 'وحدة البيع',[Buy_UnitName] as 'وحدة الشراء',[Barcode] as 'الباركود' ,[MinQty] as 'الحد الادنى',[MaxDiscount] as 'اقصى خصم مسموح',[IS_Tax] as 'هل خاضع للضريبة',Products_Group.Group_Name as 'اسم المجموعة' FROM [dbo].[Products],Products_Group where Products_Group.Group_ID=[Products].Group_ID","");

            DgvSearch.DataSource = tbl;
            showTotal();

        }

        private void showTotal()
        {
            decimal totalQty = 0, totalGomla = 0,totalPart=0 ,totalAfterTax=0 ;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalQty += Convert.ToDecimal(DgvSearch.Rows[i].Cells[3].Value);
                totalGomla += Convert.ToDecimal(DgvSearch.Rows[i].Cells[3].Value) * Convert.ToDecimal(DgvSearch.Rows[i].Cells[4].Value);
                totalPart+= Convert.ToDecimal(DgvSearch.Rows[i].Cells[3].Value) * Convert.ToDecimal(DgvSearch.Rows[i].Cells[5].Value);
                totalAfterTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[3].Value) * Convert.ToDecimal(DgvSearch.Rows[i].Cells[6].Value);

            }
            txtTotalQty.Text = Math.Round(totalQty, 2).ToString();
            txtTotalGomla.Text= Math.Round(totalGomla, 2).ToString();
            txtTotalPart.Text = Math.Round(totalPart, 2).ToString();
            txtTotalAfterTax.Text = Math.Round(totalAfterTax, 2).ToString();
        }

        private void Frm_ViewItem_Load(object sender, EventArgs e)
        {
            FillGroup();
            showAllItems();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("SELECT [Pro_ID] as ' رقم المنتج',[Pro_Name] as 'اسم المنتج',[Main_UnitName] as 'الوحدة الرئيسية',[Qty] as 'الكمية الكلية',[Gomla_Price] as 'سعر الجملة',[Sale_Price] as 'سعر التجزئه',[Tax_Value] as 'الضريبة',[Sale_PriceTax] as 'السعر بعد الضريبة',[Sale_UnitName]as 'وحدة البيع',[Buy_UnitName] as 'وحدة الشراء',[Barcode] as 'الباركود' ,[MinQty] as 'الحد الادنى',[MaxDiscount] as 'اقصى خصم مسموح',[IS_Tax] as 'هل خاضع للضريبة',Products_Group.Group_Name as 'اسم المجموعة' FROM [dbo].[Products],Products_Group where Products_Group.Group_ID=[Products].Group_ID and Products.Group_ID="+cbxGroup.SelectedValue+"", "");

            DgvSearch.DataSource = tbl;

            showTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("SELECT [Pro_ID] as ' رقم المنتج',[Pro_Name] as 'اسم المنتج',[Main_UnitName] as 'الوحدة الرئيسية',[Qty] as 'الكمية الكلية',[Gomla_Price] as 'سعر الجملة',[Sale_Price] as 'سعر التجزئه',[Tax_Value] as 'الضريبة',[Sale_PriceTax] as 'السعر بعد الضريبة',[Sale_UnitName]as 'وحدة البيع',[Buy_UnitName] as 'وحدة الشراء',[Barcode] as 'الباركود' ,[MinQty] as 'الحد الادنى',[MaxDiscount] as 'اقصى خصم مسموح',[IS_Tax] as 'هل خاضع للضريبة',Products_Group.Group_Name as 'اسم المجموعة' FROM [dbo].[Products],Products_Group where Products_Group.Group_ID=[Products].Group_ID and Products.[Barcode]=N'" + txtBarcode.Text + "'", "");

            DgvSearch.DataSource = tbl;
            showTotal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("SELECT [Pro_ID] as ' رقم المنتج',[Pro_Name] as 'اسم المنتج',[Main_UnitName] as 'الوحدة الرئيسية',[Qty] as 'الكمية الكلية',[Gomla_Price] as 'سعر الجملة',[Sale_Price] as 'سعر التجزئه',[Tax_Value] as 'الضريبة',[Sale_PriceTax] as 'السعر بعد الضريبة',[Sale_UnitName]as 'وحدة البيع',[Buy_UnitName] as 'وحدة الشراء',[Barcode] as 'الباركود' ,[MinQty] as 'الحد الادنى',[MaxDiscount] as 'اقصى خصم مسموح',[IS_Tax] as 'هل خاضع للضريبة',Products_Group.Group_Name as 'اسم المجموعة' FROM [dbo].[Products],Products_Group where Products_Group.Group_ID=[Products].Group_ID and [Pro_Name] like N'%" + txtName.Text + "%'", "");

            DgvSearch.DataSource = tbl;
            showTotal();
        }
    }
}