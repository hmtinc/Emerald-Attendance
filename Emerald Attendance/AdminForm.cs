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
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Odbc;
using ADOX;
using ADODB;
using System.Net;
using System.Net.Mail;
using System.IO;




namespace Emerald_Attendance
{
    public partial class AdminForm : Form
    {
        //Declare Variables
        public static DataSet adminDataSet;
        string dateString = "", storageString;
        public static int indexInteger, period1Integer = 0, period2Integer = 0, period3Integer = 0, period4Integer = 0, storageInteger, absentTotalInteger = 0, lateTotalInteger = 0;
        public static string sString;
        int sectionInteger = 0, periodInteger = 0;


  
       
        //Declare variables for ther report maker
        string reportString = "", locationString, temp1String;
        int absentReportTotalInteger = 0, late1TotalInteger = 0, temp1Integer = 0;
        bool reportErrorBoolean = false;

   

        public AdminForm()
        {
            InitializeComponent();
        }

        //Form load [Set all controls to default settings]
        private void AdminForm_Load(object sender, EventArgs e)
        {
            //Change back colour of list box to match background
            studentListBox.BackColor = Color.FromArgb(34, 34, 34);
            student2ListBox.BackColor = Color.FromArgb(64, 64, 64);

            //Get selected date
            dateString = monthCalendar1.SelectionStart.ToString();
            dateString = dateString.Substring(0, 10);

            //Change back colour of textboxes and label to match the background
            userLabel.BackColor = Color.FromArgb(34, 34, 34);
            nameLabel.BackColor = Color.FromArgb(34, 34, 34);
            searchTextBox.BackColor = Color.FromArgb(34, 34, 34);
            period3Label.BackColor = Color.FromArgb(22, 132, 85);
            period4Label.BackColor = Color.FromArgb(21, 76, 132);
            teacherLabel.BackColor = Color.FromArgb(64, 64, 64);
            periodStatusLabel.BackColor = Color.FromArgb(64, 64, 64);
            infoLabel.BackColor = Color.FromArgb(64, 64, 64);

            //Set max selection count for the calender to 1
            monthCalendar1.MaxSelectionCount = 1;
        }

        //Refresh student lists 
        private void AdminForm_Activated(object sender, EventArgs e)
        {
            //Declare variables
            object adminNameObject;

            //Update student list 
            updateStudentList();

            //Get admin name 
            adminNameObject = adminDataSet.Tables[0].Rows[indexInteger]["Name"];

            //Display admin name is upper right corner
            nameLabel.Text = adminNameObject.ToString();
            
    
        }

        //Update Listbox 
        private void updateStudentList()
        {

            //Declare variables 
            object studentObject, studentNumberObject;
            string nameString, numberString;

            //Clear list box
            studentListBox.Items.Clear();

            
            //Loop through student table and fill list box with names and numbers 
            if (sectionInteger == 0)
            {
                foreach (DataRow row in adminDataSet.Tables[1].Rows)
                {

                    //Get student name and number 
                    studentObject = row["Name"];
                    studentNumberObject = row["num"];

                    //Convert objects to strings
                    nameString = studentObject.ToString();
                    numberString = studentNumberObject.ToString();

                    //Add student names and numbers to list box 
                    studentListBox.Items.Add(nameString + " --- " + numberString);


                }
            }
            else if (sectionInteger == 1)
            {
                //Set sorted to false
                studentListBox.Sorted = false;

                

                foreach (DataRow row in adminDataSet.Tables[2].Rows)
                {

                    //Get class name and number 
                    studentObject = row["ID"];
                    studentNumberObject = row["Class"];

                    //Convert objects to strings
                    nameString = studentObject.ToString();
                    numberString = studentNumberObject.ToString();

                    //Add class names and numbers to list box 
                    studentListBox.Items.Add("Period 1 : " + nameString + ":" + numberString);


                }

               

                foreach (DataRow row in adminDataSet.Tables[3].Rows)
                {

                    //Get class name and number 
                    studentObject = row["ID"];
                    studentNumberObject = row["Class"];

                    //Convert objects to strings
                    nameString = studentObject.ToString();
                    numberString = studentNumberObject.ToString();

                    //Add class names and numbers to list box 
                    studentListBox.Items.Add("Period 2 : " + nameString + ":" + numberString);


                }

             
                foreach (DataRow row in adminDataSet.Tables[4].Rows)
                {

                    //Get class name and number 
                    studentObject = row["ID"];
                    studentNumberObject = row["Class"];

                    //Convert objects to strings
                    nameString = studentObject.ToString();
                    numberString = studentNumberObject.ToString();

                    //Add class names and numbers to list box 
                    studentListBox.Items.Add("Period 3 : " + nameString + ":" + numberString);


                }

               

                foreach (DataRow row in adminDataSet.Tables[5].Rows)
                {

                    //Get class name and number 
                    studentObject = row["ID"];
                    studentNumberObject = row["Class"];

                    //Convert objects to strings
                    nameString = studentObject.ToString();
                    numberString = studentNumberObject.ToString();

                    //Add class names and numbers to list box 
                    studentListBox.Items.Add("Period 4 : " + nameString + ":" + numberString);


                }
            }
            else if (sectionInteger == 2)
            {

                //Add periods to list 
                studentListBox.Items.Add("Period 1");
                studentListBox.Items.Add("Period 2");
                studentListBox.Items.Add("Period 3");
                studentListBox.Items.Add("Period 4");
            }


        }

        //Filter the student list live based on the text entered in the search bar
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //Update student list 
            updateStudentList();
            
            //Create a list with searchable student/class names 
            var studentsList = studentListBox.Items.Cast<string>().ToList();

