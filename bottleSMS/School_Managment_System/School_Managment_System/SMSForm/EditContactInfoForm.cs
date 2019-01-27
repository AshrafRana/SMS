using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class EditContactInfoForm : MetroFramework.Forms.MetroForm
    {
        int CId;
        String m1 = null, m2 = null, m3 = null, m4 = null;
        MobileSMSController mobileSMSController = new MobileSMSController();

        public EditContactInfoForm(int _CId)
        {
            InitializeComponent();
            this.CId = _CId;


        }

        private void newMobileNoButton_Click(object sender, EventArgs e)
        {
            if(newNoTextBox.Text != "")
            {
                MessageBox.Show(mobileSMSController.newcontactNoInsert(Convert.ToInt32(companyIDTextBox.Text), newNoTextBox.Text));
            }
            else
            {
                MessageBox.Show("filed should not be Empty");
            }
        }

        private void newNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void editContactInfoBttn_Click_1(object sender, EventArgs e)
        {
            if (m1 != "" && m2 != "" && m3 != "" && m4 != "" && compName.Text.Trim() != "" && personName.Text.Trim() != null && mobile1.Text.Trim() != "" && areaNameCombo.Text.Trim() != "" && addresTextBox.Text.Trim() != "" && compName.Text.Trim() != string.Empty && personName.Text.Trim() != string.Empty && mobile1.Text.Trim() != string.Empty && areaNameCombo.Text.Trim() != string.Empty && addresTextBox.Text.Trim() != string.Empty)
            {
                MessageBox.Show(mobileSMSController.contactInfoSMSUpdate(m1, m2, m3, m4, Convert.ToInt32(companyIDTextBox.Text), compName.Text, personName.Text, mobile1.Text, mobile2.Text, mobile3.Text, mobile4.Text, phoneNo.Text, areaNameCombo.Text, addresTextBox.Text));
            }
            else
            {
                MessageBox.Show("filed should not be Empty");

            }
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addresTextBox_TextChanged(object sender, EventArgs e)
        {
            compName.CharacterCasing = CharacterCasing.Upper;
            addresTextBox.CharacterCasing = CharacterCasing.Upper;
            personName.CharacterCasing = CharacterCasing.Upper;
        }

        private void EditContactInfoForm_Load(object sender, EventArgs e)
        {
            List<string> areaNames = mobileSMSController.areaSMSNameCombobox();
            foreach (var item in areaNames)
            {
                areaNameCombo.Items.Add(item);
            }

            List<string> l = mobileSMSController.selectContactDetailByCId(CId);
            List<string> mobileNumbers = mobileSMSController.selectContactNumbersByCId(CId);

            companyIDTextBox.Text = CId.ToString();
            compName.Text = l[0];
            personName.Text = l[1];
            phoneNo.Text = l[2];
            areaNameCombo.Text = l[3];
            addresTextBox.Text = l[4];

            if (mobileNumbers.Count() == 1)
            {
                mobile1.Text = mobileNumbers[0];
                m1 = mobileNumbers[0];
                
            }
            else if (mobileNumbers.Count() == 2)
            {
                mobile1.Text = mobileNumbers[0];
                mobile2.Text = mobileNumbers[1];
                m1 = mobileNumbers[0];
                m2 = mobileNumbers[1];
                
            }
            else if (mobileNumbers.Count() == 3)
            {
                mobile1.Text = mobileNumbers[0];
                mobile2.Text = mobileNumbers[1];
                mobile3.Text = mobileNumbers[2];
                m1 = mobileNumbers[0];
                m2 = mobileNumbers[1];
                m3 = mobileNumbers[2];

            }
            else if (mobileNumbers.Count() == 4)
            {
                mobile1.Text = mobileNumbers[0];
                mobile2.Text = mobileNumbers[1];
                mobile3.Text = mobileNumbers[2];
                mobile4.Text = mobileNumbers[3];

                m1 = mobileNumbers[0];
                m2 = mobileNumbers[1];
                m3 = mobileNumbers[2];
                m4 = mobileNumbers[3];

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editContactInfoBttn_Click(object sender, EventArgs e)
        {
            if (m1 != "" && m2 != "" && m3 != "" && m4 != "" && compName.Text.Trim() != "" && personName.Text.Trim() != null && mobile1.Text.Trim() != "" && areaNameCombo.Text.Trim() != "" && addresTextBox.Text.Trim() != "" && compName.Text.Trim() != string.Empty && personName.Text.Trim() != string.Empty && mobile1.Text.Trim() != string.Empty && areaNameCombo.Text.Trim() != string.Empty && addresTextBox.Text.Trim() != string.Empty)
            {
                MessageBox.Show(mobileSMSController.contactInfoSMSUpdate(m1 ,m2, m3, m4,Convert.ToInt32(companyIDTextBox.Text), compName.Text.ToUpper(), personName.Text.ToUpper(), mobile1.Text, mobile2.Text, mobile3.Text, mobile4.Text, phoneNo.Text, areaNameCombo.Text, addresTextBox.Text.ToUpper()));
            }
            else
            {
                MessageBox.Show("filed should not be Empty");

            }
        }
    }
}
