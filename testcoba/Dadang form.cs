﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testcoba
{
    public partial class Dadang_form : Form
    {
        public Dadang_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtnama.Text = "";
            txtjenis.Text = "";
        }
    }
}
