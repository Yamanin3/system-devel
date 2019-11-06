﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Login_form.Static_Classes
{
    class AC
    {

        public static OleDbConnection con = new OleDbConnection();
        public static OleDbCommand cmd = new OleDbCommand("", con);
        public static OleDbDataReader rd;

        public static string currentFullName;
        public static string sql;

        public static string getConnectionString()
        {
            // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Yamanin3\Desktop\学習\DB\Login_DB.mdb

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Application.StartupPath + "\\Login_DB.mdb;";

            return connectionString;

        }

        public static void openConnection()
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = getConnectionString();
                    con.Open();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("システムエラー" + Environment.NewLine + "説明: " + ex.Message.ToString(), "ログイン : データベースへの接続", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void closeConnection()
        {

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("システムエラー" + Environment.NewLine + "説明: " + ex.Message.ToString(), "ログイン : データベースへの接続", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
