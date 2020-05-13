using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.IO;
namespace Sales_Managment
{
    public partial class Frm_Setting : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Setting()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        //call to show orderdata in DB
        private void showOrderData()
        {
            tbl.Clear();
            tbl = db.readData("select * from OrderPrintData", "");

            if (tbl.Rows.Count >= 1)
            {
                txtName.Text = tbl.Rows[0][1].ToString();
                txtAddress.Text = tbl.Rows[0][2].ToString();
                txtDescription.Text = tbl.Rows[0][3].ToString();
                txtPhone1.Text = tbl.Rows[0][4].ToString();
                txtPhone2.Text = tbl.Rows[0][5].ToString();
            }

            try {
                //retrive image from DB
                Byte[] byteimage = new Byte[0];
                byteimage =(Byte[]) (tbl.Rows[0][0]);
                MemoryStream memoryStream = new MemoryStream(byteimage);
                pictureLogo.BackgroundImageLayout = ImageLayout.Stretch;

                pictureLogo.BackgroundImage = Image.FromStream(memoryStream);

            } catch (Exception)
            {

            }
        }
        string printerName = "";
        //call to show printers name in combo
        private void showPrinters()
        {
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                printerName = PrinterSettings.InstalledPrinters[i];
                cbxPrinter.Items.Add(printerName);
            }

            if (Properties.Settings.Default.PrinterName == "")
                cbxPrinter.SelectedIndex = 0;
            else
                cbxPrinter.Text = Properties.Settings.Default.PrinterName;
        }
        private void Frm_Setting_Load(object sender, EventArgs e)
        {
            try
            {
                showPrinters();
             }
            catch (Exception) { }
            try
            {
                showOrderData();
            }
            catch (Exception) { }

            try
            {
                showGeneralSetting();
            }
            catch (Exception) { }
        }

        private void btnSavePrinter_Click(object sender, EventArgs e)
        {
            if(cbxPrinter.Text == "")
            {
                MessageBox.Show("من فضلك تاكد من بيانات الطابعة", "تاكيد");
                return;
            }


            Properties.Settings.Default.PrinterName = cbxPrinter.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("تم الحفظ بنجاح", "تاكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        string imagePath = "";
        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName.ToString();
                pictureLogo.Image = null;
                pictureLogo.ImageLocation = imagePath;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            pictureLogo.BackgroundImage = null;
            pictureLogo.Image = null;
            imagePath = "";
        }
        //function to convert image to byte and save it in DB
        private void saveImage(string stmt ,string paramaterName,string message)
        {
            //connection to DB
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Sales_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(stmt, conn);

            //convert image to byte 
            FileStream filestream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            Byte[] bytestream = new Byte[filestream.Length];
            filestream.Read(bytestream, 0, bytestream.Length);
            filestream.Close();
            //*************************
            SqlParameter parameter = new SqlParameter(paramaterName, SqlDbType.VarBinary, bytestream.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytestream);

            cmd.Parameters.Add(parameter);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            if (message != "")
            {
                MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        DataTable tbl = new DataTable();
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if(imagePath == "")
            {
                MessageBox.Show("من فضلك اختر لوجو", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tbl.Clear();
            tbl = db.readData("select * from OrderPrintData", "");
            if (tbl.Rows.Count >= 1)
            {
                //call function to save image
                saveImage("update OrderPrintData set Logo = @Logo, Name = N'" + txtName.Text + "' ,Address = N'" + txtAddress.Text + "' ,Description = N'" + txtDescription.Text + "' ,Phone1 = N'" + txtPhone1.Text + "' ,Phone2 = N'" + txtPhone2.Text + "'", "@Logo", "تم الحفظ بنجاح");
            }else
            {
                saveImage("insert into  OrderPrintData values (@Logo,N'" + txtName.Text + "' ,N'" + txtAddress.Text + "' ,N'" + txtDescription.Text + "' ,N'" + txtPhone1.Text + "' ,N'" + txtPhone2.Text + "')" , "@Logo", "تم الحفظ بنجاح");
            }
            imagePath = "";
        }

        private void btnSaveGenralSetting_Click(object sender, EventArgs e)
        {

            if (NudSaleNumber.Value < 1 || NudBuyNumber.Value < 1)
            {
                MessageBox.Show("من فضلك لا يمكن ان يقل عدد الفواتير المطبوعه عن 1", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (rbtnVale.Checked==true)
                Properties.Settings.Default.ItemDiscount = "Value";
            else if (rbtnPresent.Checked==true)
                Properties.Settings.Default.ItemDiscount = "Present";
            Properties.Settings.Default.SalesPrintNum =Convert.ToInt32( NudSaleNumber.Value);
            Properties.Settings.Default.BuyPrintNum = Convert.ToInt32(NudBuyNumber.Value);

            if (checkTaxes.Checked == true)
                Properties.Settings.Default.Taxes = true;
            else
                Properties.Settings.Default.Taxes = false;
            if (checkdiscount.Checked == true)
                Properties.Settings.Default.SaleDiscountForCasher = true;
            else
                Properties.Settings.Default.SaleDiscountForCasher = false;

            if (checkSalePrint.Checked == true)
                Properties.Settings.Default.SalesPrint = true;
            else
                Properties.Settings.Default.SalesPrint = false;
            if (checkBuyPrint.Checked == true)
                Properties.Settings.Default.BuyPrint = true;
            else
                Properties.Settings.Default.BuyPrint = false;

            if (rbtn8cmSales.Checked == true)
            {
                Properties.Settings.Default.SalePrintKind = "8CM";
            }else if (rbtnA4Sales.Checked == true)
            {
                Properties.Settings.Default.SalePrintKind = "A4";
            }

            if (rbtn8cmBuy.Checked == true)
            {
                Properties.Settings.Default.BuyPrintKind = "8CM";
            }
            else if (rbtnA4Buy.Checked == true)
            {
                Properties.Settings.Default.BuyPrintKind = "A4";
            }


            Properties.Settings.Default.Save();

            MessageBox.Show("تم حفظ البيانات بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //call to show General setting
        private void showGeneralSetting()
        {
            if (Properties.Settings.Default.ItemDiscount == "Value")
                rbtnVale.Checked = true;
            else if (Properties.Settings.Default.ItemDiscount == "Present")
                rbtnPresent.Checked = true;



            NudSaleNumber.Value = Properties.Settings.Default.SalesPrintNum;
            NudBuyNumber.Value = Properties.Settings.Default.BuyPrintNum;

            if (Properties.Settings.Default.Taxes == true )
                checkTaxes.Checked = true;
            else
                checkTaxes.Checked = false;

            if (Properties.Settings.Default.SaleDiscountForCasher == true  )
                checkdiscount.Checked = true;
            else
                checkdiscount.Checked = false;

            if (Properties.Settings.Default.SalesPrint == true )
                checkSalePrint.Checked = true;
            else
                checkSalePrint.Checked = false;

            if (Properties.Settings.Default.BuyPrint == true )
                checkBuyPrint.Checked = true;
            else
                checkBuyPrint.Checked = false;

            if (Properties.Settings.Default.SalePrintKind == "8CM" )
            {
                rbtn8cmSales.Checked = true;
            }
            else if (Properties.Settings.Default.SalePrintKind == "A4" )
            {
                rbtnA4Sales.Checked = true;
            }

            if (Properties.Settings.Default.BuyPrintKind == "8CM" )
            {
                rbtn8cmBuy.Checked = true;
            }
            else if (Properties.Settings.Default.BuyPrintKind == "A4")
            {
                rbtnA4Buy.Checked = true;
            }
        }
    }
}