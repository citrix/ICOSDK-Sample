using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WFICALib;
using AxWFICALib;
using System.Windows.Forms;
using System.IO;


//This is Non broker connection (Like port ICA)
namespace SampleProject
{

    public partial class ICOTesterForm : Form
    {    
        public ICOTesterForm()
        {
            InitializeComponent();

        }
        string sessionID = "Session";

        private void Form1_Load(object sender, EventArgs e)
        {
          
            lblICAVer.Text = axICAClient1.ClientVersion.ToString();
            lblICOVer.Text = axICAClient1.Version.ToString();

            this.axICAClient1.OnConnect += new EventHandler(axICAClient1_OnConnect);
            this.axICAClient1.OnConnectFailed += new EventHandler(axICAClient1_OnConnectFailed);
            this.axICAClient1.OnConnecting += new EventHandler(axICAClient1_OnConnecting);
            this.axICAClient1.OnDisconnect += new EventHandler(axICAClient1_OnDisconnect);
            this.axICAClient1.OnDisconnectFailed +=new EventHandler(axICAClient1_OnDisconnectFailed);
            this.axICAClient1.OnLogon += new EventHandler(axICAClient1_OnLogon);
            this.axICAClient1.OnLogonFailed += new EventHandler(axICAClient1_OnLogonFailed);
            this.axICAClient1.OnLogoffFailed += new EventHandler(axICAClient1_OnLogoffFailed);
            this.axICAClient1.OnPublishedApp +=new EventHandler(axICAClient1_OnPublishedApp);
            this.axICAClient1.OnPublishedAppFailed +=new EventHandler(axICAClient1_OnPublishedAppFailed);
            

        }


       /// <summary>
       /// Event to hamdle button click for establishing the connection with ICA sessions
       /// </summary>
       /// <param name="sender">object </param>
       /// <param name="e">Pass the event args for the handler </param>
        private void btnConnect1_Click(object sender, EventArgs e)
        {
            axICAClient_Connect();
        }


        
        /// <summary>
        /// Setting some of the properties for establishing the connection such as 
        /// Example:
        /// axICAClient1.Address = "10.10.136.4" + ":1494";
        /// axICAClient1.HttpBrowserAddress = "10.10.136.4";
        /// axICAClient1.Username = "xyzabc";
        /// axICAClient1.SetProp("ClearPassword", "abcd@12");
        /// axICAClient1.Domain = "citrix";
        /// </summary>
        private void axICAClient_Connect()
        {

            // Initialzing 'AxWFICALib.AxICAClient ' object to some properties as shown below
            axICAClient1.BrowserProtocol = "HTTPOnTCP";

            //axICAClient1.Address, should be Server IP to which connection is to be made
            axICAClient1.Address = txtHTTPAddress.Text + ":1494";

            //axICAClient1.HttpBrowserAddress, should be also a Server IP to which connection is to be made
            axICAClient1.HttpBrowserAddress = txtHTTPAddress.Text;

            //Specify User Name, Password and domain of the Server
            axICAClient1.Username = txtUserName.Text;
            axICAClient1.SetProp("ClearPassword", textBox2.Text);
            axICAClient1.Domain = txtDomain.Text;

            //Un-Comment this below line to launch only applications published
            //axICAClient1.InitialProgram = "#" + txtAppName.Text;

            //This below line is to launch a VDA (Connect to Server). Comment this line of code and uncomment the above line to launch an application only.
            axICAClient1.Application = "";

            //Specify properties for Launch a session within the axICAClient1 control 
            axICAClient1.Launch = !IsEmbedded.Checked;
            axICAClient1.DesiredColor = ICAColorDepth.Color24Bit;
            axICAClient1.OutputMode = OutputMode.OutputModeWindowless;
            //Specify Height and Width below
            axICAClient1.DesiredHRes = 1024;
            axICAClient1.DesiredVRes = 786;

            //Setting the property for establish a connection in seamless or non-seamless
            axICAClient1.TWIMode = IsSeamless.Checked;

           
            //Invoke connect function of AxWFICALib library
            axICAClient1.Connect();
            
        }


        

        /// <summary>
        /// This function is to implement Disconnect Session
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">Pass the event args for the handler</param>
        private void btnDisconn1_Click(object sender, EventArgs e)
        {
            //invoking Disconnect function of AxWFICALib library
            axICAClient1.Disconnect();
            
        }


