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
    public partial class Frm_PrintBarcode : DevExpress.XtraEditors.XtraForm
    {
        public Frm_PrintBarcode()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void FillPro()
        {
            cbxProducts.DataSource = db.readData("select * from Products", "");
            cbxProducts.DisplayMember = "Pro_Name";
            cbxProducts.ValueMember = "Pro_ID";
        }
        private void Frm_PrintBarcode_Load(object sender, EventArgs e)
        {
            FillPro();
            
           txtProName.Text = Properties.Settings.Default.Pro_Name;
           txtBarcode.Text =Properties.Settings.Default.Pro_Barcode;
           txtSalesPrice.Text =Convert.ToString( Properties.Settings.Default.Pro_Price);
            
        }

        private void btnRandomBarcode_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            tbl = db.readData("select * from Random_Barcode ", "");
            if (tbl.Rows.Count <= 0)
            {

                txtBarcode.Text = "1000000";
                db.exceuteData("insert into Random_Barcode values (1000000)", "");
            }
            else
            {

                txtBarcode.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
                db.exceuteData("update Random_Barcode set Barcode=N'"+ (Convert.ToInt32(tbl.Rows[0][0]) + 1) + "'", "");
            }
        }

        private void btnSavebarcode_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            tbl = db.readData("select * from Random_Barcode ", "");
            if (tbl.Rows.Count <= 0)
            {
                
                db.exceuteData("insert into Random_Barcode values (N'"+txtBarcode.Text+"')", "تم الحفظ بنجاح");
            }
            else
            {
                
                db.exceuteData("update Random_Barcode set Barcode=N'" + txtBarcode.Text + "'", "تم الحفظ بنجاح");
            }
            
        }

        private void cbxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbxProducts.Items.Count >= 1)
            {
                DataTable tbl = new DataTable();
                tbl.Clear();
                tbl = db.readData("select * from Products where Pro_ID="+cbxProducts.SelectedValue+" ", "");

                if(tbl.Rows.Count >= 1)
                {
                    txtProName.Text = tbl.Rows[0][1].ToString();
                    txtBarcode.Text = tbl.Rows[0][7].ToString();
                    txtSalesPrice.Text = tbl.Rows[0][6].ToString();
                }

            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if(txtBarcode.Text =="" || txtProName.Text =="" || txtSalesPrice.Text =="")
            {
                MessageBox.Show("من فضلك اكمل البيانات","تاكيد");
                return;
            }
            DataSet1 DS = new DataSet1();

            DS.Clear();
            RptCrystalReport rpt = new RptCrystalReport();
            DS.Tables["PrintBarcode"].Rows.Add(txtProName.Text, txtBarcode.Text, txtSalesPrice.Text, "*" + txtBarcode.Text.Trim() + "*");
            //decimal count = 0;
            //try {
            //    count =Convert.ToDecimal( db.readData("select * from Barcode_Print", "").Rows[0][0]);

            //} catch (Exception) { }
            //if (count >= 1)
            //{
            //    db.exceuteData("update Barcode_Print set Pro_Name=N'"+txtProName.Text+ "' ,Pro_Barcode=N'"+txtBarcode.Text+ "' ,Pro_Price=N'"+txtSalesPrice.Text+"' ,barcode=N'"+txtBarcode.Text+"'", "");
            //}else
            //{
            //    db.exceuteData("insert into Barcode_Print values(N'" + txtProName.Text + "' ,N'" + txtBarcode.Text + "' ,N'" + txtSalesPrice.Text + "' ,N'" + txtBarcode.Text + "')", "");

            //}
            //DataTable tblS = new DataTable();
            //tblS.Clear();
            //tblS = db.readData("select * from Barcode_Print", "");

            rpt.SetDataSource(DS);
            
            Frm_Print frm = new Frm_Print();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.crystalReportViewer1.Refresh();
            frm.ShowDialog();
            Properties.Settings.Default.Pro_Barcode = txtBarcode.Text;
            Properties.Settings.Default.Save();
            db.exceuteData("update Products set Barcode=N'"+txtBarcode.Text+"' where Pro_Name=N'"+txtProName.Text+"'", "");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "" || txtProName.Text == "" || txtSalesPrice.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات", "تاكيد");
                return;
            }
            DataSet1 DS = new DataSet1();

            DS.Clear();
            RptCrystalReport rpt = new RptCrystalReport();
            DS.Tables["PrintBarcode"].Rows.Add(txtProName.Text, txtBarcode.Text, txtSalesPrice.Text, "*" + txtBarcode.Text.Trim() + "*");

            rpt.SetDataSource(DS);

            Frm_Print frm = new Frm_Print();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.crystalReportViewer1.Refresh();
            //frm.ShowDialog();
            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
            rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
            rpt.PrintToPrinter(1, true, 0, 0);

            Properties.Settings.Default.Pro_Barcode = txtBarcode.Text;
            Properties.Settings.Default.Save();
            db.exceuteData("update Products set Barcode=N'" + txtBarcode.Text + "' where Pro_Name=N'" + txtProName.Text + "'", "");

        }
    }
}