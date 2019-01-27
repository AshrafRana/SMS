using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;


namespace School_Managment_System
{
    public partial class Phone_Setting : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSMSController = new MobileSMSController();

        public Phone_Setting()
        {
            InitializeComponent();
            loadPorts();
            baudRate();
            
        }

        private void loadPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comPortComboBox.Items.Add(port);
            }
        }
        private void baudRate()
        {
            string[] baudRate = { "9600" };
            foreach (string baud in baudRate)
            {
                baudRateCombo.Items.Add(baud);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

         

        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //sm.Opens();
            //MessageBox.Show(mobileSMSController.se.sendSMS("03438093250", "hello"));
            //sm.Closes();
        }

        private void GSMConnect_Click(object sender, EventArgs e)
        {
            if (comPortComboBox.Text == "")
            {

                MessageBox.Show("Select Port ");
            }
            else if (baudRateCombo.Text == "")
            {
                MessageBox.Show("Select Baud Rate ");
                
            }
            else
            {
                string status = mobileSMSController.gsmConnection(comPortComboBox.Text, baudRateCombo.Text);

                if (status == "connected")
                {
                   
                    List<string> comm = mobileSMSController.smsModemDetail();
                    string Phone_Name = comm[0];
                    string Phone_Model = comm[1];
                    string Revision_Num = comm[2];
                    string Serial_Num = comm[3];

                    gsmTimeOut.Text = "100";
                    gsmModel.Text = Phone_Model;
                    gsmName.Text = Phone_Name;
                    serialNo.Text = Serial_Num;
                    revisionNo.Text = Revision_Num;
                    GSMConnect.Enabled = false;
                }
            }
        }

        private void GSMDisconnect_Click(object sender, EventArgs e)
        {
            
            if (mobileSMSController.disconnectProt() == false)
            {
                MessageBox.Show("No Phone Connected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                 MessageBox.Show("Disconnected Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            gsmTimeOut.Text = "";
            gsmModel.Text = "";
            gsmName.Text = "";
            serialNo.Text = "";
            revisionNo.Text = "";
            GSMConnect.Enabled = true;

        }
    }
}
