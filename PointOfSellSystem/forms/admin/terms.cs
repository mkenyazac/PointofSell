﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSellSystem.forms.admin
{
    public partial class terms : Form
    {
        public terms()
        {
            InitializeComponent();
        }

        private void browsebt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3; *.wav; *.mp4; *.mov, *.wmv; *.mpg|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
        }
    }
}
