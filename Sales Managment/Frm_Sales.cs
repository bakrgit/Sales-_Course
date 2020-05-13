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
    public partial class Frm_Sales : DevExpress.XtraEditors.XtraForm
    {


        private static Frm_Sales frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Sales GetFormSales
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_Sales();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Frm_Sales()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        Database db = new Database();
        DataTable tbl = new DataTable();



        private void FillItems()
        {

            cbxItems.DataSource = db.readData("select * from Products", "");
            cbxItems.DisplayMember = "Pro_Name";
            cbxItems.ValueMember = "Pro_ID";

        }

        public void FillCustomer()
        {

            cbxCustomer.DataSource = db.readData("select * from Customers", "");
            cbxCustomer.DisplayMember = "Cust_Name";
            cbxCustomer.ValueMember = "Cust_ID";
        }
        string stock_ID = "";
        private void Frm_Sales_Load(object sender, EventArgs e)
        {
            FillItems();
            FillCustomer();
            DtpDate.Text = DateTime.Now.ToShortDateString();
            DtpReminder.Text = DateTime.Now.ToShortDateString();
            rbtnCustNakdy_CheckedChanged(null, null);

            
            try {

                AutoNumber();
            } catch (Exception) { }

            stock_ID = Convert.ToString(Properties.Settings.Default.Stock_ID);
        }
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (Order_ID) from Sales", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {

                txtID.Text = "1";
            }
            else
            {

                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            DtpDate.Text = DateTime.Now.ToShortDateString();
            DtpReminder.Text = DateTime.Now.ToShortDateString();
            try
            {
                cbxItems.SelectedIndex = 0;
                cbxCustomer.SelectedIndex = 0;
            }
            catch (Exception) { };
            cbxItems.Text = "اختر منتج";
            DgvSale.Rows.Clear();
            rbtnCustNakdy.Checked = true;
            txtbarcode.Clear();
            txtbarcode.Focus();
            txtTotal.Clear();

        }
        private void rbtnCustNakdy_CheckedChanged(object sender, EventArgs e)
        {
            try {

                cbxCustomer.Enabled = false;
                btnCustomerBrowes.Enabled = false;
                DtpReminder.Enabled = false;

            } catch (Exception) { }
        }

        private void rbtnCustAagel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                cbxCustomer.Enabled = true;
                btnCustomerBrowes.Enabled = true;
                DtpReminder.Enabled = true;

            }
            catch (Exception) { }
        }

        private void btnCustomerBrowes_Click(object sender, EventArgs e)
        {
            Frm_Customer frm = new Frm_Customer();
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
            tblItems.Clear(); DataTable tblUnit = new DataTable();
            tblUnit.Clear();

            tblItems = db.readData("select * from Products where Pro_ID=" + cbxItems.SelectedValue + "", "");
            if (tblItems.Rows.Count >= 1)
            {
                try
                {
                    string Product_ID = tblItems.Rows[0][0].ToString();
                    string Product_Name = tblItems.Rows[0][1].ToString();
                    string Product_Qty = "1";
                    string Product_Price ="0";
                    decimal Discount = 0;
                    string Product_Unit = tblItems.Rows[0][14].ToString(); ;
                    

                    DgvSale.Rows.Add(1);
                    int rowindex = DgvSale.Rows.Count - 1;

                    DgvSale.Rows[rowindex].Cells[0].Value = Product_ID;
                    DgvSale.Rows[rowindex].Cells[1].Value = Product_Name;
                    DgvSale.Rows[rowindex].Cells[3].Value = Product_Qty;
                    DgvSale.Rows[rowindex].Cells[2].Value = Product_Unit;
                    tblUnit = db.readData("select * from Products_Unit where Pro_ID=" + DgvSale.CurrentRow.Cells[0].Value + " and Unit_Name=N'" + DgvSale.CurrentRow.Cells[2].Value + "'", "");

                    decimal realPrice = 0;
                    try
                    {
                        realPrice = Convert.ToDecimal(tblUnit.Rows[0][5]) / Convert.ToDecimal(tblUnit.Rows[0][3]);
                    }
                    catch (Exception) { }
                    DgvSale.Rows[rowindex].Cells[4].Value = realPrice;
                    decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(realPrice);

                    DgvSale.Rows[rowindex].Cells[5].Value = Discount;
                    DgvSale.Rows[rowindex].Cells[6].Value = total;
                }
                catch (Exception) { }


                try
                {
                    decimal TotalOrder = 0;
                    for (int i = 0; i <= DgvSale.Rows.Count - 1; i++)
                    {

                        TotalOrder += Convert.ToDecimal(DgvSale.Rows[i].Cells[6].Value);
                        DgvSale.ClearSelection();
                        DgvSale.FirstDisplayedScrollingRowIndex = DgvSale.Rows.Count - 1;
                        DgvSale.Rows[DgvSale.Rows.Count - 1].Selected = true;
                    }


                    txtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                    lblItemsCount.Text = (DgvSale.Rows.Count).ToString();

                }
                catch (Exception) { }
            }

        }
        private void UpdateQty()
        {

            if (DgvSale.Rows.Count >= 1)
            {
                int index = DgvSale.SelectedRows[0].Index;
                Properties.Settings.Default.Pro_ID = Convert.ToInt32(DgvSale.Rows[index].Cells[0].Value);
                Properties.Settings.Default.Item_Qty = Convert.ToDecimal(DgvSale.Rows[index].Cells[3].Value);
                Properties.Settings.Default.Item_SalePrice = Convert.ToDecimal(DgvSale.Rows[index].Cells[4].Value); ;
                Properties.Settings.Default.Item_Discount = Convert.ToDecimal(DgvSale.Rows[index].Cells[5].Value); ;
                Properties.Settings.Default.Pro_Unit = Convert.ToString(DgvSale.Rows[index].Cells[2].Value) ;
                Properties.Settings.Default.Save();


                Frm_SaleQty frm = new Frm_SaleQty();
                frm.ShowDialog();


                try
                {

                    int index2 = DgvSale.SelectedRows[0].Index;
                    DgvSale.Rows[index2].Cells[2].Value = Properties.Settings.Default.Pro_Unit;
                    DgvSale.Rows[index2].Cells[3].Value = Properties.Settings.Default.Item_Qty;
                    DgvSale.Rows[index2].Cells[4].Value = Properties.Settings.Default.Item_SalePrice;
                    DgvSale.Rows[index2].Cells[5].Value = Properties.Settings.Default.Item_Discount;

                }
                catch (Exception) { }

            }

        }
        private void Frm_Sales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {

                btnItems_Click(null, null);

            } else if (e.KeyCode == Keys.F1)
            {

                txtbarcode.Clear();
                txtbarcode.Focus();
            } else if (e.KeyCode == Keys.F11)

            {
                UpdateQty();
            }
            else if (e.KeyCode == Keys.F12)
            {
                PayOrder();
            }
        }

        //call when insert sales rb7h  table
        private void insertSalesRb7h(int i, decimal priceBeforeTax, decimal taxValue, decimal realQty, decimal buyPrice)
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            db.exceuteData("insert into Sales_Rb7h values (" + txtID.Text + " , N'" + Cust_Name + "' , " + DgvSale.Rows[i].Cells[0].Value + " , '" + d + "' , " + realQty + " , N'" + Properties.Settings.Default.USERNAME + "', " + priceBeforeTax + " , " + DgvSale.Rows[i].Cells[5].Value + " ," + DgvSale.Rows[i].Cells[6].Value + " , " + Properties.Settings.Default.TotalOrder + " , " + Properties.Settings.Default.Madfou3 + " , " + Properties.Settings.Default.Bakey + " ,N'" + DgvSale.Rows[i].Cells[2].Value + "' , " + taxValue + " , " + DgvSale.Rows[i].Cells[4].Value + " ,N'" + DtpTime.Text + "' , " + buyPrice + ")", "");

        }
        //call to update qty in store
        private void updateQtyInStore(int pro_ID, decimal realQty , int x,decimal priceBeforeTax,decimal taxValue)
        {
            DataTable tblQty = new DataTable();
            decimal QtyInStoreFirstRaw = 0;
            db.exceuteData("delete from Products_Qty where Qty <=0", "");
            int countQty = 0;
            try {
                countQty =Convert.ToInt32( db.readData("select count(Pro_ID) from Products_Qty where Pro_ID=" + pro_ID + "", "").Rows[0][0]);
            }
            catch (Exception) { }
            decimal currentQty = realQty;
            for (int i =0; i <= countQty -1;i++) {
                try
                {
                    tblQty.Clear();
                    tblQty = db.readData("select Top 1 * from Products_Qty where Pro_ID=" + pro_ID + "", "");

                    QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);
                    if (QtyInStoreFirstRaw - realQty >= 1)
                    {
                        db.exceuteData("update Products_Qty set Qty=Qty - " + realQty + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");

                        insertSalesRb7h(x, priceBeforeTax, taxValue, realQty, Convert.ToDecimal(tblQty.Rows[0][4]));
                        currentQty -= realQty;
                        return;
                    }
                    else if (QtyInStoreFirstRaw - realQty == 0)
                    {
                        db.exceuteData("update Products_Qty set Qty=Qty - " + realQty + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                        db.exceuteData("delete Products_Qty where Qty <= 0", "");
                        insertSalesRb7h(x, priceBeforeTax, taxValue, realQty, Convert.ToDecimal(tblQty.Rows[0][4]));
                        currentQty -= realQty;
                        return;
                    }
                    else if (QtyInStoreFirstRaw - realQty < 0)
                    {

                        db.exceuteData("update Products_Qty set Qty=Qty - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                        db.exceuteData("delete Products_Qty where Qty <= 0", "");
                        insertSalesRb7h(x, priceBeforeTax, taxValue, QtyInStoreFirstRaw, Convert.ToDecimal(tblQty.Rows[0][4]));
                        currentQty -= QtyInStoreFirstRaw;

                        decimal baky = Math.Abs(QtyInStoreFirstRaw - realQty);

                        tblQty.Clear();
                        tblQty = db.readData("select Top 1 * from Products_Qty where Pro_ID=" + pro_ID + " ", "");

                        QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                        if (QtyInStoreFirstRaw - baky >= 0)
                        {
                            db.exceuteData("update Products_Qty set Qty=Qty - " + baky + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                            db.exceuteData("delete Products_Qty where Qty <= 0", "");
                            insertSalesRb7h(x, priceBeforeTax, taxValue, baky, Convert.ToDecimal(tblQty.Rows[0][4]));
                            return;
                        }
                        else if (QtyInStoreFirstRaw - baky < 0)
                        {
                            decimal secondbaky = Math.Abs(QtyInStoreFirstRaw - baky);
                            db.exceuteData("update Products_Qty set Qty=Qty - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                            db.exceuteData("delete Products_Qty where Qty <= 0", "");
                            insertSalesRb7h(x, priceBeforeTax, taxValue, QtyInStoreFirstRaw, Convert.ToDecimal(tblQty.Rows[0][4]));
                            currentQty -= QtyInStoreFirstRaw;
                            tblQty.Clear();
                            tblQty = db.readData("select Top 1 * from Products_Qty where Pro_ID=" + pro_ID + " ", "");

                            QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                            if (QtyInStoreFirstRaw - secondbaky >= 0)
                            {
                                db.exceuteData("update Products_Qty set Qty=Qty - " + secondbaky + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                db.exceuteData("delete Products_Qty where Qty <= 0", "");
                                insertSalesRb7h(x, priceBeforeTax, taxValue, secondbaky, Convert.ToDecimal(tblQty.Rows[0][4]));
                                return;
                            }
                            else if (QtyInStoreFirstRaw - secondbaky < 0)
                            {
                                decimal thirdbaky = Math.Abs(QtyInStoreFirstRaw - secondbaky);
                                db.exceuteData("update Products_Qty set Qty=Qty - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                db.exceuteData("delete Products_Qty where Qty <= 0", "");
                                insertSalesRb7h(x, priceBeforeTax, taxValue, QtyInStoreFirstRaw, Convert.ToDecimal(tblQty.Rows[0][4]));

                                currentQty -= QtyInStoreFirstRaw;
                                tblQty.Clear();
                                tblQty = db.readData("select Top 1 * from Products_Qty where Pro_ID=" + pro_ID + "", "");

                                QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);
                                if (QtyInStoreFirstRaw - thirdbaky >= 0)
                                {
                                    db.exceuteData("update Products_Qty set Qty=Qty - " + thirdbaky + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                    db.exceuteData("delete Products_Qty where Qty <= 0", "");
                                    insertSalesRb7h(x, priceBeforeTax, taxValue, thirdbaky, Convert.ToDecimal(tblQty.Rows[0][4]));
                                    return;
                                }
                                else if (QtyInStoreFirstRaw - thirdbaky < 0)
                                {
                                    decimal forthbaky = Math.Abs(QtyInStoreFirstRaw - thirdbaky);
                                    db.exceuteData("update Products_Qty set Qty=Qty - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                    db.exceuteData("delete Products_Qty where Qty <= 0", "");
                                    insertSalesRb7h(x, priceBeforeTax, taxValue, QtyInStoreFirstRaw, Convert.ToDecimal(tblQty.Rows[0][4]));


                                    currentQty -= QtyInStoreFirstRaw;
                                    tblQty.Clear();
                                    tblQty = db.readData("select Top 1 * from Products_Qty where Pro_ID=" + pro_ID + " ", "");

                                    QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                                    if (QtyInStoreFirstRaw - forthbaky >= 0)
                                    {
                                        db.exceuteData("update Products_Qty set Qty=Qty - " + forthbaky + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                        db.exceuteData("delete Products_Qty where Qty <= 0", "");
                                        insertSalesRb7h(x, priceBeforeTax, taxValue, forthbaky, Convert.ToDecimal(tblQty.Rows[0][4]));

                                        return;
                                    }
                                    else if (QtyInStoreFirstRaw - forthbaky < 0)
                                    {
                                        db.exceuteData("update Products_Qty set Qty=Qty - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                        db.exceuteData("delete Products_Qty where Qty <= 0", "");
                                        insertSalesRb7h(x, priceBeforeTax, taxValue, QtyInStoreFirstRaw, Convert.ToDecimal(tblQty.Rows[0][4]));

                                        currentQty -= QtyInStoreFirstRaw;

                                    }
                                }
                            }
                        }

                    }

                    if(currentQty <= 0)
                    { return; }
                }
                catch (Exception) { }
            }

        }

        string Cust_Name = "";
        //to insert data into sales table and update qty in store
        private void insertDataInSalesUpdateStoreQty()
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            string dreminder = DtpReminder.Value.ToString("dd/MM/yyyy");
            
            if (rbtnCustAagel.Checked == true)
            { Cust_Name = cbxCustomer.Text; }
            else
            {
                if (txtCustomer.Text == "")
                    Cust_Name = "عميل نقدى";
                else if (txtCustomer.Text != "")
                {
                    Cust_Name = txtCustomer.Text;
                }

            }
            Properties.Settings.Default.TotalOrder = Convert.ToDecimal(txtTotal.Text);
            Properties.Settings.Default.Madfou3 = 0;
            Properties.Settings.Default.Bakey = 0;
            Properties.Settings.Default.Save();



            Frm_PaySale frm = new Frm_PaySale();
            frm.ShowDialog();
            db.exceuteData("insert into Sales values (" + txtID.Text + " , '" + d + "' , N'" + Cust_Name + "')", "");
            decimal priceBeforeTax = 0, taxValue = 0 , totalTax =0, qtyInMain = 0, realQty = 0;
            DataTable tblPro = new DataTable();
            tblPro.Clear();
            DataTable tblQty = new DataTable();
            tblQty.Clear();
            for (int i = 0; i <= DgvSale.Rows.Count - 1; i++)
            {
                tblPro = db.readData("select * from Products where Pro_ID=" + DgvSale.Rows[i].Cells[0].Value + "", "");
                tblQty = db.readData("select * from Products_Unit where Pro_ID=" + DgvSale.Rows[i].Cells[0].Value + " and Unit_Name=N'" + DgvSale.Rows[i].Cells[2].Value + "'", "");
                qtyInMain = Convert.ToDecimal(tblQty.Rows[0][3]);


                taxValue = (Convert.ToDecimal(tblPro.Rows[0][6]) - Convert.ToDecimal(tblPro.Rows[0][4])) / qtyInMain;
                priceBeforeTax = Convert.ToDecimal(tblPro.Rows[0][4]);
                realQty = Convert.ToDecimal(DgvSale.Rows[i].Cells[3].Value) / qtyInMain;
                totalTax += taxValue * Convert.ToDecimal(DgvSale.Rows[i].Cells[3].Value);
                if (Convert.ToDecimal(tblPro.Rows[0][2] )- realQty < 0)
                {
                    MessageBox.Show("الكمية الموجوده فى المخزن غير كافيه للبيع", "تاكيد");
                    return;
                }
                db.exceuteData("insert into Sales_Detalis values (" + txtID.Text + " , N'" + Cust_Name + "' , " + DgvSale.Rows[i].Cells[0].Value + " , '" + d + "' , " + DgvSale.Rows[i].Cells[3].Value + " , N'" + Properties.Settings.Default.USERNAME + "', " + priceBeforeTax + " , " + DgvSale.Rows[i].Cells[5].Value + " ," + DgvSale.Rows[i].Cells[6].Value + " , " + Properties.Settings.Default.TotalOrder + " , " + Properties.Settings.Default.Madfou3 + " , " + Properties.Settings.Default.Bakey + " ,N'" + DgvSale.Rows[i].Cells[2].Value + "' , " + taxValue + " , " + DgvSale.Rows[i].Cells[4].Value + " ,N'" + DtpTime.Text + "')", "");
                

                db.exceuteData("update Products set Qty = Qty - " + realQty + " where Pro_ID=" + DgvSale.Rows[i].Cells[0].Value + "", "");
                updateQtyInStore(Convert.ToInt32(DgvSale.Rows[i].Cells[0].Value) , realQty , i , priceBeforeTax, taxValue);
                
            }


            decimal totalBeforeTax = 0;
            totalBeforeTax = Convert.ToDecimal(txtTotal.Text) - totalTax;
            db.exceuteData("insert into Taxes_Report (Order_Num,Order_Type,Tax_Type,Sup_Name,Cust_Name,Total_Order,Total_Tax,Total_AfterTax,Date) values (" + txtID.Text + " ,N'فاتورة مبيعات' ,N'قيمة مضافة' ,N'لا يوجد' ,N'" + Cust_Name+"' ," + totalBeforeTax + " ," + totalTax + " ," + txtTotal.Text + " ,N'" + d + "')", "");


        }


        private void PayOrder ()
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            string dreminder = DtpReminder.Value.ToString("dd/MM/yyyy");

            if (DgvSale.Rows.Count >= 1)
            {
                

                //call to insert data in sales detalis and sales rb7h and update qty in store
                insertDataInSalesUpdateStoreQty();


                if (Properties.Settings.Default.CheckButton == true)
                {

                    try
                    {
                       

                        if (rbtnCustNakdy.Checked == true)
                        {
                            db.exceuteData("insert into Customer_Report values (" + txtID.Text + " ," + Properties.Settings.Default.Madfou3 + " , '" + d + "' , N'" + Cust_Name + "')", "");

                        }
                        else if (rbtnCustAagel.Checked == true)
                        {
                            db.exceuteData("insert into Customer_Money values (" + txtID.Text + " , N'" + Cust_Name + "' , " + Properties.Settings.Default.Bakey + " ,'" + d + "' ,'" + dreminder + "')", "");

                            if (Properties.Settings.Default.Madfou3 >= 1)
                            {
                                db.exceuteData("insert into Customer_Report values (" + txtID.Text + " ," + Properties.Settings.Default.Madfou3 + " , '" + d + "' , N'" + Cust_Name + "')", "");
                            }
                        }
                        insertMoneyIntoStock();
                        if (Properties.Settings.Default.SalesPrint == true)
                        {
                            int data = 0;
                            if (Properties.Settings.Default.PrinterName == "")
                            { MessageBox.Show("من فضلك حدد اسم الطابعة من شاشة اعدادت البرنامج", "تاكيد"); return; }
                            try
                            {
                                data = Convert.ToInt32(db.readData("select count(Name) from OrderPrintData", "").Rows[0][0]);
                            }
                            catch (Exception) { }
                            if (data <= 0)
                            { MessageBox.Show("من فضلك ادخل بيانات الفاتورة اولا فى شاشة اعدادت البرنامج", "تاكيد"); return; }

                            for (int i = 0; i <= Properties.Settings.Default.SalesPrintNum - 1; i++)
                            {
                                Print();
                            }
                        }
                        AutoNumber();
                    }
                    catch (Exception) { }
                }
            }

        }
        //call to insert money in stock insert and update money in stock
        private void insertMoneyIntoStock()
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            DataTable tblStock = new DataTable();
            if (Properties.Settings.Default.Pay_Visa == false)
            {
                db.exceuteData("insert into Stock_Insert (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + Properties.Settings.Default.Madfou3 + " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'عمليات مبيعات', N'') ", "");
                db.exceuteData("update stock set Money=Money + " + Properties.Settings.Default.Madfou3 + " where Stock_ID=" + stock_ID + "", "");
            }else
            {
                db.exceuteData("insert into Bank_Insert (Money ,Date ,Name ,Type ,Reason) values (" + Properties.Settings.Default.Madfou3 + " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'عمليات مبيعات', N'') ", "");
                db.exceuteData("update Bank set Money=Money + " + Properties.Settings.Default.Madfou3 + " ", "");

            }
        }
        private void Print()
        {
            int id = Convert.ToInt32(txtID.Text);
            DataTable tblRpt = new DataTable();

            tblRpt.Clear();
            tblRpt = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Sales_Detalis].[Qty] as 'الكمية',Unit as 'الوحدة',[Price_Tax] as 'السعر شامل الضريب',[Discount] as 'الخصم',[Total] as 'الاجمالى',[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[User_Name] as 'الكاشير',[Date] as 'التاريخ',[Sales_Detalis].Tax_Value as'الضريبة' FROM [dbo].[Sales_Detalis] , Products where Products.Pro_ID = Sales_Detalis.Pro_ID and Order_ID=" + id + "", "");
            try
            {
                Frm_Print frm = new Frm_Print();

                frm.crystalReportViewer1.RefreshReport();
                if (Properties.Settings.Default.SalePrintKind == "8CM")
                {
                    RptOrderSales rpt = new RptOrderSales();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.SERVERNAME, "Sales_System");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm.crystalReportViewer1.ReportSource = rpt;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    // rpt.PrintToPrinter(1, true, 0, 0);
                    frm.ShowDialog();

                }
                else if (Properties.Settings.Default.SalePrintKind == "A4")
                {
                    RptOrderSalesA4 rpt = new RptOrderSalesA4();
                    rpt.SetDatabaseLogon("", "", @".\SQLEXPRESS", "Sales_System");
                    rpt.SetDataSource(tblRpt);
                    rpt.SetParameterValue("ID", id);
                    frm.crystalReportViewer1.ReportSource = rpt;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    // rpt.PrintToPrinter(1, true, 0, 0);
                    frm.ShowDialog();
                }
               
            }
            catch (Exception) { }
        }
        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                

                DataTable tblItems = new DataTable();
                tblItems.Clear(); DataTable tblUnit = new DataTable();
                tblUnit.Clear();

                tblItems = db.readData("select * from Products where Barcode=N'" + txtbarcode.Text + "'", "");
                if (tblItems.Rows.Count >= 1)
                {
                    try
                    {
                        cbxItems.SelectedValue = Convert.ToInt32(tblItems.Rows[0][0]); 
                        string Product_ID = tblItems.Rows[0][0].ToString();
                        string Product_Name = tblItems.Rows[0][1].ToString();
                        string Product_Qty = "1";
                        string Product_Price = "0";
                        decimal Discount = 0;
                        string Product_Unit = tblItems.Rows[0][14].ToString(); ;


                        DgvSale.Rows.Add(1);
                        int rowindex = DgvSale.Rows.Count - 1;

                        DgvSale.Rows[rowindex].Cells[0].Value = Product_ID;
                        DgvSale.Rows[rowindex].Cells[1].Value = Product_Name;
                        DgvSale.Rows[rowindex].Cells[3].Value = Product_Qty;
                        DgvSale.Rows[rowindex].Cells[2].Value = Product_Unit;
                        tblUnit = db.readData("select * from Products_Unit where Pro_ID=" + DgvSale.CurrentRow.Cells[0].Value + " and Unit_Name=N'" + DgvSale.CurrentRow.Cells[2].Value + "'", "");

                        decimal realPrice = 0;
                        try
                        {
                            realPrice = Convert.ToDecimal(tblUnit.Rows[0][5]) / Convert.ToDecimal(tblUnit.Rows[0][3]);
                        }
                        catch (Exception) { }
                        DgvSale.Rows[rowindex].Cells[4].Value = realPrice;
                        decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(realPrice);

                        DgvSale.Rows[rowindex].Cells[5].Value = Discount;
                        DgvSale.Rows[rowindex].Cells[6].Value = total;
                    }
                    catch (Exception) { }


                    try
                    {
                        decimal TotalOrder = 0;
                        for (int i = 0; i <= DgvSale.Rows.Count - 1; i++)
                        {

                            TotalOrder += Convert.ToDecimal(DgvSale.Rows[i].Cells[6].Value);
                            DgvSale.ClearSelection();
                            DgvSale.FirstDisplayedScrollingRowIndex = DgvSale.Rows.Count - 1;
                            DgvSale.Rows[DgvSale.Rows.Count - 1].Selected = true;
                        }


                        txtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                        lblItemsCount.Text = (DgvSale.Rows.Count).ToString();

                    }
                    catch (Exception) { }
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (DgvSale.Rows.Count >= 1)
            {

                int index = DgvSale.SelectedRows[0].Index;

                DgvSale.Rows.RemoveAt(index);


                if (DgvSale.Rows.Count <= 0)
                {

                    txtTotal.Text = "0";
                }

                try
                {
                    decimal TotalOrder = 0;
                    for (int i = 0; i <= DgvSale.Rows.Count - 1; i++)
                    {

                        TotalOrder += Convert.ToDecimal(DgvSale.Rows[i].Cells[6].Value);
                        DgvSale.ClearSelection();
                        DgvSale.FirstDisplayedScrollingRowIndex = DgvSale.Rows.Count - 1;
                        DgvSale.Rows[DgvSale.Rows.Count - 1].Selected = true;
                    }


                    txtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                    lblItemsCount.Text = (DgvSale.Rows.Count).ToString();

                }
                catch (Exception) { }
            }
        }

        private void DgvSale_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal Item_Qty = 0, Item_SalePrice = 0, Item_Discount = 0;
            try
            {

                int index = DgvSale.SelectedRows[0].Index;

                Item_Qty = Convert.ToDecimal(DgvSale.Rows[index].Cells[3].Value);
                Item_SalePrice = Convert.ToDecimal(DgvSale.Rows[index].Cells[4].Value);
                Item_Discount = Convert.ToDecimal(DgvSale.Rows[index].Cells[5].Value);

                decimal Total = 0;

                Total = (Item_Qty * Item_SalePrice) - Item_Discount;

                DgvSale.Rows[index].Cells[6].Value = Total;



                decimal TotalOrder = 0;
                for (int i = 0; i <= DgvSale.Rows.Count - 1; i++)
                {

                    TotalOrder += Convert.ToDecimal(DgvSale.Rows[i].Cells[6].Value);

                }


                txtTotal.Text = Math.Round(TotalOrder, 2).ToString();

            }
            catch (Exception) { }

        }
    }
}