        /// <summary>
        /// This function is to implement LogOff Session
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">Pass the event args for the handler</param>
        private void btnLogoff1_Click(object sender, EventArgs e)
        {
            //invoking LogOff function of AxWFICALib library
            axICAClient1.Logoff();
        }

        /// <summary>
        /// This function is to launch an new Notepad within the connected Session
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">Pass the event args for the handler</param>
 
        private void btnLaunchNotepad_Click(object sender, EventArgs e)
        {
            //Run an Notepad within the Launched VDA session.
            axICAClient1.RunPublishedApplication("#Notepad", "");

            //If you want to launch Notepad and open any Text file which you might want to defaultly open every time you click Launch Notepad, 
            //provide the second argument for "axICAClient1.RunPublishedApplication("#Notepad", "");"  the path of text file you want to open. 
            //For Example: axICAClient1.RunPublishedApplication("#Notepad", "C:\\ToBeTested\\Test.txt");
           
        }

        /// <summary>
        ///  Event to hamdle button click for Clearing the List Results Window
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">Pass the event args for the handler</param>
        private void ClearEventWindow_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
        }



        private void axICAClient1_OnConnecting(object sender, EventArgs e)
        {
            lstResults.Items.Add("axICAClient1: Connecting Session [OnConnecting Event]");
        }

      
        private void axICAClient1_OnConnect(object sender, EventArgs e)
        {
           
            lstResults.Items.Add("axICAClient1: Connected Session [OnConnect Event]");
            
            int errcode = axICAClient1.SetSessionId(sessionID);
            if (errcode == 0)
            {
                lstResults.Items.Add("axICAClient1: Session ID set");
            }
            else
                lstResults.Items.Add("axICAClient1: Failed to set Session ID");
        }


        private void axICAClient1_OnLogon(object sender, EventArgs e)
        {
            lstResults.Items.Add("axICAClient1: Logging in to the Session [OnLogon Event]");
            int i = axICAClient1.GetChannelCount();
            lstResults.Items.Add("axICAClient1: Number of channels are" + Convert.ToString(i));
            lstResults.Items.Add("axICAClient1: Channel name is = " + axICAClient1.GetChannelName(0));
            i = axICAClient1.SendChannelData(axICAClient1.GetChannelName(0), axICAClient1.GetChannelName(0), 0, ICAVCDataType.DataTypeString);
            lstResults.Items.Add("SendChannel data output:" + Convert.ToString(i));
        }
        
        private void axICAClient1_OnConnectFailed(object sender, EventArgs e)
        {
            lstResults.Items.Add("axICAClient1: Connection Failed [OnConnectFailed Event]");
        }

        private void axICAClient1_OnPublishedApp(object sender, EventArgs e)
        {
            lstResults.Items.Add("axICAClient1: launched a new app [ica_OnPublishedApp Event]");
        }

        private void axICAClient1_OnPublishedAppFailed(object sender, EventArgs e)
        {
            lstResults.Items.Add("axICAClient1: Failed to launched a new app [ica_OnPublishedApp Event]");
        }

        private void axICAClient1_OnDisconnect(object sender, EventArgs e)
        {
            lstResults.Items.Add("axICAClient1: Session Disconnected [OnDisconnect Event]");
        }
      
        private void axICAClient1_OnDisconnectFailed(object sender, EventArgs e)
        {
            lstResults.Items.Add("axICAClient1: Session Disconnect Failed [OnDisconnectFailed Event]");
        }

        private void axICAClient1_OnLogoffFailed(object sender, EventArgs e)
        {
            lstResults.Items.Add("axICAClient1: Logoff Failed [OnLogoffFailed]");
        }

        private void axICAClient1_OnLogonFailed(object sender, EventArgs e)
        {
            lstResults.Items.Add("axICAClient1: Logon Failed [OnLogonFailed Event]");
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\\";
            openFileDialog1.Title = "Browse ICA Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.Filter = "ICA files (*.ica)|*.ica";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

   
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                axICAClient1.Launch = true;
                axICAClient1.LoadIcaFile(textBox1.Text);
                axICAClient1.Connect();

            }

        }
       
      
    }
}
