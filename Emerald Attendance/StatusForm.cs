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
    public partial class StatusForm : Form
    {
        //Declare variables
        public static string statString;

        public StatusForm()
        {
            InitializeComponent();
        }

        //Change status 
        private void changeButton_Click(object sender, EventArgs e)
        {
            //Assign entered value to stat string
            statString = enterTextBox.Text;

            //Pass back string value to admin form
            AdminForm.sString = statString;

            //close form
            this.Close();
        }

        //Show current status and set background color of the label and textbox
        private void StatusForm_Activated(object sender, EventArgs e)
        {
            //Set backcolor of controls to match background
            enterLabel.BackColor = Color.FromArgb(91, 91, 91);
            enterTextBox.BackColor = Color.FromArgb(91, 91, 91);

            //Display current status in title of form
            this.Text = "Change Status - Current Status is : " + statString; 
            

        }

        private void StatusForm_Load(object sender, EventArgs e)
        {

        }

     
    }
}
