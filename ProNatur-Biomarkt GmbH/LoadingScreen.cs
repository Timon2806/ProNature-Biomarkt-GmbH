﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue;

        public LoadingScreen()
        {
            InitializeComponent();
        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();
        }
        private void LoadingbarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue += 1;

            loadingProcent.Text = loadingBarValue.ToString() +"%";

            loadingProgressBar.Value = loadingBarValue;

            if (loadingBarValue >= loadingProgressBar.Maximum)
            {
                loadingbarTimer.Stop();
            }
        }

        
    }
}
