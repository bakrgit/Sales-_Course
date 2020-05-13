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
    public partial class Frm_ReturnReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ReturnReport()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void Frm_ReturnReport_Load(object sender, EventArgs e)
        {
            DtpFrom.Text = DateTime.Now.ToShortDateString();
            DtpTo.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;
            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            if (rbtnAllReturn.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم العملية' ,[Sup_Name] as 'اسم المورد',[Cust_Name] as 'اسم العميل',[Pro_Name] as 'المنتج',[Qty] as 'الكمية',[Unit_Name] as 'الوحدة',[Price] as 'السعر',[Tax_Value] as 'الضريبة',[Price_Tax] as 'السعر بعد الضريبة',[Total] as 'اجمالى الصنف',[Date] as 'التاريخ',[Total_Order] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المبلغ الباقى',[User_Name] as 'اسم المستخدم' FROM [dbo].[Returns_Detalis] where Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
            }else if (rbtnSalesReturn.Checked == true)
            {
                tbl = db.readData("SELECT Returns_Detalis.[Order_ID] as 'رقم العملية' ,[Sup_Name] as 'اسم المورد',[Cust_Name] as 'اسم العميل',[Pro_Name] as 'المنتج',[Qty] as 'الكمية',[Unit_Name] as 'الوحدة',[Price] as 'السعر',[Tax_Value] as 'الضريبة',[Price_Tax] as 'السعر بعد الضريبة',[Total] as 'اجمالى الصنف',[Date] as 'التاريخ',[Total_Order] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المبلغ الباقى',[User_Name] as 'اسم المستخدم' FROM [dbo].[Returns_Detalis] , Returns where [Returns_Detalis].Order_ID=Returns.Order_ID and Order_Type=N'مرتجعات مبيعات' and  Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");

            }else if (rbtnBuyReturn.Checked == true)
            {
                tbl = db.readData("SELECT Returns_Detalis.[Order_ID] as 'رقم العملية' ,[Sup_Name] as 'اسم المورد',[Cust_Name] as 'اسم العميل',[Pro_Name] as 'المنتج',[Qty] as 'الكمية',[Unit_Name] as 'الوحدة',[Price] as 'السعر',[Tax_Value] as 'الضريبة',[Price_Tax] as 'السعر بعد الضريبة',[Total] as 'اجمالى الصنف',[Date] as 'التاريخ',[Total_Order] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المبلغ الباقى',[User_Name] as 'اسم المستخدم' FROM [dbo].[Returns_Detalis] , Returns where [Returns_Detalis].Order_ID=Returns.Order_ID and Order_Type=N'مرتجعات مشتريات' and  Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");

            }
            DgvSearch.DataSource = tbl;

            decimal totalPrice = 0,totalTax=0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += Convert.ToDecimal(DgvSearch.Rows[i].Cells[9].Value);
                totalTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[7].Value);
            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
            txtTotalTax.Text = Math.Round(totalTax, 2).ToString();
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
                    db.exceuteData("delete  from Returns where Order_ID="+DgvSearch.CurrentRow.Cells[0].Value+"", "");

                    db.exceuteData("delete  from Returns_Detalis where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + "", "تم المسح بنجاح");

                    btnSearch_Click(null, null);
                }
            }
        }
    }
}