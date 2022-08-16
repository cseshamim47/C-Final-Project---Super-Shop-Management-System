﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABegin
{
    public partial class Form2 : Form
    {
        private Form1 F1 { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string info, Form1 f1) : this()
        {
            this.lblOutput.Text = info;
            this.F1 = f1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Back();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Back();
            Application.Exit();
        }

        private void Back()
        {
            this.Visible = false;
            //Form1 f1 = new Form1();
            this.F1.Visible = true;
        }
    }
}
