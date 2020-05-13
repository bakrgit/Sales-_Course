using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;

namespace Sales_Managment
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        int USER_ID = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                USER_ID = Convert.ToInt32(db.readData("select * from Users where User_Name=N'" + Properties.Settings.Default.USERNAME + "'", "").Rows[0][0]);

            }
            catch (Exception) { }

            barStaticItem3.Caption = "التاريخ |" + DateTime.Now.ToShortDateString();
            barStaticItem4.Caption = "اسم المستخدم |" + Properties.Settings.Default.USERNAME;
        }

        private bool checkUser(string filed, string table)
        {
            DataTable tblSearch = new DataTable();
            tblSearch = db.readData("select " + filed + " from " + table + " where User_ID=" + USER_ID + "", "");
            if (Convert.ToDecimal(tblSearch.Rows[0][0]) == 0)
            {
                MessageBox.Show("انتا لا تملك صلاحيه الدخول لهذه الشاشة", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Customer", "User_Customer");
            if (check == true)
            {
                Frm_Customer frm = new Frm_Customer();
                frm.ShowDialog();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Supp_Data", "User_Supplier");
            if (check == true)
            {
                Frm_Suppliers frm = new Frm_Suppliers();
                frm.ShowDialog();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Des_Type", "User_Deserved");
            if (check == true)
            {
                Frm_DeservedType frm = new Frm_DeservedType();
                frm.ShowDialog();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool check = checkUser("Deserved", "User_Deserved");
            if (check == true)
            {
                Frm_Deserved frm = new Frm_Deserved();
                frm.ShowDialog();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("DeservedReport", "User_Deserved");
            if (check == true)
            {
                Frm_DeservedReport frm = new Frm_DeservedReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Item_Add", "User_Setting");
            if (check == true)
            {
                Frm_Products frm = new Frm_Products();
                frm.ShowDialog();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Buy", "User_Buy");
            if (check == true)
            {
                Frm_Buy frm = new Frm_Buy();
                frm.ShowDialog();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Supp_Money", "User_Supplier");
            if (check == true)
            {
                Frm_SupplierMoney frm = new Frm_SupplierMoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Supp_Report", "User_Supplier");
            if (check == true)
            {
                Frm_SupplierReport frm = new Frm_SupplierReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("BuyReport", "User_Buy");
            if (check == true)
            {
                Frm_BuyReport frm = new Frm_BuyReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Sale", "User_Sale");
            if (check == true)
            {
                Frm_Sales frm = new Frm_Sales();
                frm.ShowDialog();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("CustomerMoney", "User_Customer");
            if (check == true)
            {
                Frm_CustomerMoney frm = new Frm_CustomerMoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("CustomerReport", "User_Customer");
            if (check == true)
            {
                Frm_CustomerReport frm = new Frm_CustomerReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("SaleReport", "User_Sale");
            if (check == true)
            {
                Frm_SalesReport frm = new Frm_SalesReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("SaleRb7h", "User_Sale");
            if (check == true)
            {
                Frm_SalesRb7h frm = new Frm_SalesRb7h();
                frm.ShowDialog();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Return_", "User_Return");
            if (check == true)
            {
                Frm_Return frm = new Frm_Return();
                frm.ShowDialog();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("ReturnReport", "User_Return");
            if (check == true)
            {
                Frm_ReturnReport frm = new Frm_ReturnReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Add_Stock", "User_StockBank");
            if (check == true)
            {
                Frm_AddStock frm = new Frm_AddStock();
                frm.ShowDialog();
            }
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool check = checkUser("Stock_Insert", "User_StockBank");
            if (check == true)
            {
                Frm_StockAddMoney frm = new Frm_StockAddMoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Bank_Insert", "User_StockBank");
            if (check == true)
            {
                Frm_BankAddMoney frm = new Frm_BankAddMoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Stock_Pull", "User_StockBank");
            if (check == true)
            {
                Frm_StockPullMoney frm = new Frm_StockPullMoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Bank_Pull", "User_StockBank");
            if (check == true)
            {
                Frm_BankPullMoney frm = new Frm_BankPullMoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Transfire_Money", "User_StockBank");
            if (check == true)
            {
                Frm_StockTransfire frm = new Frm_StockTransfire();
                frm.ShowDialog();
            }
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Transfire_BankStock", "User_StockBank");
            if (check == true)
            {
                Frm_StockBankTransfire frm = new Frm_StockBankTransfire();
                frm.ShowDialog();
            }
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Current_Money", "User_StockBank");
            if (check == true)
            {
                Frm_currentMoney frm = new Frm_currentMoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("StockBank_Report", "User_StockBank");
            if (check == true)
            {
                Frm_StockAddMoneyReport frm = new Frm_StockAddMoneyReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("StockBank_Report", "User_StockBank");
            if (check == true)
            {
                Frm_BankAddMoneyReport frm = new Frm_BankAddMoneyReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("StockBank_Report", "User_StockBank");
            if (check == true)
            {
                Frm_StockPullMoneyReport frm = new Frm_StockPullMoneyReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("StockBank_Report", "User_StockBank");
            if (check == true)
            {
                Frm_BankPullMoneyReport frm = new Frm_BankPullMoneyReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("StockBank_Report", "User_StockBank");
            if (check == true)
            {
                Frm_StockTransfireReport frm = new Frm_StockTransfireReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("StockBank_Report", "User_StockBank");
            if (check == true)
            {
                Frm_StockBankTransfireReport frm = new Frm_StockBankTransfireReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Add_Emp", "User_Emp");
            if (check == true)
            {
                Frm_Employee frm = new Frm_Employee();
                frm.ShowDialog();
            }
        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Borrow_Items", "User_Emp");
            if (check == true)
            {
                Frm_EmployeeBorrowItems frm = new Frm_EmployeeBorrowItems();
                frm.ShowDialog();
            }
        }

        private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Borrow_Money", "User_Emp");
            if (check == true)
            {
                Frm_EmployeeBorrowMoney frm = new Frm_EmployeeBorrowMoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Salary", "User_Emp");
            if (check == true)
            {
                Frm_EmployeeSalary frm = new Frm_EmployeeSalary();
                frm.ShowDialog();
            }
        }

        private void barButtonItem48_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Borrow_ItemsReport", "User_Emp");
            if (check == true)
            {
                Frm_EmployeeBorrowItemsReport frm = new Frm_EmployeeBorrowItemsReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem50_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Borrow_MoneyReport", "User_Emp");
            if (check == true)
            {
                Frm_EmployeeBorrowMoneyReport frm = new Frm_EmployeeBorrowMoneyReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem49_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("SalaryReport", "User_Emp");
            if (check == true)
            {
                Frm_EmployeeSalaryReport frm = new Frm_EmployeeSalaryReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem51_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("SanadKabd", "User_Deserved");
            if (check == true)
            {
                Frm_SanadKabd frm = new Frm_SanadKabd();
                frm.ShowDialog();
            }
        }

        private void barButtonItem52_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("SanadSarf", "User_Deserved");
            if (check == true)
            {
                Frm_SanadSarf frm = new Frm_SanadSarf();
                frm.ShowDialog();
            }
        }

        private void barButtonItem53_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("SanadReport", "User_Deserved");
            if (check == true)
            {
                Frm_SanadReport frm = new Frm_SanadReport();
                frm.ShowDialog();
            }
        }
        Database db = new Database();
        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool check = checkUser("TakeBackUp", "User_BackUp");
            if (check == true)
            {
                try
                {
                    string d = DateTime.Now.Date.ToString("dd-MM-yyyy");
                    SaveFileDialog open = new SaveFileDialog();

                    open.Filter = "BackUp Files (*.Back) | *.back";
                    open.FileName = "Sales_BackUP_" + d + "";

                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        db.exceuteData("backup database Sales_System To Disk='" + open.FileName + "'", "تم اخذ نسخه احتياطية بنجاح");
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("ReturnBackUp", "User_BackUp");
            if (check == true)
            {
                Server server = new Server(@".\SQLEXPRESS");

                Microsoft.SqlServer.Management.Smo.Database db = server.Databases["Sales_System"];

                if (db != null)
                {
                    server.KillAllProcesses(db.Name);
                }

                Restore restore = new Restore();

                restore.Database = db.Name;
                restore.Action = RestoreActionType.Database;

                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "BackUp Files (*.Back) | *.back";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    restore.Devices.AddDevice(open.FileName, DeviceType.File);
                    restore.ReplaceDatabase = true;
                    restore.NoRecovery = false;
                    restore.SqlRestore(server);
                    MessageBox.Show("تم استرجاع السنخه الاحتياطية بنجاح", "تاكيد");
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("User_Permisson", "User_Setting");
            if (check == true)
            {
                Frm_Permission frm = new Frm_Permission();
                frm.ShowDialog();
            }
        }

        private void barButtonItem54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Unit", "User_Setting");
            if (check == true)
            {
                Frm_Unit frm = new Frm_Unit();
                frm.ShowDialog();
            }
        }

        private void barButtonItem55_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Item_Group", "User_Setting");
            if (check == true)
            {
                Frm_ProductGroup frm = new Frm_ProductGroup();
                frm.ShowDialog();
            }
        }

        private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Store_Add", "User_Setting");
            if (check == true)
            {
                Frm_Store frm = new Frm_Store();
                frm.ShowDialog();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Item_View", "User_Setting");
            if (check == true)
            {
                Frm_ViewItem frm = new Frm_ViewItem();
                frm.ShowDialog();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Setting", "User_Setting");
            if (check == true)
            {
                Frm_Setting frm = new Frm_Setting();
                frm.ShowDialog();
            }
        }

        private void barButtonItem57_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Store_Gard", "User_Setting");
            if (check == true)
            {
                Frm_StoreGard frm = new Frm_StoreGard();
                frm.ShowDialog();
            }
        }

        private void barButtonItem58_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Store_Transfire", "User_Setting");
            if (check == true)
            {
                Frm_Storetransfire frm = new Frm_Storetransfire();
                frm.ShowDialog();
            }
        }

        private void barButtonItem59_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Store_TransfireReport", "User_Setting");
            if (check == true)
            {
                Frm_StoretransfireReport frm = new Frm_StoretransfireReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem60_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Store_Out", "User_Setting");
            if (check == true)
            {
                Frm_ProductsOutStore frm = new Frm_ProductsOutStore();
                frm.ShowDialog();
            }
        }

        private void barButtonItem61_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("Store_OutReport", "User_Setting");
            if (check == true)
            {
                Frm_ProductsOutStoreReport frm = new Frm_ProductsOutStoreReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem62_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkUser("TaxesReport", "User_Deserved");
            if (check == true)
            {
                Frm_TaxesReport frm = new Frm_TaxesReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkUser("User_Permisson", "User_Setting");
            if (check == true)
            {
                Frm_Permission frm = new Frm_Permission();
                frm.ShowDialog();
            }
        }

        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkUser("Supp_Money", "User_Supplier");
            if (check == true)
            {
                Frm_SupplierMoney frm = new Frm_SupplierMoney();
                frm.ShowDialog();
            }
        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkUser("Item_Add", "User_Setting");
            if (check == true)
            {
                Frm_Products frm = new Frm_Products();
                frm.ShowDialog();
            }
        }

        private void tileItem10_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkUser("CustomerMoney", "User_Customer");
            if (check == true)
            {
                Frm_CustomerMoney frm = new Frm_CustomerMoney();
                frm.ShowDialog();
            }
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkUser("Buy", "User_Buy");
            if (check == true)
            {
                Frm_Buy frm = new Frm_Buy();
                frm.ShowDialog();
            }
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkUser("Sale", "User_Sale");
            if (check == true)
            {
                Frm_Sales frm = new Frm_Sales();
                frm.ShowDialog();
            }
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkUser("Current_Money", "User_StockBank");
            if (check == true)
            {
                Frm_currentMoney frm = new Frm_currentMoney();
                frm.ShowDialog();
            }
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkUser("Return_", "User_Return");
            if (check == true)
            {
                Frm_Return frm = new Frm_Return();
                frm.ShowDialog();
            }
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkUser("SaleRb7h", "User_Sale");
            if (check == true)
            {
                Frm_SalesRb7h frm = new Frm_SalesRb7h();
                frm.ShowDialog();
            }
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_ProductsReauerd frm = new Frm_ProductsReauerd();
            frm.ShowDialog();
        }
    }
}
