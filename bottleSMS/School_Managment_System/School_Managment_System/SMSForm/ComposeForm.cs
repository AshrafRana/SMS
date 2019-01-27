using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class ComposeForm : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSmsController = new MobileSMSController();
        
        public ComposeForm()
        {
            InitializeComponent();
        }

        private void ComposeForm_Load(object sender, EventArgs e)
        {
            List<string> smsTitlelist = mobileSmsController.defineSMSTitleCombobox();
            
            foreach (var item in smsTitlelist)
            {
                smsTitle.Items.Add(item);
            }

        }

        private void singleSMSTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> smsTitlelist = mobileSmsController.defineSMSTexSelect(smsTitle.Text);
            messageTextBox.Text = smsTitlelist[0];
            CountCharacter.Text = messageTextBox.Text.Count().ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            messageTextBox.Text = String.Empty;
        }

        private void SendBttn_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (messageTextBox.Text != "")
            {
                string message = smsTitle.Text + "\n" + messageTextBox.Text;
                int smsTitleId = mobileSmsController.defineSMSSelectIdByTitle(smsTitle.Text);

                List<string> contactNo = mobileSmsController.selectAllContactNumbers();
           
                if (contactNo.Count() > 0)
                {
                    foreach (var item in contactNo)
                    {
                        if (item.Length == 11)
                        {
                            if (mobileSmsController.singleSMSSend(item, message,smsTitleId) == false)
                            {
                                MessageBox.Show("GSM Device Not Connected!");
                                break;
                            }
                            
                            i++;
                        }

                    }
                }

                if (contactNo.Count() == i)
                {
                    MessageBox.Show("M E S S A G E - S E N T Send Successfully!");
                }
                
                
            }
            else
            {
                MessageBox.Show("Select Message Title");
            }
        }
    }
}
