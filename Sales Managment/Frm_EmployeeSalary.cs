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
    public partial class Frm_EmployeeSalary : DevExpress.XtraEditors.XtraForm
    {
        public Frm_EmployeeSalary()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (Order_ID) from Employee_Salary", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {

                txtID.Text = "1";
            }
            else
            {

                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtSafySalary.Clear();
            txtToalBorrow.Clear();
            txtTotalSalary.Clear();
            txtNotes.Clear();
            txtNotes.Clear();
            DtpDate.Text = DateTime.Now.ToShortDateString();
            DtpReminder.Text = DateTime.Now.ToShortDateString();
           
            try
            {
                cbxEmployee.SelectedIndex = 0;
            }
            catch (Exception) { }

        }


        private void FillEmployee()
        {
            cbxEmployee.DataSource = db.readData("select * from Employee", "");
            cbxEmployee.DisplayMember = "Emp_Name";
            cbxEmployee.ValueMember = "Emp_ID";
        }
        string stock_ID = "";
        private void Frm_EmployeeSalary_Load(object sender, EventArgs e)
        {
            try
            {
                FillEmployee();
                AutoNumber();

            }
            catch (Exception) { }
            stock_ID =Convert.ToString(Properties.Settings.Default.Stock_ID);
        }

        private void cbxEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try {
                tbl.Clear();
                tbl = db.readData("select Salary,Date from Employee where Emp_ID="+cbxEmployee.SelectedValue+"", "");
                txtTotalSalary.Text = (tbl.Rows[0][0]).ToString();

                this.Text = tbl.Rows[0][1].ToString();
                DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                DtpReminder.Value = dt;

                try {
                    decimal totalBorrow = 0;
                    DataTable tblCkeck = new DataTable();
                    tblCkeck.Clear();
                    tblCkeck = db.readData("select * from Employee_SalaryMinus where Emp_ID="+cbxEmployee.SelectedValue+" and Pay=N'NO'", "");
              
                    for (int i=0;i <= tblCkeck.Rows.Count - 1; i++)
                    {
                        totalBorrow += Convert.ToDecimal(tblCkeck.Rows[i][4]);
                    }
                    txtToalBorrow.Text = (Math.Round(totalBorrow, 2)).ToString();

                    txtSafySalary.Text = (Convert.ToDecimal(txtTotalSalary.Text) - Convert.ToDecimal(txtToalBorrow.Text)).ToString() ;
                } catch (Exception) { }
            } catch (Exception) { }
        }

        private void payBorrow()
        {
            DataTable tblPrice = new DataTable();
            tblPrice.Clear();
            tblPrice = db.readData("select Price from Employee_SalaryMinus where Emp_ID="+cbxEmployee.SelectedValue+"", "");
            decimal totsa = Convert.ToDecimal(txtTotalSalary.Text);

            for (int i=0; i<= tblPrice.Rows.Count - 1; i++)
            {
                if (totsa >=Convert.ToDecimal( tblPrice.Rows[i][0]))
                {
                    db.exceuteData("update Employee_SalaryMinus set Pay='YES' where Emp_ID="+cbxEmployee.SelectedValue+" and Pay=N'NO' and Emp_Name=N'"+cbxEmployee.Text+"' and Price="+ Convert.ToDecimal(tblPrice.Rows[i][0]) + "", "");
                    totsa = totsa - Convert.ToDecimal(tblPrice.Rows[i][0]);
                }
            }


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            string dReminder = DtpReminder.Value.ToString("dd/MM/yyyy");
            if (cbxEmployee.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك تاكيد من اكتمال بيانات الموظفين", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal stock_Money = 0;
            tbl.Clear();
            tbl = db.readData("select * from Stock where Stock_ID=" + stock_ID + "", "");
            stock_Money = Convert.ToDecimal(tbl.Rows[0][1]);

            if (Convert.ToDecimal(txtSafySalary.Text) > stock_Money)
            {
                MessageBox.Show("المبلغ الموجود فى الخزنة غير كافى لاجراء العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            db.exceuteData("insert into Stock_Pull (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + txtSafySalary.Text + " ,N'" + d + "' ,N'"+Properties.Settings.Default.USERNAME+"' ,N'مرتبات', N'" + txtNotes.Text + "') ", "");
            db.exceuteData("update stock set Money=Money - " +txtSafySalary.Text + " where Stock_ID=" + stock_ID + "", "");


            db.exceuteData("insert into Employee_Salary values ("+txtID.Text+","+cbxEmployee.SelectedValue+" ,"+txtTotalSalary.Text+" ,"+txtToalBorrow.Text+" ,"+txtSafySalary.Text+" ,N'"+d+"' ,N'"+dReminder+"' ,N'"+txtNotes.Text+"')", "تمت عملبة الصرف بنجاح");

            try {
                payBorrow();
            } catch (Exception)
            {

            }
            AutoNumber();

        }
    }
}