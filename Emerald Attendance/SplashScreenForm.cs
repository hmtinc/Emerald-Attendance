//Software Design Assignment by : Harsh Mistry,Bradley Oosterbroek, and Logan Sikora-Beder
//Emerald Attendance : keep track of Attendance with style
//September 8th,2014 - November 28th, 2014
//A Infinity Computing Production 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Emerald_Attendance
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        //Load Login screen when timer ticks 
        private void splashTimer_Tick(object sender, EventArgs e)
        {

         

            //Open login form
            LoginForm login = new LoginForm();
            login.Show();

            //Disable timer
            splashTimer.Enabled = false; 

            //Hide Form from screen and task bar
            this.Opacity = 0.0f;
            this.ShowInTaskbar = false;

        

        }
    }
}
