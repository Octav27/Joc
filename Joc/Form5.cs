﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joc
{
    public partial class Form5 : Form
    {
       static public int alegere= 0;

        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBack1_Click(object sender, EventArgs e)
        {
            comboBoxAlegere.SelectedIndex = alegere = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            comboBoxAlegere.SelectedIndex = alegere =1;
            alegere = 1;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBoxAlegere.SelectedIndex = alegere;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAlegere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
