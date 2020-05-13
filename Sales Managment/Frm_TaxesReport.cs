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
    public partial class Frm_TaxesReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_TaxesReport()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void Frm_TaxesReport_Load(object sender, EventArgs e)
        {
            DtpFrom.Text = DateTime.Now.ToShortDateString();
            DtpTo.Text = DateTime.Now.ToShortDateString();
        }

        private void checkSale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;
            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            tbl.Clear();

            string sale = "فاتورة مبيعات" ,buy= "فاتورة مشتريات" ,returnSale= "مرتجعات مبيعات" ,returnBuy= "مرتجعات مشتريات";
            if(checkSale.Checked == true)
            {
                sale = "فاتورة مبيعات";
            }else
            {
                sale = "";
            }
            if (checkBuy.Checked == true)
            {
                buy = "فاتورة مشتريات";
            }
            else
            {
                buy = "";
            }
            if (checkSaleReturn.Checked == true)
            {
                returnSale = "مرتجعات مبيعات";
            }
            else
            {
                returnSale = "";
            }
            if (checkBuyReturn.Checked == true)
            {
                returnBuy = "مرتجعات مشتريات";
            }
            else
            {
                returnBuy = "";
            }
            
            tbl = db.readData("SELECT [Order_ID] as 'رقم العملية',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العملية',[Tax_Type] as 'نوع الضريبة',[Sup_Name] as 'اسم المورد',[Cust_Name] as 'اسم العميل',[Total_Order] as 'اجمالى الفاتورة قبل الضريبة',[Total_Tax] as 'اجمالى الضريبة',[Total_AfterTax] as 'اجمالى الفاتورة بعد الضريبة',[Date] as 'التاريخ' FROM [dbo].[Taxes_Report] where Order_Type in (N'"+sale+"' ,N'"+buy+"' ,N'"+returnSale+"' ,N'"+returnBuy+"') and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
            
            DgvSearch.DataSource = tbl;

            decimal totalPrice = 0, totalTax = 0 ,totalAfterTax=0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += Convert.ToDecimal(DgvSearch.Rows[i].Cells[6].Value);
                totalTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[7].Value);
                totalAfterTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[8].Value);
            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
            txtTotalTax.Text = Math.Round(totalTax, 2).ToString();
            txtTotalAfterTax.Text = Math.Round(totalAfterTax, 2).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DgvSearch.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.exceuteData("delete from Taxes_Report where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + "", "تم المسح بنجاح");

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
            string sale = "فاتورة مبيعات", buy = "فاتورة مشتريات", returnSale = "مرتجعات مبيعات", returnBuy = "مرتجعات مشتريات";
            if (checkSale.Checked == true)
            {
                sale = "فاتورة مبيعات";
            }
            else
            {
                sale = "";
            }
            if (checkBuy.Checked == true)
            {
                buy = "فاتورة مشتريات";
            }
            else
            {
                buy = "";
            }
            if (checkSaleReturn.Checked == true)
            {
                returnSale = "مرتجعات مبيعات";
            }
            else
            {
                returnSale = "";
            }
            if (checkBuyReturn.Checked == true)
            {
                returnBuy = "مرتجعات مشتريات";
            }
            else
            {
                returnBuy = "";
            }
            tblRpt.Clear();
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم العملية',[Order_Num] as 'رقم الفاتورة',[Order_Type] as 'نوع العملية',[Tax_Type] as 'نوع الضريبة',[Sup_Name] as 'اسم المورد',[Cust_Name] as 'اسم العميل',[Total_Order] as 'اجمالى الفاتورة قبل الضريبة',[Total_Tax] as 'اجمالى الضريبة',[Total_AfterTax] as 'اجمالى الفاتورة بعد الضريبة',[Date] as 'التاريخ' FROM [dbo].[Taxes_Report] where Order_Type in (N'" + sale + "' ,N'" + buy + "' ,N'" + returnSale + "' ,N'" + returnBuy + "') and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();

                RptTaxesReport rpt = new RptTaxesReport();


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


        private void PrintSummary()
        {
            string date1;
            string date2;
            date1 = DtpFrom.Value.ToString("dd/MM/yyyy");
            date2 = DtpTo.Value.ToString("dd/MM/yyyy");

            DataTable tblRpt = new DataTable();
         
            tblRpt.Clear();
            tblRpt = db.readData("select ISNULL( sum(Total_Order) , 0) as 'اجمالى فواتير المبيعات' ,ISNULL(sum (Total_Tax) ,0) as 'قيمه الضرائب مبيعات' ,ISNULL( Sum(Total_AfterTax) , 0 ) as 'السعر بعد الضرايب مبيعات' from Taxes_Report where Order_Type =N'فاتورة مبيعات' and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();

                RptTaxesReportsammury rpt = new RptTaxesReportsammury();


                rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                rpt.SetDataSource(tblRpt);

                rpt.SetParameterValue("@FromSale", date1);
                rpt.SetParameterValue("@ToSale", date2);
                rpt.SetParameterValue("@FromBuy", date1);
                rpt.SetParameterValue("@ToBuy", date2);
                rpt.SetParameterValue("@FromReturnSale", date1);
                rpt.SetParameterValue("@ToReturnSale", date2);
                rpt.SetParameterValue("@FromReturnBuy", date1);
                rpt.SetParameterValue("@ToReturnBuy", date2);
                frm.crystalReportViewer1.ReportSource = rpt;

                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                // rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void btnPtintReport_Click(object sender, EventArgs e)
        {
            if (DgvSearch.Rows.Count >= 1)
            {

                PrintAll();
            }
        }

        private void btnPrintSummary_Click(object sender, EventArgs e)
        {
            if (DgvSearch.Rows.Count >= 1)
            {

                PrintSummary();
            }
        }
    }
}