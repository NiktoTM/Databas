﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyTelePhone
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void Navigation_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form1().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form2().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form3().ShowDialog();
        }
    }
}
