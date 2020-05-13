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
    public partial class Frm_BankAddMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_BankAddMoney()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        Database db = new Database();

        private void onLoadScreen()
        {
            tbl.Clear();
            tbl = db.readData("select * from Bank ", "");
            if (tbl.Rows.Count <= 0)
            {
                db.exceuteData("insert into Bank values (0)", "");
                tbl = db.readData("select * from Bank ", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][0]) <= 0)
            {
                lblMoney.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][0]) >= 1)
            {
                lblMoney.Text = Convert.ToDecimal(tbl.Rows[0][0]) + "";
            }
            NudPrice.Value = 1;
            txtName.Clear();
            txtreason.Clear();

        }
        private void Frm_BankAddMoney_Load(object sender, EventArgs e)
        {
            try
            {
                onLoadScreen();
            }
            catch (Exception) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
                string d = DtpDate.Value.ToString("dd/MM/yyyy");
                if (txtName.Text == "") { MessageBox.Show("من فضلك ادخل اسم المودع", "تاكيد"); return; }
                if (NudPrice.Value <= 0) { MessageBox.Show("لابد ان يكون مبلغ الايداع اكبر من صفر", "تاكيد"); return; }
                db.exceuteData("update Bank set Money=Money + " + NudPrice.Value + " ", "");

                db.exceuteData("insert into Bank_Insert ( Money ,Date ,Name ,Type ,Reason) values (" + NudPrice.Value + " ,N'" + d + "' ,N'" + txtName.Text + "' ,N'رصيد اضافى', N'" + txtreason.Text + "') ", "تم الايداع بنجاح");
                onLoadScreen();
        }
    }
}