            //Begin update 
            studentListBox.BeginUpdate();

            //Clear listbox 
            studentListBox.Items.Clear();


            //Filter items based on text in search textbox only if its not blank 
            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                foreach (string str in studentsList)
                {
                    if (str.Contains(searchTextBox.Text))
                    {
                        studentListBox.Items.Add(str);
                    }
                }
            }
            else
            {
                //Reset listbox to default list 
                updateStudentList();
            }

            //End update 
            studentListBox.EndUpdate();

        }

        //Remove old text entered in textbox 
        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
        }

      
        //Get data for selected class/student
        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sectionInteger == 0)
            {
                //Get students attendance report for selected date when new student is selected 
                GetStudentData();
            }
            else if (sectionInteger == 1)
            {
                //Get class list for selected class
                GetClassData();
            }
            else if (sectionInteger == 2)
            {
                //Display students who were late or absent
                GetPeriodData();
            }
        }

        //Display students who were late/absent in the selected period
        private void GetPeriodData()
        {
            //Declare variables
            int selectedPeriodInteger = 0, attendInteger = 0;
            string periodStorageString, dateStorageString;

            //Clear listbox
            student2ListBox.Items.Clear();

            try
            {
                //Determine selected period 
                if (studentListBox.SelectedItem.ToString() == "Period 1")
                {
                    selectedPeriodInteger = 1;
                }
                else if (studentListBox.SelectedItem.ToString() == "Period 2")
                {
                    selectedPeriodInteger = 2;
                }
                else if (studentListBox.SelectedItem.ToString() == "Period 3")
                {
                    selectedPeriodInteger = 3;
                }
                else if (studentListBox.SelectedItem.ToString() == "Period 4")
                {
                    selectedPeriodInteger = 4;
                }
                else
                {
                    //Display error 
                    MessageBox.Show("No period selected. Please select a period to view attendance data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Exit method
                    return;
                }

                //Set sorted to false 
                student2ListBox.Sorted = false;

                //Add late item to list 
                student2ListBox.Items.Add("---Late---");

                //Get selected date
                dateStorageString = monthCalendar1.SelectionStart.ToString();
                dateStorageString = dateStorageString.Substring(0, 10);

                //Display students who were late to class on the selected date 
                foreach (DataRow row in adminDataSet.Tables[1].Rows)
                {
                    //Get period values
                    periodStorageString = row[dateStorageString].ToString();

                    //Get value for curent period
                    try
                    {
                        if (selectedPeriodInteger == 1)
                        {
                            attendInteger = int.Parse(periodStorageString.Substring(0, 1));
                        }
                        else if (selectedPeriodInteger == 2)
                        {
                            attendInteger = int.Parse(periodStorageString.Substring(1, 1));
                        }
                        else if (selectedPeriodInteger == 3)
                        {
                            attendInteger = int.Parse(periodStorageString.Substring(2, 1));
                        }
                        else if (selectedPeriodInteger == 4)
                        {
                            attendInteger = int.Parse(periodStorageString.Substring(3, 1));
                        }
                    }
                    catch
                    {
                        attendInteger = 0;
                    }

                    //display name if value is 2
                    if (attendInteger == 2)
                    {
                        student2ListBox.Items.Add(row["Name"] + " --- " + row["num"]);

                    }
                }

                //Add absent item to list 
                student2ListBox.Items.Add("---Absent---");

                //Display students who were absent on the selected date 
                foreach (DataRow row in adminDataSet.Tables[1].Rows)
                {
                    //Get period values
                    periodStorageString = row[dateStorageString].ToString();

                    //Get value for curent period
                    try
                    {
                        if (selectedPeriodInteger == 1)
                        {
                            attendInteger = int.Parse(periodStorageString.Substring(0, 1));
                        }
                        else if (selectedPeriodInteger == 2)
                        {
                            attendInteger = int.Parse(periodStorageString.Substring(1, 1));
                        }
                        else if (selectedPeriodInteger == 3)
                        {
                            attendInteger = int.Parse(periodStorageString.Substring(2, 1));
                        }
                        else if (selectedPeriodInteger == 4)
                        {
                            attendInteger = int.Parse(periodStorageString.Substring(3, 1));
                        }
                    }
                    catch
                    {
                        attendInteger = 0;
                    }

                    //display name if value is 2
                    if (attendInteger == 1)
                    {
                        student2ListBox.Items.Add(row["Name"] + " --- " + row["num"]);
                    }
                }
            }
            
            //Catch any exceptions 
            catch 
            {
                //Display error message
                MessageBox.Show("Error : No period selected. Please select a period.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Get and display list of students in the selected class 
        private void GetClassData()
        {
            //Declare variables 
            int classNumberInteger = 0;
            string classString, periodString, teacherString;
            object classNumberObject, studentNameObject, studentNumberObject;

            //Get selected class name
            if (studentListBox.SelectedIndex > -1)
            {
                classString = studentListBox.SelectedItem.ToString(); 
            }
            else
            {
                //Display error 
                MessageBox.Show("No class selected. Please select a class to view attendance data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Exit method
                return;
            }

            //Clear list box 
            student2ListBox.Items.Clear();

            //Get period and class number 
            periodString = classString.Substring(0, 12);

            //Determine period 
            if (periodString.Substring(0, 8) == "Period 1")
            {
                periodInteger = 1;
            }
            else if (periodString.Substring(0, 8) == "Period 2")
            {
                periodInteger = 2;
            }

            else if (periodString.Substring(0, 8) == "Period 3")
            {
                periodInteger = 3;
            }

            else if (periodString.Substring(0, 8) == "Period 4")
            {
                periodInteger = 4;
            }
            
            //Determine the class number
            classNumberInteger = int.Parse(periodString.Substring(11, 1));

            //Loop through student list and determine which students are in the class 
            foreach (DataRow row in adminDataSet.Tables[1].Rows)
            {
                //Get student name and class number 
                studentNameObject = row["Name"];
                classNumberObject = row[periodInteger.ToString()];
                studentNumberObject = row["num"];

                //If class number is the same as the selected class number then add the students name to the class list 
                if (classNumberObject.ToString() == classNumberInteger.ToString())
                {
                    student2ListBox.Items.Add(studentNameObject.ToString() + " --- " + studentNumberObject.ToString());
                }
            }

            //Set the period integer
            periodInteger = periodInteger + 1;

            //Get the teacher name 
            teacherString = adminDataSet.Tables[periodInteger].Rows[classNumberInteger - 1]["Teacher"].ToString(); 

            //Reset the period integer 
            periodInteger = periodInteger - 1;

            //Display teacher name
            teacherLabel.Text = "Teacher : " + teacherString;
            

        }
        //Get students attendance report for selected date
        private void GetStudentData()
        {
            //Declare variables 
            string numberString = "", tempString = "", nameString = string.Empty;
            int characterInteger = -1;
            object studentIdObject;
            DialogResult newEntryDialogResult;


            //Get students name from listbox
            if (sectionInteger == 0)
            {
                if (studentListBox.SelectedIndex > -1)
                {

                    nameString = studentListBox.SelectedItem.ToString();
                    studentListBox.Sorted = true;

                }
                else
                {
                    //Display error 
                    MessageBox.Show("No student selected. Please select a student to view attendance data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Exit method
                    return;
                }
            }

            else if (sectionInteger == 1 || sectionInteger == 2)
            {
                try
                {

                    nameString = student2ListBox.SelectedItem.ToString();

                }
                catch
                {
                    //Display error 
                    MessageBox.Show("No student selected. Please select a student to view attendance data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Exit method
                    return;
                }

            }
          



            //Loop through the nameString to determine where the name ends and the student id starts 
            foreach (char studentChar in nameString)
            {
                //Increment character counter by 1
                characterInteger = characterInteger + 1;

                //Convert charcter to a string 
                tempString = studentChar.ToString();

                //Check to see if student's name has ended
                if (tempString == "-")
                {
                    //Exit the foreach loop 
                    break;
                }
            }



            //Get the student number 
            numberString = nameString.Substring(characterInteger + 4, 6);

            //Reset character integer value to -1
            characterInteger = -1;

            //Get selected date
            dateString = monthCalendar1.SelectionStart.ToString();
            dateString = dateString.Substring(0, 10);

            //Find the student in the database 
            foreach (DataRow row in adminDataSet.Tables[1].Rows)
            {
                //Increment the counter by 1
                characterInteger++;

                //Get the current student number being referenced in the database
                studentIdObject = row["num"];

                //Convert the object to a string
                tempString = studentIdObject.ToString();

                //Check if the referenced student number equals the selected student number
                if (tempString == numberString)
                {
                    //Exit Foreach loop 
                    break;
                }
            }

            //Get students attendance report for the selected day 
            try
            {
                if (sectionInteger != 3)
                {
                    //Assign the value to the temporary string 
                    tempString = adminDataSet.Tables[1].Rows[characterInteger][dateString].ToString();

                    //Get and display number of lates and absences 
                    absentLabel.Text = adminDataSet.Tables[1].Rows[characterInteger]["a"].ToString();
                    lateLabel.Text = adminDataSet.Tables[1].Rows[characterInteger]["l"].ToString();

                    //Display student status
                    statusLabel.Text = statusString();

                    if (sectionInteger == 0 || sectionInteger == 1 || sectionInteger ==2 )
                    {
                        //Get attendance values for each period
                        GetAttendanceValues(tempString);

                        //Display attendance values
                        DisplayAttendanceValues();

                        //Display student name
                        studentLabel.Text = nameString + Environment.NewLine + "Grade : " +
                                            adminDataSet.Tables[1].Rows[characterInteger]["Grade"].ToString();

                        //Get total lates and absents 
                        lateTotalInteger = int.Parse(lateLabel.Text);
                        absentTotalInteger = int.Parse(absentLabel.Text);

                        //Display attendance value for the current period 
                        if (sectionInteger == 1)
                        {
                            classAttendance();
                        }
                    }
                }
            }

            //Catch error if no entry for the date exists 
            catch
            {
                
                //Display Question 
                newEntryDialogResult = MessageBox.Show("No Data for this date is avalible. Would you like to create a new entry?", "No Data Found",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //Add new column if dialog result is yes
                if (newEntryDialogResult == DialogResult.Yes)
                {
                    //Create new coloumn
                    adminDataSet.Tables[1].Columns.Add(dateString, typeof(string));

                    //Fill new coloumn with deafult string
                    foreach (DataRow row in adminDataSet.Tables[1].Rows)
                    {
                        row[dateString] = "0000";
                    }

                    //Assign value to temp string 
                    tempString = "";

                    //Get attendance values for each period
                    GetAttendanceValues(tempString);

                    //Display attendance values
                    DisplayAttendanceValues();

                    studentLabel.Text = nameString + Environment.NewLine + "Grade : " +
                                         adminDataSet.Tables[1].Rows[characterInteger]["Grade"].ToString();

                    //Display students status
                    statusLabel.Text = statusString();

                    //Get and display number of lates and absences 
                    absentLabel.Text = adminDataSet.Tables[1].Rows[characterInteger]["a"].ToString();
                    lateLabel.Text = adminDataSet.Tables[1].Rows[characterInteger]["l"].ToString();
                    lateTotalInteger = int.Parse(lateLabel.Text);
                    absentTotalInteger = int.Parse(absentLabel.Text);

                    //Display attendance value for the current period 
                    if (sectionInteger == 1)
                    {
                        classAttendance();
                    }

                }



            }
        }

        //Display attendance value for selected student in a selected class
        private void classAttendance()
        {
           
            if (periodInteger == 1)
            {
                periodStatusLabel.Text = "Status for this period : " + AttendanceString(period1Integer);
                
            }
            else if (periodInteger == 2)
            {
                periodStatusLabel.Text = "Status for this period : " + AttendanceString(period2Integer);
            }
            else if (periodInteger == 3)
            {
                periodStatusLabel.Text = "Status for this period : " + AttendanceString(period3Integer);
            }
            else if (periodInteger == 4)
            {
                periodStatusLabel.Text = "Status for this period : " + AttendanceString(period4Integer);
            }
        }

        //Determine students current status
        private string statusString()
        {
            //Get student number
            GetStudentNumber();

            //Get the status of selected student
            try
            {
                storageString = adminDataSet.Tables[1].Rows[storageInteger]["status"].ToString();
            }

            //Create status colomn if one doesn't exist
            catch
            {
                //Create a new column
                adminDataSet.Tables[1].Columns.Add("status", typeof(string));

                //Set the value of the storage string to be blank
                storageString = "";
            }

            //Return student status
            if (storageString == "")
            {
                return "Full Time Student";
            }
            else
            {
                return storageString;
            }
        }
        //Get attendance values for each period 
        private void GetAttendanceValues(string valueString)
        {
            
               
            //Return 0 for all values if string is empty 
            if (valueString == "")
            {
                //Assign value of 0 
                period1Integer = 0;
                period2Integer = 0;
                period3Integer = 0;
                period4Integer = 0;

                //Exit method
                return;

                
            }

            //Assign values to each integer based on the valuestring
            period1Integer = int.Parse(valueString.Substring(0, 1));
            period2Integer = int.Parse(valueString.Substring(1, 1));
            period3Integer = int.Parse(valueString.Substring(2, 1));
            period4Integer = int.Parse(valueString.Substring(3, 1));


        }

        //Display attendance values on screen 
        private void DisplayAttendanceValues()
        {
            //Display the attedance status for each period 
            period1Label.Text = AttendanceString(period1Integer);
            period2Label.Text = AttendanceString(period2Integer);
            period3Label.Text = AttendanceString(period3Integer);
            period4Label.Text = AttendanceString(period4Integer);

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
                default :
                    atString = "Present";
                    break;

            }

            //Return string value
            return atString;


        }

        //Get student/period attendance report for selected date when date is changed
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Get data depending current selected tab
            if (sectionInteger == 0 || sectionInteger == 1)
            {
                //Get student data
                GetStudentData();

                //Get selected date
                dateString = monthCalendar1.SelectionStart.ToString();
                dateString = dateString.Substring(0, 10);
            }
            else if (sectionInteger == 2)
            {
                //Get period data
                GetPeriodData();

                //Get selected date
                dateString = monthCalendar1.SelectionStart.ToString();
                dateString = dateString.Substring(0, 10);
            }
           

        }

        //Display the modify entry form 
        private void modifyPictureBox_Click(object sender, EventArgs e)
        {
            

            //Create a new instance of the modify form 
            ModifyForm modifyForm = new ModifyForm();

            //Get student number
            GetStudentNumber();

            //Only continute if a student name is selected
            if (studentListBox.SelectedIndex > -1)
            {
                //Pass on attendance values to the modify form 
                ModifyForm.value1Integer = period1Integer;
                ModifyForm.value2Integer = period2Integer;
                ModifyForm.value3Integer = period3Integer;
                ModifyForm.value4Integer = period4Integer;
                ModifyForm.absentInteger = absentTotalInteger;
                ModifyForm.lateInteger = late1TotalInteger;

                //Show the modify form 
                modifyForm.ShowDialog();

                //Update values
                updateValues();

                

                //Update period status label 
                if (sectionInteger == 1)
                {
                    classAttendance();
                }

              
            }
        }

        private void updateValues()
        {
            //Declare variables
            string newAttendanceString;

            //Display new values
            DisplayAttendanceValues();

            //Compile integers into a string
            newAttendanceString = period1Integer.ToString() + period2Integer.ToString() + period3Integer.ToString() + period4Integer.ToString();

            //Add new string into the database
            adminDataSet.Tables[1].Rows[storageInteger][dateString] = newAttendanceString;

            //Update absent and late totals
            adminDataSet.Tables[1].Rows[storageInteger]["a"] = absentTotalInteger;
            adminDataSet.Tables[1].Rows[storageInteger]["l"] = late1TotalInteger;

            //Display new absent and late totals
            absentLabel.Text = absentTotalInteger.ToString();
            lateLabel.Text = late1TotalInteger.ToString();
        }

        //Get student number
        private void GetStudentNumber()
        {
            //Declare variables 
            int characterInteger = -1;
            String tempString, nameString = "", numberString;
            object studentIdObject;

            //Get students name from listbox
            if (sectionInteger == 0)
            {
                if (studentListBox.SelectedIndex > -1)
                {
                    nameString = studentListBox.SelectedItem.ToString();
                }
                else
                {
                    //Display error 
                    MessageBox.Show("No student selected. Please select a student to view attendance data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Exit method
                    return;
                }
            }
            else if (sectionInteger == 1 || sectionInteger == 2)
            {
                if (student2ListBox.SelectedIndex > -1 && student2ListBox.SelectedItem.ToString() != "")
                {
                    nameString = student2ListBox.SelectedItem.ToString();
                }
                else
                {
                    //Display error 
                    MessageBox.Show("No student selected. Please select a student to view attendance data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Exit method
                    return;
                }
            }

             //Loop through the nameString to determine where the name ends and the student id starts 
            foreach (char studentChar in nameString)
            {
                //Increment character counter by 1
                characterInteger = characterInteger + 1;

                //Convert charcter to a string 
                tempString = studentChar.ToString();

                //Check to see if student's name has ended
                if (tempString == "-")
                {
                    //Exit the foreach loop 
                    break;
                }
            }



            //Get the student number 
            numberString = nameString.Substring(characterInteger + 4, 6);

            //Reset character integer value to -1
            characterInteger = -1;

            //Get selected date
            dateString = monthCalendar1.SelectionStart.ToString();
            dateString = dateString.Substring(0, 10);

            //Find the student in the database 
            foreach (DataRow row in adminDataSet.Tables[1].Rows)
            {
                //Increment the counter by 1
                characterInteger++;

                //Get the current student number being referenced in the database
                studentIdObject = row["num"];

                //Convert the object to a string
                tempString = studentIdObject.ToString();

                //Check if the referenced student number equals the selected student number
                if (tempString == numberString)
                {
                    //Exit Foreach loop 
                    break;
                }
            }

            //Pass on values
            storageInteger = characterInteger;
            storageString = numberString;
        }

        //Email parents 
        private void emailPictureBox_Click(object sender, EventArgs e)
        {
            //Declare variables
            DialogResult emailDialogResult;
            string emailString, messageString;

            //Get student number
            GetStudentNumber();

            

            if (studentListBox.SelectedIndex > -1)
            {
                //Ask user if he/she wants to send a email
                emailDialogResult = MessageBox.Show("Do you wish to send a email to this student's parents", "Send Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //Get parents email 
                emailString = adminDataSet.Tables[1].Rows[storageInteger]["email"].ToString(); ;

                //If email is blank display error and exit method
                if (emailString == "")
                {
                    //Display error
                    MessageBox.Show("No email on record. If you wish to register a email to this student's profile, please use the profile tool", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //exit method
                    return;

                }

                //Create an automated report to email to parents 
                messageString = msString();

                //Email student's parents 
                try
                {
                    //Create new Email message
                    MailMessage reportMailMessage = new MailMessage();

                    //Set location of the smtp server 
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    //Setup the email
                    reportMailMessage.From = new MailAddress("emeraldattendance@gmail.com");
                    reportMailMessage.To.Add(emailString);
                    reportMailMessage.Subject = "Attendance Report";
                    reportMailMessage.Body = messageString;

     
                    //Login into emerald attendance's gmail account on port 587
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("emeraldattendance@gmail.com", "123456att");
                    SmtpServer.EnableSsl = true;

                    //Send email 
                    SmtpServer.Send(reportMailMessage);
                    

                //Display success message 
                MessageBox.Show("Email Sent",
                                "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Catch any exceptions 
                catch
                {
                    
                    //Display error message
                    MessageBox.Show("Email Error : Emerald Attendance was unable to send the email, please refer to the manual for troubleshooting information",
                                    "Email Error" + Environment.NewLine + "Note : Email on students profile may be invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Create a automated email message
        private string msString()
        {
            //Generate message
            storageString = "Dear Parent's here is your child's Attendance report for " + dateString + Environment.NewLine +
                            "Period 1 : " + AttendanceString(period1Integer) + Environment.NewLine +
                            "Period 2 : " + AttendanceString(period2Integer) + Environment.NewLine +
                            "Period 3 : " + AttendanceString(period3Integer) + Environment.NewLine +
                            "Period 4 : " + AttendanceString(period4Integer) + Environment.NewLine +
                            "Report Generated by : Emerald Attendance";

            //Return message string
            return storageString;
        }

        //Print Student attendance report to print preview dialog
        private void printPictureBox_Click(object sender, EventArgs e)
        {
            //assign document to the preview dialog
            printPreviewDialog1.Document = printDocument1;

            //show print preview 
            printPreviewDialog1.ShowDialog(); 
        }

        //Setup student attendance report for the selected day 
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Declare variables
            string printString;

            //Get student number
            GetStudentNumber();

            if (studentListBox.SelectedIndex > -1)
            {
                //Generate print string
                printString = "Attendance report for : " + studentLabel.Text + Environment.NewLine +
                              "Date : " + dateString + Environment.NewLine +
                              "Period 1 : " + AttendanceString(period1Integer) + Environment.NewLine +
                              "Period 2 : " + AttendanceString(period2Integer) + Environment.NewLine +
                              "Period 3 : " + AttendanceString(period3Integer) + Environment.NewLine +
                              "Period 4 : " + AttendanceString(period4Integer) + Environment.NewLine +
                              "Report Generated by : Emerald Attendance";

                //Draw print string to the document 
                e.Graphics.DrawString(printString, new Font("Arial", 12), Brushes.Black, 100, 200);
            }
        }

        //Change student status 
        private void statusPictureBox_Click(object sender, EventArgs e)
        {
            //Get student number
            GetStudentNumber();

            if (studentListBox.SelectedIndex > -1)
            {
                //Get current status
                sString = statusLabel.Text;

                //Create new instance of the status form
                StatusForm statusForm = new StatusForm();

                //Pass on status string value
                StatusForm.statString = sString;

                //Show status form
                statusForm.ShowDialog();

                //Apply changes
                adminDataSet.Tables[1].Rows[storageInteger]["status"] = sString;

                //Update status label 
                if (sString == "")
                {
                    statusLabel.Text = "Full Time Student";
                }
                else 
                {
                    statusLabel.Text = sString;
                }

            }
        }

        //Reload student list 
        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            //Update student list 
            updateStudentList();

            //Clear search textbox
            searchTextBox.Text = "";
        }

        //Change tab to the class tab 
        private void classPictureBox_Click(object sender, EventArgs e)
        {
            //Set the section integer to 1
            sectionInteger = 1;

            //Update the list to show class names/numbers instead
            studentListBox.Items.Clear();
            updateStudentList();

        

            //Change the background image
            this.BackgroundImage = Emerald_Attendance.Properties.Resources.Admin_Panel___classes___gui___final;

            //Hide all controls not apart of the class tab 
            modifyPictureBox.Visible = false;
            emailPictureBox.Visible = false;
            statusPictureBox.Visible = false;
            printPictureBox.Visible = false;
            period1Label.Visible = false;
            period2Label.Visible = false;
            period3Label.Visible = false;
            period4Label.Visible = false;
            infoLabel.Visible = false;
            saveReportButton.Visible = false;
            previousReportButton.Visible = false;

            //Show controls apart of the class tab 
            student2ListBox.Visible = true;
            teacherLabel.Visible = true;
            periodStatusLabel.Visible = true;
            modify2PictureBox.Visible = true;
            studentListBox.Visible = true;
            searchTextBox.Visible = true;
            nameLabel.Visible = true;
            absentLabel.Visible = true;
            lateLabel.Visible = true;
            statusLabel.Visible = true;
            monthCalendar1.Visible = true;
            studentLabel.Visible = true;


        }

        //Get students attendance report for selected date when new student is selected 
        private void student2ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get student data only if a name is selected 
            if (student2ListBox.SelectedItem.ToString() != "---Late---" && student2ListBox.SelectedItem.ToString() != "---Absent---")
            {

                GetStudentData();
            }
            
        }

        

        //Modify a entry for a student 
        private void modify2PictureBox_Click(object sender, EventArgs e)
        {
            //Declare variables
            string valString;
            int selectedIndexInteger = 0;

            //Create a new instance of the modify form 
            ModifyForm modifyForm = new ModifyForm();

            //Get student number
            GetStudentNumber();

            //Get attendance values 
            valString = adminDataSet.Tables[1].Rows[storageInteger][dateString].ToString();

            //Get attendance values for each period 
            GetAttendanceValues(valString);

            

            //Only continute if a student name is selected
            if (student2ListBox.SelectedIndex > -1)
            {

                //Get the selected index integer
                if (sectionInteger == 2)
                {
                    selectedIndexInteger = studentListBox.SelectedIndex;
                }

                //Pass on attendance values to the modify form 
                ModifyForm.value1Integer = period1Integer;
                ModifyForm.value2Integer = period2Integer;
                ModifyForm.value3Integer = period3Integer;
                ModifyForm.value4Integer = period4Integer;
                ModifyForm.absentInteger = absentTotalInteger;
                ModifyForm.lateInteger = late1TotalInteger;

                //Show the modify form 
                modifyForm.ShowDialog();

                //Update values
                updateValues();



                //Update period status label 
                if (sectionInteger == 1)
                {
                    classAttendance();
                }
                else if (sectionInteger == 2)
                {
                    studentListBox.SelectedIndex = selectedIndexInteger;
                    GetPeriodData();
                }


            }
        }

    

        //Change to the section tab
        private void studentPictureBox_Click(object sender, EventArgs e)
        {
            //Set the section integer to 1
            sectionInteger = 0;

            //Update the list to show class names/numbers instead
            studentListBox.Items.Clear();
            student2ListBox.Items.Clear();
            updateStudentList();



            //Change the background image
            this.BackgroundImage = Emerald_Attendance.Properties.Resources.Admin_Panel___students___gui___final;

            //Show all controls apart of the students tab
            modifyPictureBox.Visible = true;
            emailPictureBox.Visible = true;
            statusPictureBox.Visible = true;
            printPictureBox.Visible = true;
            period1Label.Visible = true;
            period2Label.Visible = true;
            period3Label.Visible = true;
            period4Label.Visible = true;
            infoLabel.Visible = false;
            saveReportButton.Visible = false;
            previousReportButton.Visible = false;

            //Show controlls apart of the students tab 
            student2ListBox.Visible = false;
            teacherLabel.Visible = false;
            periodStatusLabel.Visible = false;
            modify2PictureBox.Visible = false;
            studentListBox.Visible = true;
            searchTextBox.Visible = true;
            nameLabel.Visible = true;
            absentLabel.Visible = true;
            lateLabel.Visible = true;
            statusLabel.Visible = true;
            monthCalendar1.Visible = true;
            studentLabel.Visible = true;

           

        }

        //Change to the period tab
        private void periodPictureBox_Click(object sender, EventArgs e)
        {
            //Set the section integer to 1
            sectionInteger = 2;

            //Update the list to show class names/numbers instead
            studentListBox.Items.Clear();
            student2ListBox.Items.Clear();
            updateStudentList();



            //Change the background image
            this.BackgroundImage = Emerald_Attendance.Properties.Resources.Admin_Panel___periods___gui___final;

            //Hide all controls not apart of the period tab  and show controls apart of the periods tab
            modifyPictureBox.Visible = false;
            emailPictureBox.Visible = false;
            statusPictureBox.Visible = false;
            printPictureBox.Visible = false;
            period1Label.Visible = false;
            period2Label.Visible = false;
            period3Label.Visible = false;
            period4Label.Visible = false;
            student2ListBox.Visible = true;
            teacherLabel.Visible = false;
            periodStatusLabel.Visible = false;
            modify2PictureBox.Visible = true;
            infoLabel.Visible = true;
            studentListBox.Visible = true;
            searchTextBox.Visible = true;
            nameLabel.Visible = true;
            absentLabel.Visible = true;
            lateLabel.Visible = true;
            statusLabel.Visible = true;
            monthCalendar1.Visible = true;
            saveReportButton.Visible = false;
            previousReportButton.Visible = false;
            studentLabel.Visible = true;
        }

        //change to the report tab
        private void reportPictureBox_Click(object sender, EventArgs e)
        {
            //Declare variables
            DialogResult confirmDialogResult;
            
            

            //Confirm tab change
            confirmDialogResult = MessageBox.Show("Do you want to proceed with report creation?" + Environment.NewLine  + "Make sure you have selected the desired date before proceeding",
                                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //stop loading new tab if result is not
            if (confirmDialogResult == DialogResult.No) 
            {
                return;
            }

            //Check if a was not selected
            if (dateString == "")
            {
                //Display error 
                MessageBox.Show("Error : No date selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Stop loading new tab 
                return;
            }

            //Set the section integer 
            sectionInteger = 3;

            //Change the background image
            this.BackgroundImage = Emerald_Attendance.Properties.Resources.Admin_Panel___Report___gui___final;

            //Hide all controls not apart of the report tab  and show controls apart of the periods tab
            modifyPictureBox.Visible = false;
            emailPictureBox.Visible = false;
            statusPictureBox.Visible = false;
            printPictureBox.Visible = false;
            period1Label.Visible = false;
            period2Label.Visible = false;
            period3Label.Visible = false;
            period4Label.Visible = false;
            student2ListBox.Visible = false;
            teacherLabel.Visible = false;
            periodStatusLabel.Visible = false;
            modify2PictureBox.Visible = true;
            infoLabel.Visible = false;
            studentListBox.Visible = false;
            searchTextBox.Visible = false;
            absentLabel.Visible = false;
            lateLabel.Visible = false;
            statusLabel.Visible = false;
            monthCalendar1.Visible = false;
            saveReportButton.Visible = true;
            previousReportButton.Visible = true;
            studentLabel.Visible = false;

        }
        
        //Determine if student was late 
        private void getReportLateValue(int startInteger, int endInteger)
        {
            //Determine stuents who were late and write there name/email to the report
            foreach (DataRow row in adminDataSet.Tables[1].Rows)
            {
                try
                {
                    //Get attendance string
                    temp1String = row[dateString].ToString();
                }

                //Catch any exceptions 
                catch
                {
                    reportErrorBoolean = true;
                    break;
                }

                //Get value for set period 
                try
                {
                    temp1String = temp1String.Substring(startInteger, endInteger);
                }

                //Catch any exceptions 
                catch
                {
                    temp1String = "0";
                }



                //Get the integer value
                temp1Integer = int.Parse(temp1String);

                //Determine if student was late
                if (temp1Integer == 2)
                {
                    //Write students name the report string
                    reportString = reportString + Environment.NewLine + row["Name"].ToString() + " --- " + row["num"].ToString();
                    late1TotalInteger = late1TotalInteger + 1;
                }



            }
        }

        //Determine if student was absenrt
        private void getReportAbsentValue(int startInteger, int endInteger)
        {
            //Determine stuents who were late and write there name/email to the report
            foreach (DataRow row in adminDataSet.Tables[1].Rows)
            {
                //Get attendance string
                temp1String = row[dateString].ToString();

                //Get value for set period 
                try
                {
                    temp1String = temp1String.Substring(startInteger, endInteger);
                }

                //Catch any exceptions 
                catch
                {
                    temp1String = "0";
                }



                //Get the integer value
                temp1Integer = int.Parse(temp1String);

                //Determine if student was absent
                if (temp1Integer == 1)
                {
                    //Write students name the report string
                    reportString = reportString + Environment.NewLine + row["Name"].ToString() + " --- " + row["num"].ToString();
                    absentReportTotalInteger = absentReportTotalInteger + 1;
                }



            }
        }

        //Save report for selected day in a txt file 
        private void saveReportButton_Click(object sender, EventArgs e)
        {
            //declare variables
            int startingInteger = 0, endingInteger = 1;
            string tempDateString;
          
            //Reset the report string
            reportString = "";

            //take out /'s from the date string
            tempDateString = dateString.Substring(0, 2) + "-" + dateString.Substring(3, 2);

            //set save location 
            locationString = @"c:\temp\attreports\" + tempDateString + ".txt";
          
         
            //Delete file if it already exists 
            if (File.Exists(locationString))
            {
                File.Delete(locationString);
            }

            //Start setting up the report to save
            reportString = "Emerald Attendance Report for " + dateString + Environment.NewLine + "Report created by Report Maker v1.0";

            //Students late for period 1
            reportString = reportString + Environment.NewLine + "Students who were late period 1";
            startingInteger = 0;
            getReportLateValue(startingInteger, endingInteger);

            //Students late for period 2
            reportString = reportString + Environment.NewLine + "Students who were late period 2";
            startingInteger = 1;
            getReportLateValue(startingInteger, endingInteger);

            //Students late for period 3
            reportString = reportString + Environment.NewLine + "Students who were late period 3";
            startingInteger = 2;
            getReportLateValue(startingInteger, endingInteger);

            //Students late for period 4
            reportString = reportString + Environment.NewLine + "Students who were late period 4";
            startingInteger = 3;
            getReportLateValue(startingInteger, endingInteger);

            //Display error message if an exception was rasied 
            if (reportErrorBoolean == true)
            {
                //Display error message
                MessageBox.Show("Error : No data exists for the selected day" + Environment.NewLine + "Please create a entry for the selected day before requesting a report",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //stop report creation
                return;
            }


            //Students Absent for period 1
            reportString = reportString + Environment.NewLine + "Students who were absent period 1";
            startingInteger = 0;
            getReportAbsentValue(startingInteger, endingInteger);

            //Students Absent for period 2
            reportString = reportString + Environment.NewLine + "Students who were absent period 2";
            startingInteger = 1;
            getReportAbsentValue(startingInteger, endingInteger);

            //Students Absent for period 3
            reportString = reportString + Environment.NewLine + "Students who were absent period 3";
            startingInteger = 2;
            getReportAbsentValue(startingInteger, endingInteger);

            //Students Absent for period 4
            reportString = reportString + Environment.NewLine + "Students who were absent period 4";
            startingInteger = 3;
            getReportAbsentValue(startingInteger, endingInteger);

            //Total absents and lates
            reportString = reportString + Environment.NewLine + "Total Absents : " + absentReportTotalInteger.ToString();
            reportString = reportString + Environment.NewLine + "Total Lates : " + late1TotalInteger.ToString();

            //End of report
            reportString = reportString + Environment.NewLine + "End of report for " + dateString;


            //Write report to a text file 
            FileStream reportFileStream = new FileStream(locationString, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter reportStreamWriter = new StreamWriter(reportFileStream);
            reportStreamWriter.Write(reportString);

            //Close and save the txt file 
            reportStreamWriter.Close();

            //Display success message and open folder containing file
            MessageBox.Show("Report Created and Saved to C:-temp-attreports", "Report Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(@"c:\temp\attreports");
        }

        //Open folder containing previous reports
        private void previousReportButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\temp\attreports");
        }

        //Display form to enable user to add students/classes 
        private void addPictureBox_Click(object sender, EventArgs e)
        {
            //Create new instance of the add form
            AddForm addForm = new AddForm();

            //Show the add form 
            addForm.ShowDialog();

            //Update student list 
            updateStudentList();

        }

        //Display the aboutbox
        private void aboutPictureBox_Click(object sender, EventArgs e)
        {
            //Create new instance of the aboutform
            AboutBox1 aboutForm = new AboutBox1();

            //Show the about box
            aboutForm.ShowDialog();

        }

        //Display profile form
        private void profilePictureBox_Click(object sender, EventArgs e)
        {

            //Create new instance of the profile form
            ProfileForm profileForm = new ProfileForm();

            //get student number 
            GetStudentNumber();

            //Show the profile form
            profileForm.ShowDialog();

        }

        //Save and upload database 
        //FTP upload intergrated by Harsh, Bradley, & Logan
        //FTP upload code taken from : http://stackoverflow.com/questions/10151680/upload-file-on-ftp
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
      
            //Declare upload variables 
            String sourceFilePathString = "C:\\temp\\database.xml";
            String ftpString = "ftp://ftp.infcomp.x10.mx"; 
            String ftpUsernameString = "attendance@infcomp.x10.mx";
            String ftpPasswordString = "1234567";

            //Declare export variables
            string dttString = "C:\\temp\\database.xml";

        
            //Display uploading message
            closePictureBox.Visible = true;

            //Delete files if they already exist
            if (File.Exists(@dttString))
            {
                File.Delete(@dttString);
            }

            //Write XML file to the set location
            adminDataSet.WriteXml(dttString);


            //Upload to ftp server
            try
            {
                //Create a File object
                FileInfo objFile = new FileInfo(sourceFilePathString);
                FtpWebRequest objFTPRequest;

                // Create FtpWebRequest object 
                objFTPRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpString + "/" + objFile.Name));

                // Set Credintials
                objFTPRequest.Credentials = new NetworkCredential(ftpUsernameString, ftpPasswordString);
                objFTPRequest.KeepAlive = false;

                // Set the data transfer type.
                objFTPRequest.UseBinary = true;

                // Set content length
                objFTPRequest.ContentLength = objFile.Length;

                // Set request method
                objFTPRequest.Method = WebRequestMethods.Ftp.UploadFile;

                // Set buffer size
                int intBufferLength = 16 * 1024;
                byte[] objBuffer = new byte[intBufferLength];

                // Opens a file to read
                FileStream objFileStream = objFile.OpenRead();

                // Get Stream of the file
                System.IO.Stream objStream = objFTPRequest.GetRequestStream();

                //Set length size
                int len = 0;

                while ((len = objFileStream.Read(objBuffer, 0, intBufferLength)) != 0)
                {
                    // Write file Content 
                    objStream.Write(objBuffer, 0, len);

                }

                //Close Connection
                objStream.Close();
                objFileStream.Close();

            }

            //Catch any exceptions 
            catch 
            {
                //Display error
                MessageBox.Show("Error : Unable to Upload to Server" + Environment.NewLine + "Please check that application is not blocked in your firewall",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }

            //Exit application
            Application.Exit();
        }

        //Logout of the current account and show the login form
        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            //Declare variables
            DialogResult logoutDialogResult;

            //Confirm log-out
            logoutDialogResult = MessageBox.Show("Do you wish to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If answer was no, cancel logout
            if (logoutDialogResult == DialogResult.No)
            {
                return;
            }

            //Relaunch application to avoid errors when switching between forms
            //Work around for crashing bug 
            try
            {
                //Run the program again and close this one
                System.Diagnostics.Process.Start(Application.StartupPath + "\\Emerald Attendance.exe");

                //Upload data to server 
                AdminForm_FormClosing(null, null);

                //Close the current instance of the application 
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch
            {
                //Upload data to server 
                AdminForm_FormClosing(null, null);
            }
            
        }

       
       
       

       

      
      
    }
}
