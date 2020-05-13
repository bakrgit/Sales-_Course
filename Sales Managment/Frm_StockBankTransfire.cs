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
    public partial class Frm_StockBankTransfire : DevExpress.XtraEditors.XtraForm
    {
        public Frm_StockBankTransfire()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void fillStock()
        {
            cbxStock.DataSource = db.readData("select * from Stock_Data", "");
            cbxStock.DisplayMember = "Stock_Name";
            cbxStock.ValueMember = "Stock_ID";
        }
        private void onLoadScreen()
        {
            tbl.Clear();
            DataTable tblBank = new DataTable();
            tblBank.Clear();
            tbl = db.readData("select * from Stock where Stock_ID=" + cbxStock.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.exceuteData("insert into Stock values (" + cbxStock.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from Stock where Stock_ID=" + cbxStock.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lblMoneyStock.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lblMoneyStock.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
            }

            tblBank = db.readData("select * from Bank","");
            if (Convert.ToDecimal(tblBank.Rows[0][0]) <= 0)
            {
                lblMoneyBank.Text = "0";
            }
            else if (Convert.ToDecimal(tblBank.Rows[0][0]) >= 1)
            {
                lblMoneyBank.Text = Convert.ToDecimal(tblBank.Rows[0][0]) + "";
            }
            NudPrice.Value = 1;
            txtName.Clear();

        }
        private void Frm_StockBankTransfire_Load(object sender, EventArgs e)
        {
            fillStock();
            onLoadScreen();
        }

        private void cbxStock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select * from Stock where Stock_ID=" + cbxStock.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.exceuteData("insert into Stock values (" + cbxStock.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from Stock where Stock_ID=" + cbxStock.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lblMoneyStock.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lblMoneyStock.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
            }
            NudPrice.Value = 1;
            txtName.Clear();
        }


        private void fromStockTobank()
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (NudPrice.Value > Convert.ToDecimal(lblMoneyStock.Text))
            {
                MessageBox.Show("لا يمكن تحويل مبلغ اكبر من المبلغ الموجود فى الخزنة", "تاكيد"); return;
            }

            db.exceuteData("update Stock set Money=Money - " + NudPrice.Value + " where Stock_ID=" + cbxStock.SelectedValue + "", "");


            db.exceuteData("insert into Stock_Pull (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + cbxStock.SelectedValue + " ," + NudPrice.Value + " ,N'" + d + "' ,N'" + txtName.Text + "' ,N'تحويل الى بنك', N'') ", "");

            db.exceuteData("update Bank set Money=Money+"+NudPrice.Value+" ", "");

            db.exceuteData("insert into Bank_Insert (  Money ,Date ,Name ,Type ,Reason) values (" + NudPrice.Value + " ,N'" + d + "' ,N'" + txtName.Text + "' ,N'تحويل من خزنة', N'') ", "");
            db.exceuteData("insert into StockBank_Transfire ( Money ,Date ,From_ ,To_ ,Name ) values (" + NudPrice.Value + " ,N'" + d + "' ,N'" + cbxStock.Text + "' , N'البنك',N'" + txtName.Text + "' ) ", "تمت عملية التحويل بنجاح");
            onLoadScreen();
        }


        private void fromBanktoStock()
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (NudPrice.Value > Convert.ToDecimal(lblMoneyBank.Text))
            {
                MessageBox.Show("لا يمكن تحويل مبلغ اكبر من المبلغ الموجود فى البنك", "تاكيد"); return;
            }

            db.exceuteData("update Stock set Money=Money + " + NudPrice.Value + " where Stock_ID=" + cbxStock.SelectedValue + "", "");


            db.exceuteData("insert into Stock_Insert (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + cbxStock.SelectedValue + " ," + NudPrice.Value + " ,N'" + d + "' ,N'" + txtName.Text + "' ,N'تحويل من بنك', N'') ", "");

            db.exceuteData("update Bank set Money=Money - " + NudPrice.Value + " ", "");
            db.exceuteData("insert into Bank_Pull (  Money ,Date ,Name ,Type ,Reason) values (" + NudPrice.Value + " ,N'" + d + "' ,N'" + txtName.Text + "' ,N'تحويل الى خزنة', N'') ", "");

            db.exceuteData("insert into StockBank_Transfire ( Money ,Date ,From_ ,To_ ,Name ) values (" + NudPrice.Value + " ,N'" + d + "' ,N'البنك' , N'"+cbxStock.Text+"',N'" + txtName.Text + "' ) ", "تمت عملية التحويل بنجاح");
            onLoadScreen();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (cbxStock.Items.Count <= 0) { MessageBox.Show("من فضلك املئ بيانات الخزنات اولا", "تاكيد"); return; }
           
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الشخص المسؤل عن التحويل", "تاكيد"); return;
            }

            if (rbtnFromStockTobank.Checked == true)
            {
                fromStockTobank();
            }else
            {
                fromBanktoStock();
            }
        }
    }
}