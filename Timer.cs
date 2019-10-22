﻿using System;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Timer : Form
    {
        System.Windows.Forms.Timer t;
        int num = 1;
        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 100;
            t.Tick += new EventHandler(t_Tick);
            label1.Text = "" + num;
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            label1.Text = "" + num++;
            if (progressBar1.Value >= 100) t.Stop();
        }
    }
}
