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
    public partial class Frm_currentMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_currentMoney()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

            tblBank = db.readData("select * from Bank", "");
            if (Convert.ToDecimal(tblBank.Rows[0][0]) <= 0)
            {
                lblMoneyBank.Text = "0";
            }
            else if (Convert.ToDecimal(tblBank.Rows[0][0]) >= 1)
            {
                lblMoneyBank.Text = Convert.ToDecimal(tblBank.Rows[0][0]) + "";
            }

        }
        private void Frm_currentMoney_Load(object sender, EventArgs e)
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
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Frm_StockAddMoney frm = new Frm_StockAddMoney();
            frm.ShowDialog();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            Frm_BankAddMoney frm = new Frm_BankAddMoney();
            frm.ShowDialog();
        }
    }
}