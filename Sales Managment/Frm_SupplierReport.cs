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
    public partial class Frm_SupplierReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SupplierReport()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();



        private void FillSupplier()
        {

            cbxSupplier.DataSource = db.readData("select * from Suppliers", "");
            cbxSupplier.DisplayMember = "Sup_Name";
            cbxSupplier.ValueMember = "Sup_ID";
        }
        private void Frm_SupplierReport_Load(object sender, EventArgs e)
        {
            FillSupplier();
            DtpDate.Text = DateTime.Now.ToShortDateString();


            tbl.Clear();
            tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Price] as 'المبلغ المدفوع',[Date] as 'تاريخ ادفع' ,Suppliers.Sup_Name as 'اسم المورد' FROM [dbo].[Supplier_Report] ,Suppliers where Suppliers.Sup_ID =Supplier_Report.Sup_ID", "");

            DgvSearch.DataSource = tbl;

            decimal totalPrice = 0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += Convert.ToDecimal(DgvSearch.Rows[i].Cells[1].Value);

            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            if (rbtnAllSup.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Price] as 'المبلغ المدفوع',[Date] as 'تاريخ ادفع' ,Suppliers.Sup_Name as 'اسم المورد' FROM [dbo].[Supplier_Report] ,Suppliers where Suppliers.Sup_ID =Supplier_Report.Sup_ID", "");
            }
            else if (rbtnOneSupplier.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Price] as 'المبلغ المدفوع',[Date] as 'تاريخ ادفع' ,Suppliers.Sup_Name as 'اسم المورد' FROM [dbo].[Supplier_Report] ,Suppliers where Suppliers.Sup_ID =Supplier_Report.Sup_ID and Suppliers.Sup_ID =" + cbxSupplier.SelectedValue + "", "");

            }
            DgvSearch.DataSource = tbl;

            decimal totalPrice = 0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += Convert.ToDecimal(DgvSearch.Rows[i].Cells[1].Value);

            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DgvSearch.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (rbtnOneSupplier.Checked == true)
                    {

                        db.exceuteData("delete from Supplier_Report where Sup_ID=" + cbxSupplier.SelectedValue + "", "تم مسح البيانات بنجاح");
                        Frm_SupplierReport_Load(null, null);
                    }
                    else { MessageBox.Show("من فضلك حدد مورد اولا", "تاكيد"); return; }
                }
            }
        }
    }
}