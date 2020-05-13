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
    public partial class Frm_SanadKabd : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SanadKabd()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (Order_ID) from Sanad_Kabd", "");

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
            txtReason.Clear();
            txtName.Clear();
            txtFrom.Clear();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;

        }

        int row;
        private void Show()
        {
            tbl.Clear();
            tbl = db.readData("select * from Sanad_Kabd", "");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشه");
            }
            else
            {
                try
                {
                    txtID.Text = tbl.Rows[row][0].ToString();
                    txtName.Text = tbl.Rows[row][1].ToString();
                    NudPrice.Value = Convert.ToDecimal(tbl.Rows[row][2]);
                    this.Text = tbl.Rows[row][3].ToString();
                    DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                    DtpDate.Value = dt;
                    txtFrom.Text = tbl.Rows[row][4].ToString();
                    txtReason.Text = tbl.Rows[row][5].ToString();
                }
                catch (Exception) { }
            }

            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
        }
        string stock_ID = "";
        private void Frm_SanadKabd_Load(object sender, EventArgs e)
        {
            AutoNumber();
            stock_ID = Convert.ToString(Properties.Settings.Default.Stock_ID);
        }
        private void Print()
        {
            int id = Convert.ToInt32(txtID.Text);
            DataTable tblRpt = new DataTable();

            tblRpt.Clear();
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم العملية' ,[Name] as 'اسم المسؤل عن القبض',[Price] as 'المبلغ',[Date] as 'تاريخ العملية',[From_] as 'تم القبض من ',[Reason] as 'السبب' FROM [dbo].[Sanad_Kabd] where Order_ID="+id+"", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();

                RptSanadKabd rpt = new RptSanadKabd();


                rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                rpt.SetDataSource(tblRpt);
                rpt.SetParameterValue("ID", id);
                frm.crystalReportViewer1.ReportSource = rpt;

                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //rpt.PrintToPrinter(1, true, 0, 0);
                frm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "" || txtName.Text =="")
            {
                MessageBox.Show("من فضلك اكمل البيانات");
                return;
            }
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            db.exceuteData("update stock set Money=Money + "+NudPrice.Value+" where Stock_ID="+stock_ID+"", "");
            db.exceuteData("insert into Stock_Insert (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + NudPrice.Value + " ,N'" + d + "' ,N'" + txtName.Text + "' ,N'سند قبض', N'" + txtReason.Text + "') ", "");

            db.exceuteData("insert into Sanad_Kabd Values (" + txtID.Text + " ,N'"+txtName.Text+"' ,"+NudPrice.Value+" ,N'"+d+"' ,N'"+txtFrom.Text+"' ,N'"+txtReason.Text+"')", "تم الادخال بنجاح");
            Print();
            AutoNumber();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Sanad_Kabd where Order_ID=" + txtID.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Sanad_Kabd ", "تم مسح البيانات بنجاح");
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
                tbl = db.readData("select count(Order_ID) from Sanad_Kabd", "");
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
            tbl = db.readData("select count(Order_ID) from Sanad_Kabd", "");
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
            tbl = db.readData("select count(Order_ID) from Sanad_Kabd", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            Show();
        }
    }
}