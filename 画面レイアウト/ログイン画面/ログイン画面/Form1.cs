using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ログイン画面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 32;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ユーザIDを入力してください。");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("パスワードを入力してください。");
            }
            else
            {

                #region SQL文

                string dbPath = Application.StartupPath + @"\kabukanri.db";
                using (SQLiteConnection con = new SQLiteConnection("Data Source=" + dbPath))
                {

                    DataTable dt = new DataTable();
                    StringBuilder sql = new StringBuilder();
                    SQLiteCommand cmd = new SQLiteCommand();

                    sql.AppendLine("select CD,パスワード from ログイン者");
                    sql.AppendLine("where CD = @CD");
                    sql.AppendLine("and パスワード = @パスワード");

                    cmd.Parameters.Add("CD", System.Data.DbType.String);
                    cmd.Parameters.Add("パスワード", System.Data.DbType.String);

                    cmd.Parameters["CD"].Value = Logintxt.Text;
                    cmd.Parameters["パスワード"].Value = Passwordtxt.Text;


                    cmd.CommandText = sql.ToString();
                    //入力内容とクエリの結果を判定
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        string CD, PW;

                        CD = reader.GetString(reader.GetOrdinal("CD"));
                        PW = reader.GetString(reader.GetOrdinal("パスワード"));

                    }
                }
            }
            #endregion

            //TO-DOログインID・PWの一致チェックのロジック
            Menu Menu = new Menu();
            //メインメニューを開く
            Menu.Show();
            //ログイン画面を閉じる
            this.Visible = false;
        }
    }

}
    }
    
        }
  
