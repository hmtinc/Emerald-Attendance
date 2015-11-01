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
using System.Net;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Odbc;
using System.IO;






namespace Emerald_Attendance
{   

    public partial class LoginForm : Form
    {

        //Declare Login Variables 
        string usernameString, passwordString; //Username and Password
        bool connectionBoolean = false ; //Connection (Stores connection status)
        int counterInteger; //Counter variable
        HttpWebResponse result; //Result of web connection 
        bool loginCheckBoolean = false; //Login boolean (Determine if user is allowed to login)
        int accountIndexInteger; //Index of account in database 
        bool adminBoolean = false; //Admin boolean
        public static bool formOpenedBoolean = false;

        //Declare Database variables
        public static DataSet databaseDataSet;
     

        public LoginForm()
        {
            InitializeComponent();
        }

        //Form Load (Contact server and set default properties for objects on forms)
        private void loginForm_Load(object sender, EventArgs e)
        {
            //Declare variables
            string folderName = @"c:\temp";
            string pathString = System.IO.Path.Combine(folderName, "attreports");
            string xmlString = @"C:\temp\database.xml";

            //Delete the xml file if it already exist
            if (File.Exists(xmlString))
            {
                File.Delete(xmlString);
            }

            //Create reports folder if it doesn't exsist
            try
            {
                System.IO.Directory.CreateDirectory(pathString);
                Console.WriteLine("Folder created");
            }

            //Catch any exceptions 
            catch
            {
                Console.WriteLine("Folder already exists");
            }

            //Contact server and declare server connect variables 
            try
            {
                //Request index web page from server
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://infcomp.x10.mx");
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();

                //Assign result to connection result variable 
                result = response;
            }

            //Catch Exception if server is offline 
            catch (WebException)
            {
                result = null; // set connection result status to null (server not avalible)
            }



            //Make Textbox's back colour the same as the background
            userTextBox.BackColor = Color.FromArgb(34, 34, 34);
            passwordTextBox.BackColor = Color.FromArgb(34, 34, 34);

            //Make Label's back colour the same as the background
            copyrightLabel.BackColor = Color.FromArgb(126, 126, 126);

            //Determine if server is online and assign value to connection variable
            if (result == null || result.StatusCode != HttpStatusCode.OK)
            {
                connectionBoolean = false; //Set Connection variable to connection failed 
                this.Text = "Error #101 : Failed to Connect to Infinity Computing's Server"; //Display error message in form title 

            }
            else
            {
                connectionBoolean = true; //Set connection variable to connected

            }

            //Only continue if this is the first time the loginform instance is being loaded
            if (formOpenedBoolean == false)
            {
                //Download XML database from server
                FTPConnect();


                //Create a new dataset to copy the xml file to
                databaseDataSet = new DataSet();

                // Create new FileStream to read xml 
                System.IO.FileStream fsReadXml = new System.IO.FileStream
                    (xmlString, System.IO.FileMode.Open);

                //Read the xml database into the dataset 
                try
                {
                    databaseDataSet.ReadXml(fsReadXml);

                }
                catch (Exception ex)
                {
                    //Display Error
                    MessageBox.Show(ex.ToString());

                    //set connection boolean to false
                    connectionBoolean = false;
                }
                finally
                {
                    //Close File stream
                    fsReadXml.Close();
                }

            }
            





        }

        //Hide password with the default system password character
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            //Hide Text in Password box with the System Password Character 
            passwordTextBox.UseSystemPasswordChar = true;

            
        }

        //Start Login procedure if the login picture is clicked
        private void loginPictureBox_Click(object sender, EventArgs e)
        {
            //Change background image to give the illusion of a pressed button 
            this.BackgroundImage = Emerald_Attendance.Properties.Resources.Login_Screen_selected;

            //Run login script 
            login(); 

            //Change Background Image back to orginal login screen image
            this.BackgroundImage = Emerald_Attendance.Properties.Resources.Login_Screen;


        }

