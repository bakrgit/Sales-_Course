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
    public partial class Frm_Employee : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Employee()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (Emp_ID) from Employee", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {

                txtID.Text = "1";
            }
            else
            {

                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }

            txtName.Clear();
            txtPhone.Clear();
            txtSearch.Clear();
            txtAddress.Clear();
            txtSalary.Clear();
            txtNationalID.Clear();
            
            DtbDate.Text = DateTime.Now.ToShortDateString();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnSave.Enabled = false;

        }

        int row;
        private void Show()
        {
            tbl.Clear();
            tbl = db.readData("select * from Employee", "");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشه");
            }
            else
            {try
                {
                    txtID.Text = tbl.Rows[row][0].ToString();
                    txtName.Text = tbl.Rows[row][1].ToString();
                    txtSalary.Text = tbl.Rows[row][2].ToString();

                    txtNationalID.Text = tbl.Rows[row][4].ToString();
                    txtAddress.Text = tbl.Rows[row][6].ToString();
                    txtPhone.Text = tbl.Rows[row][5].ToString();
                    this.Text = tbl.Rows[row][3].ToString();
                    DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                    DtbDate.Value = dt;
                }
                catch (Exception) { }
            }

            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الموظف");
                return;
            }
            if (txtSalary.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم راتب الموظف");
                return;
            }
            string d = DtbDate.Value.ToString("dd/MM/yyyy");
            db.exceuteData("insert into Employee Values (" + txtID.Text + " ,N'" + txtName.Text + "' ,"+txtSalary.Text+", N'"+d+"', N'"+txtNationalID.Text+ "',N'" + txtPhone.Text + "',N'" + txtAddress.Text + "'  )", "تم الادخال بنجاح");

            AutoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الموظف");
                return;
            }
            if (txtSalary.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم راتب الموظف");
                return;
            }
            string d = DtbDate.Value.ToString("dd/MM/yyyy");
            db.exceuteData("update Employee set  Emp_Name=N'" + txtName.Text + "' ,Salary=" + txtSalary.Text + ",Date= N'" + d + "',National_ID= N'" + txtNationalID.Text + "',Emp_Phone=N'" + txtPhone.Text + "',Emp_Address=N'" + txtAddress.Text + "'  where Emp_ID=" + txtID.Text + " ", "تم التعديل بنجاح");

            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Employee where Emp_ID=" + txtID.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Employee ", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count(Emp_ID) from Employee", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                Show();
            }
            else
            {


                row--;
                Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(Emp_ID) from Employee", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == row)
            {
                row = 0;
                Show();
            }
            else
            {
                row++;
                Show();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(Emp_ID) from Employee", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable tblSearch = new DataTable();
            tbl.Clear();
            tblSearch = db.readData("select * from Employee where Emp_Name like N'%"+txtSearch.Text+"%'", "");

            if (tblSearch.Rows.Count <= 0)
            {
            }
            else
            {
                try
                {
                    txtID.Text = tblSearch.Rows[0][0].ToString();
                    txtName.Text = tblSearch.Rows[0][1].ToString();
                    txtSalary.Text = tblSearch.Rows[0][2].ToString();

                    txtNationalID.Text = tblSearch.Rows[0][4].ToString();
                    txtAddress.Text = tblSearch.Rows[0][6].ToString();
                    txtPhone.Text = tblSearch.Rows[0][5].ToString();
                    this.Text = tblSearch.Rows[0][3].ToString();
                    DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                    DtbDate.Value = dt;
                }
                catch (Exception) { }
            }

            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
        }
    }
}