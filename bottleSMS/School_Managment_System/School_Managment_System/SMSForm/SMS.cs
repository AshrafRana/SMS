using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class SMS : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSMSController = new MobileSMSController();
        private static Phone_Setting phoneSetting = null;
       
        private static ComposeForm compose_Sms = null;
        private static SendBoxForm studentSentBox = null;
        private static UnSendBoxForm studentUnsentBox = null;
        private static DefineSMS defineSMS = null;
        private static AddContactForm acf = null;
        private static AreaForm af = null;
        private static ContactDetailForm cdf = null;

        public SMS()
        {
            InitializeComponent();
        }
        
        private void SMS_Load(object sender, EventArgs e)
        {}
        private void SMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            mobileSMSController.disconnectProt();
        }

        private void gsmsetting_Click(object sender, EventArgs e)
        {
            if (phoneSetting == null || phoneSetting.IsDisposed)
            {
                phoneSetting = new Phone_Setting();
                phoneSetting.Show();
            }
            else
            {
                phoneSetting.WindowState = FormWindowState.Normal;
                phoneSetting.Show();
                phoneSetting.Focus();

            }
        }

        private void createGroup_Click(object sender, EventArgs e)
        {
           
        }

        private void groupContacts_Click(object sender, EventArgs e)
        {
           
        }

        private void composesms_Click(object sender, EventArgs e)
        {
            if (compose_Sms == null || compose_Sms.IsDisposed)
            {
                compose_Sms = new ComposeForm();
                compose_Sms.Show();
            }
            else
            {
                compose_Sms.WindowState = FormWindowState.Normal;
                compose_Sms.Show();
                compose_Sms.Focus();

            }
        }

        private void outbox_Click(object sender, EventArgs e)
        {
            if (defineSMS == null || defineSMS.IsDisposed)
            {
                defineSMS = new DefineSMS();
                defineSMS.Show();
            }
            else
            {
                defineSMS.WindowState = FormWindowState.Normal;
                defineSMS.Show();
                defineSMS.Focus();

            }
        }

        private void sentbox_Click(object sender, EventArgs e)
        {
            if (studentSentBox == null || studentSentBox.IsDisposed)
            {
                studentSentBox = new SendBoxForm();
                studentSentBox.Show();
            }
            else
            {
                studentSentBox.WindowState = FormWindowState.Normal;
                studentSentBox.Show();
                studentSentBox.Focus();

            }
        }

        private void unsentbox_Click(object sender, EventArgs e)
        {
            if (studentUnsentBox == null || studentUnsentBox.IsDisposed)
            {
                studentUnsentBox = new UnSendBoxForm();
                studentUnsentBox.Show();
            }
            else
            {
                studentUnsentBox.WindowState = FormWindowState.Normal;
                studentUnsentBox.Show();
                studentUnsentBox.Focus();

            }
        }
        

        private void closeform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inbox_Click(object sender, EventArgs e)
        {

        }

        private void NewContactNo_Click(object sender, EventArgs e)
        {
            
            if (acf == null || acf.IsDisposed)
            {
                acf = new AddContactForm();
                acf.Show();
            }
            else
            {
                acf.WindowState = FormWindowState.Normal;
                acf.Show();
                acf.Focus();

            }
        }

        private void AddArea_Click(object sender, EventArgs e)
        {
            
            if (af == null || af.IsDisposed)
            {
                af = new AreaForm();
                af.Show();
            }
            else
            {
                af.WindowState = FormWindowState.Normal;
                af.Show();
                af.Focus();

            }
        }

        private void contactInfoPicBox_Click(object sender, EventArgs e)
        {
            if (cdf == null || cdf.IsDisposed)
            {
                cdf = new ContactDetailForm();
                cdf.Show();
            }
            else
            {
                cdf.WindowState = FormWindowState.Normal;
                cdf.Show();
                cdf.Focus();

            }
        }
    }
}
