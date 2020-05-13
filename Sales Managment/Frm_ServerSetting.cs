using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_Managment
{
    public partial class Frm_ServerSetting : Form
    {
        public Frm_ServerSetting()
        {
            InitializeComponent();
        }

        private void Frm_ServerSetting_Load(object sender, EventArgs e)
        {
            txtServerName.Text = Properties.Settings.Default.SERVERNAME;
            txtDatabase.Text = Properties.Settings.Default.DATABASENAME;
            txtUserName.Text = Properties.Settings.Default.DATABASEUSERNAME;
            txtPassword.Text = Properties.Settings.Default.DATABASEPASSWORD;
            if(Properties.Settings.Default.CheckSHOW == false)
            { checkBoxDontShow.Checked = false; }
            else
            {
                checkBoxDontShow.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SERVERNAME= txtServerName.Text ;
            Properties.Settings.Default.DATABASENAME = txtDatabase.Text ;
            Properties.Settings.Default.DATABASEUSERNAME = txtUserName.Text ;
            Properties.Settings.Default.DATABASEPASSWORD= txtPassword.Text ;

            if (checkBoxDontShow.Checked == false)
            {
                Properties.Settings.Default.CheckSHOW = false;
            }
            else
            {
                Properties.Settings.Default.CheckSHOW = true;
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ بنجاح", "تاكيد");
        }
    }
}
