﻿using System;
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
    public partial class Sign_Up_Form : Form
    {
        public Sign_Up_Form()
        {
            InitializeComponent();
        }
        private void Have_An_Account_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.ShowDialog();
            this.Show();
            
        }
    }
}
