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
    public partial class Frm_CustomerReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CustomerReport()
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
        private void Frm_CustomerReport_Load(object sender, EventArgs e)
        {
            FillCustomer();
            DtpDate.Text = DateTime.Now.ToShortDateString();


            tbl.Clear();
            tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة' ,[Price] as 'المبلغ المدفوع' ,[Date] as 'تاريخ الدفع'  ,[Cust_Name] as 'اسم العميل' FROM [dbo].[Customer_Report]", "");

            DgvSearch.DataSource = tbl;

            decimal totalPrice = 0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += Convert.ToDecimal(DgvSearch.Rows[i].Cells[1].Value);

            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            if (rbtnAllCust.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة' ,[Price] as 'المبلغ المدفوع' ,[Date] as 'تاريخ الدفع'  ,[Cust_Name] as 'اسم العميل' FROM [dbo].[Customer_Report]", "");
            }else
            {

                tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة' ,[Price] as 'المبلغ المدفوع' ,[Date] as 'تاريخ الدفع'  ,[Cust_Name] as 'اسم العميل' FROM [dbo].[Customer_Report] where Cust_Name=N'"+cbxCustomer.Text+"'", "");

            }
            DgvSearch.DataSource = tbl;

            decimal totalPrice = 0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += Convert.ToDecimal(DgvSearch.Rows[i].Cells[1].Value);

            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DgvSearch.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (rbtnOneCustomer.Checked == true)
                    {

                        db.exceuteData("delete from Customer_Report where Cust_Name=N'" + cbxCustomer.Text+ "'", "تم مسح البيانات بنجاح");
                        Frm_CustomerReport_Load(null, null);
                    }
                    else { MessageBox.Show("من فضلك حدد عميل اولا", "تاكيد"); return; }
                }
            }
        }
    }
}