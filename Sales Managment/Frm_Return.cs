using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Sales_Managment
{
    public partial class Frm_Return : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Return()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        Database db = new Database(); 
        private void fillStore()
        {
            cbxStore1.DataSource = db.readData("select * from Store", "");
            cbxStore1.DisplayMember = "Store_Name";
            cbxStore1.ValueMember = "Store_ID";
            cbxStore2.DataSource = db.readData("select * from Store", "");
            cbxStore2.DisplayMember = "Store_Name";
            cbxStore2.ValueMember = "Store_ID";
        }
        string stock_ID = "";
        private void Frm_Return_Load(object sender, EventArgs e)
        {
            if (rbtnSales.Checked == true)
            {
                lblName1.Text = "اسم العميل:";
            }
            else {
                lblName1.Text = "اسم المورد:";
            }
            DtpDate.Text = DateTime.Now.ToShortDateString();
            fillStore();
            stock_ID =Convert.ToString( Properties.Settings.Default.Stock_ID);
        }
        //when press sales return
        private void salesReturn()
        {
            
            tbl.Clear();
            tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',[Cust_Name] as 'اسم العميل',Products.Pro_Name as 'المنتج',[Sales_Detalis].[Qty] as 'الكمية',Price as 'السعر',([Sales_Detalis].Tax_Value * [Sales_Detalis].Qty) as 'الضريبة',[Sales_Detalis].[Price_Tax] as 'السعر بعد الضريبة',[Discount] as 'الخصم',[Total] as 'الاجمالى',Unit as 'الوحدة',[TotalOrder] as 'اجمالى الفاتورة',[Madfou3] as 'المبلغ المدفوع',[Baky] as 'المتبقى',[User_Name] as 'الكاشير',[Date] as 'التاريخ' FROM [dbo].[Sales_Detalis] , Products where Products.Pro_ID = Sales_Detalis.Pro_ID and Order_ID=" + txtID.Text+ "", "");
            DgvSearch.DataSource = tbl;
            //decimal bakyDB = 0;
            //try {

            //    bakyDB =Convert.ToDecimal( db.readData("select baky from Sales_Detalis where Order_ID="+txtID.Text+" ", "").Rows[0][0]);
            //} catch (Exception) { }
            decimal totalOrder = 0, totalMadfou3=0,baky=0 ,taxValue=0,totalAfterTax=0;

            for (int i=0;i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalOrder += Convert.ToDecimal( DgvSearch.Rows[i].Cells[8].Value) - Convert.ToDecimal(DgvSearch.Rows[i].Cells[5].Value);
                taxValue += Convert.ToDecimal(DgvSearch.Rows[i].Cells[5].Value);
                totalAfterTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[8].Value);
            }
            try
            {
                totalMadfou3 = Convert.ToDecimal(DgvSearch.Rows[0].Cells[8].Value);
                txtTotalOrder.Text = (Math.Round(totalOrder, 2)).ToString();
                txtMadfou3.Text = (Math.Round(totalMadfou3, 2)).ToString();
                txtTotalTax.Text = (Math.Round(taxValue, 2)).ToString();
                txtTotalOrderAfterTax.Text = (Math.Round(totalAfterTax, 2)).ToString();

                baky = totalAfterTax - totalMadfou3;
                txtbaky.Text = (Math.Round(baky, 2)).ToString();
            }
            catch (Exception) { }
            ResetCustSup();
        }
        //when press buy return
        private void buyReturn()
        {

            tbl.Clear();
            tbl = db.readData("SELECT [Order_ID] as 'رقم الفاتورة',Suppliers.Sup_Name as 'اسم المورد',Products.Pro_Name as 'اسم المنتج',[Date] as 'تاريخ الفاتورة',[Buy_Detalis].[Qty] as 'الكمية' ,Unit_Name as 'الوحدة',[Price] as 'السعر قبل الضريبة',([Buy_Detalis].Tax_Value * [Buy_Detalis].[Qty]) as 'الضريبة',Price_Tax as 'السعر بعد الضريبة',[Discount] as 'الخصم',[Total] as 'اجمالى الصنف',[TotalOrder] as 'الاجمالى العام',[User_Name] as 'اسم المستخدم' ,[Madfou3] as 'المدفوع',[Baky] as 'المبلغ المتبقى' FROM [dbo].[Buy_Detalis],Suppliers,Products where  Suppliers.Sup_ID =[Buy_Detalis].Sup_ID and Products.Pro_ID =[Buy_Detalis].Pro_ID and Order_ID=" + txtID.Text + "", "");
            DgvSearch.DataSource = tbl;
            //decimal bakyDB = 0;
            //try {

            //    bakyDB =Convert.ToDecimal( db.readData("select baky from Sales_Detalis where Order_ID="+txtID.Text+" ", "").Rows[0][0]);
            //} catch (Exception) { }
            decimal totalOrder = 0, totalMadfou3 = 0, baky = 0, taxValue = 0, totalAfterTax = 0;

            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                totalOrder += Convert.ToDecimal(DgvSearch.Rows[i].Cells[10].Value) - Convert.ToDecimal(DgvSearch.Rows[i].Cells[7].Value);
                taxValue += Convert.ToDecimal(DgvSearch.Rows[i].Cells[7].Value);
                totalAfterTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[10].Value);
            }
            try
            {
                totalMadfou3 = Convert.ToDecimal(DgvSearch.Rows[0].Cells[13].Value);
                txtTotalOrder.Text = (Math.Round(totalOrder, 2)).ToString();
                txtMadfou3.Text = (Math.Round(totalMadfou3, 2)).ToString();
                txtTotalTax.Text = (Math.Round(taxValue, 2)).ToString();
                txtTotalOrderAfterTax.Text = (Math.Round(totalAfterTax, 2)).ToString();

                baky = totalAfterTax - totalMadfou3;
                txtbaky.Text = (Math.Round(baky, 2)).ToString();
            }
            catch (Exception) { }
            ResetCustSup();
        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(txtID.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم فاتورة","تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    return;
                }

                if (rbtnSales.Checked == true)
                {
                    salesReturn();
                }
                else if (rbtnBuy.Checked == true)
                {
                    buyReturn();
                }
            }
        }

        private void rbtnSales_CheckedChanged(object sender, EventArgs e)
        {
            ResetCustSup();
        }

        private void rbtnBuy_CheckedChanged(object sender, EventArgs e)
        {
            ResetCustSup();
        }


        private void ResetCustSup()
        {

            if (rbtnSales.Checked == true)
            {
                lblName1.Text = "اسم العميل:";
                lblName2.Text = "اسم العميل:";
            }
            else
            {
                lblName1.Text = "اسم المورد:";
                lblName2.Text = "اسم المورد:";
            }
        }
        private void onLoadScreen()
        {
            tbl.Clear();
            DgvSearch.DataSource = tbl;
            txtbaky.Clear();
            txtMadfou3.Clear();
            txtTotalOrder.Clear();
            txtID.Clear();
            txtName1.Clear();
            txtName2.Clear();

            rbtnSales.Checked = true;
            txtbaky.Text = "0";
            txtMadfou3.Text = "0";
            txtID.Focus();
        }
        string d = "";
        //when press return all order sales
        private void returnAllSales()
        {
            DataTable tblStock = new DataTable();
           d= DtpDate.Value.ToString("dd/MM/yyyy");
            if (txtName1.Text == "") { MessageBox.Show("من فضلك ادخل اسم العميل","تاكيد");return; }
            decimal stock_Money = 0;
            tblStock.Clear();
            tblStock = db.readData("select * from Stock where Stock_ID=" + stock_ID + "", "");
            stock_Money = Convert.ToDecimal(tblStock.Rows[0][1]);

            if (Convert.ToDecimal(txtTotalOrderAfterTax.Text) > stock_Money)
            {
                MessageBox.Show("المبلغ الموجود فى الخزنة غير كافى لاجراء العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            db.exceuteData("delete from Sales where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + "", "");
            db.exceuteData("delete from Sales_Detalis where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + "", "");
            db.exceuteData("delete from Sales_Rb7h where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + "", "");

            //insert data into return table
            db.exceuteData("insert into Returns (Order_Date , Order_Type) values ('"+d+"',N'مرتجعات مبيعات')", "");
            int id = 1;
            try {
                id =Convert.ToInt32( db.readData("select max(Order_ID) from Returns", "").Rows[0][0]);
            } catch (Exception) { }

            decimal totalTax = 0;
            //insert into return detalis 
            for (int i=0;i <=DgvSearch.Rows.Count - 1; i++)
            {
                db.exceuteData("insert into Returns_Detalis values (" + id+" ,N'' ,N'"+txtName1.Text+"' ,N'"+DgvSearch.Rows[i].Cells[2].Value+"' , N'"+d+"' ,"+ DgvSearch.Rows[i].Cells[3].Value + " ,"+ DgvSearch.Rows[i].Cells[4].Value + " ,"+ DgvSearch.Rows[i].Cells[8].Value + " , N'"+Properties.Settings.Default.USERNAME+"' ,"+txtTotalOrderAfterTax.Text+" ,"+txtMadfou3.Text+" , "+txtbaky.Text+" ,"+txtTotalTax.Text+" , "+ DgvSearch.Rows[i].Cells[6].Value + " ,N'"+ DgvSearch.Rows[i].Cells[9].Value + "')", "");
                int proID = 1;
                try {
                    proID = Convert.ToInt32(db.readData("select Pro_ID from Products where Pro_Name=N'"+ DgvSearch.Rows[i].Cells[2].Value + "'", "").Rows[0][0]);
                } catch (Exception) { }
                decimal QtyInMain = 0, realQty =0 ;
                DataTable tblUnit = new DataTable();
                tblUnit.Clear();
                tblUnit = db.readData("select * from Products_Unit where Pro_ID=" + proID + " and Unit_Name=N'" + DgvSearch.Rows[i].Cells[9].Value  + "'", "");
                try
                {
                    QtyInMain = Convert.ToDecimal(tblUnit.Rows[0][3]);
                }
                catch (Exception) { }

                  realQty =Convert.ToDecimal( DgvSearch.Rows[i].Cells[3].Value) / QtyInMain;
                
                db.exceuteData("update Products set Qty=Qty + "+ realQty + " where Pro_ID="+proID+"", "");

                DataTable tblQty = new DataTable();
                tblQty.Clear();
                tblQty = db.readData("select top 1 * from Products_Qty where Pro_ID="+proID+" and Store_ID="+cbxStore1.SelectedValue+" ", "");
                if(tblQty.Rows.Count >= 1)
                {
                    db.exceuteData("update Products_Qty set Qty=Qty + "+ realQty + " where Pro_ID="+ proID + " and Store_ID="+cbxStore1.SelectedValue+" and Qty="+tblQty.Rows[0][3]+" and Buy_Price="+ tblQty.Rows[0][4] + "", "");
                }else
                {
                    tblQty.Clear();
                    tblQty = db.readData("select top 1 * from Products_Qty where Pro_ID=" + proID + " ", "");
                    if (tblQty.Rows.Count >= 1)
                    {
                        db.exceuteData("insert into Products_Qty values (" + proID + " , " + cbxStore1.SelectedValue + " ,N'" + cbxStore1.Text + "' , " + realQty + " , " + tblQty.Rows[0][4] + " , " + DgvSearch.Rows[i].Cells[6].Value + ")", "");
                    }else
                    {
                        string buyPrice = Microsoft.VisualBasic.Interaction.InputBox("ادخل سعر الشراء للمنتج " + (DgvSearch.Rows[i].Cells[3].Value), "سعر الشراء", "من فضلك ادخل السعر هنا", 1, 1);
                        db.exceuteData("insert into Products_Qty values (" + proID + " , " + cbxStore1.SelectedValue + " ,N'" + cbxStore1.Text + "' , " + realQty + " , " + buyPrice + " , " + DgvSearch.Rows[i].Cells[6].Value + ")", "");

                    }
                }
                totalTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[5].Value);

            }

            db.exceuteData("insert into Stock_Pull (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + txtTotalOrderAfterTax.Text + " ,N'" + d + "' ,N'"+Properties.Settings.Default.USERNAME+"' ,N'مرتجعات مبيعات', N'') ", "");
            db.exceuteData("update stock set Money=Money - " + txtTotalOrderAfterTax.Text + " where Stock_ID=" + stock_ID + "", "");

            decimal totalBeforeTax = 0;
            totalBeforeTax = Convert.ToDecimal(txtTotalOrderAfterTax.Text) - totalTax;
            db.exceuteData("insert into Taxes_Report (Order_Num,Order_Type,Tax_Type,Sup_Name,Cust_Name,Total_Order,Total_Tax,Total_AfterTax,Date) values (" + Convert.ToDecimal(DgvSearch.CurrentRow.Cells[0].Value) + " ,N'مرتجعات مبيعات' ,N'قيمة مضافة' ,N'لا يوجد' ,N'" + txtName1.Text + "' ," + totalBeforeTax + " ," + totalTax + " ," + txtTotalOrderAfterTax.Text + " ,N'" + d + "')", "");


            MessageBox.Show("تمت عمليه الارجاع بنجاح","تاكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);
            onLoadScreen();
            
        }
        //when press return all order buy
        private void returnAllBuy()
        {
            d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (txtName1.Text == "") { MessageBox.Show("من فضلك ادخل اسم المورد", "تاكيد"); return; }
            db.exceuteData("delete from Buy where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + "", "");
            db.exceuteData("delete from Buy_Detalis where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + "", "");
            
            //insert data into return table
            db.exceuteData("insert into Returns (Order_Date , Order_Type) values ('" + d + "',N'مرتجعات مشتريات')", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception) { }
            decimal totalTax = 0;
            //insert into return detalis 
            for (int i = 0; i <= DgvSearch.Rows.Count - 1; i++)
            {
                db.exceuteData("insert into Returns_Detalis values (" + id + " ,N'" + txtName1.Text + "' ,N'' ,N'" + DgvSearch.Rows[i].Cells[2].Value + "' , N'" + d + "' ," + DgvSearch.Rows[i].Cells[3].Value + " ," + DgvSearch.Rows[i].Cells[5].Value + " ," + DgvSearch.Rows[i].Cells[9].Value + " , N'" + Properties.Settings.Default.USERNAME + "' ," + txtTotalOrderAfterTax.Text + " ," + txtMadfou3.Text + " , " + txtbaky.Text + " ," + txtTotalTax.Text + " , " + DgvSearch.Rows[i].Cells[8].Value + " ,N'" + DgvSearch.Rows[i].Cells[5].Value + "')", "");
                int proID = 1;
                try
                {
                    proID = Convert.ToInt32(db.readData("select Pro_ID from Products where Pro_Name=N'" + DgvSearch.Rows[i].Cells[2].Value + "'", "").Rows[0][0]);
                }
                catch (Exception) { }

                decimal QtyInMain = 0, realQty = 0;
                DataTable tblUnit = new DataTable();
                tblUnit.Clear();
                tblUnit = db.readData("select * from Products_Unit where Pro_ID=" + proID + " and Unit_Name=N'" + DgvSearch.Rows[i].Cells[5].Value + "'", "");
                try
                {
                    QtyInMain = Convert.ToDecimal(tblUnit.Rows[0][3]);
                }
                catch (Exception) { }

                realQty = Convert.ToDecimal(DgvSearch.Rows[i].Cells[4].Value) / QtyInMain;

                db.exceuteData("update Products set Qty=Qty - " + realQty + " where Pro_ID=" + proID + "", "");

                DataTable tblQty = new DataTable();
                tblQty.Clear();
                tblQty = db.readData("select * from Products_Qty where PRo_ID="+proID+" and Store_ID="+cbxStore1.SelectedValue+"", "");
                decimal def = 0;
                def = Convert.ToDecimal(tblQty.Rows[0][3]) - realQty; 
                if (def  < 0)
                {
                    MessageBox.Show("الكمية المراد ارجاعها غير موجوده فى المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                } else
                {
                         db.exceuteData("update Products_Qty set Qty=Qty - "+ realQty + " where Pro_ID="+ proID + " and Store_ID="+cbxStore1.SelectedValue+" and Qty="+tblQty.Rows[0][3]+" and Buy_Price="+ tblQty.Rows[0][4] + "", "");
                }
                totalTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[6].Value);
            }
            db.exceuteData("insert into Stock_Insert (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + txtTotalOrderAfterTax.Text + " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'مرتجعات مشتريات', N'') ", "");
            db.exceuteData("update stock set Money=Money + " + txtTotalOrderAfterTax.Text + " where Stock_ID=" + stock_ID + "", "");

            decimal totalBeforeTax = 0;
            totalBeforeTax = Convert.ToDecimal(txtTotalOrderAfterTax.Text) - totalTax;
            db.exceuteData("insert into Taxes_Report (Order_Num,Order_Type,Tax_Type,Sup_Name,Cust_Name,Total_Order,Total_Tax,Total_AfterTax,Date) values (" + Convert.ToDecimal(DgvSearch.CurrentRow.Cells[0].Value) + " ,N'مرتجعات مشتريات' ,N'قيمة مضافة' ,N'"+txtName1.Text+"' ,N'لا يوجد' ," + totalBeforeTax + " ," + totalTax + " ," + txtTotalOrderAfterTax.Text + " ,N'" + d + "')", "");

            MessageBox.Show("تمت عمليه الارجاع بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            onLoadScreen();
        }
        private void btnReturnAll_Click(object sender, EventArgs e)
        {
            if(DgvSearch.Rows.Count >= 1)
            {

                if (rbtnSales.Checked == true)
                {
                    returnAllSales();

                }else if (rbtnBuy.Checked == true)
                {
                    returnAllBuy();
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        //when user press return item only in sales
        private void returnItemSaleOnly()
        {
            DataTable tblStock = new DataTable();
            d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (txtName2.Text == "") { MessageBox.Show("من فضلك ادخل اسم العميل", "تاكيد"); return; }
            decimal stock_Money = 0;
            tblStock.Clear();
            tblStock = db.readData("select * from Stock where Stock_ID=" + stock_ID + "", "");
            stock_Money = Convert.ToDecimal(tblStock.Rows[0][1]);

            if (Convert.ToDecimal(DgvSearch.CurrentRow.Cells[8].Value) > stock_Money)
            {
                MessageBox.Show("المبلغ الموجود فى الخزنة غير كافى لاجراء العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int proID = 1;
            try
            {
                proID = Convert.ToInt32(db.readData("select Pro_ID from Products where Pro_Name=N'" + DgvSearch.CurrentRow.Cells[2].Value + "'", "").Rows[0][0]);
            }
            catch (Exception) { }
            db.exceuteData("delete from Sales_Detalis where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + " and Pro_ID="+proID+" and Qty="+ DgvSearch.CurrentRow.Cells[3].Value + " and Total=" + DgvSearch.CurrentRow.Cells[8].Value + "", "");
            db.exceuteData("delete from Sales_Rb7h where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + " and Pro_ID=" + proID + " and Qty=" + DgvSearch.CurrentRow.Cells[3].Value + " and Total=" + DgvSearch.CurrentRow.Cells[8].Value + "", "");

            //insert data into return table
            db.exceuteData("insert into Returns (Order_Date , Order_Type) values ('" + d + "',N'مرتجعات مبيعات')", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception) { }
            //insert into return detalis 
            
                db.exceuteData("insert into Returns_Detalis values (" + id + " ,N'' ,N'" + txtName2.Text + "' ,N'" + DgvSearch.CurrentRow.Cells[2].Value + "' , N'" + d + "' ," + DgvSearch.CurrentRow.Cells[3].Value + " ," + DgvSearch.CurrentRow.Cells[4].Value + " ," + DgvSearch.CurrentRow.Cells[8].Value + " , N'" + Properties.Settings.Default.USERNAME + "' ," + txtTotalOrderAfterTax.Text + " ," + txtMadfou3.Text + " , " + txtbaky.Text + " ," + txtTotalTax.Text + " , " + DgvSearch.CurrentRow.Cells[6].Value + " ,N'" + DgvSearch.CurrentRow.Cells[9].Value + "')", "");
                
                decimal QtyInMain = 0, realQty = 0 , totalTax=0;
                DataTable tblUnit = new DataTable();
                tblUnit.Clear();
                tblUnit = db.readData("select * from Products_Unit where Pro_ID=" + proID + " and Unit_Name=N'" + DgvSearch.CurrentRow.Cells[9].Value + "'", "");
                try
                {
                    QtyInMain = Convert.ToDecimal(tblUnit.Rows[0][3]);
                }
                catch (Exception) { }

                realQty = Convert.ToDecimal(DgvSearch.CurrentRow.Cells[3].Value) / QtyInMain;

                db.exceuteData("update Products set Qty=Qty + " + realQty + " where Pro_ID=" + proID + "", "");

                DataTable tblQty = new DataTable();
                tblQty.Clear();
                tblQty = db.readData("select top 1 * from Products_Qty where Pro_ID=" + proID + " and Store_ID=" + cbxStore2.SelectedValue + " ", "");
                if (tblQty.Rows.Count >= 1)
                {
                    db.exceuteData("update Products_Qty set Qty=Qty + " + realQty + " where Pro_ID=" + proID + " and Store_ID=" + cbxStore2.SelectedValue + " and Qty=" + tblQty.Rows[0][3] + " and Buy_Price=" + tblQty.Rows[0][4] + "", "");
                }
                else
                {
                    tblQty.Clear();
                    tblQty = db.readData("select top 1 * from Products_Qty where Pro_ID=" + proID + " ", "");
                    if (tblQty.Rows.Count >= 1)
                    {
                        db.exceuteData("insert into Products_Qty values (" + proID + " , " + cbxStore2.SelectedValue + " ,N'" + cbxStore2.Text + "' , " + realQty + " , " + tblQty.Rows[0][4] + " , " + DgvSearch.CurrentRow.Cells[6].Value + ")", "");
                    }
                    else
                    {
                        string buyPrice = Microsoft.VisualBasic.Interaction.InputBox("ادخل سعر الشراء للمنتج " + (DgvSearch.CurrentRow.Cells[2].Value), "سعر الشراء", "من فضلك ادخل السعر هنا", 1, 1);
                        db.exceuteData("insert into Products_Qty values (" + proID + " , " + cbxStore2.SelectedValue + " ,N'" + cbxStore2.Text + "' , " + realQty + " , " + buyPrice + " , " + DgvSearch.CurrentRow.Cells[6].Value + ")", "");

                    }
                }
            
            db.exceuteData("insert into Stock_Pull (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + DgvSearch.CurrentRow.Cells[8].Value + " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'مرتجعات مبيعات', N'') ", "");
            db.exceuteData("update stock set Money=Money - " + DgvSearch.CurrentRow.Cells[8].Value + " where Stock_ID=" + stock_ID + "", "");

            //insert into tax report
            totalTax = Convert.ToDecimal(DgvSearch.CurrentRow.Cells[5].Value);
            decimal totalBeforeTax = 0;decimal totalItem = 0;
            totalItem = Convert.ToDecimal(DgvSearch.CurrentRow.Cells[3].Value) * Convert.ToDecimal(DgvSearch.CurrentRow.Cells[6].Value);
            totalBeforeTax = Convert.ToDecimal(totalItem) - totalTax;
            db.exceuteData("insert into Taxes_Report (Order_Num,Order_Type,Tax_Type,Sup_Name,Cust_Name,Total_Order,Total_Tax,Total_AfterTax,Date) values (" + Convert.ToDecimal(DgvSearch.CurrentRow.Cells[0].Value) + " ,N'مرتجعات مبيعات' ,N'قيمة مضافة' ,N'لا يوجد' ,N'" + txtName2.Text + "' ," + totalBeforeTax + " ," + totalTax + " ," + totalItem + " ,N'" + d + "')", "");

            MessageBox.Show("تمت عمليه الارجاع بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            onLoadScreen();

        }
        //when user press return item only in buy
        private void returnItemBuyOnly()
        {
            d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (txtName2.Text == "") { MessageBox.Show("من فضلك ادخل اسم المورد", "تاكيد"); return; }
            int proID = 1;
            try
            {
                proID = Convert.ToInt32(db.readData("select Pro_ID from Products where Pro_Name=N'" + DgvSearch.CurrentRow.Cells[2].Value + "'", "").Rows[0][0]);
            }
            catch (Exception) { }
            db.exceuteData("delete from Buy_Detalis where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + " and Pro_ID="+proID+" and Qty="+ DgvSearch.CurrentRow.Cells[4].Value + " and Total="+ DgvSearch.CurrentRow.Cells[10].Value + " ", "");

            //insert data into return table
            db.exceuteData("insert into Returns (Order_Date , Order_Type) values ('" + d + "',N'مرتجعات مشتريات')", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception) { }
            //insert into return detalis 
           
                db.exceuteData("insert into Returns_Detalis values (" + id + " ,N'" + txtName2.Text + "' ,N'' ,N'" + DgvSearch.CurrentRow.Cells[2].Value + "' , N'" + d + "' ," + DgvSearch.CurrentRow.Cells[3].Value + " ," + DgvSearch.CurrentRow.Cells[5].Value + " ," + DgvSearch.CurrentRow.Cells[9].Value + " , N'" + Properties.Settings.Default.USERNAME + "' ," + txtTotalOrderAfterTax.Text + " ," + txtMadfou3.Text + " , " + txtbaky.Text + " ," + txtTotalTax.Text + " , " + DgvSearch.CurrentRow.Cells[8].Value + " ,N'" + DgvSearch.CurrentRow.Cells[5].Value + "')", "");
                

                decimal QtyInMain = 0, realQty = 0;
                DataTable tblUnit = new DataTable();
                tblUnit.Clear();
                tblUnit = db.readData("select * from Products_Unit where Pro_ID=" + proID + " and Unit_Name=N'" + DgvSearch.CurrentRow.Cells[5].Value + "'", "");
                try
                {
                    QtyInMain = Convert.ToDecimal(tblUnit.Rows[0][3]);
                }
                catch (Exception) { }

                realQty = Convert.ToDecimal(DgvSearch.CurrentRow.Cells[4].Value) / QtyInMain;

                db.exceuteData("update Products set Qty=Qty - " + realQty + " where Pro_ID=" + proID + "", "");

                DataTable tblQty = new DataTable();
                tblQty.Clear();
                tblQty = db.readData("select * from Products_Qty where PRo_ID=" + proID + " and Store_ID=" + cbxStore2.SelectedValue + "", "");
                decimal def = 0;
                def = Convert.ToDecimal(tblQty.Rows[0][3]) - realQty;
                if (def < 0)
                {
                    MessageBox.Show("الكمية المراد ارجاعها غير موجوده فى المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    db.exceuteData("update Products_Qty set Qty=Qty - " + realQty + " where Pro_ID=" + proID + " and Store_ID=" + cbxStore2.SelectedValue + " and Qty=" + tblQty.Rows[0][3] + " and Buy_Price=" + tblQty.Rows[0][4] + "", "");
                }

            db.exceuteData("insert into Stock_Insert (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + (DgvSearch.CurrentRow.Cells[10].Value) + " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'مرتجعات مشتريات', N'') ", "");
            db.exceuteData("update stock set Money=Money + " + (DgvSearch.CurrentRow.Cells[10].Value) + " where Stock_ID=" + stock_ID + "", "");
            //insert into tax report
            decimal totalTax = 0;
            totalTax = Convert.ToDecimal(DgvSearch.CurrentRow.Cells[7].Value);
            decimal totalBeforeTax = 0; decimal totalItem = 0;
            totalItem = Convert.ToDecimal(DgvSearch.CurrentRow.Cells[4].Value) * Convert.ToDecimal(DgvSearch.CurrentRow.Cells[8].Value);
            totalBeforeTax = Convert.ToDecimal(totalItem) - totalTax;
            db.exceuteData("insert into Taxes_Report (Order_Num,Order_Type,Tax_Type,Sup_Name,Cust_Name,Total_Order,Total_Tax,Total_AfterTax,Date) values (" + Convert.ToDecimal(DgvSearch.CurrentRow.Cells[0].Value) + " ,N'مرتجعات مشتريات' ,N'قيمة مضافة'  ,N'" + txtName2.Text + "',N'لا يوجد' ," + totalBeforeTax + " ," + totalTax + " ," + totalItem + " ,N'" + d + "')", "");


            MessageBox.Show("تمت عمليه الارجاع بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            onLoadScreen();
        }
        //when user press return qty in sales 
        private void returnQtySaleOnly()
        {
            DataTable tblStock = new DataTable();
            d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (txtName2.Text == "") { MessageBox.Show("من فضلك ادخل اسم العميل", "تاكيد"); return; }
            decimal stock_Money = 0;
            tblStock.Clear();
            tblStock = db.readData("select * from Stock where Stock_ID=" + stock_ID + "", "");
            stock_Money = Convert.ToDecimal(tblStock.Rows[0][1]);

            if ((Convert.ToDecimal(DgvSearch.CurrentRow.Cells[6].Value) * NudQty.Value ) > stock_Money)
            {
                MessageBox.Show("المبلغ الموجود فى الخزنة غير كافى لاجراء العملية", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int proID = 1;
            try
            {
                proID = Convert.ToInt32(db.readData("select Pro_ID from Products where Pro_Name=N'" + DgvSearch.CurrentRow.Cells[2].Value + "'", "").Rows[0][0]);
            }
            catch (Exception) { }
            decimal QtyInMain = 0, realQty = 0;
            DataTable tblUnit = new DataTable();
            tblUnit.Clear();
            tblUnit = db.readData("select * from Products_Unit where Pro_ID=" + proID + " and Unit_Name=N'" + DgvSearch.CurrentRow.Cells[9].Value + "'", "");
            try
            {
                QtyInMain = Convert.ToDecimal(tblUnit.Rows[0][3]);
            }
            catch (Exception) { }

            realQty = NudQty.Value / QtyInMain;
            if ((Convert.ToDecimal(DgvSearch.CurrentRow.Cells[3].Value) - NudQty.Value) <= 0)
            {
                MessageBox.Show("الكمية المراد ترجعيها اكبر من الكمية التى تم بيعها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            db.exceuteData("update Sales_Detalis set Qty=Qty - "+ realQty + " where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + " and Pro_ID=" + proID + " and Qty=" + DgvSearch.CurrentRow.Cells[3].Value + " and Total=" + DgvSearch.CurrentRow.Cells[8].Value + "", "");
            db.exceuteData("update Sales_Rb7h set Qty=Qty - " + realQty + " where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + " and Pro_ID=" + proID + " and Qty=" + DgvSearch.CurrentRow.Cells[3].Value + " and Total=" + DgvSearch.CurrentRow.Cells[8].Value + "", "");
            //insert data into return table
            db.exceuteData("insert into Returns (Order_Date , Order_Type) values ('" + d + "',N'مرتجعات مبيعات')", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception) { }
            //insert into return detalis 

            db.exceuteData("insert into Returns_Detalis values (" + id + " ,N'' ,N'" + txtName2.Text + "' ,N'" + realQty + "' , N'" + d + "' ," + DgvSearch.CurrentRow.Cells[3].Value + " ," + DgvSearch.CurrentRow.Cells[4].Value + " ," + DgvSearch.CurrentRow.Cells[8].Value + " , N'" + Properties.Settings.Default.USERNAME + "' ," + txtTotalOrderAfterTax.Text + " ," + txtMadfou3.Text + " , " + txtbaky.Text + " ," + txtTotalTax.Text + " , " + DgvSearch.CurrentRow.Cells[6].Value + " ,N'" + DgvSearch.CurrentRow.Cells[9].Value + "')", "");
            
            db.exceuteData("update Products set Qty=Qty + " + realQty + " where Pro_ID=" + proID + "", "");

            DataTable tblQty = new DataTable();
            tblQty.Clear();
            tblQty = db.readData("select top 1 * from Products_Qty where Pro_ID=" + proID + " and Store_ID=" + cbxStore2.SelectedValue + " ", "");
            if (tblQty.Rows.Count >= 1)
            {
                db.exceuteData("update Products_Qty set Qty=Qty + " + realQty + " where Pro_ID=" + proID + " and Store_ID=" + cbxStore2.SelectedValue + " and Qty=" + tblQty.Rows[0][3] + " and Buy_Price=" + tblQty.Rows[0][4] + "", "");
            }
            else
            {
                tblQty.Clear();
                tblQty = db.readData("select top 1 * from Products_Qty where Pro_ID=" + proID + " ", "");
                if (tblQty.Rows.Count >= 1)
                {
                    db.exceuteData("insert into Products_Qty values (" + proID + " , " + cbxStore2.SelectedValue + " ,N'" + cbxStore2.Text + "' , " + realQty + " , " + tblQty.Rows[0][4] + " , " + DgvSearch.CurrentRow.Cells[6].Value + ")", "");
                }
                else
                {
                    string buyPrice = Microsoft.VisualBasic.Interaction.InputBox("ادخل سعر الشراء للمنتج " + (DgvSearch.CurrentRow.Cells[2].Value), "سعر الشراء", "من فضلك ادخل السعر هنا", 1, 1);
                    db.exceuteData("insert into Products_Qty values (" + proID + " , " + cbxStore2.SelectedValue + " ,N'" + cbxStore2.Text + "' , " + realQty + " , " + buyPrice + " , " + DgvSearch.CurrentRow.Cells[6].Value + ")", "");

                }
            }

            db.exceuteData("insert into Stock_Pull (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + (Convert.ToDecimal(DgvSearch.CurrentRow.Cells[6].Value) * NudQty.Value) + " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'مرتجعات مبيعات', N'') ", "");
            db.exceuteData("update stock set Money=Money - " + (Convert.ToDecimal(DgvSearch.CurrentRow.Cells[6].Value) * NudQty.Value) + " where Stock_ID=" + stock_ID + "", "");

            //insert into tax report
            decimal totalTax = 0,itemTax=0;
            itemTax = Convert.ToDecimal(DgvSearch.CurrentRow.Cells[5].Value) / Convert.ToDecimal(DgvSearch.CurrentRow.Cells[3].Value);
            totalTax = itemTax * NudQty.Value;
            decimal totalBeforeTax = 0; decimal totalItem = 0;
            totalItem = NudQty.Value * Convert.ToDecimal(DgvSearch.CurrentRow.Cells[6].Value);
            totalBeforeTax = Convert.ToDecimal(totalItem) - totalTax;
            db.exceuteData("insert into Taxes_Report (Order_Num,Order_Type,Tax_Type,Sup_Name,Cust_Name,Total_Order,Total_Tax,Total_AfterTax,Date) values (" + Convert.ToDecimal(DgvSearch.CurrentRow.Cells[0].Value) + " ,N'مرتجعات مبيعات' ,N'قيمة مضافة'  ,N'لا يوجد' ,N'" + txtName2.Text + "'," + totalBeforeTax + " ," + totalTax + " ," + totalItem + " ,N'" + d + "')", "");


            MessageBox.Show("تمت عمليه الارجاع بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            onLoadScreen();
        }
        //when user press return qty in buy 
        private void returnQtyBuyOnly()
        {
            d = DtpDate.Value.ToString("dd/MM/yyyy");
            if (txtName2.Text == "") { MessageBox.Show("من فضلك ادخل اسم المورد", "تاكيد"); return; }
            int proID = 1;
            try
            {
                proID = Convert.ToInt32(db.readData("select Pro_ID from Products where Pro_Name=N'" + DgvSearch.CurrentRow.Cells[2].Value + "'", "").Rows[0][0]);
            }
            catch (Exception) { }
            decimal QtyInMain = 0, realQty = 0;
            DataTable tblUnit = new DataTable();
            tblUnit.Clear();
            tblUnit = db.readData("select * from Products_Unit where Pro_ID=" + proID + " and Unit_Name=N'" + DgvSearch.CurrentRow.Cells[5].Value + "'", "");
            try
            {
                QtyInMain = Convert.ToDecimal(tblUnit.Rows[0][3]);
            }
            catch (Exception) { }

            realQty = NudQty.Value;
            if ((Convert.ToDecimal(DgvSearch.CurrentRow.Cells[4].Value) - NudQty.Value) <= 0)
            {
                MessageBox.Show("الكمية المراد ترجعيها اكبر من الكمية التى تم شرائها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            db.exceuteData("update Buy_Detalis set Qty=Qty - " + realQty + " where Order_ID=" + DgvSearch.CurrentRow.Cells[0].Value + " and Pro_ID=" + proID + " and Qty=" + DgvSearch.CurrentRow.Cells[4].Value + " and Total=" + DgvSearch.CurrentRow.Cells[10].Value + "", "");

            //insert data into return table
            db.exceuteData("insert into Returns (Order_Date , Order_Type) values ('" + d + "',N'مرتجعات مشتريات')", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception) { }
            //insert into return detalis 

            db.exceuteData("insert into Returns_Detalis values (" + id + " ,N'" + txtName2.Text + "' ,N'' ,N'" + DgvSearch.CurrentRow.Cells[2].Value + "' , N'" + d + "' ," + realQty + " ," + DgvSearch.CurrentRow.Cells[6].Value + " ," + DgvSearch.CurrentRow.Cells[10].Value + " , N'" + Properties.Settings.Default.USERNAME + "' ," + txtTotalOrderAfterTax.Text + " ," + txtMadfou3.Text + " , " + txtbaky.Text + " ," + txtTotalTax.Text + " , " + DgvSearch.CurrentRow.Cells[8].Value + " ,N'" + DgvSearch.CurrentRow.Cells[5].Value + "')", "");


            DataTable tblUnit2 = new DataTable();
            tblUnit2.Clear();
            tblUnit2 = db.readData("select * from Products_Unit where Pro_ID=" + proID + " and Unit_Name=N'" + DgvSearch.CurrentRow.Cells[5].Value + "'", "");
            try
            {
                QtyInMain = Convert.ToDecimal(tblUnit2.Rows[0][3]);
            }
            catch (Exception) { }

            realQty = NudQty.Value / QtyInMain;
            db.exceuteData("update Products set Qty=Qty - " + realQty + " where Pro_ID=" + proID + "", "");

            DataTable tblQty = new DataTable();
            tblQty.Clear();
            tblQty = db.readData("select * from Products_Qty where Pro_ID=" + proID + " and Store_ID=" + cbxStore2.SelectedValue + "", "");
            decimal def = 0;
            def = Convert.ToDecimal(tblQty.Rows[0][3]) - realQty;
            if (def < 0)
            {
                MessageBox.Show("الكمية المراد ارجاعها غير موجوده فى المخزن", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                db.exceuteData("update Products_Qty set Qty=Qty - " + realQty + " where Pro_ID=" + proID + " and Store_ID=" + cbxStore2.SelectedValue + " and Qty=" + tblQty.Rows[0][3] + " and Buy_Price=" + tblQty.Rows[0][4] + "", "");
            }

            db.exceuteData("insert into Stock_Insert (Stock_ID , Money ,Date ,Name ,Type ,Reason) values (" + stock_ID + " ," + (Convert.ToDecimal(DgvSearch.CurrentRow.Cells[8].Value) * NudQty.Value) + " ,N'" + d + "' ,N'" + Properties.Settings.Default.USERNAME + "' ,N'مرتجعات مشتريات', N'') ", "");
            db.exceuteData("update stock set Money=Money + " + (Convert.ToDecimal(DgvSearch.CurrentRow.Cells[8].Value) * NudQty.Value) + " where Stock_ID=" + stock_ID + "", "");

            //insert into tax report
            decimal totalTax = 0, itemTax = 0;
            itemTax = Convert.ToDecimal(DgvSearch.CurrentRow.Cells[7].Value) / Convert.ToDecimal(DgvSearch.CurrentRow.Cells[4].Value);
            totalTax = itemTax * NudQty.Value;
            decimal totalBeforeTax = 0; decimal totalItem = 0;

            totalItem = NudQty.Value * Convert.ToDecimal(DgvSearch.CurrentRow.Cells[8].Value);
            totalBeforeTax = Convert.ToDecimal(totalItem) - totalTax;
            db.exceuteData("insert into Taxes_Report (Order_Num,Order_Type,Tax_Type,Sup_Name,Cust_Name,Total_Order,Total_Tax,Total_AfterTax,Date) values (" + Convert.ToDecimal(DgvSearch.CurrentRow.Cells[0].Value) + " ,N'مرتجعات مشتريات' ,N'قيمة مضافة'  ,N'" + txtName2.Text + "',N'لا يوجد' ," + totalBeforeTax + " ," + totalTax + " ," + totalItem + " ,N'" + d + "')", "");


            MessageBox.Show("تمت عمليه الارجاع بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            onLoadScreen();
        }
        private void btnReturnItemOnly_Click(object sender, EventArgs e)
        {
            if(DgvSearch.Rows.Count >= 1)
            {
                if (rbtnReturnItemOnly.Checked == true)
                {
                    if (rbtnSales.Checked == true)
                    {
                        returnItemSaleOnly();

                    }else if (rbtnBuy.Checked == true)
                    {
                        returnItemBuyOnly();
                    }
                }else if (rbtnReturnQtyonly.Checked == true)
                {
                    if (rbtnSales.Checked == true)
                    {
                        returnQtySaleOnly();

                    }
                    else if (rbtnBuy.Checked == true)
                    {
                        returnQtyBuyOnly();
                    }
                }
            }
        }
    }
}