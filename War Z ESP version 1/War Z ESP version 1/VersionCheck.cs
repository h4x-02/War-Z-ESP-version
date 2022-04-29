using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace War_Z_ESP_version_1
{
    public partial class VersionCheck : Form
    {
        public VersionCheck()
        {
            InitializeComponent();
            string VerNr = VerBox.Text;
        }

        public bool TryCn(string VerNr)
        {
            // check sql data base
            MySqlConnection con = new MySqlConnection("server=................;user=chris270_admin;password=............;database=..............;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM version WHERE v_version = '" + VerNr + "';");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {

                if (reader.IsDBNull(0) == true)
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                    
                }
                else
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                    
                }
            }
            else
            {
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TryCn(VerBox.Text) == true)
            {
                Form1 form_launch = new Form1();
                form_launch.ShowDialog();
                this.Close();
            }
            else
            {
                 MessageBox.Show("Please Downlaod the latest version from ................/", "WarZ Hack - Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VerBox_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}