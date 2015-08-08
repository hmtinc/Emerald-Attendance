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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        //Load students current profile
        private void ProfileForm_Activated(object sender, EventArgs e)
        {
            //Clear all listboxes
            period1ListBox.Items.Clear();
            period2ListBox.Items.Clear();
            period3ListBox.Items.Clear();
            period4ListBox.Items.Clear();
       

            //Load list of period 1 classes
            foreach (DataRow row in AdminForm.adminDataSet.Tables[2].Rows)
            {
                period1ListBox.Items.Add(row["Class"].ToString());
            }

            //Load list of period 2 classes
            foreach (DataRow row in AdminForm.adminDataSet.Tables[3].Rows)
            {
                period2ListBox.Items.Add(row["Class"].ToString());
            }

            //Load list of period 3 classes
            foreach (DataRow row in AdminForm.adminDataSet.Tables[4].Rows)
            {
                period3ListBox.Items.Add(row["Class"].ToString());
            }

            //Load list of period 4 classes
            foreach (DataRow row in AdminForm.adminDataSet.Tables[5].Rows)
            {
                period4ListBox.Items.Add(row["Class"].ToString());

            }

            //Set selected index of listboxes
            period1ListBox.SelectedIndex = int.Parse(AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["1"].ToString()) - 1;
            period2ListBox.SelectedIndex = int.Parse(AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["2"].ToString()) - 1;
            period3ListBox.SelectedIndex = int.Parse(AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["3"].ToString()) - 1;
            period4ListBox.SelectedIndex = int.Parse(AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["4"].ToString()) - 1;
            

            //Display students name
            nameTextBox.Text = AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["Name"].ToString(); 

            //Display students grade
            gradeTextBox.Text = AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["Grade"].ToString(); 

            //Display student number
            numberTextBox.Text = AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["num"].ToString(); 

            //Display student email
            try
            {
                emailTextBox.Text = AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["email"].ToString();
            }

            //Catch any exception
            catch
            {
                Console.WriteLine("No email on record");
            }


        }

        //Modify profile
        private void modifyButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            string enteredEmailString;
            bool validBoolean = false;

            //Get entered email 
            enteredEmailString = emailTextBox.Text;

            //Loop through email string to determine if its a valid email
            foreach (char emailCharacter in enteredEmailString)
            {
                //Exit loop if @ is found
                if (emailCharacter.ToString() == "@")
                {
                    //Set valid boolean to true 
                    validBoolean = true;

                    //break foreach loop
                    break;
                }
            }

            //Save email address
            if (validBoolean == true)
            {
                AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["email"] = emailTextBox.Text;
            }
            else
            {
                //Display error 
                MessageBox.Show("Error entered email is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Exit methid
                return;
            }

            //Save period selections
            AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["1"] = period1ListBox.SelectedIndex + 1;
            AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["2"] = period2ListBox.SelectedIndex + 1;
            AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["3"] = period3ListBox.SelectedIndex + 1;
            AdminForm.adminDataSet.Tables[1].Rows[AdminForm.storageInteger]["4"] = period4ListBox.SelectedIndex + 1;

           
        }

        //Close form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
