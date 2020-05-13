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
    public partial class Frm_SalesRb7h : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SalesRb7h()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();

        private void fillUser()
        {
            cbxUser.DataSource = db.readData("select * from Users", "");
            cbxUser.DisplayMember = "User_Name";
            cbxUser.ValueMember = "User_ID";
        }
        private void Frm_SalesRb7h_Load(object sender, EventArgs e)
        {
            fillUser();
            DtpFrom.Text = DateTime.Now.ToShortDateString();
            DtpTo.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            tbl.Clear();
            string date1;
            string date2;
            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            if (checkOrderNumber.Checked == false)
            {
                if (rbtnAllUser.Checked == true)
                {

                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Unit] as 'الوحدة',[Sales_Rb7h].[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sales_Rb7h].[Tax_Value] as 'قيمة الضريبة',[Price_Tax] as 'السعر بعد الضريبة',([Price_Tax] -  [Buy_Price]) * [Sales_Rb7h].[Qty] as 'الربح',[Total] as 'اجمالى الصنف' ,[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[Date]  as 'التاريخ',[User_Name] as 'اسم الكاشير',[Time] as 'الوقت' FROM [dbo].[Sales_Rb7h] ,Products where Products.Pro_ID =Sales_Rb7h.Pro_ID and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'   ORDER BY Order_ID ASC", "");
                }
                else if (rbtnOneUser.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Unit] as 'الوحدة',[Sales_Rb7h].[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sales_Rb7h].[Tax_Value] as 'قيمة الضريبة',[Price_Tax] as 'السعر بعد الضريبة',([Price_Tax] -  [Buy_Price]) * [Sales_Rb7h].[Qty] as 'الربح',[Total] as 'اجمالى الصنف' ,[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[Date]  as 'التاريخ',[User_Name] as 'اسم الكاشير',[Time] as 'الوقت' FROM [dbo].[Sales_Rb7h] ,Products where Products.Pro_ID =Sales_Rb7h.Pro_ID and User_Name =N'" + cbxUser.Text + "' and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'   ORDER BY Order_ID ASC", "");
                }
            }
            else if (checkOrderNumber.Checked == true)
            {
                if (rbtnAllUser.Checked == true)
                {

                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Unit] as 'الوحدة',[Sales_Rb7h].[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sales_Rb7h].[Tax_Value] as 'قيمة الضريبة',[Price_Tax] as 'السعر بعد الضريبة',([Price_Tax] -  [Buy_Price]) * [Sales_Rb7h].[Qty] as 'الربح',[Total] as 'اجمالى الصنف' ,[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[Date]  as 'التاريخ',[User_Name] as 'اسم الكاشير',[Time] as 'الوقت' FROM [dbo].[Sales_Rb7h] ,Products where Products.Pro_ID =Sales_Rb7h.Pro_ID and Order_ID =" + txtOrderNumber.Text + "  and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'   ORDER BY Order_ID ASC", "");
                }
                else if (rbtnOneUser.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Unit] as 'الوحدة',[Sales_Rb7h].[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sales_Rb7h].[Tax_Value] as 'قيمة الضريبة',[Price_Tax] as 'السعر بعد الضريبة',([Price_Tax] -  [Buy_Price]) * [Sales_Rb7h].[Qty] as 'الربح',[Total] as 'اجمالى الصنف' ,[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[Date]  as 'التاريخ',[User_Name] as 'اسم الكاشير',[Time] as 'الوقت' FROM [dbo].[Sales_Rb7h] ,Products where Products.Pro_ID =Sales_Rb7h.Pro_ID and User_Name =N'" + cbxUser.Text + "' and Order_ID=" + txtOrderNumber.Text + "  and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'   ORDER BY Order_ID ASC", "");

                }
            }
            DgvSearch.DataSource = tbl;


            decimal totalOrder = 0 ,TotalRb7h=0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalOrder += Convert.ToDecimal(DgvSearch.Rows[i].Cells[10].Value);
                TotalRb7h += Convert.ToDecimal(DgvSearch.Rows[i].Cells[9].Value);
            }
            txtTotal.Text = Math.Round(totalOrder, 2).ToString();
            txtTotalRb7h.Text = Math.Round(TotalRb7h, 2).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (DgvSearch.Rows.Count >= 1)
            {

                string date1;
                string date2;
                date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
                date2 = DtpTo.Value.ToString("yyyy-MM-dd");

                if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.exceuteData("delete from Sales_Rb7h where Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم المسح بنجاح");

                    btnSearch_Click(null, null);
                }
            }
        }
        private void PrintAll()
        {
            string date1;
            string date2;
            date1 = DtpFrom.Value.ToString("dd/MM/yyyy");
            date2 = DtpTo.Value.ToString("dd/MM/yyyy");

            DataTable tblRpt = new DataTable();

            tblRpt.Clear();
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Unit] as 'الوحدة',[Sales_Rb7h].[Qty] as 'الكمية',[Buy_Price] as 'سعر الشراء',[Discount] as 'الخصم',[Sales_Rb7h].[Tax_Value] as 'قيمة الضريبة',[Price_Tax] as 'السعر بعد الضريبة',([Price_Tax] -  [Buy_Price]) * [Sales_Rb7h].[Qty] as 'الربح',[Total] as 'اجمالى الصنف' ,[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[Date]  as 'التاريخ',[User_Name] as 'اسم الكاشير',[Time] as 'الوقت' FROM [dbo].[Sales_Rb7h] ,Products where Products.Pro_ID =Sales_Rb7h.Pro_ID and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();

                RptSalesRb7h rpt = new RptSalesRb7h();


                rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                rpt.SetDataSource(tblRpt);

                rpt.SetParameterValue("From", date1);
                rpt.SetParameterValue("To", date2);
                frm.crystalReportViewer1.ReportSource = rpt;

                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                // rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void btnPtintOrderAll_Click(object sender, EventArgs e)
        {
            if(DgvSearch.Rows.Count >= 1)
            {

                PrintAll();
            }
        }
    }
}