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
    public partial class Frm_ProductsOutStore : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ProductsOutStore()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();


        private void FillPro()
        {
            cbxProducts.DataSource = db.readData("select * from Products", "");
            cbxProducts.DisplayMember = "Pro_Name";
            cbxProducts.ValueMember = "Pro_ID";
        }

        private void FillStore()
        {
            cbxStoreFrom.DataSource = db.readData("select * from Store", "");
            cbxStoreFrom.DisplayMember = "Store_Name";
            cbxStoreFrom.ValueMember = "Store_ID";
            
        }
        private void Frm_ProductsOutStore_Load(object sender, EventArgs e)
        {
            FillStore();
            FillPro();
        }

        private void cbxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cbxUnit.DataSource = db.readData("select * from Products_Unit where Pro_ID=" + cbxProducts.SelectedValue + "", "");
                cbxUnit.DisplayMember = "Unit_Name";
                cbxUnit.ValueMember = "Unit_ID";
            }
            catch (Exception) { }
        }
        //call to update qty in store
        private void updateQtyInStore(int pro_ID, decimal realQty)
        {
            DataTable tblQty = new DataTable();
            decimal QtyInStoreFirstRaw = 0;
            db.exceuteData("delete from Products_Qty where Qty <=0", "");

            tblQty.Clear();
            tblQty = db.readData("select Top 1 * from Products_Qty where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");

            QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);
            if (QtyInStoreFirstRaw - realQty >= 1)
            {
                db.exceuteData("update Products_Qty set Qty=Qty - " + realQty + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");

            }
            else if (QtyInStoreFirstRaw - realQty == 0)
            {
                db.exceuteData("update Products_Qty set Qty=Qty - " + realQty + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                db.exceuteData("delete Products_Qty where Qty <= 0", "");
            }
            else if (QtyInStoreFirstRaw - realQty < 0)
            {

                db.exceuteData("update Products_Qty set Qty=Qty - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                db.exceuteData("delete Products_Qty where Qty <= 0", "");

                decimal baky = Math.Abs(QtyInStoreFirstRaw - realQty);

                tblQty.Clear();
                tblQty = db.readData("select Top 1 * from Products_Qty where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");

                QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                if (QtyInStoreFirstRaw - baky >= 0)
                {
                    db.exceuteData("update Products_Qty set Qty=Qty - " + baky + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                    db.exceuteData("delete Products_Qty where Qty <= 0", "");

                }
                else if (QtyInStoreFirstRaw - baky < 0)
                {
                    decimal secondbaky = Math.Abs(QtyInStoreFirstRaw - baky);
                    db.exceuteData("update Products_Qty set Qty=Qty - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                    db.exceuteData("delete Products_Qty where Qty <= 0", "");

                    tblQty.Clear();
                    tblQty = db.readData("select Top 1 * from Products_Qty where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");

                    QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                    if (QtyInStoreFirstRaw - secondbaky >= 0)
                    {
                        db.exceuteData("update Products_Qty set Qty=Qty - " + secondbaky + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                        db.exceuteData("delete Products_Qty where Qty <= 0", "");
                    }
                    else if (QtyInStoreFirstRaw - secondbaky < 0)
                    {
                        decimal thirdbaky = Math.Abs(QtyInStoreFirstRaw - secondbaky);
                        db.exceuteData("update Products_Qty set Qty=Qty - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                        db.exceuteData("delete Products_Qty where Qty <= 0", "");

                        tblQty.Clear();
                        tblQty = db.readData("select Top 1 * from Products_Qty where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");

                        QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);
                        if (QtyInStoreFirstRaw - thirdbaky >= 0)
                        {
                            db.exceuteData("update Products_Qty set Qty=Qty - " + thirdbaky + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                            db.exceuteData("delete Products_Qty where Qty <= 0", "");
                        }
                        else if (QtyInStoreFirstRaw - thirdbaky < 0)
                        {
                            decimal forthbaky = Math.Abs(QtyInStoreFirstRaw - thirdbaky);
                            db.exceuteData("update Products_Qty set Qty=Qty - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                            db.exceuteData("delete Products_Qty where Qty <= 0", "");


                            tblQty.Clear();
                            tblQty = db.readData("select Top 1 * from Products_Qty where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "");

                            QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                            if (QtyInStoreFirstRaw - forthbaky >= 0)
                            {
                                db.exceuteData("update Products_Qty set Qty=Qty - " + forthbaky + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                db.exceuteData("delete Products_Qty where Qty <= 0", "");
                            }
                            else if (QtyInStoreFirstRaw - forthbaky < 0)
                            {
                                db.exceuteData("update Products_Qty set Qty=Qty - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + " and Qty=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                db.exceuteData("delete Products_Qty where Qty <= 0", "");
                            }
                        }
                    }
                }

            }

        }
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtBarcode.Text != "")
                {
                    tbl.Clear();
                    tbl = db.readData("select * from Products where Barcode =N'" + txtBarcode.Text + "'", "");
                    if (tbl.Rows.Count >= 1)
                    {
                        cbxProducts.SelectedValue = Convert.ToDecimal(tbl.Rows[0][0]);
                    }

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbxProducts.Items.Count >= 1)
            {
                if(cbxUnit.Items.Count >=1)
                {
                    if (cbxStoreFrom.Items.Count >= 1)
                    {


                        DataTable tblUnit = new DataTable();
                        decimal QtyInMain = 0, realQty = 0, totalQtyInStore = 0;
                        try
                        {
                            int pro_ID = Convert.ToInt32(cbxProducts.SelectedValue);
                            tbl.Clear();
                            tbl = db.readData("select * from Products_Unit where Pro_ID=" + pro_ID + " and Unit_Name=N'" + cbxUnit.Text + "'", "");
                            try
                            {
                                QtyInMain = Convert.ToDecimal(tbl.Rows[0][3]);
                            }
                            catch (Exception) { }

                            if (QtyInMain > 1)
                            {
                                realQty = NudQty.Value / QtyInMain;
                            }
                            else
                            {
                                realQty = NudQty.Value;
                            }

                            try
                            {
                                totalQtyInStore = Convert.ToDecimal(db.readData("select sum(Qty) from Products_Qty where Pro_ID=" + pro_ID + " and Store_ID=" + cbxStoreFrom.SelectedValue + "", "").Rows[0][0]);
                            }
                            catch (Exception) { }

                            if (totalQtyInStore - realQty < 0)
                            {
                                MessageBox.Show("الكمية المراد اخرجها غير موجود فى المخزن حاليا", "تاكيد");
                                return;
                            }

                            updateQtyInStore(pro_ID, realQty);
                            insertIntoProductOutStore();
                            MessageBox.Show("تمت عملية الاخراج بنجاح", "تاكيد");
                            autonumber();
                        }
                        catch (Exception) { }

                    }
                }
            }
        }



        private void insertIntoProductOutStore()
        {
            string d = DtpDate.Value.ToString("dd/MM/yyyy");
            db.exceuteData("insert into Products_OutStore (Pro_ID,Pro_Name,Store_Name,Qty,Unit,Date,Name,Reason) Values (" + cbxProducts.SelectedValue + " ,N'" + cbxProducts.Text + "' ,N'" + cbxStoreFrom.Text + "'  ," + NudQty.Value + " ,N'" + cbxUnit.Text + "' , N'" + d + "' ,N'" + txtName.Text + "' ,N'" + txtReason.Text + "')", "");
        }
        private void autonumber()
        {
            try
            {
                cbxProducts.SelectedIndex = 0;
                cbxStoreFrom.SelectedIndex = 0;
                cbxUnit.SelectedIndex = 0;
                NudQty.Value = 1;
                txtName.Clear();
                txtReason.Clear();
            }
            catch (Exception) { }
        }
    }
}