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
    public partial class Frm_BankAddMoneyReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_BankAddMoneyReport()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void Frm_BankAddMoneyReport_Load(object sender, EventArgs e)
        {
            DtpFrom.Text = DateTime.Now.ToShortDateString();
            DtpTo.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;
            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readData("SELECT [Order_ID] as 'رقم العملية',[Money] as 'المبلغ',[Date] as 'التاريخ',[Name] as 'اسم الشخص المسؤل',[Type] as 'نوع الايداع' ,[Reason] as 'السبب' FROM [Bank_Insert] where Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");

            if (tbl.Rows.Count >= 1)
            {
                DgvSearch.DataSource = tbl;
                decimal Sum = 0;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(tbl.Rows[i][1]);
                }

                txtTotal.Text = Math.Round(Sum, 2).ToString();
            }
            else
            { txtTotal.Text = "0"; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;
            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.exceuteData("delete from Bank_Insert where Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");

            }
        }
    }
}