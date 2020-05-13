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
    public partial class Frm_EmployeeSalaryReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_EmployeeSalaryReport()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void FillEmployee()
        {
            cbxEmployee.DataSource = db.readData("select * from Employee", "");
            cbxEmployee.DisplayMember = "Emp_Name";
            cbxEmployee.ValueMember = "Emp_ID";
        }
        private void Frm_EmployeeSalaryReport_Load(object sender, EventArgs e)
        {
            FillEmployee();
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
            if (rbtnAllEmp.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم العملية',Employee.[Emp_Name] as 'اسم الموظف',[Total_Salary] as 'اجمالى المرتب',[Total_Borrow] as 'اجمالى السلفيات والمسحوبات',[Safy_Salary] as 'صافى المرتب',[Order_Date] as 'تاريخ الصرف',[Date_Reminder] as 'تاريخ الاستحقاق',[Notes] as 'ملاحظات' FROM [dbo].[Employee_Salary],Employee where Employee.Emp_ID=[Employee_Salary].Emp_ID and Convert(date,[Order_Date] ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            }
            else
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم العملية',Employee.[Emp_Name] as 'اسم الموظف',[Total_Salary] as 'اجمالى المرتب',[Total_Borrow] as 'اجمالى السلفيات والمسحوبات',[Safy_Salary] as 'صافى المرتب',[Order_Date] as 'تاريخ الصرف',[Date_Reminder] as 'تاريخ الاستحقاق',[Notes] as 'ملاحظات' FROM [dbo].[Employee_Salary],Employee where Employee.Emp_ID=[Employee_Salary].Emp_ID and [Employee_Salary].Emp_ID="+cbxEmployee.SelectedValue+" and Convert(date,[Order_Date] ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            }
            if (tbl.Rows.Count >= 1)
            {
                DgvSearch.DataSource = tbl;
                decimal Sum = 0;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(tbl.Rows[i][4]);
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
                db.exceuteData("delete from Employee_Salary where Convert(date,[Order_Date] ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");

            }
        }
    }
}