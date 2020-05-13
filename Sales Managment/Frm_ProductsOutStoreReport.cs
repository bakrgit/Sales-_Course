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
    public partial class Frm_ProductsOutStoreReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ProductsOutStoreReport()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();


        private void FillStore()
        {

            cbxStoreFrom.DataSource = db.readData("select * from Store", "");
            cbxStoreFrom.DisplayMember = "Store_Name";
            cbxStoreFrom.ValueMember = "Store_ID";
        }
        private void Frm_ProductsOutStoreReport_Load(object sender, EventArgs e)
        {
            FillStore();

            DtpFrom.Text = DateTime.Now.ToShortDateString();
            DtpTo.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            string date1;
            string date2;
            date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = DtpTo.Value.ToString("yyyy-MM-dd");
            
            if(rbtnAllStoreFrom.Checked==true)
               tbl = db.readData("SELECT [Order_ID] as 'رقم العملية',[Pro_Name] as 'اسم المنتج',[Store_Name] as 'اسم المخزن',[Qty] as 'الكمية المخرجة' ,[Unit] as 'الوحدة',[Date] as 'التاريخ',[Name] as 'اسم المسؤل',[Reason] as 'ملاحظات' FROM [dbo].[Products_OutStore] where Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
              else
                tbl = db.readData("SELECT [Order_ID] as 'رقم العملية',[Pro_Name] as 'اسم المنتج',[Store_Name] as 'اسم المخزن',[Qty] as 'الكمية المخرجة' ,[Unit] as 'الوحدة',[Date] as 'التاريخ',[Name] as 'اسم المسؤل',[Reason] as 'ملاحظات' FROM [dbo].[Products_OutStore] where Store_Name=N'"+cbxStoreFrom.Text+"' and Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");



            DgvSearch.DataSource = tbl;

            if (tbl.Rows.Count >= 1)
            {
                decimal totalQty = 0;
                for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
                {
                    totalQty += Convert.ToDecimal(DgvSearch.Rows[i].Cells[3].Value);

                }
                txtTotalQty.Text = Math.Round(totalQty, 2).ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DgvSearch.Rows.Count >= 1)
            {
                string date1;
                string date2;
                date1 = DtpFrom.Value.ToString("yyyy-MM-dd");
                date2 = DtpTo.Value.ToString("yyyy-MM-dd");
                if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.exceuteData("delete from Products_OutStore where  Convert(date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم المسح بنجاح");

                    btnSearch_Click(null, null);
                }
            }
        }
    }
}