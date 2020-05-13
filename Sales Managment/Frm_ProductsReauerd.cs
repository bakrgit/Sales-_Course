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
    public partial class Frm_ProductsReauerd : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ProductsReauerd()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void Frm_ProductsReauerd_Load(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select Pro_Name as 'اسم المنتج' ,Qty as 'الكمية الموجوده منه' ,MinQty as 'حد الطلب' from Products where MinQty >=1 and Qty <= MinQty ", "");

            DgvSearch.DataSource = tbl;
            txtTotal.Text = tbl.Rows.Count +"";

        }
    }
}