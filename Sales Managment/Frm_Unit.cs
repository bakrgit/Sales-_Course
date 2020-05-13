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
    public partial class Frm_Unit : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Unit()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable tbl = new DataTable(); DataTable tblUnit = new DataTable();
        private void AutoNumber()
        {
            tblUnit.Clear();
            tblUnit = db.readData("select Unit_ID as 'رقم الوحدة' ,Unit_Name as 'اسم الوحدة' from Unit", "");
            DgvSearch.DataSource = tblUnit;
            tbl.Clear();
            tbl = db.readData("select max (Unit_ID) from Unit", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {

                txtID.Text = "1";
            }
            else
            {

                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }

            txtName.Clear();
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
            tbl = db.readData("select * from Unit", "");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشه");
            }
            else
            {
                txtID.Text = tbl.Rows[row][0].ToString();
                txtName.Text = tbl.Rows[row][1].ToString();
            }

            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
        }
        private void Frm_Unit_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الوحدة");
                return;
            }
            db.exceuteData("insert into Unit Values (" + txtID.Text + " ,N'" + txtName.Text + "')", "تم الادخال بنجاح");

            AutoNumber();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الوحدة");
                return;
            }
            db.readData("update Unit set Unit_Name=N'" + txtName.Text + "'  where Unit_ID=" + txtID.Text + "", "تم تعديل البيانات بنجاح");
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Unit where Unit_ID=" + txtID.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Unit ", "تم مسح البيانات بنجاح");
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
                tbl = db.readData("select count(Unit_ID) from Unit", "");
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
            tbl = db.readData("select count(Unit_ID) from Unit", "");
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
            tbl = db.readData("select count(Unit_ID) from Unit", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            Show();
        }

        private void DgvSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try {
                 if(DgvSearch.Rows.Count >= 1)
                {
                    DataTable tblShow = new DataTable();
                    tblShow.Clear();
                    tblShow = db.readData("select * from Unit where Unit_ID="+DgvSearch.CurrentRow.Cells[0].Value+"", "");
                    
                        txtID.Text = tblShow.Rows[0][0].ToString();
                        txtName.Text = tblShow.Rows[0][1].ToString();
                    
                    btnAdd.Enabled = false;
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
                    btnSave.Enabled = true;
                }

            } catch (Exception) { }
        }
    }
}