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
    public partial class Frm_Buy : DevExpress.XtraEditors.XtraForm
    {

        private static Frm_Buy frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Buy GetFormBuy
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Buy();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }


        public Frm_Buy()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }





        Database db = new Database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (Order_ID) from Buy", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {

                txtID.Text = "1";
            }
            else
            {

                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            DtpDate.Text = DateTime.Now.ToShortDateString();
            DtpAagel.Text = DateTime.Now.ToShortDateString();
            try
            {
                cbxItems.SelectedIndex = 0;
                cbxSupplier.SelectedIndex = 0;
                cbxStore.SelectedIndex = 0;
            }
            catch (Exception) { };
            cbxItems.Text = "اختر منتج";
            DgvBuy.Rows.Clear();
            rbtnCash.Checked = true;
            txtbarcode.Clear();
            txtbarcode.Focus();
            txtTotal.Clear();

        }


        private void FillItems()
        {

            cbxItems.DataSource = db.readData("select * from Products", "");
            cbxItems.DisplayMember = "Pro_Name";
            cbxItems.ValueMember = "Pro_ID";

        }
        public void FillSupplier()
        {

            cbxSupplier.DataSource = db.readData("select * from Suppliers", "");
            cbxSupplier.DisplayMember = "Sup_Name";
            cbxSupplier.ValueMember = "Sup_ID";
        }
        public void FillStore()
        {

            cbxStore.DataSource = db.readData("select * from Store", "");
            cbxStore.DisplayMember = "Store_Name";
            cbxStore.ValueMember = "Store_ID";
        }
        private void Frm_Buy_Load(object sender, EventArgs e)
        {
            FillItems();
            FillSupplier();
            FillStore();
            try
            {
                AutoNumber();
            }
            catch (Exception) { }
            stock_ID =Convert.ToString(Properties.Settings.Default.Stock_ID) ;

        }

        private void btnSupplierbrowse_Click(object sender, EventArgs e)
        {
            Frm_Suppliers frm = new Frm_Suppliers();
            frm.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            if (cbxItems.Text == "اختر منتج")
            {
                MessageBox.Show("من فضلك اختر منتج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbxItems.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل المنتجات اولا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable tblItems = new DataTable();
            tblItems.Clear();
            DataTable tblPrice = new DataTable();
            tblPrice.Clear();
            DataTable tblunit = new DataTable();
            tblunit.Clear();

            tblItems = db.readData("select * from Products where Pro_ID=" + cbxItems.SelectedValue + "", "");
            if (tblItems.Rows.Count >= 1)
            {
                try
                {
                    int countQty = 0;
                    try {
                        countQty = Convert.ToInt32(db.readData("select sum (Pro_ID) from Products_Qty where Pro_ID=" + cbxItems.SelectedValue + "", "").Rows[0][0]);
                    } catch (Exception) { }


                    tblPrice = db.readData("select * from Products_Qty where Pro_ID=" + cbxItems.SelectedValue + "", "");

                    string Product_ID = tblItems.Rows[0][0].ToString();
                    string Product_Name = tblItems.Rows[0][1].ToString();
                    string Product_Qty = "1";
                    string Product_Price = tblPrice.Rows[countQty - 1][4].ToString();
                    string Product_Unit = tblItems.Rows[0][16].ToString();
                    decimal Discount = 0;


                    DgvBuy.Rows.Add(1);
                    int rowindex = DgvBuy.Rows.Count - 1;

                    DgvBuy.Rows[rowindex].Cells[0].Value = Product_ID;
                    DgvBuy.Rows[rowindex].Cells[1].Value = Product_Name;
                    DgvBuy.Rows[rowindex].Cells[2].Value = Product_Unit;
                    DgvBuy.Rows[rowindex].Cells[3].Value = Product_Qty;
                    tblunit = db.readData("select * from Products_Unit where Pro_ID=" + DgvBuy.CurrentRow.Cells[0].Value + " and Unit_Name=N'" + DgvBuy.CurrentRow.Cells[2].Value + "'", "");
                    decimal realPrice = 0;
                    try {
                        realPrice = Convert.ToDecimal(Product_Price) / Convert.ToDecimal(tblunit.Rows[0][3]);
                    } catch (Exception) { }
                    decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(realPrice);

                    DgvBuy.Rows[rowindex].Cells[4].Value = Math.Round(realPrice, 2);
                    DgvBuy.Rows[rowindex].Cells[5].Value = Discount;
                    DgvBuy.Rows[rowindex].Cells[6].Value = Math.Round(total, 2);
                }
                catch (Exception) { }


                try
                {
                    decimal TotalOrder = 0;
                    for (int i = 0; i <= DgvBuy.Rows.Count - 1; i++)
                    {

                        TotalOrder += Convert.ToDecimal(DgvBuy.Rows[i].Cells[6].Value);
                        DgvBuy.ClearSelection();
                        DgvBuy.FirstDisplayedScrollingRowIndex = DgvBuy.Rows.Count - 1;
                        DgvBuy.Rows[DgvBuy.Rows.Count - 1].Selected = true;
                    }


                    txtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                    lblItemsCount.Text = (DgvBuy.Rows.Count).ToString();

                }
                catch (Exception) { }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (DgvBuy.Rows.Count >= 1)
            {

                int index = DgvBuy.SelectedRows[0].Index;

                DgvBuy.Rows.RemoveAt(index);


                if (DgvBuy.Rows.Count <= 0)
                {

                    txtTotal.Text = "0";
                }

                try
                {
                    decimal TotalOrder = 0;
                    for (int i = 0; i <= DgvBuy.Rows.Count - 1; i++)
                    {

                        TotalOrder += Convert.ToDecimal(DgvBuy.Rows[i].Cells[6].Value);
                        DgvBuy.ClearSelection();
                        DgvBuy.FirstDisplayedScrollingRowIndex = DgvBuy.Rows.Count - 1;
                        DgvBuy.Rows[DgvBuy.Rows.Count - 1].Selected = true;
                    }


                    txtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                    lblItemsCount.Text = (DgvBuy.Rows.Count).ToString();

                }
                catch (Exception) { }
            }
        }

        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                DataTable tblItems = new DataTable();
                tblItems.Clear();
                DataTable tblPrice = new DataTable();
                tblPrice.Clear();
                DataTable tblunit = new DataTable();
                tblunit.Clear();

                tblItems = db.readData("select * from Products where Barcode=N'" + txtbarcode.Text + "'", "");
                if (tblItems.Rows.Count >= 1)
                {
                    try
                    {
                        cbxItems.SelectedValue = Convert.ToDecimal(tblItems.Rows[0][0]);
                    }
                    catch (Exception) { }
                    try
                    {
                        int countQty = 0;
                        try
                        {
                            countQty = Convert.ToInt32(db.readData("select sum (Pro_ID) from Products_Qty where Pro_ID=" + cbxItems.SelectedValue + "", "").Rows[0][0]);
                        }
                        catch (Exception) { }


                        tblPrice = db.readData("select * from Products_Qty where Pro_ID=" + cbxItems.SelectedValue + "", "");

                        string Product_ID = tblItems.Rows[0][0].ToString();
                        string Product_Name = tblItems.Rows[0][1].ToString();
                        string Product_Qty = "1";
                        string Product_Price = tblPrice.Rows[countQty - 1][4].ToString();
                        string Product_Unit = tblItems.Rows[0][16].ToString();
                        decimal Discount = 0;


                        DgvBuy.Rows.Add(1);
                        int rowindex = DgvBuy.Rows.Count - 1;

                        DgvBuy.Rows[rowindex].Cells[0].Value = Product_ID;
                        DgvBuy.Rows[rowindex].Cells[1].Value = Product_Name;
                        DgvBuy.Rows[rowindex].Cells[2].Value = Product_Unit;
                        DgvBuy.Rows[rowindex].Cells[3].Value = Product_Qty;
                        tblunit = db.readData("select * from Products_Unit where Pro_ID=" + DgvBuy.CurrentRow.Cells[0].Value + " and Unit_Name=N'" + DgvBuy.CurrentRow.Cells[2].Value + "'", "");
                        decimal realPrice = 0;
                        try
                        {
                            realPrice = Convert.ToDecimal(Product_Price) / Convert.ToDecimal(tblunit.Rows[0][3]);
                        }
                        catch (Exception) { }
                        decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(realPrice);

                        DgvBuy.Rows[rowindex].Cells[4].Value = Math.Round(realPrice, 2);
                        DgvBuy.Rows[rowindex].Cells[5].Value = Discount;
                        DgvBuy.Rows[rowindex].Cells[6].Value = Math.Round(total, 2);
                    }
                    catch (Exception) { }


                    try
                    {
                        decimal TotalOrder = 0;
                        for (int i = 0; i <= DgvBuy.Rows.Count - 1; i++)
                        {

                            TotalOrder += Convert.ToDecimal(DgvBuy.Rows[i].Cells[6].Value);
                            DgvBuy.ClearSelection();
                            DgvBuy.FirstDisplayedScrollingRowIndex = DgvBuy.Rows.Count - 1;
                            DgvBuy.Rows[DgvBuy.Rows.Count - 1].Selected = true;
                        }


                        txtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                        lblItemsCount.Text = (DgvBuy.Rows.Count).ToString();

                    }
                    catch (Exception) { }
                }
            }
        }
        //call to insert data in buy and buy detalis table and update qty in store
        private void insertAndUpdateData()
        {
            DataTable tblUnit = new DataTable();
            tblUnit.Clear(); DataTable tblQty = new DataTable();
            tblQty.Clear();
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            string dreminder = DtpAagel.Value.ToString("dd/MM/yyyy");
            //insert data into buy table
            db.exceuteData("insert into Buy values (" + txtID.Text + " , N'" + d + "' ," + cbxSupplier.SelectedValue + ")", "");
            decimal taxValue = 0, totalTax=0, taxPersent = 0, priceBeforeTax = 0, qtyInMqin = 0, realQty = 0;
            //for statment to insert data in buy detalis table and update qty in store
            for (int i = 0; i <= DgvBuy.Rows.Count - 1; i++)
            {
                try
                {
                    //to get products persent tax
                    taxPersent = Convert.ToDecimal(db.readData("select * from Products where Pro_ID=" + DgvBuy.Rows[i].Cells[0].Value + "", "").Rows[0][5]);
                }
                catch (Exception) { }
                //to get product tax value
                taxValue = (Convert.ToDecimal(DgvBuy.Rows[i].Cells[4].Value) / 100) * taxPersent;
                //to get product price before tax
                priceBeforeTax = Convert.ToDecimal(DgvBuy.Rows[i].Cells[4].Value) - taxValue;
                totalTax += taxValue * Convert.ToDecimal(DgvBuy.Rows[i].Cells[3].Value);
                //insert data into buy detalis
                db.exceuteData("insert into Buy_Detalis values (" + txtID.Text + " , " + cbxSupplier.SelectedValue + " ," + DgvBuy.Rows[i].Cells[0].Value + " ,N'" + d + "' , " + DgvBuy.Rows[i].Cells[3].Value + " ,N'" + Properties.Settings.Default.USERNAME + "' ," + priceBeforeTax + " , " + DgvBuy.Rows[i].Cells[5].Value + " , " + DgvBuy.Rows[i].Cells[6].Value + " , " + txtTotal.Text + " , " + Properties.Settings.Default.Madfou3 + " , " + Properties.Settings.Default.Bakey + " ," + taxValue + " ," + DgvBuy.Rows[i].Cells[4].Value + " ,N'" + DtpTime.Text + "' , N'" + DgvBuy.Rows[i].Cells[2].Value + "')", "");
                //to get real qty based unit name
                tblUnit = db.readData("select * from Products_Unit where Pro_ID=" + DgvBuy.Rows[i].Cells[0].Value + " and Unit_Name=N'" + DgvBuy.Rows[i].Cells[2].Value + "'", "");
                qtyInMqin = Convert.ToDecimal(tblUnit.Rows[0][3]);
                realQty = Convert.ToDecimal(DgvBuy.Rows[i].Cells[3].Value) / qtyInMqin;

                //update All qty in products table
                db.exceuteData("update Products set Qty = Qty + " + realQty + " where Pro_ID=" + DgvBuy.Rows[i].Cells[0].Value + "", "");
                //************************************
                //check if same product data exist or not
                tblQty = db.readData("select * from Products_Qty where Pro_ID=" + DgvBuy.Rows[i].Cells[0].Value + " and Store_ID=" + cbxStore.SelectedValue + " and Buy_Price=" + DgvBuy.Rows[i].Cells[4].Value + "", "");
                if (tblQty.Rows.Count >= 1)
                {//if exist .. update data
                    db.exceuteData("update Products_Qty set Qty=Qty +" + realQty + " where Pro_ID=" + DgvBuy.Rows[i].Cells[0].Value + " and Store_ID=" + cbxStore.SelectedValue + " and Buy_Price=" + DgvBuy.Rows[i].Cells[4].Value + " ", "");
                }
                else
                {
                    decimal salePrice = 0;
                    try
                    {
                        salePrice = Convert.ToDecimal(db.readData("select * from Products where Pro_ID=" + DgvBuy.Rows[i].Cells[0].Value + "", "").Rows[0][6]);
                    }
                    catch (Exception) { }
                    //if not exist .. insert new data
                    db.exceuteData("insert into Products_Qty values  (" + DgvBuy.Rows[i].Cells[0].Value + " ," + cbxStore.SelectedValue + " ,N'" + cbxStore.Text + "' , " + realQty + "," + DgvBuy.Rows[i].Cells[4].Value + " ," + salePrice + ")", "");
                }


            }
            decimal totalBeforeTax = 0;
            totalBeforeTax = Convert.ToDecimal(txtTotal.Text) - totalTax;
            db.exceuteData("insert into Taxes_Report (Order_Num,Order_Type,Tax_Type,Sup_Name,Cust_Name,Total_Order,Total_Tax,Total_AfterTax,Date) values ("+txtID.Text+" ,N'فاتورة مشتريات' ,N'قيمة مضافة' ,N'"+cbxSupplier.Text+"' ,N'لا يوجد' ,"+ totalBeforeTax + " ,"+totalTax+" ,"+txtTotal.Text+" ,N'"+d+"')", "");

        }
        string stock_ID = "";
        //call to check if the stock have money to pay or not
        private bool checkIfMoneyExist()
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            DataTable tblStock = new DataTable();
            decimal stock_Money = 0;
            tblStock.Clear();
            tblStock = db.readData("select * from Stock where Stock_ID=" + stock_ID + "", "");
            stock_Money = Convert.ToDecimal(tblStock.Rows[0][1]);

            if (Convert.ToDecimal(Properties.Settings.Default.Madfou3) > stock_Money)
            {
                MessageBox.Show("المبلغ الموجود فى الخزنة غير كافى لاجراء العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            db.exceuteData("insert into Stock_Pull (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + Properties.Settings.Default.Madfou3 + " ,N'" + d + "' ,N'"+Properties.Settings.Default.USERNAME+"' ,N'عمليات شراء', N'') ", "");
            db.exceuteData("update stock set Money=Money - " + Properties.Settings.Default.Madfou3 + " where Stock_ID=" + stock_ID + "", "");
            return true;
        }
        private void PayOrder()
        {
            string dreminder = DtpAagel.Value.ToString("dd/MM/yyyy");
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (DgvBuy.Rows.Count >= 1)
            {
                if (cbxSupplier.Items.Count <= 0) { MessageBox.Show("من فضلك اختر مورد اولا", "تاكيد"); return; }
                if (cbxStore.Items.Count <= 0) { MessageBox.Show("من فضلك ادخل المخازن اولا", "تاكيد"); return; }
                
                try
                {
                    if (DgvBuy.Rows.Count >= 1)
                    {
                        Properties.Settings.Default.TotalOrder = Convert.ToDecimal(txtTotal.Text);
                        Properties.Settings.Default.Madfou3 = 0;
                        Properties.Settings.Default.Bakey = 0;
                        Properties.Settings.Default.Save();

                        Frm_PayBuy frm = new Frm_PayBuy();
                        frm.ShowDialog();

                    }

                    if (Properties.Settings.Default.CheckButton == true)
                    {

                        bool check =checkIfMoneyExist();
                        if(check == false)
                        {
                            return;
                        }
                        insertAndUpdateData();

                        if (rbtnCash.Checked == true)
                        {
                            db.exceuteData("insert into Supplier_Report values (" + txtID.Text + " ," + Properties.Settings.Default.Madfou3 + " , '" + d + "' , " + cbxSupplier.SelectedValue + ")", "");

                        }
                        else if (rbtnAagel.Checked == true)
                        {
                            db.exceuteData("insert into Supplier_Money values (" + txtID.Text + " , " + cbxSupplier.SelectedValue + " , " + Properties.Settings.Default.Bakey + " ,'" + d + "' ,'" + dreminder + "')", "");

                            if (Properties.Settings.Default.Madfou3 >= 1)
                            {
                                db.exceuteData("insert into Supplier_Report values (" + txtID.Text + " ," + Properties.Settings.Default.Madfou3 + " , '" + d + "' , " + cbxSupplier.SelectedValue + ")", "");
                            }
                        }
                        if (Properties.Settings.Default.BuyPrint == true)
                        {
                            int data = 0;
                            if(Properties.Settings.Default.PrinterName =="")
                            { MessageBox.Show("من فضلك حدد اسم الطابعة من شاشة اعدادت البرنامج", "تاكيد"); return; }
                            try {
                                data =Convert.ToInt32( db.readData("select count(Name) from OrderPrintData", "").Rows[0][0]);
                            } catch (Exception) { }
                            if(data <= 0)
                            { MessageBox.Show("من فضلك ادخل بيانات الفاتورة اولا فى شاشة اعدادت البرنامج", "تاكيد"); return; }

                            for (int i = 0; i <= Properties.Settings.Default.BuyPrintNum - 1; i++)
                            {
                                Print();
                            }
                        }

                        AutoNumber();
                    }
                    
                }
                catch (Exception) { }
            }
        }
               

        
    

        //to print 8 cm order or A4
        private void Print()
        {
            int id =Convert.ToInt32( txtID.Text);
            DataTable tblRpt = new DataTable();
          
            tblRpt.Clear();
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',Products.Pro_Name as 'اسم المنتج',[Date] as 'تاريخ الفاتورة',[Buy_Detalis].[Qty] as 'الكمية',Unit_Name as 'الوحدة',[User_Name] as 'اسم المستخدم',[Price] as 'السعر قبل الضريبة',[Buy_Detalis].Tax_Value as 'الضريبة',Price_Tax as 'السعر بعد الضريبة',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'الاجمالى العام',[Madfou3] as 'المدفوع',[Baky] as 'المبلغ المتبقى' FROM [dbo].[Buy_Detalis],Suppliers,Products where  Suppliers.Sup_ID =[Buy_Detalis].Sup_ID and Products.Pro_ID =[Buy_Detalis].Pro_ID and Order_ID ="+id+"","");
            try
            {
            Frm_Print frm = new Frm_Print();
            
            frm.crystalReportViewer1.RefreshReport();
               
                if (Properties.Settings.Default.BuyPrintKind == "8CM")
                {
                    RptOrderBuy rpt = new RptOrderBuy();
                    rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm.crystalReportViewer1.ReportSource = rpt;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    rpt.PrintToPrinter(1, true, 0, 0);
                    //frm.ShowDialog();
                }
                else if (Properties.Settings.Default.BuyPrintKind == "A4")
                {
                    RptOrderBuyA4 rpt = new RptOrderBuyA4();
                    rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm.crystalReportViewer1.ReportSource = rpt;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    rpt.PrintToPrinter(1, true, 0, 0);
                    //frm.ShowDialog();
                }




            }
            catch (Exception) { }
        }



        private void UpdateQty()
        {

            if (DgvBuy.Rows.Count >= 1)
            {

                int index = DgvBuy.SelectedRows[0].Index;

                Properties.Settings.Default.Item_Qty = Convert.ToDecimal(DgvBuy.Rows[index].Cells[3].Value);
                Properties.Settings.Default.Item_BuyPrice = Convert.ToDecimal(DgvBuy.Rows[index].Cells[4].Value); ;
                Properties.Settings.Default.Item_Discount = Convert.ToDecimal(DgvBuy.Rows[index].Cells[5].Value); ;
                Properties.Settings.Default.Pro_Unit = Convert.ToString(DgvBuy.Rows[index].Cells[2].Value);
                Properties.Settings.Default.Pro_ID = Convert.ToInt32(DgvBuy.Rows[index].Cells[0].Value);
                Properties.Settings.Default.Save();


                Frm_BuyQty frm = new Frm_BuyQty();
                frm.ShowDialog();

            }

        }


        private void Frm_Buy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {

                PayOrder();

            }
            else if (e.KeyCode == Keys.F11)
            {

                UpdateQty();

                try
                {

                    int index = DgvBuy.SelectedRows[0].Index;
                    DgvBuy.Rows[index].Cells[2].Value = Properties.Settings.Default.Pro_Unit;
                    DgvBuy.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_Qty;
                    DgvBuy.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_BuyPrice;
                    DgvBuy.Rows[index].Cells[5].Value = Properties.Settings.Default.Item_Discount;

                }
                catch (Exception) { }

            }
            else if (e.KeyCode == Keys.F1)
            {
                txtbarcode.Clear();
                txtbarcode.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnItems_Click(null, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnDeleteItem_Click(null, null);
            }
        }

        private void DgvBuy_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal Item_Qty = 0 ,Item_BuyPrice= 0 ,Item_Discount =0;
            try {

                int index = DgvBuy.SelectedRows[0].Index;

                Item_Qty =Convert.ToDecimal( DgvBuy.Rows[index].Cells[3].Value);
                Item_BuyPrice = Convert.ToDecimal(DgvBuy.Rows[index].Cells[4].Value);
                Item_Discount = Convert.ToDecimal(DgvBuy.Rows[index].Cells[5].Value);

                decimal Total = 0;

                Total = (Item_Qty * Item_BuyPrice) - Item_Discount;

                DgvBuy.Rows[index].Cells[6].Value = Total;



                decimal TotalOrder = 0;
                for (int i = 0; i <= DgvBuy.Rows.Count - 1; i++)
                {

                    TotalOrder += Convert.ToDecimal(DgvBuy.Rows[i].Cells[6].Value);

                }


                txtTotal.Text = Math.Round(TotalOrder, 2).ToString();

            } catch(Exception) { }
        }
    }

        
    }