﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NineTime
{
    public partial class NTchoClock : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public NTchoClock()
        {
            InitializeComponent();
        }

        private void NTchoClock_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void rdBtn_timer_Click(object sender, EventArgs e)
        {
            NTC_TIMER NTCTM = new NTC_TIMER();
            NTCTM.Show();
        }

        private void rdBtn_stopwatch_Click(object sender, EventArgs e)
        {
            NTC_stopwatch NTCST = new NTC_stopwatch();
            NTCST.Show();
        }

        private void rdBtn_calender_Click(object sender, EventArgs e)
        {
            NTC_calender NTCCL = new NTC_calender();
            NTCCL.Show();
        }
    }
}
