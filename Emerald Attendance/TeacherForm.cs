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

    public partial class TeacherForm : Form
    {
        //Declare variables
        public static DataSet teacherDataset;
        string dateStorageString, storageString;
        public static int indexInteger;
        int periodInteger = 0, sectionInteger = 0, period1Integer = 0, period2Integer = 0, period3Integer = 0, period4Integer = 0;
        int lateTotalInteger = 0, absentTotalInteger = 0, storageInteger =0;

       
      

        public TeacherForm()
        {
            InitializeComponent();
        }

        //Form load set all controls to default settings
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            //Declare variables
            object teacherNameObject;
            string classString;

            //Get admin name 
            teacherNameObject = teacherDataset.Tables[0].Rows[indexInteger]["Name"];

            //Display Teacher name is upper right corner
            nameLabel.Text = teacherNameObject.ToString();

            //Change back colour of list box to match background
            studentListBox.BackColor = Color.FromArgb(64, 64, 64);

            //Get selected date
            dateStorageString = monthCalendar1.SelectionStart.ToString();
            dateStorageString = dateStorageString.Substring(0, 10);

            //Get/display periods teacher teaches
            foreach (DataRow row in teacherDataset.Tables[2].Rows)
            {
                if (row["Teacher"].ToString() == nameLabel.Text)
                {
                    classString = row["ID"].ToString() + " Period 1 " + row["Class"].ToString();
                    period1Label.Text = classString;
                }
            }
            foreach (DataRow row in teacherDataset.Tables[3].Rows)
            {
                if (row["Teacher"].ToString() == nameLabel.Text)
                {
                    classString = row["ID"].ToString() + " Period 2 " + row["Class"].ToString();
                    period2Label.Text = classString;
                }
            }
            foreach (DataRow row in teacherDataset.Tables[4].Rows)
            {
                if (row["Teacher"].ToString() == nameLabel.Text)
                {
                    classString = row["ID"].ToString() + " Period 3 " + row["Class"].ToString();
                    period3Label.Text = classString;
                }
            }
            foreach (DataRow row in teacherDataset.Tables[5].Rows)
            {
                if (row["Teacher"].ToString() == nameLabel.Text)
                {
                    classString = row["ID"].ToString() + " Period 4 " + row["Class"].ToString();
                    period4Label.Text = classString;
                }
            }


        }


        //Update student list 
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Get selected date
            dateStorageString = monthCalendar1.SelectionStart.ToString();
            dateStorageString = dateStorageString.Substring(0, 10);

            //Get student data
            GetStudentData();

            

        }

        //Display students in teachers period 1 class
        private void period1Label_Click(object sender, EventArgs e)
        {
            if (period1Label.Text != "---")
            {
                //Declare variables 
                int classIdInteger = 0;

                //Set period integer value
                periodInteger = 1;

                //Clear listbox
                studentListBox.Items.Clear();

                //Get class id
                classIdInteger = int.Parse(period1Label.Text.Substring(0, 1));

                //Determine students apart of the class and display them in the listbox
                foreach (DataRow row in teacherDataset.Tables[1].Rows)
                {
                    if (row["1"].ToString() == classIdInteger.ToString())
                    {
                        studentListBox.Items.Add(row["Name"].ToString() + " --- " + row["num"].ToString());
                    }
                }

            }

        }

        //Display students in teachers period 2 class
        private void period2Label_Click(object sender, EventArgs e)
        {
            if (period2Label.Text != "---")
            {
                //Declare variables 
                int classIdInteger = 0;

                //Set period integer value
                periodInteger = 2;

                //Clear listbox
                studentListBox.Items.Clear();

                //Get class id
                classIdInteger = int.Parse(period1Label.Text.Substring(0, 1));

                //Determine students apart of the class and display them in the listbox
                foreach (DataRow row in teacherDataset.Tables[1].Rows)
                {
                    if (row["2"].ToString() == classIdInteger.ToString())
                    {
                        studentListBox.Items.Add(row["Name"].ToString() + " --- " + row["num"].ToString());
                    }
                }

            }

        }

        //Display students in teachers period 3 class
        private void period3Label_Click(object sender, EventArgs e)
        {
            if (period2Label.Text != "---")
            {
                //Declare variables 
                int classIdInteger = 0;

                //Set period integer value
                periodInteger = 3;

                //Clear listbox
                studentListBox.Items.Clear();

                //Get class id
                classIdInteger = int.Parse(period1Label.Text.Substring(0, 1));

                //Determine students apart of the class and display them in the listbox
                foreach (DataRow row in teacherDataset.Tables[1].Rows)
                {
                    if (row["3"].ToString() == classIdInteger.ToString())
                    {
                        studentListBox.Items.Add(row["Name"].ToString() + " --- " + row["num"].ToString());
                    }
                }

            }
        }

        //Display students in teachers period 4 class
        private void period4Label_Click(object sender, EventArgs e)
        {
            if (period2Label.Text != "---")
            {
                //Declare variables 
                int classIdInteger = 0;

                //Set period integer value
                periodInteger = 4;

                //Clear listbox
                studentListBox.Items.Clear();

                //Get class id
                classIdInteger = int.Parse(period1Label.Text.Substring(0, 1));

                //Determine students apart of the class and display them in the listbox
                foreach (DataRow row in teacherDataset.Tables[1].Rows)
                {
                    if (row["4"].ToString() == classIdInteger.ToString())
                    {
                        studentListBox.Items.Add(row["Name"].ToString() + " --- " + row["num"].ToString());
                    }
                }

            }
        }

        //Get student data
        private void GetStudentData()
        {
            //Declare variables 
            string numberString = "", tempString = "", nameString = string.Empty;
            int characterInteger = -1;
            object studentIdObject;
            DialogResult newEntryDialogResult;


            //Get students name from listbox
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
            dateStorageString = monthCalendar1.SelectionStart.ToString();
            dateStorageString = dateStorageString.Substring(0, 10);

            //Find the student in the database 
            foreach (DataRow row in teacherDataset.Tables[1].Rows)
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
                
                    //Assign the value to the temporary string 
                    tempString = teacherDataset.Tables[1].Rows[characterInteger][dateStorageString].ToString();

                    //Get and display number of lates and absences 
                    absentLabel.Text = teacherDataset.Tables[1].Rows[characterInteger]["a"].ToString();
                    lateLabel.Text = teacherDataset.Tables[1].Rows[characterInteger]["l"].ToString();

                    //Display student status
                    statusLabel.Text = statusString();

                    if (sectionInteger == 0 )
                    {
                        //Get attendance values for each period
                        GetAttendanceValues(tempString);


                        //Display student name
                        studentLabel.Text = nameString + Environment.NewLine + "Grade : " +
                                            teacherDataset.Tables[1].Rows[characterInteger]["Grade"].ToString();

                        //Get total lates and absents 
                        lateTotalInteger = int.Parse(lateLabel.Text);
                        absentTotalInteger = int.Parse(absentLabel.Text);

                        //Display period data
                        classAttendance();

                       
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
                    teacherDataset.Tables[1].Columns.Add(dateStorageString, typeof(string));

                    //Assign value to temp string 
                    tempString = "";

                    //Get attendance values for each period
                    GetAttendanceValues(tempString);

      

                    studentLabel.Text = nameString + Environment.NewLine + "Grade : " +
                                         teacherDataset.Tables[1].Rows[characterInteger]["Grade"].ToString();

                    //Display students status
                    statusLabel.Text = statusString();
                    //Display period data
                    classAttendance();

                    //Get and display number of lates and absences 
                    absentLabel.Text = teacherDataset.Tables[1].Rows[characterInteger]["a"].ToString();
                    lateLabel.Text = teacherDataset.Tables[1].Rows[characterInteger]["l"].ToString();
                    lateTotalInteger = int.Parse(lateLabel.Text);
                    absentTotalInteger = int.Parse(absentLabel.Text);

                

                }



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

        private string statusString()
        {
            //Get student number
            GetStudentNumber();

            //Get the status of selected student
            storageString = teacherDataset.Tables[1].Rows[storageInteger]["status"].ToString();

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
            dateStorageString = monthCalendar1.SelectionStart.ToString();
            dateStorageString = dateStorageString.Substring(0, 10);

            //Find the student in the database 
            foreach (DataRow row in teacherDataset.Tables[1].Rows)
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

        //Update student data
        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get student data
            GetStudentData();

            
        }

        //Mark selected student as absent
        private void absentPictureBox_Click(object sender, EventArgs e)
        {
            //Declare variables
            string attendString;

            //Exit method if no student is selected
            if (studentListBox.SelectedIndex == -1)
            {
                //Display error
                MessageBox.Show("No Student Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Exit method
                return;
            }

      

            //Change value for current period to 1
            if (periodInteger == 1)
            {
                //Increment absent total
                if (period1Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                    absentTotalInteger = absentTotalInteger + 1;
                }
                else if (period1Integer != 1)
                {
                    absentTotalInteger = absentTotalInteger + 1;
                }

                //Set period integer value
                period1Integer = 1;
            }
            else if (periodInteger == 2)
            {
                //Increment absent total
                if (period2Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                    absentTotalInteger = absentTotalInteger + 1;
                }
                else if (period2Integer != 1)
                {
                    absentTotalInteger = absentTotalInteger + 1;
                }

                //Set period integer value
                period2Integer = 1;
            }
            else if (periodInteger == 3)
            {
                //Increment absent total
                if (period3Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                    absentTotalInteger = absentTotalInteger + 1;
                }
                else if (period3Integer != 1)
                {
                    absentTotalInteger = absentTotalInteger + 1;
                }

                //Set period integer value
                period3Integer = 1;
            }
            else if (periodInteger == 4)
            {
                //Increment absent total
                if (period4Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                    absentTotalInteger = absentTotalInteger + 1;
                }
                else if (period4Integer != 1)
                {
                    absentTotalInteger = absentTotalInteger + 1;
                }

                //Set period integer value
                period4Integer = 1;
            }
            else if (periodInteger == 0)
            {
                //Display error
                MessageBox.Show("No Period Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Exit method
                return;
            }

            //Compile new attendance string
            attendString = period1Integer.ToString() + period2Integer.ToString() + period3Integer.ToString() + period4Integer.ToString();

            //Save changes
            teacherDataset.Tables[1].Rows[storageInteger][dateStorageString] = attendString;
            teacherDataset.Tables[1].Rows[storageInteger]["a"] = absentTotalInteger;
            teacherDataset.Tables[1].Rows[storageInteger]["l"] = lateTotalInteger;

            //Update student data
            GetStudentData();
        }

        //Mark selected student as late
        private void LatePictureBox_Click(object sender, EventArgs e)
        {
            //Declare variables
            string attendString;

            //Exit method if no student is selected
            if (studentListBox.SelectedIndex == -1)
            {
                //Display error
                MessageBox.Show("No Student Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Exit method
                return;
            }

            //Change value for current period to 2
            if (periodInteger == 1)
            {
                //Increment late total
                if (period1Integer == 1)
                {
                    lateTotalInteger = lateTotalInteger + 1;
                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period1Integer != 2)
                {
                    lateTotalInteger = lateTotalInteger + 1;
                }

                //Set period integer value
                period1Integer = 2;
            }
            else if (periodInteger == 2)
            {
                //Increment late total
                if (period2Integer == 1)
                {
                    lateTotalInteger = lateTotalInteger + 1;
                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period2Integer != 2)
                {
                    lateTotalInteger = lateTotalInteger + 1;
                }

                //Set period integer value
                period2Integer = 2;
            }
            else if (periodInteger == 3)
            {
                //Increment late total
                if (period3Integer == 1)
                {
                    lateTotalInteger = lateTotalInteger + 1;
                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period3Integer != 2)
                {
                    lateTotalInteger = lateTotalInteger + 1;
                }

                //Set period integer value
                period3Integer = 2;
            }
            else if (periodInteger == 4)
            {
                //Increment late total
                if (period4Integer == 1)
                {
                    lateTotalInteger = lateTotalInteger + 1;
                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period4Integer != 2)
                {
                    lateTotalInteger = lateTotalInteger + 1;
                }

                //Set period integer value
                period4Integer = 1;
            }
            else if (periodInteger == 0)
            {
                //Display error
                MessageBox.Show("No Period Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Exit method
                return;
            }

        

            //Compile new attendance string
            attendString = period1Integer.ToString() + period2Integer.ToString() + period3Integer.ToString() + period4Integer.ToString();

            //Save changes
            teacherDataset.Tables[1].Rows[storageInteger][dateStorageString] = attendString;
            teacherDataset.Tables[1].Rows[storageInteger]["a"] = absentTotalInteger;
            teacherDataset.Tables[1].Rows[storageInteger]["l"] = lateTotalInteger;

            //Update student data
            GetStudentData();
        }

        //Mark selected student as on school trip
        private void schoolPictureBox_Click(object sender, EventArgs e)
        {
            //Declare variables
            string attendString;

            //Exit method if no student is selected
            if (studentListBox.SelectedIndex == -1)
            {
                //Display error
                MessageBox.Show("No Student Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Exit method
                return;
            }

            //Change value for current period to 3
            if (periodInteger == 1)
            {
                //decrement late/absent total
                if (period1Integer == 1)
                {
  
                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period1Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                }

                //Assign new value
                period1Integer = 3;
            }
            else if (periodInteger == 2)
            {
                //decrement late/absent total
                if (period2Integer == 1)
                {

                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period2Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                }

                //Assign new value
                period2Integer = 3;
            }
            else if (periodInteger == 2)
            {
                //decrement late/absent total
                if (period3Integer == 1)
                {

                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period3Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                }

                //Assign new value
                period3Integer = 3;
            }
            else if (periodInteger == 2)
            {
                //decrement late/absent total
                if (period4Integer == 1)
                {

                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period4Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                }

                //Assign new value
                period4Integer = 3;
            }
            else if (periodInteger == 2)
            {
                //Display error
                MessageBox.Show("No Period Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Exit method
                return;
            }

 
            //Compile new attendance string
            attendString = period1Integer.ToString() + period2Integer.ToString() + period3Integer.ToString() + period4Integer.ToString();

            //Save changes
            teacherDataset.Tables[1].Rows[storageInteger][dateStorageString] = attendString;
            teacherDataset.Tables[1].Rows[storageInteger]["a"] = absentTotalInteger;
            teacherDataset.Tables[1].Rows[storageInteger]["l"] = lateTotalInteger;


            //Update student data
            GetStudentData();
        }

        //Mark selected student as present
        private void presentPictureBox_Click(object sender, EventArgs e)
        {
            //Declare variables
            string attendString;

            //Exit method if no student is selected
            if (studentListBox.SelectedIndex == -1)
            {
                //Display error
                MessageBox.Show("No Student Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Exit method
                return;
            }

            //Change value for current period to 3
            if (periodInteger == 1)
            {
                //decrement late/absent total
                if (period1Integer == 1)
                {

                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period1Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                }

                //Assign new value
                period1Integer = 0;
            }
            else if (periodInteger == 2)
            {
                //decrement late/absent total
                if (period2Integer == 1)
                {

                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period2Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                }

                //Assign new value
                period2Integer = 0;
            }
            else if (periodInteger == 2)
            {
                //decrement late/absent total
                if (period3Integer == 1)
                {

                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period3Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                }

                //Assign new value
                period3Integer = 0;
            }
            else if (periodInteger == 2)
            {
                //decrement late/absent total
                if (period4Integer == 1)
                {

                    absentTotalInteger = absentTotalInteger - 1;
                }
                else if (period4Integer == 2)
                {
                    lateTotalInteger = lateTotalInteger - 1;
                }

                //Assign new value
                period4Integer = 0;
            }
            else if (periodInteger == 2)
            {
                //Display error
                MessageBox.Show("No Period Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Exit method
                return;
            }


            //Compile new attendance string
            attendString = period1Integer.ToString() + period2Integer.ToString() + period3Integer.ToString() + period4Integer.ToString();

            //Save changes
            teacherDataset.Tables[1].Rows[storageInteger][dateStorageString] = attendString;
            teacherDataset.Tables[1].Rows[storageInteger]["a"] = absentTotalInteger;
            teacherDataset.Tables[1].Rows[storageInteger]["l"] = lateTotalInteger;


            //Update student data
            GetStudentData();
        }

        //Mark student absent/present/late/on trip based on button pressed
        private void studentListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F1)
            {
                //Mark Absent
                absentPictureBox_Click(null, null);
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F2)
            {
                //Mark Late 
                LatePictureBox_Click(null, null);
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F3)
            {
                //Mark on trip  
                schoolPictureBox_Click(null, null);
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F4)
            {
                //Mark present
                presentPictureBox_Click(null, null);
            }
        }

        //Mark student absent/present/late/on trip based on button pressed
        private void TeacherForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F1)
            {
                //Mark Absent
                absentPictureBox_Click(null, null);
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F2)
            {
                //Mark Late 
                LatePictureBox_Click(null, null);
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F3)
            {
                //Mark on trip  
                schoolPictureBox_Click(null, null);
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F4)
            {
                //Mark present
                presentPictureBox_Click(null, null);
            }
        }


        //Save and upload database 
        //FTP upload intergrated by Harsh, Bradley, & Logan
        //FTP upload code taken from : http://stackoverflow.com/questions/10151680/upload-file-on-ftp
        private void TeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Declare upload variables 
            String sourceFilePathString = "C:\\temp\\database.xml";
            String ftpString = "ftp://ftp.infcomp.x10.mx";
            String ftpUsernameString = "attendance@infcomp.x10.mx";
            String ftpPasswordString = "1234567";

            //Declare export variables
            string dttString = "C:\\temp\\database.xml";

            //Display uploading message
            connectionPictureBox.Visible = true;
            

            //Delete files if they already exist
            if (File.Exists(@dttString))
            {
                File.Delete(@dttString);
            }

            //Write XML file to the set location
            teacherDataset.WriteXml(dttString);


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
                TeacherForm_FormClosing(null, null);

                //Close the current instance of the application 
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch
            {
                //Upload data to server 
                TeacherForm_FormClosing(null, null);
            }
        }

        //Submit attendance and Exit application 
        private void SubmitPictureBox_Click(object sender, EventArgs e)
        {
            //Declare variables
            DialogResult confirmDialogResult;

            //Confirm action
            confirmDialogResult = MessageBox.Show("Are you sure you want to submit your attendance entries to the server", "Submit",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If result is yes, save and exit the application
            if (confirmDialogResult == DialogResult.Yes)
            {
                TeacherForm_FormClosing(null, null);
            }

        }

       
    }
}
