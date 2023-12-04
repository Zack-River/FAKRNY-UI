using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakrny_Sign_up_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Login_UserName_TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Login_UserName_TextBox.Text == "")
                {
                    Login_UserName_TextBox.Text = "Username";
                    return;

                }
                Login_UserName_TextBox.ForeColor = Color.White;
                Login_Username_Error_Panel.Visible = false;
            }
            catch { }
        }

        private void Login_Password_TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Login_Password_TextBox.Text == "")
                {
                    Login_Password_TextBox.Text = "Password";
                    return;

                }
                Login_Password_TextBox.ForeColor = Color.White;
                Login_Password_Error_Panel.Visible = false;
            }
            catch { }
        }

        private void Login_UserName_TextBox_Click(object sender, EventArgs e)
        {
            Login_UserName_TextBox.SelectAll();
        }

        private void Login_Password_TextBox_Click(object sender, EventArgs e)
        {
            Login_Password_TextBox.SelectAll();
        }

        private void Login_Button_MouseEnter(object sender, EventArgs e)
        {
            Login_Button.ForeColor = Color.FromArgb(38, 38, 38);
        }

        private void Login_Button_MouseLeave(object sender, EventArgs e)
        {
            Login_Button.ForeColor = Color.FromArgb(149, 149, 149);
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (Login_UserName_TextBox.Text == "Username") // Write your own condition
            {
                Login_Username_Error_Panel.Visible = true;
                Login_UserName_TextBox.Focus();
                return;

            }
            if (Login_Password_TextBox.Text == "Password") // Write your own condition
            {
                Login_Password_Error_Panel.Visible = true;
                Login_Password_TextBox.Focus();
                return;
            }
        }

        private void Create_New_Acount_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
