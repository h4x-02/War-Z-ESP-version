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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            string KeyNr = KeyBox.Text;
            string ActiveKey = ActiveBox.Text;
        }

        public bool TryCn(string KeyNr, string ActiveKey)
        {
            // check sql data base
            MySqlConnection con = new MySqlConnection("");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mod_licensing WHERE licensekey = '" + KeyNr + "' AND status = '" + ActiveKey + "';");
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

        private void login_Click(object sender, EventArgs e)
        {
            if (TryCn(KeyBox.Text, ActiveBox.Text) == true)
            {
                VersionCheck form_launch = new VersionCheck();
                form_launch.ShowDialog(); 
                this.Close();
            }
            else
            {
                string KeyNr = KeyBox.Text;
                string KeyActive = ActiveBox.Text;
                MessageBox.Show("Your key (" + KeyNr + ") was invalid or not active. \nPlease check if it is the correct key or you need to buy another month.", "WarZ Hack - Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm form_about = new AboutForm();
            form_about.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void KeyBuyLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }
        
    }
}