using Attendance_Management_System_Client.Biometric;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System_Client
{
    public partial class Form1 : Form
    {
        private Verification verification;
        public Form1()
        {
            InitializeComponent();            
            notify.BalloonTipTitle = "Attendance Management System";
            notify.BalloonTipText = "Application is running in the background scan your fingerprints to sign-in or sign-out";
            notify.Icon = Icon;
            verification = new Verification(this);
            verification.Start();
        }

        public NotifyIcon Notify
        {
            get { return notify; }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           this.Close();         
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
           e.Cancel = true;
           this.Hide();
           notify.ShowBalloonTip(2000);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
