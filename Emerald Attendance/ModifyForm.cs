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
    public partial class ModifyForm : Form
    {
        public static int value1Integer = 0, value2Integer = 0, value3Integer = 0, value4Integer = 0, absentInteger = 0, lateInteger = 0;
        public ModifyForm()
        {
            InitializeComponent();
        }

        //Set the background color for each control
        private void ModifyForm_Load(object sender, EventArgs e)
        {
            //Set the back color of labels and listboxes
            periodLabel.BackColor = Color.FromArgb(91, 91, 91);
            optionLabel.BackColor = Color.FromArgb(91, 91, 91);
            periodListBox.BackColor = Color.FromArgb(91, 91, 91);
            optionListBox.BackColor = Color.FromArgb(91, 91, 91);
        }

        //Close the modify form
        private void closeButton_Click(object sender, EventArgs e)
        {
            //Pass back attendance values
            AdminForm.period1Integer = value1Integer;
            AdminForm.period2Integer = value2Integer;
            AdminForm.period3Integer = value3Integer;
            AdminForm.period4Integer = value4Integer;
            AdminForm.absentTotalInteger = absentInteger;
            AdminForm.lateTotalInteger = lateInteger;

            //Close the form
            this.Close();
        }

        //Display current attendance info
        private void ModifyForm_Activated(object sender, EventArgs e)
        {
            //Add attendance items to the listbox
            periodListBox.Items.Add("Period 1 : " + AttendanceString(value1Integer));
            periodListBox.Items.Add("Period 2 : " + AttendanceString(value2Integer));
            periodListBox.Items.Add("Period 3 : " + AttendanceString(value3Integer));
            periodListBox.Items.Add("Period 4 : " + AttendanceString(value4Integer));
        }

        //Get string value for period based of the attendance integer
        private string AttendanceString(int valueInteger)
        {
            //Declare variables
            string atString;

            //Determine string value based on attendance integer 
            switch (valueInteger)
            {
                case 0:
                    atString = "Present";
                    break;
                case 1:
                    atString = "Absent";
                    break;
                case 2:
                    atString = "Late";
                    break;
                case 3:
                    atString = "School Trip";
                    break;
                default:
                    atString = "Present";
                    break;

            }

            //Return string value
            return atString;


        }

        //Modify selected period
        private void modifyButton_Click(object sender, EventArgs e)
        {
            //declare variables
            int index1Integer = 0, index2Integer = 0;

            //Get selected index of both checkboxes
            index1Integer = periodListBox.SelectedIndex;
            index2Integer = optionListBox.SelectedIndex;


            //Check to make sure a item is selected in both listboxes
            if (index1Integer < 0 || index2Integer < 0)
            {
                //Display error
                MessageBox.Show("No Period or option selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                //Clear listbox
                periodListBox.Items.Clear();




                //Update Period listbox 
                ModifyForm_Activated(null, null);

                //Stop the modfiy method
                return;

            }


            //Update absent and late totals
            if (index1Integer == 0)
            {
                abTotal(index2Integer, value1Integer);
            }
            else if (index1Integer == 1)
            {
                abTotal(index2Integer, value2Integer);
            }
            else if (index1Integer == 2)
            {
                abTotal(index2Integer, value3Integer);
            }
            else
            {
                abTotal(index2Integer, value4Integer);
            }

            //Modify the selected period based on selected index
            if (index1Integer == 0)
            {
                value1Integer = index2Integer;
            }
            else if (index1Integer == 1)
            {
                value2Integer = index2Integer;
            }
            else if (index1Integer == 2)
            {
                value3Integer = index2Integer;
            }
            else
            {
                value4Integer = index2Integer;
            }

            //Clear listbox
            periodListBox.Items.Clear();

            
            

            //Update Period listbox 
            ModifyForm_Activated(null, null);

        }

        //Determine new absent or late total 
        private void abTotal(int indexInteger , int valueInteger)
        {
            //Check for absent value change
            if (valueInteger == 1 && indexInteger != 1)
            {
                absentInteger = absentInteger - 1;
            }

            //Check for late value change
            if (valueInteger == 2 && indexInteger != 2)
            {
                lateInteger =  lateInteger - 1;
            }

            //Check for change from present/school trip to late/absent
            if (valueInteger == 0 || valueInteger == 3) 
            {
                if (indexInteger == 1)
                {
                    absentInteger = absentInteger + 1;
                }
                else if (indexInteger == 2) 
                {
                    lateInteger  = lateInteger + 1;
                }
            }
        }

       
    }
}
