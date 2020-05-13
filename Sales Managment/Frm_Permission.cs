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
    public partial class Frm_Permission : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Permission()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable(); DataTable tblGroup = new DataTable();
        private void AutoNumber()
        {
            tblGroup.Clear();
            tblGroup = db.readData("SELECT [User_ID] as 'رقم المستخدم',[User_Name] as 'اسم المستخدم',[Type] as 'نوعة',[Rb7h] as 'نسبة الربح' FROM [dbo].[Users]", "");
            DgvSearch.DataSource = tblGroup;
            tbl.Clear();
            tbl = db.readData("select max (User_ID) from Users", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {

                txtID.Text = "1";
            }
            else
            {

                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtPassword.Clear();
            txtUserName.Clear();
            NudPrice.Value = 1;
            try
            {
                cbxStock.SelectedIndex = 0;
                cbxType.SelectedIndex = 0;
            }catch (Exception) { }
            FillUsers();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;

        }

        int row;
        private void Show()
        {
            tbl.Clear();
            tbl = db.readData("select * from Users", "");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشه");
            }
            else
            {
                txtID.Text = tbl.Rows[row][0].ToString();
                txtUserName.Text = tbl.Rows[row][1].ToString();
                txtPassword.Text = tbl.Rows[row][2].ToString();
                cbxType.Text = tbl.Rows[row][3].ToString();
                cbxStock.SelectedValue =Convert.ToDecimal( tbl.Rows[row][4]);
                NudPrice.Value = Convert.ToDecimal(tbl.Rows[row][5]);
            }

            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }

        private void FillStock()
        {
            cbxStock.DataSource = db.readData("select * from Stock_Data", "");
            cbxStock.DisplayMember = "Stock_Name";
            cbxStock.ValueMember = "Stock_ID";
        }
        private void FillUsers()
        {
            cbxUser1.DataSource = db.readData("select * from Users", "");
            cbxUser1.DisplayMember = "User_Name";
            cbxUser1.ValueMember = "User_ID";

            cbxUser2.DataSource = db.readData("select * from Users", "");
            cbxUser2.DisplayMember = "User_Name";
            cbxUser2.ValueMember = "User_ID";

            cbxUser3.DataSource = db.readData("select * from Users", "");
            cbxUser3.DisplayMember = "User_Name";
            cbxUser3.ValueMember = "User_ID";

            cbxUser4.DataSource = db.readData("select * from Users", "");
            cbxUser4.DisplayMember = "User_Name";
            cbxUser4.ValueMember = "User_ID";

            cbxUser5.DataSource = db.readData("select * from Users", "");
            cbxUser5.DisplayMember = "User_Name";
            cbxUser5.ValueMember = "User_ID";

            cbxUser6.DataSource = db.readData("select * from Users", "");
            cbxUser6.DisplayMember = "User_Name";
            cbxUser6.ValueMember = "User_ID";

            cbxUser7.DataSource = db.readData("select * from Users", "");
            cbxUser7.DisplayMember = "User_Name";
            cbxUser7.ValueMember = "User_ID";

            cbxUser8.DataSource = db.readData("select * from Users", "");
            cbxUser8.DisplayMember = "User_Name";
            cbxUser8.ValueMember = "User_ID";

            cbxUser9.DataSource = db.readData("select * from Users", "");
            cbxUser9.DisplayMember = "User_Name";
            cbxUser9.ValueMember = "User_ID";
            

            cbxUser11.DataSource = db.readData("select * from Users", "");
            cbxUser11.DisplayMember = "User_Name";
            cbxUser11.ValueMember = "User_ID";
        }
        private void Frm_Permission_Load(object sender, EventArgs e)
        {
            try
            {
                FillStock();
                AutoNumber();
            }catch (Exception) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUserName.Text =="")
            {
                MessageBox.Show("من فضلك اكمل البيانات");
                return;
            }
            db.exceuteData("insert into Users Values (" + txtID.Text + " , N'"+txtUserName.Text+"' ,N'"+txtPassword.Text+"' ,N'"+cbxType.Text+"' ,"+cbxStock.SelectedValue+" , "+NudPrice.Value+")", "تم الادخال بنجاح");
            db.exceuteData("insert into User_Setting Values ("+txtID.Text+" , 0,0,0,0,0,0,0,0,0,0,0,0)", "");
            db.exceuteData("insert into User_Customer Values (" + txtID.Text + " , 0,0,0)", "");
            db.exceuteData("insert into User_Supplier Values (" + txtID.Text + " , 0,0,0)", "");
            db.exceuteData("insert into User_Buy Values (" + txtID.Text + " , 0,0)", "");
            db.exceuteData("insert into User_Sale Values (" + txtID.Text + " , 0,0,0)", "");
            db.exceuteData("insert into User_Return Values (" + txtID.Text + " , 0,0)", "");
            db.exceuteData("insert into User_StockBank Values (" + txtID.Text + " , 0,0,0,0,0,0,0,0,0)", "");
            db.exceuteData("insert into User_Emp Values (" + txtID.Text + " , 0,0,0,0,0,0,0)", "");
            db.exceuteData("insert into User_Deserved Values (" + txtID.Text + " , 0,0,0,0,0,0,0)", "");
            db.exceuteData("insert into User_Report Values (" + txtID.Text + " , 0,0,0,0,0,0)", "");
            db.exceuteData("insert into User_BackUp Values (" + txtID.Text + " , 0,0)", "");

            
            AutoNumber();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count(User_ID) from Users", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                Show();
            }
            else
            {


                row--;
                Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(User_ID) from Users", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == row)
            {
                row = 0;
                Show();
            }
            else
            {
                row++;
                Show();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(User_ID) from Users", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات");
                return;
            }
            db.exceuteData("update  Users set  User_Name=N'" + txtUserName.Text + "' ,User_Password=N'" + txtPassword.Text + "' ,Type=N'" + cbxType.Text + "' ,Stock_ID=" + cbxStock.SelectedValue + " ,Rb7h=" + NudPrice.Value + " where User_ID=" + txtID.Text + " ", "تم التعديل بنجاح");
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Users where User_ID=" + txtID.Text + "", "تم مسح البيانات بنجاح");

                DataTable tblUser = new DataTable();
                tblUser = db.readData("select * from Users","");
                if(tblUser.Rows.Count <= 0)
                {
                    string type = "مدير";
                    db.exceuteData("insert into Users Values (1 ,N'"+Properties.Settings.Default.USERNAME+"' ,N'"+Properties.Settings.Default.USERNAME+"' ,N'"+type+"', 1 ,0  )", "");
                }
                AutoNumber();
            }
        }
        DataTable tblSearch = new DataTable();
        private void cbxUser1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try {
                tblSearch.Clear();
                tblSearch = db.readData("select * from User_Setting where User_ID=" + cbxUser1.SelectedValue+"", "");
                if(tblSearch.Rows.Count >= 1)
                {
                    if(Convert.ToDecimal( tblSearch.Rows[0][1]) == 1)
                    {
                        checkUnit.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 0)
                    {
                        checkUnit.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 1)
                    {
                        checkPermission.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 0)
                    {
                        checkPermission.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 1)
                    {
                        checkViewItems.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 0)
                    {
                        checkViewItems.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][4]) == 1)
                    {
                        checkSetting.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][4]) == 0)
                    {
                        checkSetting.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][5]) == 1)
                    {
                        checkaddItem.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][5]) == 0)
                    {
                        checkaddItem.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][6]) == 1)
                    {
                        checkItemsGroup.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][6]) == 0)
                    {
                        checkItemsGroup.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][7]) == 1)
                    {
                        checkAddStore.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][7]) == 0)
                    {
                        checkAddStore.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][8]) == 1)
                    {
                        checkStoreGard.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][8]) == 0)
                    {
                        checkStoreGard.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][9]) == 1)
                    {
                        checkStoreTransfire.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][9]) == 0)
                    {
                        checkStoreTransfire.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][10]) == 1)
                    {
                        checkStoreOut.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][10]) == 0)
                    {
                        checkStoreOut.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][11]) == 1)
                    {
                        checkStoreTransfireReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][11]) == 0)
                    {
                        checkStoreTransfireReport.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][12]) == 1)
                    {
                        checkStoreOutReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][12]) == 0)
                    {
                        checkStoreOutReport.Checked = false;
                    }
                }
            

            } catch (Exception ) {  }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try {

                int unit = 0, setting = 0, userPermission = 0, itemView = 0, addItem = 0 ,itemsGroup=0 ,addStore=0 ,storeGard=0 ,storeTransfire=0,storeOut=0, storeTransfireReport=0 , storeOutReport=0;

                if (checkUnit.Checked == true)
                    unit = 1;
                else
                    unit = 0;
                if (checkSetting.Checked == true)
                    setting = 1;
                else
                    setting = 0;

                if (checkPermission.Checked == true)
                    userPermission = 1;
                else
                    userPermission = 0;

                if (checkViewItems.Checked == true)
                    itemView = 1;
                else
                    itemView = 0;
                if (checkaddItem.Checked == true)
                    addItem = 1;
                else
                    addItem = 0;
                if (checkItemsGroup.Checked == true)
                    itemsGroup = 1;
                else
                    itemsGroup = 0;
                if (checkAddStore.Checked == true)
                    addStore = 1;
                else
                    addStore = 0;
                if (checkStoreGard.Checked == true)
                    storeGard = 1;
                else
                    storeGard = 0;
                if (checkStoreTransfire.Checked == true)
                    storeTransfire = 1;
                else
                    storeTransfire = 0;
                if (checkStoreOut.Checked == true)
                    storeOut = 1;
                else
                    storeOut = 0;
                if (checkStoreTransfireReport.Checked == true)
                    storeTransfireReport = 1;
                else
                    storeTransfireReport = 0;
                if (checkStoreOutReport.Checked == true)
                    storeOutReport = 1;
                else
                    storeOutReport = 0;
                db.exceuteData("update User_Setting Set Unit=" + unit + " ,User_Permisson="+userPermission+ " ,Item_View="+itemView+ " ,Setting="+setting+ " , Item_Add="+addItem+ " ,Item_Group="+itemsGroup+ " ,Store_Add="+addStore+ " ,Store_Gard="+storeGard+ ",Store_Transfire="+storeTransfire+ ",Store_Out="+storeOut+ ",Store_TransfireReport="+storeTransfireReport+ ",Store_OutReport="+storeOutReport+" where User_ID=" + cbxUser1.SelectedValue+"", "تم التعديل بنجاح");
                cbxUser1.SelectedIndex = 0;

            } catch (Exception) { }
        }

        private void cbxUser2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblSearch.Clear();
                tblSearch = db.readData("select * from User_Customer where User_ID=" + cbxUser2.SelectedValue + "", "");
                if (tblSearch.Rows.Count >= 1)
                {
                    if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 1)
                    {
                        checkCustomer.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 0)
                    {
                        checkCustomer.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 1)
                    {
                        checkCustomerMoney.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 0)
                    {
                        checkCustomerMoney.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 1)
                    {
                        checkCustomerReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 0)
                    {
                        checkCustomerReport.Checked = false;
                    }
                    //=======================
                    
                }

            }
            catch (Exception) { }
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {

                int customer = 0, customerMoney = 0, customerReport = 0;

                if (checkCustomer.Checked == true)
                    customer = 1;
                else
                    customer = 0;
                if (checkCustomerMoney.Checked == true)
                    customerMoney = 1;
                else
                    customerMoney = 0;

                if (checkCustomerReport.Checked == true)
                    customerReport = 1;
                else
                    customerReport = 0;

                
                db.exceuteData("update User_Customer Set Customer=" + customer + " ,CustomerMoney=" + customerMoney + " ,CustomerReport=" + customerReport + "  where User_ID=" + cbxUser2.SelectedValue + "", "تم التعديل بنجاح");
                cbxUser2.SelectedIndex = 0;

            }
            catch (Exception) { }
        }

        private void cbxUser3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblSearch.Clear();
                tblSearch = db.readData("select * from User_Supplier where User_ID=" + cbxUser3.SelectedValue + "", "");
                if (tblSearch.Rows.Count >= 1)
                {
                    if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 1)
                    {
                        checkSupplier.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 0)
                    {
                        checkSupplier.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 1)
                    {
                        checkSupplierMony.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 0)
                    {
                        checkSupplierMony.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 1)
                    {
                        checkSupplierReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 0)
                    {
                        checkSupplierReport.Checked = false;
                    }
                    //=======================

                }

            }
            catch (Exception) { }
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            try
            {

                int supplier = 0, supplierMoney = 0, supplierReport = 0;

                if (checkSupplier.Checked == true)
                    supplier = 1;
                else
                    supplier = 0;
                if (checkSupplierMony.Checked == true)
                    supplierMoney = 1;
                else
                    supplierMoney = 0;

                if (checkSupplierReport.Checked == true)
                    supplierReport = 1;
                else
                    supplierReport = 0;


                db.exceuteData("update User_Supplier Set Supp_Data=" + supplier + " ,Supp_Money=" + supplierMoney + " ,Supp_Report=" + supplierReport + "  where User_ID=" + cbxUser3.SelectedValue + "", "تم التعديل بنجاح");
                cbxUser3.SelectedIndex = 0;

            }
            catch (Exception) { }
        }

        private void cbxUser4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblSearch.Clear();
                tblSearch = db.readData("select * from User_Buy where User_ID=" + cbxUser4.SelectedValue + "", "");
                if (tblSearch.Rows.Count >= 1)
                {
                    if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 1)
                    {
                        checkBuy.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 0)
                    {
                        checkBuy.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 1)
                    {
                        checkBuyReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 0)
                    {
                        checkBuyReport.Checked = false;
                    }
                    //=======================
                    

                }

            }
            catch (Exception) { }
        }

        private void btnSaveBuy_Click(object sender, EventArgs e)
        {
            try
            {

                int buy = 0, buyReport = 0;

                if (checkBuy.Checked == true)
                    buy = 1;
                else
                    buy = 0;
                if (checkBuyReport.Checked == true)
                    buyReport = 1;
                else
                    buyReport = 0;
                


                db.exceuteData("update User_Buy Set Buy=" + buy + " ,BuyReport=" + buyReport + "  where User_ID=" + cbxUser4.SelectedValue + "", "تم التعديل بنجاح");
                cbxUser3.SelectedIndex = 0;

            }
            catch (Exception) { }
        }

        private void cbxUser5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            try
            {

                int sale = 0, saleReport = 0 ,SaleRb7h;

                if (checkSale.Checked == true)
                    sale = 1;
                else
                    sale = 0;
                if (checkSaleReport.Checked == true)
                    saleReport = 1;
                else
                    saleReport = 0;

                if (checkSaleRb7h.Checked == true)
                    SaleRb7h = 1;
                else
                    SaleRb7h = 0;

                db.exceuteData("update User_Sale Set Sale=" + sale + " ,SaleReport=" + saleReport + " ,SaleRb7h ="+SaleRb7h+"  where User_ID=" + cbxUser5.SelectedValue + "", "تم التعديل بنجاح");
                cbxUser3.SelectedIndex = 0;

            }
            catch (Exception) { }
        }

        private void cbxUser6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblSearch.Clear();
                tblSearch = db.readData("select * from User_Return where User_ID=" + cbxUser6.SelectedValue + "", "");
                if (tblSearch.Rows.Count >= 1)
                {
                    if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 1)
                    {
                        checkReturn.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 0)
                    {
                        checkReturn.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 1)
                    {
                        checkStockInsert.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 0)
                    {
                        checkStockInsert.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 1)
                    {
                        checkBankInsert.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 0)
                    {
                        checkBankInsert.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][4]) == 1)
                    {
                        checkStockPull.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][4]) == 0)
                    {
                        checkStockPull.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][5]) == 1)
                    {
                        checkBankPull.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][5]) == 0)
                    {
                        checkBankPull.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][6]) == 1)
                    {
                        checkTransfireMoney.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][6]) == 0)
                    {
                        checkTransfireMoney.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][7]) == 1)
                    {
                        checkTransfireStockBank.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][7]) == 0)
                    {
                        checkTransfireStockBank.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][8]) == 1)
                    {
                        checkCurrentMoney.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][8]) == 0)
                    {
                        checkCurrentMoney.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][9]) == 1)
                    {
                        checkStockBankReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][9]) == 0)
                    {
                        checkStockBankReport.Checked = false;
                    }
                    //=======================

                }

            }
            catch (Exception) { }
        }

        private void btnSaveReturn_Click(object sender, EventArgs e)
        {
            try
            {

                int return_ = 0, returnReport = 0;

                if (checkReturn.Checked == true)
                    return_ = 1;
                else
                    return_ = 0;
                if (checkReturnReport.Checked == true)
                    returnReport = 1;
                else
                    returnReport = 0;

                db.exceuteData("update User_Return Set Return_=" + return_ + " ,ReturnReport=" + returnReport + "   where User_ID=" + cbxUser6.SelectedValue + "", "تم التعديل بنجاح");
                cbxUser3.SelectedIndex = 0;

            }
            catch (Exception) { }
        }

        private void cbxUser7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblSearch.Clear();
                tblSearch = db.readData("select * from User_StockBank where User_ID=" + cbxUser7.SelectedValue + "", "");
                if (tblSearch.Rows.Count >= 1)
                {
                    if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 1)
                    {
                        checkAddStock.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 0)
                    {
                        checkAddStock.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 1)
                    {
                        checkStockInsert.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 0)
                    {
                        checkStockInsert.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 1)
                    {
                        checkBankInsert.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 0)
                    {
                        checkBankInsert.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][4]) == 1)
                    {
                        checkStockPull.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][4]) == 0)
                    {
                        checkStockPull.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][5]) == 1)
                    {
                        checkBankPull.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][5]) == 0)
                    {
                        checkBankPull.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][6]) == 1)
                    {
                        checkTransfireMoney.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][6]) == 0)
                    {
                        checkTransfireMoney.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][7]) == 1)
                    {
                        checkTransfireStockBank.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][7]) == 0)
                    {
                        checkTransfireStockBank.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][8]) == 1)
                    {
                        checkCurrentMoney.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][8]) == 0)
                    {
                        checkCurrentMoney.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][9]) == 1)
                    {
                        checkStockBankReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][9]) == 0)
                    {
                        checkStockBankReport.Checked = false;
                    }
                    //=======================


                }

            }
            catch (Exception) { }
        }

        private void btnSaveStockBank_Click(object sender, EventArgs e)
        {
            try
            {

                int addStock = 0, stockInsert = 0,bankInsert=0,stockPull =0,bankPull =0,transfireMoney=0 ,transfireStockBank=0,currentMoney=0, stockBankReport=0;

                if (checkAddStock.Checked == true)
                    addStock = 1;
                else
                    addStock = 0;
                if (checkStockInsert.Checked == true)
                    stockInsert = 1;
                else
                    stockInsert = 0;

                if (checkBankInsert.Checked == true)
                    bankInsert = 1;
                else
                    bankInsert = 0;
                if (checkStockPull.Checked == true)
                    stockPull = 1;
                else
                    stockPull = 0;
                if (checkBankPull.Checked == true)
                    bankPull = 1;
                else
                    bankPull = 0;
                if (checkTransfireMoney.Checked == true)
                    transfireMoney = 1;
                else
                    transfireMoney = 0;
                if (checkTransfireStockBank.Checked == true)
                    transfireStockBank = 1;
                else
                    transfireStockBank = 0;
                if (checkCurrentMoney.Checked == true)
                    currentMoney = 1;
                else
                    currentMoney = 0;
                if (checkStockBankReport.Checked == true)
                    stockBankReport = 1;
                else
                    stockBankReport = 0;
                db.exceuteData("update User_StockBank Set Add_Stock=" + addStock + " ,Stock_Insert=" + stockInsert + ",Bank_Insert="+bankInsert+ " ,Stock_Pull ="+stockPull+ " ,Bank_Pull="+bankPull+ ",Transfire_Money="+transfireMoney+ ",Transfire_BankStock="+transfireStockBank+ ",Current_Money="+currentMoney+ ",StockBank_Report="+stockBankReport+"   where User_ID=" + cbxUser7.SelectedValue + "", "تم التعديل بنجاح");
                cbxUser3.SelectedIndex = 0;

            }
            catch (Exception) { }
        }

        private void cbxUser5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblSearch.Clear();
                tblSearch = db.readData("select * from User_Sale where User_ID=" + cbxUser5.SelectedValue + "", "");
                if (tblSearch.Rows.Count >= 1)
                {
                    if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 1)
                    {
                        checkSale.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 0)
                    {
                        checkSale.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 1)
                    {
                        checkSaleReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 0)
                    {
                        checkSaleReport.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 1)
                    {
                        checkSaleRb7h.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 0)
                    {
                        checkSaleRb7h.Checked = false;
                    }
                    //=======================

                }

            }
            catch (Exception) { }
        }

        private void cbxUser8_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblSearch.Clear();
                tblSearch = db.readData("select * from User_Emp where User_ID=" + cbxUser8.SelectedValue + "", "");
                if (tblSearch.Rows.Count >= 1)
                {
                    if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 1)
                    {
                        checkAddEmployee.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 0)
                    {
                        checkAddEmployee.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 1)
                    {
                        checkBorrowItems.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 0)
                    {
                        checkBorrowItems.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 1)
                    {
                        checkBorrowMoney.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 0)
                    {
                        checkBorrowMoney.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][4]) == 1)
                    {
                        checkSalary.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][4]) == 0)
                    {
                        checkSalary.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][5]) == 1)
                    {
                        checkBorrowItemReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][5]) == 0)
                    {
                        checkBorrowItemReport.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][6]) == 1)
                    {
                        checkBorrowMoneyReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][6]) == 0)
                    {
                        checkBorrowMoneyReport.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][7]) == 1)
                    {
                        checkSalaryReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][7]) == 0)
                    {
                        checkSalaryReport.Checked = false;
                    }
                    //=======================

                }

            }
            catch (Exception) { }
        }

        private void btnSaveEmplyoee_Click(object sender, EventArgs e)
        {
            try
            {

                int addEmp = 0, borrowItems = 0, borrowMoeny = 0, salary = 0, borrowItemsReport = 0, borrowMoenyReport = 0, salaryReport = 0;

                if (checkAddEmployee.Checked == true)
                    addEmp = 1;
                else
                    addEmp = 0;
                if (checkBorrowItems.Checked == true)
                    borrowItems = 1;
                else
                    borrowItems = 0;

                if (checkBorrowMoney.Checked == true)
                    borrowMoeny = 1;
                else
                    borrowMoeny = 0;
                if (checkSalary.Checked == true)
                    salary = 1;
                else
                    salary = 0;
                if (checkBorrowItemReport.Checked == true)
                    borrowItemsReport = 1;
                else
                    borrowItemsReport = 0;
                if (checkBorrowMoneyReport.Checked == true)
                    borrowMoenyReport = 1;
                else
                    borrowMoenyReport = 0;
                if (checkSalaryReport.Checked == true)
                    salaryReport = 1;
                else
                    salaryReport = 0;
                db.exceuteData("update User_Emp Set Add_Emp=" + addEmp + " ,Borrow_Items=" + borrowItems + ",Borrow_Money=" + borrowMoeny + " ,Salary =" + salary + " ,Borrow_ItemsReport=" + borrowItemsReport + ",Borrow_MoneyReport=" + borrowMoenyReport + ",SalaryReport=" + salaryReport + "   where User_ID=" + cbxUser8.SelectedValue + "", "تم التعديل بنجاح");
                cbxUser3.SelectedIndex = 0;

            }
            catch (Exception) { }
        }

        private void cbxUser9_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblSearch.Clear();
                tblSearch = db.readData("select * from User_Deserved where User_ID=" + cbxUser9.SelectedValue + "", "");
                if (tblSearch.Rows.Count >= 1)
                {
                    if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 1)
                    {
                        checkDesType.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 0)
                    {
                        checkDesType.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 1)
                    {
                        checkDeserved.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 0)
                    {
                        checkDeserved.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 1)
                    {
                        checkDeservedReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][3]) == 0)
                    {
                        checkDeservedReport.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][4]) == 1)
                    {
                        checkSanadKabd.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][4]) == 0)
                    {
                        checkSanadKabd.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][5]) == 1)
                    {
                        checkSanadSarf.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][5]) == 0)
                    {
                        checkSanadSarf.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][6]) == 1)
                    {
                        checkSanadReport.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][6]) == 0)
                    {
                        checkSanadReport.Checked = false;
                    }

                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][7]) == 1)
                    {
                        checkTaxes.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][7]) == 0)
                    {
                        checkTaxes.Checked = false;
                    }


                }

            }
            catch (Exception) { }
        }

        private void btnSaveDeserved_Click(object sender, EventArgs e)
        {
            try
            {

                int desType = 0, deserved = 0, deservedReport = 0, sanadKabd = 0, sanadSarf = 0, sanadReport = 0,taxes=0;

                if (checkDesType.Checked == true)
                    desType = 1;
                else
                    desType = 0;
                if (checkDeserved.Checked == true)
                    deserved = 1;
                else
                    deserved = 0;

                if (checkDeservedReport.Checked == true)
                    deservedReport = 1;
                else
                    deservedReport = 0;
                if (checkSanadKabd.Checked == true)
                    sanadKabd = 1;
                else
                    sanadKabd = 0;
                if (checkSanadSarf.Checked == true)
                    sanadSarf = 1;
                else
                    sanadSarf = 0;
                if (checkSanadReport.Checked == true)
                    sanadReport = 1;
                else
                    sanadReport = 0;

                if (checkTaxes.Checked == true)
                    taxes = 1;
                else
                    taxes = 0;
                db.exceuteData("update User_Deserved Set Des_Type=" + desType + " ,Deserved=" + deserved + ",DeservedReport=" + deservedReport + " ,SanadKabd =" + sanadKabd + " ,SanadSarf=" + sanadSarf + ",SanadReport=" + sanadReport + ",TaxesReport="+taxes+"   where User_ID=" + cbxUser9.SelectedValue + "", "تم التعديل بنجاح");
                cbxUser9.SelectedIndex = 0;

            }
            catch (Exception) { }
        }

        private void cbxUser10_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void cbxUser11_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblSearch.Clear();
                tblSearch = db.readData("select * from User_BackUp where User_ID=" + cbxUser11.SelectedValue + "", "");
                if (tblSearch.Rows.Count >= 1)
                {
                    if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 1)
                    {
                        checkTake.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][1]) == 0)
                    {
                        checkTake.Checked = false;
                    }
                    //=======================
                    if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 1)
                    {
                        checkrestore.Checked = true;
                    }
                    else if (Convert.ToDecimal(tblSearch.Rows[0][2]) == 0)
                    {
                        checkrestore.Checked = false;
                    }
                   

                }

            }
            catch (Exception) { }
        }

        private void btnSaveDeservedsss_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            try
            {

                int takeBackup = 0, restoreBackup = 0;

                if (checkTake.Checked == true)
                    takeBackup = 1;
                else
                    takeBackup = 0;
                if (checkrestore.Checked == true)
                    restoreBackup = 1;
                else
                    restoreBackup = 0;

                

                db.exceuteData("update User_BackUp Set TakeBackUp=" + takeBackup + " ,ReturnBackUp=" + restoreBackup + "  where User_ID=" + cbxUser11.SelectedValue + "", "تم التعديل بنجاح");
                cbxUser11.SelectedIndex = 0;

            }
            catch (Exception) { }
        }
    }
}