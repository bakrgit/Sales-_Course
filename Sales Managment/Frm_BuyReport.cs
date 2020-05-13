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
    public partial class Frm_BuyReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_BuyReport()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();


        private void FillSupplier()
        {

            cbxSupplier.DataSource = db.readData("select * from Suppliers", "");
            cbxSupplier.DisplayMember = "Sup_Name";
            cbxSupplier.ValueMember = "Sup_ID";
        }
        private void Frm_BuyReport_Load(object sender, EventArgs e)
        {
            FillSupplier();
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

            if (rbtnAllSup.Checked == true)
            {

                if (checkOrderNumber.Checked == false)
                {
                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',Products.Pro_Name as 'اسم المنتج',[Date] as 'تاريخ الفاتورة',[Buy_Detalis].[Qty] as 'الكمية' ,Unit_Name as 'الوحدة',[Price] as 'السعر قبل الضريبة',[Buy_Detalis].Tax_Value as 'الضريبة',Price_Tax as 'السعر بعد الضريبة',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'الاجمالى العام',[User_Name] as 'اسم المستخدم' ,[Madfou3] as 'المدفوع',[Baky] as 'المبلغ المتبقى' FROM [dbo].[Buy_Detalis],Suppliers,Products where  Suppliers.Sup_ID =[Buy_Detalis].Sup_ID and Products.Pro_ID =[Buy_Detalis].Pro_ID and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'   ORDER BY Order_ID ASC", "");
                }
                else if (checkOrderNumber.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',Products.Pro_Name as 'اسم المنتج',[Date] as 'تاريخ الفاتورة',[Buy_Detalis].[Qty] as 'الكمية' ,Unit_Name as 'الوحدة',[Price] as 'السعر قبل الضريبة',[Buy_Detalis].Tax_Value as 'الضريبة',Price_Tax as 'السعر بعد الضريبة',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'الاجمالى العام',[User_Name] as 'اسم المستخدم' ,[Madfou3] as 'المدفوع',[Baky] as 'المبلغ المتبقى' FROM [dbo].[Buy_Detalis],Suppliers,Products where  Suppliers.Sup_ID =[Buy_Detalis].Sup_ID and Products.Pro_ID =[Buy_Detalis].Pro_ID and Order_ID =" + txtOrderNumber.Text + " and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'  ORDER BY Order_ID ASC", "");
                }

            }
            else if (rbtnOneSupplier.Checked == true)
            {
                if (checkOrderNumber.Checked == false)
                {
                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',Products.Pro_Name as 'اسم المنتج',[Date] as 'تاريخ الفاتورة',[Buy_Detalis].[Qty] as 'الكمية' ,Unit_Name as 'الوحدة',[Price] as 'السعر قبل الضريبة',[Buy_Detalis].Tax_Value as 'الضريبة',Price_Tax as 'السعر بعد الضريبة',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'الاجمالى العام',[User_Name] as 'اسم المستخدم' ,[Madfou3] as 'المدفوع',[Baky] as 'المبلغ المتبقى' FROM [dbo].[Buy_Detalis],Suppliers,Products where  Suppliers.Sup_ID =[Buy_Detalis].Sup_ID and Products.Pro_ID =[Buy_Detalis].Pro_ID and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' and [Buy_Detalis].Sup_ID=" + cbxSupplier.SelectedValue + " ORDER BY Order_ID ASC ", "");
                }
                else if (checkOrderNumber.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',Products.Pro_Name as 'اسم المنتج',[Date] as 'تاريخ الفاتورة',[Buy_Detalis].[Qty] as 'الكمية' ,Unit_Name as 'الوحدة',[Price] as 'السعر قبل الضريبة',[Buy_Detalis].Tax_Value as 'الضريبة',Price_Tax as 'السعر بعد الضريبة',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'الاجمالى العام',[User_Name] as 'اسم المستخدم' ,[Madfou3] as 'المدفوع',[Baky] as 'المبلغ المتبقى' FROM [dbo].[Buy_Detalis],Suppliers,Products where  Suppliers.Sup_ID =[Buy_Detalis].Sup_ID and Products.Pro_ID =[Buy_Detalis].Pro_ID and Order_ID =" + txtOrderNumber.Text + "  and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' and [Buy_Detalis].Sup_ID=" + cbxSupplier.SelectedValue + " ORDER BY Order_ID ASC ", "");

                }
            }


            DgvSearch.DataSource = tbl;


            decimal totalPrice = 0 ,totalTax =0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += Convert.ToDecimal(DgvSearch.Rows[i].Cells[10].Value);
                totalTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[7].Value) * Convert.ToDecimal(DgvSearch.Rows[i].Cells[4].Value);
            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
            txtTotalTax.Text = Math.Round(totalTax, 2).ToString();
        }
        private void Print()
        {
            int id = Convert.ToInt32(DgvSearch.CurrentRow.Cells[0].Value);
            DataTable tblRpt = new DataTable();

            tblRpt.Clear();
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',Products.Pro_Name as 'اسم المنتج',[Date] as 'تاريخ الفاتورة',[Buy_Detalis].[Qty] as 'الكمية',Unit_Name as 'الوحدة',[User_Name] as 'اسم المستخدم',[Price] as 'السعر قبل الضريبة',[Buy_Detalis].Tax_Value as 'الضريبة',Price_Tax as 'السعر بعد الضريبة',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'الاجمالى العام',[Madfou3] as 'المدفوع',[Baky] as 'المبلغ المتبقى' FROM [dbo].[Buy_Detalis],Suppliers,Products where  Suppliers.Sup_ID =[Buy_Detalis].Sup_ID and Products.Pro_ID =[Buy_Detalis].Pro_ID and Order_ID =" + id + "", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();

                if (Properties.Settings.Default.BuyPrintKind == "8CM")
                {
                    RptOrderBuy rpt = new RptOrderBuy();
                    rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm.crystalReportViewer1.ReportSource = rpt;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                    frm.ShowDialog();
                }
                else if (Properties.Settings.Default.BuyPrintKind == "A4")
                {
                    RptOrderBuyA4 rpt = new RptOrderBuyA4();
                    rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm.crystalReportViewer1.ReportSource = rpt;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    rpt.PrintToPrinter(1, true, 0, 0);
                    //frm.ShowDialog();
                }




            }
            catch (Exception) { }
        }
        private void btnPtintOrder_Click(object sender, EventArgs e)
        {
            if (DgvSearch.Rows.Count >= 1)
            {

                Print();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DgvSearch.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.exceuteData("delete  from Buy where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + "", "تم المسح بنجاح");

                    btnSearch_Click(null, null);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            

        }

        private void DgvSearch_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void PrintAll()
        {
            string date1;
            string date2;
            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");

            DataTable tblRpt = new DataTable();

            tblRpt.Clear();
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',Products.Pro_Name as 'اسم المنتج',[Date] as 'تاريخ الفاتورة',[Buy_Detalis].[Qty] as 'الكمية' ,Unit_Name as 'الوحدة',[Price] as 'السعر قبل الضريبة',[Buy_Detalis].Tax_Value as 'الضريبة',Price_Tax as 'السعر بعد الضريبة',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'الاجمالى العام',[User_Name] as 'اسم المستخدم' ,[Madfou3] as 'المدفوع',[Baky] as 'المبلغ المتبقى' FROM [dbo].[Buy_Detalis],Suppliers,Products where  Suppliers.Sup_ID =[Buy_Detalis].Sup_ID and Products.Pro_ID =[Buy_Detalis].Pro_ID and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ORDER BY Order_ID ASC", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();

                RptBuyReport rpt = new RptBuyReport();


                //rpt.SetDatabaseLogon(Properties.Settings.Default.USERNAME, Properties.Settings.Default.DATABASEPASSWORD, @".\SQLEXPRESS", "Sales_System");

                rpt.DataSourceConnections[0].IntegratedSecurity = false;
                rpt.DataSourceConnections[0].SetConnection(Properties.Settings.Default.SERVERNAME ,"SalesSystem" , "admin","123");
                
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

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            if(DgvSearch.Rows.Count >= 1)
            {

                PrintAll();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}