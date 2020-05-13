using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace Sales_Managment
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        Thread t;
        public Frm_Login()
        {
            InitializeComponent();
            try {
                t = new Thread(new ThreadStart (StartSplash));
                t.Start();
                Thread.Sleep(5000);
                t.Abort();
            } catch (Exception) { }
            
            
        }


        private void StartSplash()
        {
            try {
                Application.Run(new Splash());
            } catch (Exception) { }
        }



        Database db = new Database();
        DataTable tbl = new DataTable();

        //to check if db exist or not
        private bool checkDatabase()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("" ,conn);

            SqlDataReader rdr;

            try
            {
                cmd.CommandText = "exec sys.sp_databases";
                conn.Open();

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.GetString(0) == "Sales_System")
                    {
                        return true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            conn.Close();
            rdr.Dispose();
            cmd.Dispose();
            return false;
        }
        //to create db if not exist
        private void createDatabase()
        {
          bool check= checkDatabase();


            if(check ==false)
            {
                try
                {
                    //string conn = @"Data Source=.\SQLEXPRESS;Integrated Security=True";

                    //string script = File.ReadAllText(Application.StartupPath + @"\sqlscript.sql");

                    //SqlConnection co = new SqlConnection(conn);

                    //Server server = new Server(new ServerConnection(co));


                    //server.ConnectionContext.ExecuteNonQuery(script);


                    var fileContent = File.ReadAllText(Application.StartupPath + @"\sqlscript.sql");
                    var sqlqueries = fileContent.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                    var con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=True");
                    var cmd = new SqlCommand("query", con);
                    con.Open();

                    foreach (var query in sqlqueries)
                    {
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                catch (Exception ex ) { MessageBox.Show(ex.Message); }
            }
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            try {

              //createDatabase();
                
            } catch (Exception) { }
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {

                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                btnLogin_Click(null, null);
            }
        }
        //to make program trial version
        private bool Trial()
        {         
            int num = Properties.Settings.Default.Trial;
            int thisnum = num + 1;
            Properties.Settings.Default.Trial = thisnum;
            Properties.Settings.Default.Save();
            if (thisnum >= 100)
            {
                MessageBox.Show("هذه نسخه تجريبيه تم انتهائها", "تاكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else
            {
                int baky = 100 - thisnum;
                MessageBox.Show("هذه نسخه تجريبيه ومتبقي لك عدد مرات  "+ baky + " مرات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Reset();
            if (Properties.Settings.Default.Product_Key == "NO")
            {
                Frm_serial frm = new Frm_serial();
                frm.ShowDialog();

            }
            else
            {
                tbl.Clear();
                if (rbtnManager.Checked == true)
                    tbl = db.readData("select * from Users where User_Name=N'" + txtUserName.Text + "' and User_Password=N'" + txtPassword.Text + "' and Type=N'مدير'", "");
                else if (rbtnEmp.Checked == true)
                    tbl = db.readData("select * from Users where User_Name=N'" + txtUserName.Text + "' and User_Password=N'" + txtPassword.Text + "' and Type=N'مستخدم عادى'", "");
                if (tbl.Rows.Count <= 0)
                {
                    DataTable tblStock = new DataTable();
                    tblStock = db.readData("select * from Stock_Data", "");
                    if (tblStock.Rows.Count <= 0)
                    {
                        db.exceuteData("insert into Stock_Data Values (1,N'الخزنة الرئيسية') ", "");
                    }
                    string type = "مدير";
                    db.exceuteData("insert into Users values (1 ,N'" + Properties.Settings.Default.USERNAME + "' ,N'" + Properties.Settings.Default.USERNAME + "',N'" + type + "',1,0)", "");
                    db.exceuteData("insert into User_Setting Values (1 , 1,1,1,1,1,1,1,1,1,1,1,1)", "");
                    db.exceuteData("insert into User_Customer Values (1 , 1,1,1)", "");
                    db.exceuteData("insert into User_Supplier Values (1 , 1,1,1)", "");
                    db.exceuteData("insert into User_Buy Values (1 , 1,1)", "");
                    db.exceuteData("insert into User_Sale Values (1 , 1,1,1)", "");
                    db.exceuteData("insert into User_Return Values (1 , 1,1)", "");
                    db.exceuteData("insert into User_StockBank Values (1 , 1,1,1,1,1,1,1,1,1)", "");
                    db.exceuteData("insert into User_Emp Values (1 , 1,1,1,1,1,1,1)", "");
                    db.exceuteData("insert into User_Deserved Values (1 , 1,1,1,1,1,1,1)", "");
                    db.exceuteData("insert into User_Report Values (1 , 1,1,1,1,1,1)", "");
                    db.exceuteData("insert into User_BackUp Values (1 , 1,1)", "");
                    tbl.Clear();
                    if (rbtnManager.Checked == true)
                        tbl = db.readData("select * from Users where User_Name=N'" + txtUserName.Text + "' and User_Password=N'" + txtPassword.Text + "' and Type=N'مدير'", "");
                    else if (rbtnEmp.Checked == true)
                        tbl = db.readData("select * from Users where User_Name=N'" + txtUserName.Text + "' and User_Password=N'" + txtPassword.Text + "' and Type=N'مستخدم عادى'", "");

                }
                if (tbl.Rows.Count >= 1)
                {
                    //bool check;
                    //check = Trial();
                    //if (check == false)
                    //{
                    //    return;
                    //}
                    Properties.Settings.Default.USERNAME = txtUserName.Text;
                    Properties.Settings.Default.Stock_ID = Convert.ToInt32(tbl.Rows[0][4]);
                    Properties.Settings.Default.Save();
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("كلمة السر او اسم المستخدم  خطا", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckSHOW == true)
            {
                MessageBox.Show("غير مسموح لك بالتعديل في البيانات", "تاكيد");
            }
            else
            {
                Frm_ServerSetting frm = new Frm_ServerSetting();
                frm.ShowDialog();
            }
        }
    }
}