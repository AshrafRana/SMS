using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class AddContactForm : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSMSController = new MobileSMSController();

        public AddContactForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            List<string> areaNames = mobileSMSController.areaSMSNameCombobox();
            foreach (var item in areaNames)
            {
                areaNameCombo.Items.Add(item);
            }
        }
        
        private void Save_Click(object sender, EventArgs e)
        {

            if (compName.Text.Trim() != "" && personName.Text.Trim() != null && mobie1.Text.Trim() != ""  && areaNameCombo.Text.Trim() != "" && addresTextBox.Text.Trim() != "" && compName.Text.Trim() != string.Empty && personName.Text.Trim() != string.Empty && mobie1.Text.Trim() != string.Empty && areaNameCombo.Text.Trim() != string.Empty && addresTextBox.Text.Trim() != string.Empty)
            {
                if (mobie1.Text.Length == 11)
                {
                       MessageBox.Show(mobileSMSController.contactInfoSMSInsert(compName.Text.ToUpper(), personName.Text.ToUpper(), mobie1.Text, mobile2.Text, mobile3.Text, mobile4.Text, phoneNo.Text, areaNameCombo.Text, addresTextBox.Text.ToUpper()));
                }
                else
                {
                    MessageBox.Show("Mobile Number must be 11 digits");
                }
             }
            else
            {
                MessageBox.Show("filed should not be Empty");

            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            compName.Text = null;
            personName.Text = null;
            mobie1.Text = null;
            mobile2.Text = null;
            mobile3.Text = null;
            mobile4.Text = null;
            phoneNo.Text = null;
            areaNameCombo.Text = null;
            addresTextBox.Text = null;
        }

        private void mobile2_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            var regex = new Regex(@"[^0-9{11}\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void personName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void compName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z.\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        
        private void addresTextBox_TextChanged(object sender, EventArgs e)
        {
            compName.CharacterCasing = CharacterCasing.Upper;
            addresTextBox.CharacterCasing = CharacterCasing.Upper;
            personName.CharacterCasing = CharacterCasing.Upper;
           
        }

        private void phoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
