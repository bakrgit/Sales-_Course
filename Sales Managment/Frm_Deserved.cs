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
    public partial class Frm_Deserved : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Deserved()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (Des_ID) from Deserved", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {

                txtID.Text = "1";
            }
            else
            {

                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            NudPrice.Value = 1;
            DtpDate.Text = DateTime.Now.ToShortDateString();
            txtNote.Clear();
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
            tbl = db.readData("select * from Deserved", "");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشه");
            }
            else
            {
                try
                {
                    txtID.Text = tbl.Rows[row][0].ToString();
                    NudPrice.Value = Convert.ToDecimal(tbl.Rows[row][1]);
                    this.Text = tbl.Rows[row][2].ToString();
                    DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                    DtpDate.Value = dt;
                    txtNote.Text = tbl.Rows[row][3].ToString();
                    cbxType.SelectedValue = Convert.ToDecimal(tbl.Rows[row][4]);
                }
                catch (Exception) { }
                }

            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
        }
        private void  FillType()
        {
            cbxType.DataSource = db.readData("select * from Deserved_Type", "");
            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Des_ID";
        }
        string stock_ID = "";
        private void Frm_Deserved_Load(object sender, EventArgs e)
        {
            AutoNumber();
            FillType();
            stock_ID = Convert.ToString(Properties.Settings.Default.Stock_ID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (cbxType.Items.Count <=0)
            {
                MessageBox.Show("من فضلك ادخل الانواع اولا");
                return;
            }
            decimal stock_Money = 0;
            tbl.Clear();
            tbl = db.readData("select * from Stock where Stock_ID=" + stock_ID + "", "");
            stock_Money = Convert.ToDecimal(tbl.Rows[0][1]);

            if (Convert.ToDecimal(NudPrice.Value) > stock_Money)
            {
                MessageBox.Show("المبلغ الموجود فى الخزنة غير كافى لاجراء العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            db.exceuteData("insert into Stock_Pull (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + NudPrice.Value+ " ,N'" + d + "' ,N'"+Properties.Settings.Default.USERNAME+"' ,N'مصروفات', N'" + txtNote.Text + "') ", "");
            db.exceuteData("update stock set Money=Money - " + NudPrice.Value + " where Stock_ID=" + stock_ID + "", "");
            
            db.exceuteData("insert into Deserved Values (" + txtID.Text + " ," + NudPrice.Value + " , N'"+d+"' ,N'"+txtNote.Text+"' ,"+cbxType.SelectedValue+")", "تم الادخال بنجاح");

            AutoNumber();
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
                tbl = db.readData("select count(Des_ID) from Deserved", "");
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
            tbl = db.readData("select count(Des_ID) from Deserved", "");
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
            tbl = db.readData("select count(Des_ID) from Deserved", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
            FillType();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(NudPrice.Value <= 0)
            {

                MessageBox.Show("لا يمكن ادخال اقل من 1","تاكيد");
                return;
            }
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            db.readData("update Deserved set Price=" + NudPrice.Value + ",Date='"+d+"' ,Notes=N'"+txtNote.Text+"' ,Type_ID="+cbxType.SelectedValue+"  where Des_ID=" + txtID.Text + "", "تم تعديل البيانات بنجاح");
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Deserved where Des_ID=" + txtID.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Deserved", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }
    }
}