using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Sales_Managment
{
    class Database
    {
        //connection to database
        MySqlConnection conn = new MySqlConnection(@"server=" + Properties.Settings.Default.SERVERNAME + "; Port=3306;Database=" + Properties.Settings.Default.DATABASENAME + ";Uid=" + Properties.Settings.Default.DATABASEUSERNAME + " ; Pwd=" + Properties.Settings.Default.DATABASEPASSWORD + "");
        MySqlCommand cmd = new MySqlCommand();

        
        // select 
        public DataTable readData(string stmt ,string message)
        {
            DataTable tbl = new DataTable();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                //load data from database to tbl 
                tbl.Load(cmd.ExecuteReader());

                conn.Close();
                if (message != "")
                {
                    MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } finally
            {
                conn.Close();
            }
         
            
            return tbl;
        }

        // insert update delete 
        public bool exceuteData(string stmt ,string message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if(message !="")
                {
                    MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }catch(Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