     //Login Procedure 
        private void login()
        {
            //Declare variables
            int lengthInteger = 0, tableCounterInteger = 0;
            object usernameObject, passwordObject;
            string tempUserString, tempPassString;
            bool correctUserBoolean = false;

            //Proceed with login only if application is conncted to server 
            if (loginCheckBoolean == true)
            {
                //Get entered username and password from textboxes
                usernameString = userTextBox.Text;
                passwordString = passwordTextBox.Text;

                //Get length of dataset 
                lengthInteger = databaseDataSet.Tables[0].Select("Registered").Length;
          
            
                //Loop through dataset until match for username is found or datset runs out 
                foreach (DataRow row in databaseDataSet.Tables[0].Rows)
                {
                    //Set value of cell to the username object 
                    usernameObject = row["Username"];

                    //Convert object to string and assign it username string variable 
                    tempUserString = usernameObject.ToString();

                    //Add 1 to the counter
                    tableCounterInteger = tableCounterInteger + 1;

                    //Check if username matchs input 
                    if (tempUserString == usernameString)
                    {
                        //Assign row number to account index variable 
                        accountIndexInteger = tableCounterInteger - 1;

                        //Set correct user boolean to true
                        correctUserBoolean = true;
                        
                        //Exit for each loop 
                        break;
                    }

                    
                }

                //Only continue with login if correct username was found 
                if (correctUserBoolean == true)
                {
                    //Get password that matchs current user
                    passwordObject = databaseDataSet.Tables[0].Rows[accountIndexInteger]["Password"];

                    //Convert password object to a string
                    tempPassString = passwordObject.ToString();

                    //Check if inputed password matchs database
                    if (passwordString == tempPassString)
                    {
                        //Check if user is a admin 
                        adminCheck();

                        //Load New form based on
                        loadForm();

                    }
                    else 
                    {
                        //Display login error message 
                        MessageBox.Show("Invalid Password : Please Note Passwords Are Case-Sensitive", "Error #104", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //Exit login method
                        return;
                    }

                }
                else
                {
                    //Display login error message 
                    MessageBox.Show("Invalid Username : Please Note Usernames Are Case-Sensitive", "Error #103", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Exit login method
                    return;
                }

                


                
            }
        }

    //Check if user is admin
        private void adminCheck()
        {
            //Declare variables 
            object adminObject;

            //Get true/false value from admin coloum 
            adminObject = databaseDataSet.Tables[0].Rows[accountIndexInteger]["Admin"];

            //Assign admin value to admin boolean 
            adminBoolean = Convert.ToBoolean(adminObject);

        }

    //Load new form based on account status
        private void loadForm()
        {
            //Load admin form or teachers form 
            if (adminBoolean == true)
            {
                //Create a new instance of the admin form 
                AdminForm adminForm = new AdminForm();
           

                //Transfer dataset and account varaibles to the admin form
                AdminForm.adminDataSet = databaseDataSet;
                AdminForm.indexInteger = accountIndexInteger;

                //Show admin form 
                adminForm.Show();

                //Hide the login form 
                this.Visible = false;

                //Clear the username and password fields
                userTextBox.Text = "Username";
                passwordTextBox.Text = "Password";
            }
            else
            {
                //Create new instance of the teacher form
                TeacherForm teacherForm = new TeacherForm();

                //Transfer dataset and account variables to the teacher form
                TeacherForm.teacherDataset = databaseDataSet;
                TeacherForm.indexInteger = accountIndexInteger;

                //Show the teacher form
                teacherForm.Show();

                //Hide the login form 
                this.Visible = false;

                //Clear the username and password fields
                userTextBox.Text = "Username";
                passwordTextBox.Text = "Password";
            }
        }

    
    // Enter Button Code (Run login proocedure if enter is pressed since main login button is a picture not a button )
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Run Login Script if enter if pressed while the text is highlighted 
                login();
            }
        }

