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
    public partial class Frm_EmployeeBorrowMoneyReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_EmployeeBorrowMoneyReport()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void Frm_EmployeeBorrowMoneyReport_Load(object sender, EventArgs e)
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
            if (rbtnAll.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم العملية' ,[Borrow_From] as 'الدائن',[Borrow_To] as 'المدين-سلف لـ',[Order_Date] as 'تاريخ السلف',[Date_Reminder] as 'تاريخ الاستحقاق',[Price] as 'المبلغ',[Notes] as 'ملاحظات' FROM [dbo].[Employee_BorrowMoney] where  Convert(date,[Order_Date] ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            }
            else
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم العملية' ,[Borrow_From] as 'الدائن',[Borrow_To] as 'المدين-سلف لـ',[Order_Date] as 'تاريخ السلف',[Date_Reminder] as 'تاريخ الاستحقاق',[Price] as 'المبلغ',[Notes] as 'ملاحظات' FROM [dbo].[Employee_BorrowMoney] where [Borrow_To]=N'"+txtName.Text+"' and Convert(date,[Order_Date] ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            }
            if (tbl.Rows.Count >= 1)
            {
                DgvSearch.DataSource = tbl;
                decimal Sum = 0;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(tbl.Rows[i][5]);
                }

                txtTotal.Text = Math.Round(Sum, 2).ToString();
            }
            else
            { txtTotal.Text = "0"; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;
            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.exceuteData("delete from Employee_BorrowMoney where Convert(date,[Order_Date] ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");

            }
        }
    }
}