using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.PduConverter;
using GsmComm.Server;


namespace School_Managment_System
{
    class MobileSMS
    {

        public static Int16 Comm_Port = 0;
        public static Int32 Comm_BaudRate = 0;
        public static Int32 Comm_TimeOut = 0;
        public static GsmCommMain comm;
        SmsSubmitPdu pdu1;

        //public void dis() {

        //    try
        //    {
        //        if (!comm.IsConnected())
        //        {
        //            MessageBox.Show("No Phone Connected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            return;
        //        }
        //        else
        //        {

        //            comm.Close();
        //            MessageBox.Show("Disconnected Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        }
        //    }

        //    catch (Exception No_Conn)
        //    {

        //        MessageBox.Show("No Phone Connected!!\r\n\n" + No_Conn, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //    }

        //}
        public string MessageReceived()
        {
            string status = "";
            
            return status;
        }
        public string set(string comPort, string baudRate) {
            string status = "";
            try
            {
                Comm_Port = Convert.ToInt16("6");
                Comm_BaudRate = Convert.ToInt32(9600);
                Comm_TimeOut = Convert.ToInt32(100);
                comm = new GsmCommMain(Comm_Port, Comm_BaudRate, Comm_TimeOut);

            }
            catch (Exception E1)
            {
                MessageBox.Show("Error Converting COM Port Settings Values", "Check COM Port Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

            comm = new GsmCommMain(Comm_Port, Comm_BaudRate, Comm_TimeOut);
            
                try
                {

                comm.Open();
                if (comm.IsConnected())
                {

                    
                    MessageBox.Show("Connected Successfully To GSM Phone / Modem...!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    status = "connected";
                }

                
            }
            catch (Exception E2)
            {
                MessageBox.Show("Error While Connecting To GSM Phone / Modem", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return status;
          }
        public List<string> modemDetail()
        {
            List<string> list = new List<string>();
            try
            {
                string Phone_Name = comm.IdentifyDevice().Manufacturer.ToUpper().ToString();
                string Phone_Model = comm.IdentifyDevice().Model.ToUpper().ToString();
                string Revision_Num = comm.IdentifyDevice().Revision.ToUpper().ToString();
                string Serial_Num = comm.IdentifyDevice().SerialNumber.ToUpper().ToString();
                string address = comm.GetSmscAddress().ToString();
                
                list.Add(Phone_Name);
                list.Add(Phone_Model);
                list.Add(Revision_Num);
                list.Add(Serial_Num);
                
            }
            catch (Exception e50)
            {
                MessageBox.Show("Error Retriving COM Port Phone Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return list;
        }

        public bool checkGSMConected()
        {
            bool status = false;
            if (comm != null)
            {
                if (comm.IsConnected() == true)
                {
                    return true;
                }
               
            }
            return status;
        }

        public bool disconnectPort()
        {

            bool status = false;

            if (comm != null)
            {


                if (!comm.IsConnected())
                {
                    //MessageBox.Show("No Phone Connected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    status = false;
                }
                else
                {
                    comm.Close();
                    // MessageBox.Show("Disconnected Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    status = true;
                }

            }

            return status;

        }

        public bool sendSMS(string CELL_Number, string SMS_Message)
        {

            bool status = false;

            try
            {
                if (comm != null)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    pdu1 = new SmsSubmitPdu(SMS_Message, CELL_Number, "");

                    comm.SendMessage(pdu1);

                    Cursor.Current = Cursors.Default;

                    //MessageBox.Show("M E S S A G E - S E N T", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    status = true;

                }
            }
            catch (Exception E5)
            {

                //MessageBox.Show("Error Sending SMS To Destination Address\r\n\n Connection Has Been Terminated !!!\r\n\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //comm.Close();
                status = false;
            }
            return status;
        }
    }
}