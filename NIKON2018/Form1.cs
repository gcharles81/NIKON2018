using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Ini;
using System.IO;

namespace NIKON2018
{
    public partial class Form1 : Form
    {
        string Selected_Port_Baudrate;    //used for storing selected Baudrate and COMport,for displaying purposes 
        SerialPort COMport = new SerialPort();
        Boolean Have_message = false;
        String sRecv;


        public Form1()
        {
            InitializeComponent();

            FOLDERS(); /// Create folders if not found

            //Populate the Combobox with SerialPorts on the System
            ComboBox_Available_SerialPorts.Items.AddRange(SerialPort.GetPortNames());

            // Disable Baudrate Selection also
            ComboBox_Standard_Baudrates.Enabled = false;

            COMport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

        }

        public void FOLDERS()
        {

            String path18 = "test_folder";

            if (Directory.Exists(path18))
            {

            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path18);
            }


            String path19 = "config";

            if (Directory.Exists(path19))
            {

            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path19);
            }


            path18 = "config/COM_Settings.ini";

            if (File.Exists(path18))
            {


            }

            else//create it 
            {

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////		
                IniFile ini = new IniFile("config/COM_Settings.ini");

                ini.IniWriteValue("Info Serial", "File info ", "//File format created by Charles Galea 2018.");
                ini.IniWriteValue("Info Serial", "File Created ", DateTime.Now.ToString());

                ini.IniWriteValue("COMM SETTINGS", "PORT_NUMBER", "COM1");
                ini.IniWriteValue("COMM SETTINGS", "BAUD_RATE", "9600");
                ini.IniWriteValue("COMM SETTINGS", "PARITY", "None");
                ini.IniWriteValue("COMM SETTINGS", "DATA_BITS", "8");


                MessageBox.Show("Please make sure you setup COM Port for the first time");
            }
        }
        private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (COMport.BytesToRead == 23) //i need only byte 113 so i use '==3'
            {


                sRecv = COMport.ReadExisting();
                Have_message = true;
                //   label1.Text = sRecv.ToString();
            }


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Have_message)
            {
                string phrase = sRecv.ToString();



                string[] words = phrase.Split(',');



                String X = words[0].ToString();
                String Y = words[1].ToString();



                Xvalue_label.Text = X;
                Yvalue_label.Text = Y;



                Have_message = false;
                Send_CMD_SXY();//lets reply SXY

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Local Variables
            string Port_Name = ComboBox_Available_SerialPorts.SelectedItem.ToString();    // Store the selected COM port name to "Port_Name" varaiable
            int Baud_Rate = Convert.ToInt32(ComboBox_Standard_Baudrates.SelectedItem); // Convert the string "9600" to int32 9600
                                                                                       //Store the string in Textbox to variable "Data"

            //SerialPort COMport = new SerialPort(Port_Name, Baud_Rate, Parity.None, 8, StopBits.Two); //Create a new  SerialPort Object (defaullt setting -> 8N1)
            COMport.Encoding = Encoding.ASCII;
            COMport.PortName = Port_Name;
            COMport.BaudRate = Baud_Rate;
            COMport.Parity = Parity.None;
            COMport.DataBits = 8;
            COMport.StopBits = StopBits.Two;
            COMport.DtrEnable = true;
            COMport.RtsEnable = true;

            try
            {

                COMport.Open();
            }
            #region  
            catch (UnauthorizedAccessException SerialException) //exception that is thrown when the operating system denies access 
            {
                MessageBox.Show(SerialException.ToString());

                COMport.Close();
            }

            catch (System.IO.IOException SerialException)     // An attempt to set the state of the underlying port failed
            {
                MessageBox.Show(SerialException.ToString());

                COMport.Close();
            }

            catch (InvalidOperationException SerialException) // The specified port on the current instance of the SerialPort is already open
            {
                MessageBox.Show(SerialException.ToString());

                COMport.Close();
            }

            catch //Any other ERROR
            {
                MessageBox.Show("ERROR in Opening Serial PORT -- UnKnown ERROR");
                COMport.Close();
            }
            #endregion

        }

        private void button2_Click(object sender, EventArgs e)
        {
            COMport.Close();
        }

        private void RESET_button_Click(object sender, EventArgs e)
        {
            Send_CMD_SXY();
        }

        private void Send_CMD_SXY()
        {
            if (COMport.IsOpen == true)
            {
                String testStr = "SXY\r\n"; // Ascii "53 58 59 0D 0A"
                byte[] buf = System.Text.Encoding.UTF8.GetBytes(testStr);
                COMport.Write(buf, 0, buf.Length);
            }

            else
            {
                //Do nothng
            }
        }

        private void ComboBox_Standard_Baudrates_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Selected_Port_Baudrate = Selected_Port_Baudrate + Environment.NewLine;
            Selected_Port_Baudrate = Selected_Port_Baudrate + ComboBox_Standard_Baudrates.SelectedItem.ToString() + " bps selected";
        }


        private void ComboBox_Available_SerialPorts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Selected_Port_Baudrate = ComboBox_Available_SerialPorts.SelectedItem.ToString() + " Selected"; // Store the Selected COM port

                          

            ComboBox_Standard_Baudrates.Enabled = true;       // Enable Baudrate Selection after COM port is Selected
        }
    }
}
