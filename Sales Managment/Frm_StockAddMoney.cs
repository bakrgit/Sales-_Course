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
    public partial class Frm_StockAddMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_StockAddMoney()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        Database db = new Database();

        private void onLoadScreen ()
        {
            fillStock();
            tbl.Clear();
            tbl = db.readData("select * from Stock where Stock_ID="+cbxStock.SelectedValue+"","");
            if(tbl.Rows.Count <= 0)
            {
                db.exceuteData("insert into Stock values ("+cbxStock.SelectedValue+" , 0)","");
                tbl = db.readData("select * from Stock where Stock_ID=" + cbxStock.SelectedValue + "", "");
            }
            if (Convert.ToDecimal( tbl.Rows[0][1] ) <= 0)
            {
                lblMoney.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lblMoney.Text = Convert.ToDecimal(tbl.Rows[0][1]) +"";
            }
            NudPrice.Value = 1;
            txtName.Clear();
            txtreason.Clear();

        }
        private void fillStock()
        {
            cbxStock.DataSource = db.readData("select * from Stock_Data","");
            cbxStock.DisplayMember = "Stock_Name";
            cbxStock.ValueMember = "Stock_ID";
        }
        private void Frm_StockAddMoney_Load(object sender, EventArgs e)
        {try
            {
                onLoadScreen();
            }catch(Exception) { }
        }

        private void cbxStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxStock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
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
                    lblMoney.Text = "0";
                }
                else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
                {
                    lblMoney.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
                }
            }
            catch (Exception) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbxStock.Items.Count >= 1)
            {
                string d = DtpDate.Value.ToString("dd/MM/yyyy");
                if (txtName.Text == "") { MessageBox.Show("من فضلك ادخل اسم المودع", "تاكيد"); return;  }
                if (NudPrice.Value <=0) { MessageBox.Show("لابد ان يكون مبلغ الايداع اكبر من صفر", "تاكيد"); return; }
                db.exceuteData("update Stock set Money=Money + "+NudPrice.Value+" where Stock_ID="+cbxStock.SelectedValue+"", "");

                db.exceuteData("insert into Stock_Insert (Stock_ID , Money ,Date ,Name ,Type ,Reason) values ("+cbxStock.SelectedValue+" ,"+NudPrice.Value+" ,N'"+d+"' ,N'"+txtName.Text+"' ,N'رصيد اضافى', N'"+txtreason.Text+"') ", "تم الايداع بنجاح");
                onLoadScreen();
            }
        }
    }
}