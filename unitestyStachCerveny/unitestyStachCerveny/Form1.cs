﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unitestyStachCerveny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HerniPostava hp = new HerniPostava("Jakub");

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                hp.ZmenaPozice(Cursor.Position.X, Cursor.Position.Y);
            }
        }
    }
}
