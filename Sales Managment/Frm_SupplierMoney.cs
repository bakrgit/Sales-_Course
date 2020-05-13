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
    public partial class Frm_SupplierMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SupplierMoney()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable tbl = new DataTable();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
      private void FillSupplier()
        {

            cbxSupplier.DataSource = db.readData("select * from Suppliers", "");
            cbxSupplier.DisplayMember = "Sup_Name";
            cbxSupplier.ValueMember = "Sup_ID" ;
        }
        string stock_ID = "";
        private void Frm_SupplierMoney_Load(object sender, EventArgs e)
        {
            stock_ID = Convert.ToString(Properties.Settings.Default.Stock_ID);
            try
            {
                FillSupplier();
            }catch(Exception) { }

            DtpDate.Text = DateTime.Now.ToShortDateString();
            tbl.Clear();
            tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',[Price] as 'السعر',[Order_Date] as 'تاريخ الفاتورة',[Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Supplier_Money],Suppliers where Suppliers.Sup_ID =[Supplier_Money].Sup_ID", "");

            DgvSearch.DataSource = tbl;

            decimal totalPrice = 0;
            for (int i =0; i <= DgvSearch.Rows.Count -1; i++)
            {
                totalPrice +=Convert.ToDecimal( DgvSearch.Rows[i].Cells[2].Value);

            }
            txtTotal.Text =Math.Round( totalPrice  , 2).ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbl.Clear();

            if (rbtnAllSup.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',[Price] as 'السعر',[Order_Date] as 'تاريخ الفاتورة',[Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Supplier_Money],Suppliers where Suppliers.Sup_ID =[Supplier_Money].Sup_ID", "");
            }
            else if (rbtnOneSupplier.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',[Price] as 'السعر',[Order_Date] as 'تاريخ الفاتورة',[Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Supplier_Money],Suppliers where Suppliers.Sup_ID =[Supplier_Money].Sup_ID and Suppliers.Sup_ID="+cbxSupplier.SelectedValue+" ", "");


            }
            DgvSearch.DataSource = tbl;

            decimal totalPrice = 0;
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalPrice += Convert.ToDecimal(DgvSearch.Rows[i].Cells[2].Value);

            }
            txtTotal.Text = Math.Round(totalPrice, 2).ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(DgvSearch.Rows.Count >= 1)
            {

                string d = DtpDate.Value.ToString("dd/MM/yyyy");

                decimal stock_Money = 0;
                tbl.Clear();
                tbl = db.readData("select * from Stock where Stock_ID=" + stock_ID + "", "");
                stock_Money = Convert.ToDecimal(tbl.Rows[0][1]);
                if (rbtnPayAll.Checked == true)
                {
                    if (Convert.ToDecimal(DgvSearch.CurrentRow.Cells[2].Value) > stock_Money)
                    {
                        MessageBox.Show("المبلغ الموجود فى الخزنة غير كافى لاجراء العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }else
                {
                    if (Convert.ToDecimal(NudPrice.Value) > stock_Money)
                    {
                        MessageBox.Show("المبلغ الموجود فى الخزنة غير كافى لاجراء العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (rbtnPayAll.Checked == true)
                {
                    if (MessageBox.Show("هل انتا متاكد من تسديد المبلغ", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (rbtnAllSup.Checked == true) { MessageBox.Show("من فضلك حدد اسم مورد", "تاكيد"); return; }
                        db.exceuteData("delete from Supplier_Money where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + " and Price =" + DgvSearch.CurrentRow.Cells[2].Value + "", "");
                        db.exceuteData("insert  into Supplier_Report values (" + DgvSearch.CurrentRow.Cells[0].Value + " , " + DgvSearch.CurrentRow.Cells[2].Value + " , '" + d + "' , " + cbxSupplier.SelectedValue + ")", "تم تسديد المبلغ بنجاح");
                        Frm_SupplierMoney_Load(null,null);

                    }
                }else if (rbtnPayPart.Checked == true)
                {

                    if (MessageBox.Show("هل انتا متاكد من تسديد المبلغ", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (rbtnAllSup.Checked == true) { MessageBox.Show("من فضلك حدد اسم مورد", "تاكيد"); return; }

                        decimal money =Convert.ToDecimal( DgvSearch.CurrentRow.Cells[2].Value) - NudPrice.Value;
                        db.exceuteData("update Supplier_Money set Price="+ money + " where Order_ID="+DgvSearch.CurrentRow.Cells[0].Value+" and Price="+ DgvSearch.CurrentRow.Cells[2].Value + "", "");
                        db.exceuteData("insert  into Supplier_Report values (" + DgvSearch.CurrentRow.Cells[0].Value + " , " + NudPrice.Value + " , '" + d + "' , " + cbxSupplier.SelectedValue + ")", "تم تسديد المبلغ بنجاح");
                        Frm_SupplierMoney_Load(null, null);

                    }
                }


                if (rbtnPayAll.Checked == true)
                {
                    db.exceuteData("insert into Stock_Pull (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + DgvSearch.CurrentRow.Cells[2].Value + " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'مستحقات الى موردين', N'') ", "");
                    db.exceuteData("update stock set Money=Money - " + DgvSearch.CurrentRow.Cells[2].Value + " where Stock_ID=" + stock_ID + "", "");
                }
                else
                {
                    db.exceuteData("insert into Stock_Pull (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + NudPrice.Value + " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'مستحقات الى موردين', N'') ", "");
                    db.exceuteData("update stock set Money=Money - " + NudPrice.Value + " where Stock_ID=" + stock_ID + "", "");

                }
            }
        }
        private void PrintOneSupplier()
        {
            int id = Convert.ToInt32(cbxSupplier.SelectedValue);
            DataTable tblRpt = new DataTable();

            tblRpt.Clear();
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',[Price] as 'السعر',[Order_Date] as 'تاريخ الفاتورة',[Reminder_Date] as 'تاريخ الاستحقاق' FROM [dbo].[Supplier_Money],Suppliers where Suppliers.Sup_ID =[Supplier_Money].Sup_ID and Suppliers.Sup_ID=" + id + "", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();

                RptSupplierMonry rpt = new RptSupplierMonry();


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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rbtnOneSupplier.Checked == true)
            {
                if(DgvSearch.Rows.Count >= 1)
                {
                    PrintOneSupplier();

                }
            }
        }
    }
}