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
    public partial class Frm_Products : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Products()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (Pro_ID) from Products", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {

                txtID.Text = "1";
            }
            else
            {

                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            if(Properties.Settings.Default.Taxes == true)
            {
                checkTaxes.Checked = true;
            }
            else
            {
                checkTaxes.Checked = false;
            }
            txtBarcode.Clear();
            txtProName.Clear();
            txtProNameSearch.Clear();
            NudSalePrice.Value = 1;
            NudMinQty.Value = 0;
            NudQtyStore.Value = 1;
            NudBuyPriceStore.Value = 1;
            NudMAxDiscount.Value = 0;
            NudAllQty.Value = 0;
            NudUnitPrice.Value = 1;
            NudQtyInMain.Value = 1;
            try
            {
                FillPro();
            }
            catch (Exception) { }
            try
            {
                cbxMainUnit.SelectedIndex = 0;
                cbxUnitSale.SelectedIndex = 0;
                cbxUnitBuy.SelectedIndex = 0;
                cbxGroup.SelectedIndex = 0;
            }catch(Exception) { }
            try
            {
                DgvStore.Rows.Clear();
                DgvUnits.Rows.Clear();
            }
            catch (Exception) { }
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnSave.Enabled = false;
            btnPrintBarcode.Enabled = false;
        }

        int row;
        private void Show()
        {
            tbl.Clear();
            tbl = db.readData("select * from Products", "");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات فى هذه الشاشه");
            }
            else
            {
                try
                {
                    txtID.Text = tbl.Rows[row][0].ToString();
                    txtProName.Text =tbl.Rows[row][1].ToString();
                    NudAllQty.Value = Convert.ToDecimal(tbl.Rows[row][2]);
                    NudGomlaPrice.Value = Convert.ToDecimal(tbl.Rows[row][3]);
                    NudSalePrice.Value = Convert.ToDecimal(tbl.Rows[row][4]);
                    Nudtax.Value = Convert.ToDecimal(tbl.Rows[row][5]);

                    txtSalePriceTax.Text = tbl.Rows[row][6].ToString();
                    txtBarcode.Text = tbl.Rows[row][7].ToString();
                    NudMinQty.Value = Convert.ToDecimal(tbl.Rows[row][8]);
                    NudMAxDiscount.Value = Convert.ToDecimal(tbl.Rows[row][9]);
                    if (tbl.Rows[row][10].ToString() == "خاضع للضريبة")
                    {
                        checkTaxes.Checked = true;
                    }
                    else
                    {
                        checkTaxes.Checked = false;
                    }
                    cbxGroup.SelectedValue = Convert.ToDecimal(tbl.Rows[row][11]);
                    cbxMainUnit.SelectedValue = Convert.ToDecimal(tbl.Rows[row][13]);
                    cbxUnitSale.SelectedValue = Convert.ToDecimal(tbl.Rows[row][15]);
                    cbxUnitBuy.SelectedValue = Convert.ToDecimal(tbl.Rows[row][17]);
                }
                catch (Exception) { }


                try {

                    DataTable tblStore = new DataTable();
                    tblStore.Clear();
                    tblStore = db.readData("select * from Products_Qty where Pro_ID="+txtID.Text+"", "");
                    DgvStore.Rows.Clear();
                    if (tblStore.Rows.Count >= 1)
                    {
                        foreach (DataRow row in tblStore.Rows) {
                            DgvStore.Rows.Add(1);
                            int indexrow = DgvStore.Rows.Count - 1;
                            DgvStore.Rows[indexrow].Cells[0].Value = row[2];
                            DgvStore.Rows[indexrow].Cells[1].Value = row[3];
                            DgvStore.Rows[indexrow].Cells[2].Value = row[4];
                        }
                    }

                } catch(Exception) { }

                try
                {

                    DataTable tblunit = new DataTable();
                    tblunit.Clear();
                    tblunit = db.readData("select * from Products_Unit where Pro_ID=" + txtID.Text + "", "");
                    DgvUnits.Rows.Clear();
                    if (tblunit.Rows.Count >= 1)
                    {
                        foreach (DataRow row in tblunit.Rows)
                        {
                            DgvUnits.Rows.Add(1);
                            int indexrow = DgvUnits.Rows.Count - 1;
                            DgvUnits.Rows[indexrow].Cells[0].Value = row[2];
                            DgvUnits.Rows[indexrow].Cells[1].Value = row[3];
                            DgvUnits.Rows[indexrow].Cells[2].Value = row[4];
                        }
                    }

                }
                catch (Exception) { }
            }

            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
            btnPrintBarcode.Enabled = true;
        }

        private void FillPro()
        {
            cbxProducts.DataSource = db.readData("select * from Products", "");
            cbxProducts.DisplayMember = "Pro_Name";
            cbxProducts.ValueMember = "Pro_ID";
        }
        private void fillGroups()
        {
            cbxGroup.DataSource = db.readData("select * from Products_Group", "");
            cbxGroup.DisplayMember = "Group_Name";
            cbxGroup.ValueMember = "Group_ID";
        }
        private void fillStore()
        {
            cbxStore.DataSource = db.readData("select * from Store", "");
            cbxStore.DisplayMember = "Store_Name";
            cbxStore.ValueMember = "Store_ID";
        }
        private void fillUnit()
        {
            cbxMainUnit.DataSource = db.readData("select * from Unit", "");
            cbxMainUnit.DisplayMember = "Unit_Name";
            cbxMainUnit.ValueMember = "Unit_ID";

            cbxUnitSale.DataSource = db.readData("select * from Unit", "");
            cbxUnitSale.DisplayMember = "Unit_Name";
            cbxUnitSale.ValueMember = "Unit_ID";

            cbxUnitBuy.DataSource = db.readData("select * from Unit", "");
            cbxUnitBuy.DisplayMember = "Unit_Name";
            cbxUnitBuy.ValueMember = "Unit_ID";
            cbxUnit.DataSource = db.readData("select * from Unit", "");
            cbxUnit.DisplayMember = "Unit_Name";
            cbxUnit.ValueMember = "Unit_ID";
        }
        private void Frm_Products_Load(object sender, EventArgs e)
        {
            try
            {
                fillUnit();
                fillGroups();
                fillStore();
                AutoNumber();
            }
            catch (Exception) { }
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
                tbl = db.readData("select count(Pro_ID) from Products", "");
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
            tbl = db.readData("select count(Pro_ID) from Products", "");
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
            tbl = db.readData("select count(Pro_ID) from Products", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber(); 
        }

        //called when user add new products
        private bool productValidation()
        {
            if (txtProName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المنتج اولا");
                return false;
            }

            if (NudSalePrice.Value <= 0)
            {
                MessageBox.Show("لا يمكن ان يكون سعر البيع اقل من 1");
                return false; ;
            }
            if (NudMAxDiscount.Value >= NudSalePrice.Value)
            {
                MessageBox.Show("لا يمكن ان يكون الخصم المسموح اكبر من سعر البيع");
                return false; ;
            }

            if (NudMinQty.Value > NudAllQty.Value)
            {
                MessageBox.Show("لا يمكن ان يكون حد الطلب اكبر من الكميه الموجوده");
                return false; ;
            }
            if (NudGomlaPrice.Value > Convert.ToDecimal(txtSalePriceTax.Text))
            {
                MessageBox.Show("لا يمكن ان يكون سعر الجمله اكبر من سعر التجزئه");
                return false; ;
            }

            if (cbxMainUnit.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل الوحدات اولا");
                return false; ;
            }
            if (cbxGroup.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل التصنيفات اولا");
                return false; ;
            }
            if (DgvStore.Rows.Count <= 0)
            {
                MessageBox.Show("لا يمكن اضافه المنتج قبل اضافه كمية له على الاقل");
                return false; ;
            }

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = false;
            check = productValidation();
            if (check == true)
            {

                string is_Tax = "";
                if (checkTaxes.Checked == true)
                {
                    is_Tax = "خاضع للضريبة";
                }
                else
                {
                    is_Tax = "غير خاضع للضريبة";
                }
                db.exceuteData("insert into Products Values (" + txtID.Text + " ,N'" + txtProName.Text + "' ," + NudAllQty.Value + " ," + NudGomlaPrice.Value + " ," + NudSalePrice.Value + " ," + Nudtax.Value + " ," + txtSalePriceTax.Text + " ,N'" + txtBarcode.Text + "' , " + NudMinQty.Value + " , " + NudMAxDiscount.Value + ",N'" + is_Tax + "' ," + cbxGroup.SelectedValue + " ,N'" + cbxMainUnit.Text + "' ," + cbxMainUnit.SelectedValue + " ,N'" + cbxUnitSale.Text + "' ," + cbxUnitSale.SelectedValue + " ,N'" + cbxUnitBuy.Text + "' ," + cbxUnitBuy.SelectedValue + ")", "");
                for (int i = 0; i <= DgvStore.Rows.Count - 1; i++)
                {
                    int store_ID = 0;
                    try
                    {
                        store_ID = Convert.ToInt32(db.readData("select * from Store where Store_Name=N'" + DgvStore.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception) { }
                    db.exceuteData("insert into Products_Qty values (" + txtID.Text + " ," + store_ID + " ,N'" + DgvStore.Rows[i].Cells[0].Value + "' ," + DgvStore.Rows[i].Cells[1].Value + " , " + DgvStore.Rows[i].Cells[2].Value + " ," + txtSalePriceTax.Text + ")", "");
                }

                for (int i = 0; i <= DgvUnits.Rows.Count - 1; i++)
                {
                    int unit_ID = 0;
                    try
                    {
                        unit_ID = Convert.ToInt32(db.readData("select * from Unit where Unit_Name=N'" + DgvUnits.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception) { }
                    db.exceuteData("insert into Products_Unit values (" + txtID.Text + " ," + unit_ID + " ,N'" + DgvUnits.Rows[i].Cells[0].Value + "' ," + DgvUnits.Rows[i].Cells[1].Value + " , " + DgvUnits.Rows[i].Cells[2].Value + " ," + txtSalePriceTax.Text + ")", "");
                   
                }

                db.exceuteData("insert into Products_Unit values (" + txtID.Text + " ," + cbxMainUnit.SelectedValue + " ,N'" + cbxMainUnit.Text + "' ,1 , " + txtSalePriceTax.Text + " ," + txtSalePriceTax.Text + ")", "");
                MessageBox.Show("تم اضافة بيانات المنتج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoNumber();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = false;
            check = productValidation();
            if (check == true)
            {

                string is_Tax = "";
                if (checkTaxes.Checked == true)
                {
                    is_Tax = "خاضع للضريبة";
                }
                else
                {
                    is_Tax = "غير خاضع للضريبة";
                }
                db.exceuteData("update  Products set Pro_Name=N'" + txtProName.Text + "' ,Qty=" + NudAllQty.Value + " ,Gomla_Price=" + NudGomlaPrice.Value + " ,Sale_Price=" + NudSalePrice.Value + " ,Tax_Value=" + Nudtax.Value + " ,Sale_PriceTax=" + txtSalePriceTax.Text + " ,Barcode=N'" + txtBarcode.Text + "' ,MinQty= " + NudMinQty.Value + " , MaxDiscount=" + NudMAxDiscount.Value + ",IS_Tax=N'" + is_Tax + "' ,Group_ID=" + cbxGroup.SelectedValue + " ,Main_UnitName=N'" + cbxMainUnit.Text + "' ,Main_UnitID=" + cbxMainUnit.SelectedValue + " ,Sale_UnitName=N'" + cbxUnitSale.Text + "' ,Sale_UnitID=" + cbxUnitSale.SelectedValue + " ,Buy_UnitName=N'" + cbxUnitBuy.Text + "' ,Buy_UnitID=" + cbxUnitBuy.SelectedValue + " where Pro_ID="+txtID.Text+"", "");


                db.exceuteData("delete from Products_Qty where Pro_ID="+txtID.Text+"", "");
                for (int i = 0; i <= DgvStore.Rows.Count - 1; i++)
                {
                    int store_ID = 0;
                    try
                    {
                        store_ID = Convert.ToInt32(db.readData("select * from Store where Store_Name=N'" + DgvStore.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception) { }
                    db.exceuteData("insert into Products_Qty values (" + txtID.Text + " ," + store_ID + " ,N'" + DgvStore.Rows[i].Cells[0].Value + "' ," + DgvStore.Rows[i].Cells[1].Value + " , " + DgvStore.Rows[i].Cells[2].Value + " ," + txtSalePriceTax.Text + ")", "");
                }
                db.exceuteData("delete from Products_Unit where Pro_ID=" + txtID.Text + "", "");
                for (int i = 0; i <= DgvUnits.Rows.Count - 1; i++)
                {
                    int unit_ID = 0;
                    try
                    {
                        unit_ID = Convert.ToInt32(db.readData("select * from Unit where Unit_Name=N'" + DgvUnits.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception) { }
                    db.exceuteData("insert into Products_Unit values (" + txtID.Text + " ," + unit_ID + " ,N'" + DgvUnits.Rows[i].Cells[0].Value + "' ," + DgvUnits.Rows[i].Cells[1].Value + " , " + DgvUnits.Rows[i].Cells[2].Value + " ," + txtSalePriceTax.Text + ")", "");

                }
                string unit_Name = cbxMainUnit.Text;

                for (int i = 0; i <= DgvUnits.Rows.Count - 1; i++)
                {
                    if (unit_Name == Convert.ToString(DgvUnits.Rows[i].Cells[0].Value))
                    {
                        MessageBox.Show("تم حفظ البيانات بيانات المنتج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AutoNumber();
                        return;
                    }
                }
                db.exceuteData("insert into Products_Unit values (" + txtID.Text + " ," + cbxMainUnit.SelectedValue + " ,N'" + cbxMainUnit.Text + "' ,1 , " + txtSalePriceTax.Text + " ," + txtSalePriceTax.Text + ")", "");
                MessageBox.Show("تم حفظ البيانات بيانات المنتج", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoNumber();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Products_Qty where Pro_ID=" + txtID.Text + "", "");
                db.readData("delete from Products_Unit where Pro_ID=" + txtID.Text + "", "");
                db.readData("delete from Products where Pro_ID=" + txtID.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متاكد من مسح البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Products_Qty ", "");
                db.readData("delete from Products_Unit ", "");
                db.readData("delete from Products where ", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtProNameSearch.Text != "") {

                DataTable tblSearch = new DataTable();
                tblSearch.Clear();

                tblSearch = db.readData("select * from Products where Pro_Name Like N'%"+txtProNameSearch.Text+"%' ", "");

                if (tblSearch.Rows.Count <= 0)
                {
                    MessageBox.Show("لا يوجد منتج بهذا الاسم");
                }
                else
                {
                    try
                    {
                        txtID.Text = tblSearch.Rows[0][0].ToString();
                        txtProName.Text = tblSearch.Rows[0][1].ToString();
                        NudAllQty.Value = Convert.ToDecimal(tblSearch.Rows[0][2]);
                        NudSalePrice.Value = Convert.ToDecimal(tblSearch.Rows[0][4]);
                        txtBarcode.Text = tblSearch.Rows[0][5].ToString();
                        NudMinQty.Value = Convert.ToDecimal(tblSearch.Rows[0][6]);
                        NudMAxDiscount.Value = Convert.ToDecimal(tblSearch.Rows[0][7]);
                    }
                    catch (Exception) { }
                }

                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void cbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void cbxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cbxProducts.Items.Count >= 1)
            {
                DataTable tblSearch = new DataTable();
                tblSearch.Clear();
                tblSearch = db.readData("select * from Products where Pro_ID="+cbxProducts.SelectedValue+"", "");

                if (tblSearch.Rows.Count <= 0)
                {
                }
                else
                {
                    try
                    {
                        txtID.Text = tblSearch.Rows[0][0].ToString();
                        txtProName.Text = tblSearch.Rows[0][1].ToString();
                        NudAllQty.Value = Convert.ToDecimal(tblSearch.Rows[0][2]);
                        NudGomlaPrice.Value = Convert.ToDecimal(tblSearch.Rows[0][3]);
                        NudSalePrice.Value = Convert.ToDecimal(tblSearch.Rows[0][4]);
                        Nudtax.Value = Convert.ToDecimal(tblSearch.Rows[0][5]);

                        txtSalePriceTax.Text = tblSearch.Rows[0][6].ToString();
                        txtBarcode.Text = tblSearch.Rows[0][7].ToString();
                        NudMinQty.Value = Convert.ToDecimal(tblSearch.Rows[0][8]);
                        NudMAxDiscount.Value = Convert.ToDecimal(tblSearch.Rows[0][9]);
                        if (tblSearch.Rows[0][10].ToString() == "خاضع للضريبة")
                        {
                            checkTaxes.Checked = true;
                        }
                        else
                        {
                            checkTaxes.Checked = false;
                        }
                        cbxGroup.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][11]);
                        cbxMainUnit.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][13]);
                        cbxUnitSale.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][15]);
                        cbxUnitBuy.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][17]);
                    }
                    catch (Exception) { }


                    try
                    {

                        DataTable tblStore = new DataTable();
                        tblStore.Clear();
                        tblStore = db.readData("select * from Products_Qty where Pro_ID=" + txtID.Text + "", "");
                        DgvStore.Rows.Clear();
                        if (tblStore.Rows.Count >= 1)
                        {
                            foreach (DataRow row in tblStore.Rows)
                            {
                                DgvStore.Rows.Add(1);
                                int indexrow = DgvStore.Rows.Count - 1;
                                DgvStore.Rows[indexrow].Cells[0].Value = row[2];
                                DgvStore.Rows[indexrow].Cells[1].Value = row[3];
                                DgvStore.Rows[indexrow].Cells[2].Value = row[4];
                            }
                        }

                    }
                    catch (Exception) { }

                    try
                    {

                        DataTable tblunit = new DataTable();
                        tblunit.Clear();
                        tblunit = db.readData("select * from Products_Unit where Pro_ID=" + txtID.Text + "", "");
                        DgvUnits.Rows.Clear();
                        if (tblunit.Rows.Count >= 1)
                        {
                            foreach (DataRow row in tblunit.Rows)
                            {
                                DgvUnits.Rows.Add(1);
                                int indexrow = DgvUnits.Rows.Count - 1;
                                DgvUnits.Rows[indexrow].Cells[0].Value = row[2];
                                DgvUnits.Rows[indexrow].Cells[1].Value = row[3];
                                DgvUnits.Rows[indexrow].Cells[2].Value = row[4];
                            }
                        }

                    }
                    catch (Exception) { }
                }

                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
                btnSave.Enabled = true;
                btnPrintBarcode.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NudSalePrice_ValueChanged(object sender, EventArgs e)
        {
            try {
                decimal taxVal = 0, salePrice = 0;
                salePrice = NudSalePrice.Value;
                taxVal = (salePrice / 100) * Nudtax.Value;
                if (checkTaxes.Checked == true)
                {
                    txtSalePriceTax.Text = (salePrice + taxVal).ToString(); 
                }
                else
                {
                    txtSalePriceTax.Text = (salePrice ).ToString();
                }

            } catch (Exception) { }
        }

        private void checkTaxes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTaxes.Checked == true)
            {
                Nudtax.Value = 5;
            }else
            {
                Nudtax.Value = 0;
            }
        }

        private void Nudtax_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal taxVal = 0, salePrice = 0;
                salePrice = NudSalePrice.Value;
                taxVal = (salePrice / 100) * Nudtax.Value;
                if (checkTaxes.Checked == true)
                {
                    txtSalePriceTax.Text = (salePrice + taxVal).ToString();
                }
                else
                {
                    txtSalePriceTax.Text = (salePrice).ToString();
                }

            }
            catch (Exception) { }
        }

        private void btnAddQty_Click(object sender, EventArgs e)
        {
            if (cbxStore.Items.Count >= 1)
            {

                if (NudBuyPriceStore.Value <=0 || NudQtyStore.Value <= 0)
                {
                    MessageBox.Show("من فضلك ادخل الكمية و سعر الشراء");
                    return;
                }

                DgvStore.Rows.Add(1);
                int indexrow = DgvStore.Rows.Count - 1;
                DgvStore.Rows[indexrow].Cells[0].Value = cbxStore.Text;
                DgvStore.Rows[indexrow].Cells[1].Value = NudQtyStore.Value;
                DgvStore.Rows[indexrow].Cells[2].Value = NudBuyPriceStore.Value;

                decimal total = 0;
                for (int i=0; i <= DgvStore.Rows.Count - 1; i++)
                {
                    total +=Convert.ToDecimal( DgvStore.Rows[i].Cells[1].Value);
                }

                NudAllQty.Value = total;
            }
        }

        private void btnRemoveStore_Click(object sender, EventArgs e)
        {
            if(DgvStore.Rows.Count >= 1)
            {
                DgvStore.Rows.RemoveAt(DgvStore.CurrentCell.RowIndex);
                decimal total = 0;
                for (int i = 0; i <= DgvStore.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(DgvStore.Rows[i].Cells[1].Value);
                }

                NudAllQty.Value = total;
            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (cbxUnit.Items.Count >= 1)
            {

                if (NudQtyInMain.Value <= 0 || NudUnitPrice.Value <= 0)
                {
                    MessageBox.Show("من فضلك ادخل عدد القطع و سعر الوحدة");
                    return;
                }
                if (Convert.ToInt32(cbxUnit.SelectedValue) == Convert.ToInt32(cbxMainUnit.SelectedValue))
                {
                    MessageBox.Show("لا مكن اختيار الوحدة الصغرى مثل الوحدة الكبرى","من فضلك راجع الوحدات");
                    return;
                }

                string unit_Name = cbxUnit.Text;

                for (int i=0;i <=DgvUnits.Rows.Count - 1; i++)
                {
                    if(unit_Name == Convert.ToString(DgvUnits.Rows[i].Cells[0].Value))
                    {
                        MessageBox.Show("هذه الوحدة تم اضافتها من قبل", "تاكيد");
                        return;
                    }
                }

                DgvUnits.Rows.Add(1);
                int indexrow = DgvUnits.Rows.Count - 1;
                DgvUnits.Rows[indexrow].Cells[0].Value = cbxUnit.Text;
                DgvUnits.Rows[indexrow].Cells[1].Value = NudQtyInMain.Value;
                DgvUnits.Rows[indexrow].Cells[2].Value = NudUnitPrice.Value;

                
            }
        }

        private void btnRemoveUnit_Click(object sender, EventArgs e)
        {
            if (DgvUnits.Rows.Count >= 1)
            {
                DgvUnits.Rows.RemoveAt(DgvUnits.CurrentCell.RowIndex);
               
            }
        }

        private void NudQtyInMain_ValueChanged(object sender, EventArgs e)
        {
            try {
                NudUnitPrice.Value =Convert.ToDecimal( txtSalePriceTax.Text )/ NudQtyInMain.Value;

            } catch (Exception) { }
        }

        private void txtSearchBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if (txtSearchBarcode.Text != "")
                {
                    DataTable tblSearch = new DataTable();
                    tblSearch.Clear();
                    tblSearch = db.readData("select * from Products where Barcode=N'" + txtSearchBarcode.Text+ "'", "");

                    if (tblSearch.Rows.Count <= 0)
                    {
                    }
                    else
                    {
                        try
                        {
                            txtID.Text = tblSearch.Rows[0][0].ToString();
                            txtProName.Text = tblSearch.Rows[0][1].ToString();
                            NudAllQty.Value = Convert.ToDecimal(tblSearch.Rows[0][2]);
                            NudGomlaPrice.Value = Convert.ToDecimal(tblSearch.Rows[0][3]);
                            NudSalePrice.Value = Convert.ToDecimal(tblSearch.Rows[0][4]);
                            Nudtax.Value = Convert.ToDecimal(tblSearch.Rows[0][5]);

                            txtSalePriceTax.Text = tblSearch.Rows[0][6].ToString();
                            txtBarcode.Text = tblSearch.Rows[0][7].ToString();
                            NudMinQty.Value = Convert.ToDecimal(tblSearch.Rows[0][8]);
                            NudMAxDiscount.Value = Convert.ToDecimal(tblSearch.Rows[0][9]);
                            if (tblSearch.Rows[0][10].ToString() == "خاضع للضريبة")
                            {
                                checkTaxes.Checked = true;
                            }
                            else
                            {
                                checkTaxes.Checked = false;
                            }
                            cbxGroup.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][11]);
                            cbxMainUnit.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][13]);
                            cbxUnitSale.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][15]);
                            cbxUnitBuy.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][17]);
                        }
                        catch (Exception) { }


                        try
                        {

                            DataTable tblStore = new DataTable();
                            tblStore.Clear();
                            tblStore = db.readData("select * from Products_Qty where Pro_ID=" + txtID.Text + "", "");
                            DgvStore.Rows.Clear();
                            if (tblStore.Rows.Count >= 1)
                            {
                                foreach (DataRow row in tblStore.Rows)
                                {
                                    DgvStore.Rows.Add(1);
                                    int indexrow = DgvStore.Rows.Count - 1;
                                    DgvStore.Rows[indexrow].Cells[0].Value = row[2];
                                    DgvStore.Rows[indexrow].Cells[1].Value = row[3];
                                    DgvStore.Rows[indexrow].Cells[2].Value = row[4];
                                }
                            }

                        }
                        catch (Exception) { }

                        try
                        {

                            DataTable tblunit = new DataTable();
                            tblunit.Clear();
                            tblunit = db.readData("select * from Products_Unit where Pro_ID=" + txtID.Text + "", "");
                            DgvUnits.Rows.Clear();
                            if (tblunit.Rows.Count >= 1)
                            {
                                foreach (DataRow row in tblunit.Rows)
                                {
                                    DgvUnits.Rows.Add(1);
                                    int indexrow = DgvUnits.Rows.Count - 1;
                                    DgvUnits.Rows[indexrow].Cells[0].Value = row[2];
                                    DgvUnits.Rows[indexrow].Cells[1].Value = row[3];
                                    DgvUnits.Rows[indexrow].Cells[2].Value = row[4];
                                }
                            }

                        }
                        catch (Exception) { }
                    }

                    btnAdd.Enabled = false;
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
                    btnSave.Enabled = true;
                    btnPrintBarcode.Enabled = true;
                }
            }
        }

        private void txtProNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                if (txtProNameSearch.Text != "")
                {
                    DataTable tblSearch = new DataTable();
                    tblSearch.Clear();
                    tblSearch = db.readData("select * from Products where Pro_Name like N'%" + txtProNameSearch.Text + "%'", "");

                    if (tblSearch.Rows.Count <= 0)
                    {
                    }
                    else
                    {
                        try
                        {
                            txtID.Text = tblSearch.Rows[0][0].ToString();
                            txtProName.Text = tblSearch.Rows[0][1].ToString();
                            NudAllQty.Value = Convert.ToDecimal(tblSearch.Rows[0][2]);
                            NudGomlaPrice.Value = Convert.ToDecimal(tblSearch.Rows[0][3]);
                            NudSalePrice.Value = Convert.ToDecimal(tblSearch.Rows[0][4]);
                            Nudtax.Value = Convert.ToDecimal(tblSearch.Rows[0][5]);

                            txtSalePriceTax.Text = tblSearch.Rows[0][6].ToString();
                            txtBarcode.Text = tblSearch.Rows[0][7].ToString();
                            NudMinQty.Value = Convert.ToDecimal(tblSearch.Rows[0][8]);
                            NudMAxDiscount.Value = Convert.ToDecimal(tblSearch.Rows[0][9]);
                            if (tblSearch.Rows[0][10].ToString() == "خاضع للضريبة")
                            {
                                checkTaxes.Checked = true;
                            }
                            else
                            {
                                checkTaxes.Checked = false;
                            }
                            cbxGroup.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][11]);
                            cbxMainUnit.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][13]);
                            cbxUnitSale.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][15]);
                            cbxUnitBuy.SelectedValue = Convert.ToDecimal(tblSearch.Rows[0][17]);
                        }
                        catch (Exception) { }


                        try
                        {

                            DataTable tblStore = new DataTable();
                            tblStore.Clear();
                            tblStore = db.readData("select * from Products_Qty where Pro_ID=" + txtID.Text + "", "");
                            DgvStore.Rows.Clear();
                            if (tblStore.Rows.Count >= 1)
                            {
                                foreach (DataRow row in tblStore.Rows)
                                {
                                    DgvStore.Rows.Add(1);
                                    int indexrow = DgvStore.Rows.Count - 1;
                                    DgvStore.Rows[indexrow].Cells[0].Value = row[2];
                                    DgvStore.Rows[indexrow].Cells[1].Value = row[3];
                                    DgvStore.Rows[indexrow].Cells[2].Value = row[4];
                                }
                            }

                        }
                        catch (Exception) { }

                        try
                        {

                            DataTable tblunit = new DataTable();
                            tblunit.Clear();
                            tblunit = db.readData("select * from Products_Unit where Pro_ID=" + txtID.Text + "", "");
                            DgvUnits.Rows.Clear();
                            if (tblunit.Rows.Count >= 1)
                            {
                                foreach (DataRow row in tblunit.Rows)
                                {
                                    DgvUnits.Rows.Add(1);
                                    int indexrow = DgvUnits.Rows.Count - 1;
                                    DgvUnits.Rows[indexrow].Cells[0].Value = row[2];
                                    DgvUnits.Rows[indexrow].Cells[1].Value = row[3];
                                    DgvUnits.Rows[indexrow].Cells[2].Value = row[4];
                                }
                            }

                        }
                        catch (Exception) { }
                    }

                    btnAdd.Enabled = false;
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
                    btnSave.Enabled = true;
                    btnPrintBarcode.Enabled = true;
                }
            }
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Pro_Name = txtProName.Text;
            Properties.Settings.Default.Pro_Barcode = txtBarcode.Text;
            Properties.Settings.Default.Pro_Price =Convert.ToDecimal( txtSalePriceTax.Text);
            Properties.Settings.Default.Save();
            Frm_PrintBarcode frm = new Frm_PrintBarcode();
            frm.ShowDialog();
            txtBarcode.Text = Properties.Settings.Default.Pro_Barcode;
        }

        private void cbxUnitSale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}