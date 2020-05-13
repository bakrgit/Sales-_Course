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
    public partial class Frm_CustomerMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CustomerMoney()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();


        private void FillCustomer()
        {

            cbxCustomer.DataSource = db.readData("select * from Customers", "");
            cbxCustomer.DisplayMember = "Cust_Name";
            cbxCustomer.ValueMember = "Cust_ID";
        }
        string stock_ID = "";
        private void Frm_CustomerMoney_Load(object sender, EventArgs e)
        {
            stock_ID = Convert.ToString(Properties.Settings.Default.Stock_ID);
            try
            {
                FillCustomer();
            }
            catch (Exception) { }

            DtpDate.Text = DateTime.Now.ToShortDateString();
            tbl.Clear();
            tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cus_Name] as 'العميل',[Price] as 'المبلغ المستحق',[Order_Date] as 'تاريخ الفاتورة',[Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Customer_Money] ", "");

            DgvSearch.DataSource = tbl;

            decimal totalPrice = 0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += Convert.ToDecimal(DgvSearch.Rows[i].Cells[2].Value);

            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbl.Clear();

            if (rbtnAllCust.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cus_Name] as 'العميل',[Price] as 'المبلغ المستحق',[Order_Date] as 'تاريخ الفاتورة',[Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Customer_Money] ", "");
            }else if (rbtnOneCustomer.Checked==true)
            {

                tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cus_Name] as 'العميل',[Price] as 'المبلغ المستحق',[Order_Date] as 'تاريخ الفاتورة',[Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Customer_Money] where Cus_Name=N'" + cbxCustomer.Text+"' ", "");

            }
            DgvSearch.DataSource = tbl;

            decimal totalPrice = 0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += Convert.ToDecimal(DgvSearch.Rows[i].Cells[2].Value);

            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (DgvSearch.Rows.Count >= 1)
            {

                string d = DtpDate.Value.ToString("dd/MM/yyyy");

                if (rbtnPayAll.Checked == true)
                {
                    if (MessageBox.Show("هل انتا متاكد من تسديد المبلغ", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (rbtnAllCust.Checked == true) { MessageBox.Show("من فضلك حدد اسم عميل", "تاكيد"); return; }
                        db.exceuteData("delete from Customer_Money where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + " and Price =" + DgvSearch.CurrentRow.Cells[2].Value + "", "");
                        db.exceuteData("insert  into Customer_Report values (" + DgvSearch.CurrentRow.Cells[0].Value + " , " + DgvSearch.CurrentRow.Cells[2].Value + " , '" + d + "' , N'" + cbxCustomer.Text  + "')", "تم تسديد المبلغ بنجاح");
                        Frm_CustomerMoney_Load(null, null);

                    }
                }
                else if (rbtnPayPart.Checked == true)
                {

                    if (MessageBox.Show("هل انتا متاكد من تسديد المبلغ", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (rbtnAllCust.Checked == true) { MessageBox.Show("من فضلك حدد اسم عميل", "تاكيد"); return; }

                        decimal money = Convert.ToDecimal(DgvSearch.CurrentRow.Cells[2].Value) - NudPrice.Value;
                        db.exceuteData("update Customer_Money set Price=" + money + " where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + " and Price=" + DgvSearch.CurrentRow.Cells[2].Value + "", "");
                        db.exceuteData("insert  into Customer_Report values (" + DgvSearch.CurrentRow.Cells[0].Value + " , " + NudPrice.Value + " , '" + d + "' , N'" + cbxCustomer.Text + "')", "تم تسديد المبلغ بنجاح");
                        Frm_CustomerMoney_Load(null, null);

                    }
                }
                if (rbtnPayAll.Checked == true)
                {
                    db.exceuteData("insert into Stock_Insert (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + DgvSearch.CurrentRow.Cells[2].Value + " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'مستحقات من عملاء', N'') ", "");
                    db.exceuteData("update stock set Money=Money + " + DgvSearch.CurrentRow.Cells[2].Value + " where Stock_ID=" + stock_ID + "", "");
                }else
                {
                    db.exceuteData("insert into Stock_Insert (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + NudPrice.Value+ " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'مستحقات من عملاء', N'') ", "");
                    db.exceuteData("update stock set Money=Money + " + NudPrice.Value + " where Stock_ID=" + stock_ID + "", "");

                }
            }
        }
        private void PrintOneCustomer()
        {
            string name = Convert.ToString(cbxCustomer.Text);
            DataTable tblRpt = new DataTable();

            tblRpt.Clear();
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cus_Name] as 'العميل',[Price] as 'المبلغ المستحق',[Order_Date] as 'تاريخ الفاتورة',[Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Customer_Money] where Cus_Name=N'"+name+"'", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();

                RptCustomerMoney rpt = new RptCustomerMoney();


                rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("Name", name);
                frm.crystalReportViewer1.ReportSource = rpt;

                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rbtnOneCustomer.Checked == true)
            {
                if (DgvSearch.Rows.Count >= 1)
                {
                    PrintOneCustomer();

                }
            }
        }
    }
}