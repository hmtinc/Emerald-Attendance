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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        //Add new student to database
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            string nameString, numberString, tempString;
            int gradeInteger = 0, class1Integer = 0, class2Integer = 0, class3Integer = 0, class4Integer = 0;
            bool errorBoolean = false;

            //Get student name 
            nameString = lastNameTextBox.Text + " " + nameTextBox.Text;

            //Display error if name text box is blank
            if (nameTextBox.Text == "First Name" || nameTextBox.Text == "" || lastNameTextBox.Text == "Last Name" || lastNameTextBox.Text == "")
            {
                //Display error
                MessageBox.Show("Error : No First or Last Name Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                //Stop method
                return;
            }

            //Loop through name to check there is no -'s in the name
            foreach (char nameCharacter in nameString)
            {
                //Convert the character to a sring
                tempString = nameCharacter.ToString();

                //Check to see if character is a dash
                if (tempString == "-")
                {
                    //Display error
                    MessageBox.Show("Error : Symbols are not allowed in names" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Stop method
                    return;
                }


            }

            //Get student number
            numberString = numberTextBox.Text;

            //display error if student number is not in the proper format
            if (numberString.Length < 6 || numberString.Length > 6)
            {
                //Display error
                MessageBox.Show("Error : Student number is not in the valid format. The student number must be 6 digits long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

            //Check database to see if student number is taken
            foreach (DataRow row in AdminForm.adminDataSet.Tables[1].Rows)
            {
                if (row["num"].ToString() == numberString)
                {
                    //Display error
                    MessageBox.Show("Error : Student number is already taken, please enter a new student number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Stop method
                    errorBoolean = true;
                    break;
                }
            }

            //Stop method
            if (errorBoolean == true)
            {
                return;
            }


            //Get Grade
            try
            {
                gradeInteger = int.Parse(GradeTextBox.Text);
            }

            //Catch any exceptions
            catch
            {
                //Display error
                MessageBox.Show("Error : Grade is invalid, Grade must be either 9, 10, 11, or 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

            //Check to see if grade is valid 
            if (gradeInteger == 9 || gradeInteger == 10 || gradeInteger == 11 || gradeInteger == 12)
            {
                Console.WriteLine("Grade Integer is Valid");
            }
            else
            {
                //Display error
                MessageBox.Show("Error : Grade is invalid, Grade must be either 9, 10, 11, or 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

            //Determine if no selection is made for a certain period
            if (period1ListBox.SelectedIndex < 0 || period2ListBox.SelectedIndex < 0 || period3ListBox.SelectedIndex < 0 || period4ListBox.SelectedIndex < 0)
            {
                //Display error
                MessageBox.Show("No selection made for one of the periods", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

            //Get and assign the period values
            class1Integer = period1ListBox.SelectedIndex + 1;
            class2Integer = period2ListBox.SelectedIndex + 1;
            class3Integer = period3ListBox.SelectedIndex + 1;
            class4Integer = period4ListBox.SelectedIndex + 1;

            //Create a new row in the dataset
            DataRow newStudentDataRow = AdminForm.adminDataSet.Tables[1].NewRow();

            //Add values to the new row
            newStudentDataRow["num"] = numberString;
            newStudentDataRow["Name"] = nameString;
            newStudentDataRow["Grade"] = gradeInteger;
            newStudentDataRow["1"] = class1Integer;
            newStudentDataRow["2"] = class2Integer;
            newStudentDataRow["3"] = class3Integer;
            newStudentDataRow["4"] = class4Integer;
            newStudentDataRow["l"] = 0;
            newStudentDataRow["a"] = 0;
            newStudentDataRow["student"] = true;

            //Update the database 
            AdminForm.adminDataSet.Tables[1].Rows.Add(newStudentDataRow);


        }

        

        //Load List of classes when form is activated
        private void AddForm_Activated(object sender, EventArgs e)
        {
            
            //Clear all listboxes
            period1ListBox.Items.Clear();
            period2ListBox.Items.Clear();
            period3ListBox.Items.Clear();
            period4ListBox.Items.Clear();
            teacherListBox.Items.Clear();


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

            //Load list of teachers
            foreach (DataRow row in AdminForm.adminDataSet.Tables[0].Rows)
            {
                if (row["Teach"].ToString() == "s")
                {
                    teacherListBox.Items.Add(row["Name"].ToString());
                }
            }

        }

        //Hide Text in Password box with the System Password Character 
        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            //Hide Text in Password box with the System Password Character 
            passTextBox.UseSystemPasswordChar = true;
        }

        //Add new teacher
        private void teacherButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            string nameString, passString, userString;

            //Get the teachers name 
            nameString = teacherNameTextBox.Text;

            //Check if name box is blank 
            if (nameString == "")
            {
                //Display error
                MessageBox.Show("Error : No Name Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

            
            //Get username
            userString = userNameTextBox.Text;

            //Check if username is blank
            if (userString == "")
            {
                //Display error
                MessageBox.Show("Error : No UserName Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

            //Loop through dataset to ensure the name and username do not already exist 
            foreach (DataRow row in AdminForm.adminDataSet.Tables[0].Rows)
            {
                if (userString == row["Username"].ToString())
                {
                    //Display error
                    MessageBox.Show("Error : Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Stop method
                    return;
                }
                else if (nameString == row["Name"].ToString())
                {
                    //Display error
                    MessageBox.Show("Error : Teacher name already exists in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Stop method
                    return;
                }
            }

            //Get Password
            passString = passTextBox.Text;

            //Check if password is blank 
            if (passString == "")
            {
                //Display error
                MessageBox.Show("Error : No Password Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

           
            //Create a new row in the dataset
            DataRow newTeacherDataRow = AdminForm.adminDataSet.Tables[0].NewRow();

            //Add values to the new row
            newTeacherDataRow["Username"] = userString;
            newTeacherDataRow["Password"] = passString;
            newTeacherDataRow["Name"] = nameString;
            newTeacherDataRow["Registered"] = true;

            //Add status of teacher to the new row
            if (adminCheckBox.Checked)
            {
                newTeacherDataRow["Admin"] = true;
            }
            else
            {
                newTeacherDataRow["Teach"] = "s";
                newTeacherDataRow["Admin"] = false;
            }

          
            //Update database
            AdminForm.adminDataSet.Tables[0].Rows.Add(newTeacherDataRow);


            //Call the form activate method
            AddForm_Activated(null, null);
           
        }

        //Close the form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Add new class to database
        private void classButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            string nameString, teacherString;
            int periodInteger = 0, idInteger = 0;
            

            //Get the class name
            nameString = classTextBox.Text;

            //Check if class name is blank
            if (nameString == "")
            {
                //Display error
                MessageBox.Show("Error : No Name Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

            //Get entered period
            try
            {
                periodInteger = int.Parse(periodTextBox.Text);
            }

            //Catch any exceptions 
            catch
            {
                //Display error
                MessageBox.Show("Error : Invalid period number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

            //Check if period number is valid 
            if (periodInteger == 1 || periodInteger == 2 || periodInteger == 3 || periodInteger == 4)
            {
                Console.WriteLine("Valid Period Number");
            }
            else
            {
                //Display error
                MessageBox.Show("Error : Invalid period number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

            //Add 1 to the period integer 
            periodInteger = periodInteger + 1;

            //Get selected teacher name
            if (teacherListBox.SelectedIndex > -1)
            {
                teacherString = teacherListBox.SelectedItem.ToString();
            }
            else
            {
                //Display error
                MessageBox.Show("Error : No teacher selected ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop method
                return;
            }

            //Loop through the database to make sure selected teacher is no already teaching a class that period
            foreach (DataRow row in AdminForm.adminDataSet.Tables[periodInteger].Rows)
            {
                if (row["Teacher"].ToString() == teacherString)
                {
                    //Display error
                    MessageBox.Show("Error : Selected teacher already teaches a class during the selected period.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Stop method
                    return;
                }
            }

            //Get id integer of last entry 
            foreach (DataRow row in AdminForm.adminDataSet.Tables[periodInteger].Rows)
            {
                idInteger = int.Parse(row["ID"].ToString());
            }

            //Add 1 to the id
            idInteger = idInteger + 1;

            //Create a new row in the dataset
            DataRow newClassDataRow = AdminForm.adminDataSet.Tables[periodInteger].NewRow();

            //Add values to the new row
            newClassDataRow["Class"] = nameString;
            newClassDataRow["Teacher"] = teacherString;
            newClassDataRow["ID"] = idInteger;
            

            //Update database
            AdminForm.adminDataSet.Tables[periodInteger].Rows.Add(newClassDataRow);

            //Call the form activate method
            AddForm_Activated(null, null);

            
        }

      

        

     

      

        
    }
}
