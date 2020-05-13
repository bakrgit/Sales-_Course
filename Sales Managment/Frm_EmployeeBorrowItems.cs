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
    public partial class Frm_EmployeeBorrowItems : DevExpress.XtraEditors.XtraForm
    {
        public Frm_EmployeeBorrowItems()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (Order_ID) from Employee_BorrowItems", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {

                txtID.Text = "1";
            }
            else
            {

                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            NudQty.Value = 1;
            DtpDate.Text = DateTime.Now.ToShortDateString();
           try {
                cbxEmployee.SelectedIndex = 0;
                cbxItems.SelectedIndex = 0;
            } catch (Exception) { }

        }

        private void Fillitems()
        {
            cbxItems.DataSource = db.readData("select * from Products", "");
            cbxItems.DisplayMember = "Pro_Name";
            cbxItems.ValueMember = "Pro_ID";
        }
        private void FillEmployee()
        {
            cbxEmployee.DataSource = db.readData("select * from Employee", "");
            cbxEmployee.DisplayMember = "Emp_Name";
            cbxEmployee.ValueMember = "Emp_ID";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (cbxItems.Items.Count <= 0 || cbxEmployee.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك تاكيد من اكتمال البيانات","تاكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (NudQty.Value <= 0)
            {
                MessageBox.Show("لابد ان تكون الكمية المسحوبة لا تقل عن 1", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            decimal price_ = 0,totalPrice=0;
            try {

                price_ =Convert.ToDecimal( db.readData("select Sale_Price from Products where Pro_ID=" + cbxItems.SelectedValue+"", "").Rows[0][0]);
            } catch (Exception)
            {

            }
            totalPrice = price_ * NudQty.Value;
            db.exceuteData("insert into Employee_SalaryMinus (Emp_ID,Emp_Name ,Date ,Price,Pay) values ("+cbxEmployee.SelectedValue+" ,N'"+cbxEmployee.Text+"' ,N'"+d+"' ,"+ totalPrice + " ,'NO')", "");
            db.exceuteData("update Products set Qty=Qty - " + NudQty.Value + " where Pro_ID=" + cbxItems.SelectedValue + "", "");
            db.exceuteData("insert into Employee_BorrowItems values ("+txtID.Text+" , "+cbxItems.SelectedValue+" , "+cbxEmployee.SelectedValue+" , '"+d+"' , "+NudQty.Value+") ", "تمت اضافة العملية بنجاح");
            AutoNumber();
        }

        private void Frm_EmployeeBorrowItems_Load(object sender, EventArgs e)
        {
            try
            {
                Fillitems();
                FillEmployee();
                AutoNumber();
            }
            catch (Exception) { }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBarcode.Text == "") { return; }
            DataTable tblSearch = new DataTable();
            if (e.KeyChar == 13)
            {

                tblSearch.Clear();
                tblSearch = db.readData("select * from Products where Barcode=N'"+txtBarcode.Text+"'", "");

                if (tblSearch.Rows.Count >= 1)
                {
                    cbxItems.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][0]);
                }
            }
        }
    }
}