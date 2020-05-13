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
    public partial class Frm_SalesReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SalesReport()
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
        private void Frm_SalesReport_Load(object sender, EventArgs e)
        {
            DtpFrom.Text = DateTime.Now.ToShortDateString();
            DtpTo.Text = DateTime.Now.ToShortDateString();
            fillUser();
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

                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Sales_Detalis].[Qty] as 'الكمية',Unit as 'الوحدة',Price as 'السعر قبل الضريبة',[Sales_Detalis].Tax_Value as'الضريبة',[Price_Tax] as 'السعر شامل الضريب',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[User_Name] as 'الكاشير',[Date] as 'التاريخ' FROM [dbo].[Sales_Detalis] , Products where Products.Pro_ID = Sales_Detalis.Pro_ID and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'   ORDER BY Order_ID ASC", "");
                }
                else if (rbtnOneUser.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Sales_Detalis].[Qty] as 'الكمية',Unit as 'الوحدة',Price as 'السعر قبل الضريبة',[Sales_Detalis].Tax_Value as'الضريبة',[Price_Tax] as 'السعر شامل الضريب',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[User_Name] as 'الكاشير',[Date] as 'التاريخ' FROM [dbo].[Sales_Detalis] , Products where Products.Pro_ID = Sales_Detalis.Pro_ID and User_Name=N'" + cbxUser.Text + "' and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'   ORDER BY Order_ID ASC", "");
                }
            }
            else if (checkOrderNumber.Checked == true)
            {
                if (rbtnAllUser.Checked == true)
                {

                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Sales_Detalis].[Qty] as 'الكمية',Unit as 'الوحدة',Price as 'السعر قبل الضريبة',[Sales_Detalis].Tax_Value as'الضريبة',[Price_Tax] as 'السعر شامل الضريب',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[User_Name] as 'الكاشير',[Date] as 'التاريخ' FROM [dbo].[Sales_Detalis] , Products where Products.Pro_ID = Sales_Detalis.Pro_ID and Order_ID=" + txtOrderNumber.Text + "  and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'   ORDER BY Order_ID ASC", "");
                }else if (rbtnOneUser.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Sales_Detalis].[Qty] as 'الكمية',Unit as 'الوحدة',Price as 'السعر قبل الضريبة',[Sales_Detalis].Tax_Value as'الضريبة',[Price_Tax] as 'السعر شامل الضريب',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[User_Name] as 'الكاشير',[Date] as 'التاريخ' FROM [dbo].[Sales_Detalis] , Products where Products.Pro_ID = Sales_Detalis.Pro_ID and User_Name=N'" + cbxUser.Text + "' and Order_ID=" + txtOrderNumber.Text + "  and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'   ORDER BY Order_ID ASC", "");

                }
            }
            DgvSearch.DataSource = tbl;


            decimal totalPrice = 0 ,totalTax=0 ,totalPriceTax=0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += (Convert.ToDecimal(DgvSearch.Rows[i].Cells[5].Value) * Convert.ToDecimal(DgvSearch.Rows[i].Cells[3].Value)) - Convert.ToDecimal(DgvSearch.Rows[i].Cells[8].Value); ;
                totalTax += (Convert.ToDecimal(DgvSearch.Rows[i].Cells[6].Value) * Convert.ToDecimal(DgvSearch.Rows[i].Cells[3].Value));
                totalPriceTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[9].Value);
            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
            txtTotalTax.Text = Math.Round(totalTax, 2).ToString();
            txtPriceTax.Text = Math.Round(totalPriceTax, 2).ToString();
            decimal rb7h = 0;
            if (rbtnOneUser.Checked == true)
            {
                try
                {
                    rb7h = Convert.ToDecimal(db.readData("select * from Users where User_ID=" + cbxUser.SelectedValue + "", "").Rows[0][5]);
                    txtUserRb7h.Text = ((Convert.ToDecimal(txtPriceTax.Text) / 100) * rb7h) + "";
                }
                catch (Exception) { }
                
            }
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
                    db.exceuteData("delete from Sales where Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم المسح بنجاح");

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
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Sales_Detalis].[Qty] as 'الكمية',[Sales_Detalis].[Price_Tax] as 'السعر',[Discount] as 'الخصم',[Total] as 'الاجمالى',[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[User_Name] as 'الكاشير',[Date] as 'التاريخ' FROM [dbo].[Sales_Detalis] , Products where Products.Pro_ID = Sales_Detalis.Pro_ID and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();

                RptSalesReport rpt = new RptSalesReport();


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
            if (DgvSearch.Rows.Count >= 1)
            {

                PrintAll();
            }
        }
        private void Print()
        {
            int id = Convert.ToInt32(DgvSearch.CurrentRow.Cells[0].Value);
            DataTable tblRpt = new DataTable();

            tblRpt.Clear();
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Sales_Detalis].[Qty] as 'الكمية',[Price] as 'السعر',[Discount] as 'الخصم',[Total] as 'الاجمالى',[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[User_Name] as 'الكاشير',[Date] as 'التاريخ' FROM [dbo].[Sales_Detalis] , Products where Products.Pro_ID = Sales_Detalis.Pro_ID and Order_ID=" + id + "", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();

                if (Properties.Settings.Default.SalePrintKind == "8CM")
                {
                    RptOrderSales rpt = new RptOrderSales();
                    rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm.crystalReportViewer1.ReportSource = rpt;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    // rpt.PrintToPrinter(1, true, 0, 0);
                    frm.ShowDialog();

                }
                else if (Properties.Settings.Default.SalePrintKind == "A4")
                {
                    RptOrderSalesA4 rpt = new RptOrderSalesA4();
                    rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm.crystalReportViewer1.ReportSource = rpt;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    // rpt.PrintToPrinter(1, true, 0, 0);
                    frm.ShowDialog();
                }
            }
            catch (Exception) { }
        }
        private void btnOrderPrint_Click(object sender, EventArgs e)
        {
            if(DgvSearch.Rows.Count >= 1)
            {

                Print();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}