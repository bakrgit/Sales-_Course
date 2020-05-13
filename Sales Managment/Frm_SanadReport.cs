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
    public partial class Frm_SanadReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SanadReport()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void Frm_SanadReport_Load(object sender, EventArgs e)
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
            if (rbtnKabd.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم العملية',[Name] as 'اسم المسؤل عن القبض',[Price] as 'المبلغ',[Date] as 'تاريخ العملية',[From_] as 'تم القبض من ',[Reason] as 'السبب' FROM [dbo].[Sanad_Kabd] where Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            }
            else
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم العملية',[Name] as 'اسم المسؤل عن الصرف',[Price] as 'المبلغ',[Date] as 'تاريخ العملية',[To_] as 'تم الصرف لــ ',[Reason] as 'السبب' FROM [dbo].[Sanad_Sarf] where Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");

            }
            if (tbl.Rows.Count >= 1)
            {
                DgvSearch.DataSource = tbl;
                decimal Sum = 0;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(tbl.Rows[i][2]);
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
                if(rbtnKabd.Checked==true)
                    db.exceuteData("delete from Sanad_Kabd where Convert(date,[Date] ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");
                else
                    db.exceuteData("delete from Sanad_Sarf where Convert(date,[Date] ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");

            }
        }
    }
}