        private void userTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Run Login Script if enter if pressed while the text boxis highlighted 
                login();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Run Login Script if enter if pressed while the form  is highlighted 
                login();
            }
        }

        //Save and upload database 
        //FTP upload intergrated by Harsh, Bradley, & Logan
        //FTP upload code taken from : http://stackoverflow.com/questions/10151680/upload-file-on-ftp
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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
            connectionPictureBox.Image = Emerald_Attendance.Properties.Resources.upload_final;

            //Delete files if they already exist
            if (File.Exists(@dttString))
            {
                File.Delete(@dttString);
            }

            //Write XML file to the set location
            databaseDataSet.WriteXml(dttString);


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
                MessageBox.Show("FTP Error : Unable to Upload to Server" + Environment.NewLine + "Please check that application is not blocked in your firewall",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //Exit application
            Application.Exit(); 
        }

        //Timer to auto close promt screen and display connection status 
        private void connectionTimer_Tick(object sender, EventArgs e)
        {
            counterInteger = counterInteger + 1; // Add 1 to the counter 

            //Display correct status depending on connection status
            if ((connectionBoolean == true)&&(counterInteger == 3))
            {
                connectionPictureBox.Image = Emerald_Attendance.Properties.Resources.connected; //Display Connection estabished 
            }
            else if ((connectionBoolean == true)&&(counterInteger == 5 ))
            {
                connectionPictureBox.Hide(); //Hide Picturebox 
                connectionTimer.Enabled = false; //disable timer
                loginCheckBoolean = true; //Set login boolean to true
            }
            else if ((connectionBoolean == false) && (counterInteger == 3))
            {
                connectionPictureBox.Image = Emerald_Attendance.Properties.Resources.connectfail; //Display Connection failed
            }
            else if (counterInteger == 8)
            {
                Application.Exit(); //Exit application if connection has failed
            }
        }

        //Connect to ftp server and download the access database 
        private void FTPConnect()
        {
            //Attempt to download the file from the server
            try
            {
                //Declare Connection Variables and assign values 
                int read;
                FtpWebRequest requestFtpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://ftp.infcomp.x10.mx/database.xml"); //Server address 
                requestFtpWebRequest.Method = WebRequestMethods.Ftp.DownloadFile; // Connection action
                    requestFtpWebRequest.Credentials = new NetworkCredential("attendance@infcomp.x10.mx", "1234567"); //Username and Pass
                FtpWebResponse responderFtpWebResponse = (FtpWebResponse)requestFtpWebRequest.GetResponse();
                Stream responseStream = responderFtpWebResponse.GetResponseStream();
                FileStream databaseFileStream = File.Create(@"C:\temp\database.xml");
                responseStream.ReadTimeout = 10000;
                byte[] downloadBufferByte = new byte[32 * 1024];

                

                
                //Download file in 32mb Chunks
                while ((read = responseStream.Read(downloadBufferByte, 0, downloadBufferByte.Length)) > 0)
                {
                    //Read the File and Write it to the buffer 
                    databaseFileStream.Write(downloadBufferByte, 0, read);
                }

                //Close the file 
                databaseFileStream.Close();

                //Close the connection
                responseStream.Close();
                responderFtpWebResponse.Close();
            }

            //Catch any exceptions 
            catch
            {
                //Set connection boolean to = false
                connectionBoolean = false;

                //Display error in form title
                this.Text = "Error #103 : FTP Error";
            }

        }

        //Exit application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm_FormClosing(null, null);
        }

        // Display about box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create new instance of the about form
            AboutBox1 aboutForm = new AboutBox1();

            //Display the about box
            aboutForm.ShowDialog();
        }

        //Clear password when click to prevent people from copying passwords 
        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
        }

        //Open quickstart guide located on infcomp.x10.mx
        private void quickStartGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://infcomp.x10.mx/guide.pdf");

        }

     

        
      
        }


  

    }

