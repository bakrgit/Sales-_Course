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
    public partial class Frm_StockTransfire : DevExpress.XtraEditors.XtraForm
    {
        public Frm_StockTransfire()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void fillStock()
        {
            cbxStockFrom.DataSource = db.readData("select * from Stock_Data", "");
            cbxStockFrom.DisplayMember = "Stock_Name";
            cbxStockFrom.ValueMember = "Stock_ID";
            cbxStockTo.DataSource = db.readData("select * from Stock_Data", "");
            cbxStockTo.DisplayMember = "Stock_Name";
            cbxStockTo.ValueMember = "Stock_ID";
        }
        private void onLoadScreen()
        {
            tbl.Clear();
            tbl = db.readData("select * from Stock where Stock_ID=" + cbxStockFrom.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.exceuteData("insert into Stock values (" + cbxStockFrom.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from Stock where Stock_ID=" + cbxStockFrom.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lblMoney1.Text = "0";
                lblMoney2.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lblMoney1.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
                lblMoney2.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
            }
            NudPrice.Value = 1;
            txtName.Clear();
            txtreason.Clear();

        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void Frm_StockTransfire_Load(object sender, EventArgs e)
        {

            fillStock();
            onLoadScreen();
        }
        private void fromstock1()
        {
            tbl.Clear();
            tbl = db.readData("select * from Stock where Stock_ID=" + cbxStockFrom.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.exceuteData("insert into Stock values (" + cbxStockFrom.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from Stock where Stock_ID=" + cbxStockFrom.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lblMoney1.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lblMoney1.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
            }
            NudPrice.Value = 1;
            txtName.Clear();
            txtreason.Clear();
        }
        private void tostock2()
        {
            tbl.Clear();
            tbl = db.readData("select * from Stock where Stock_ID=" + cbxStockTo.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.exceuteData("insert into Stock values (" + cbxStockTo.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from Stock where Stock_ID=" + cbxStockTo.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lblMoney2.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lblMoney2.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
            }
            NudPrice.Value = 1;
            txtName.Clear();
            txtreason.Clear();
        }
        private void cbxStockFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                fromstock1();
            }catch(Exception) { }
        }

        private void cbxStockTo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tostock2();
            }
            catch (Exception) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {
                string d = DtpDate.Value.ToString("dd/MM/yyyy");
                if (cbxStockTo.Items.Count <= 0) { MessageBox.Show("من فضلك املئ بيانات الخزنات اولا","تاكيد"); return; }
                if (Convert.ToInt32( cbxStockFrom.SelectedValue) == Convert.ToInt32(cbxStockTo.SelectedValue )) { MessageBox.Show("لا يمكن تحويل رصيد لنفس الخزنة", "تاكيد"); return; }

                if (NudPrice.Value > Convert.ToDecimal (lblMoney1.Text))
                { MessageBox.Show("الرصيد الموجود فى الخزنة لا يكفى للتحويل", "تاكيد"); return; }
                if (txtName.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الشخص المسؤل عن التحويل", "تاكيد"); return;
                }

                db.exceuteData("update Stock set Money=Money - "+NudPrice.Value+" where Stock_ID="+cbxStockFrom.SelectedValue+"", "");
                db.exceuteData("update Stock set Money=Money + " + NudPrice.Value + " where Stock_ID=" + cbxStockTo.SelectedValue + "", "");
                db.exceuteData("insert into Stock_Pull (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + cbxStockFrom.SelectedValue + " ," + NudPrice.Value + " ,N'" + d + "' ,N'" + txtName.Text + "' ,N'تحويل الى خزنة', N'" + txtreason.Text + "') ", "");
                db.exceuteData("insert into Stock_Insert (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + cbxStockFrom.SelectedValue + " ," + NudPrice.Value + " ,N'" + d + "' ,N'" + txtName.Text + "' ,N'تحويل من خزنة اخرى', N'" + txtreason.Text + "') ", "");
                db.exceuteData("insert into Stock_Transfire ( Money ,Date ,From_ ,To_ ,Name ,Reason) values (" + NudPrice.Value + " ,N'" + d + "' ,"+cbxStockFrom.SelectedValue+" , "+cbxStockTo.SelectedValue+",N'" + txtName.Text + "' , N'" + txtreason.Text + "') ", "تمت عملية التحويل بنجاح");

                onLoadScreen();
            }
            catch (Exception) { }
        }
    }
}