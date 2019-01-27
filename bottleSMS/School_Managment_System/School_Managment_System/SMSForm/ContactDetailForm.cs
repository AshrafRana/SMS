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
    public partial class ContactDetailForm : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSMSController = new MobileSMSController();
        AddContactForm acf = null;
        EditContactInfoForm ecf = null;

        public ContactDetailForm()
        {
            InitializeComponent();
        }

        private void ContactDetailForm_Load(object sender, EventArgs e)
        {
            List<string> areaNames = mobileSMSController.areaSMSNameCombobox();
            foreach (var item in areaNames)
            {
                areaNameCombo.Items.Add(item);
            }

            mobileSMSController.contactDeatilSMSDataGridView().Clear();
            contactDetailGridView.DataSource = mobileSMSController.contactDeatilSMSDataGridView();
            rowCountTextBox.Text = contactDetailGridView.Rows.Count.ToString();

        }

        private void AddContactInfo_Click(object sender, EventArgs e)
        {
            AddContactForm acf = new AddContactForm();
            acf.Show();
        }
        int CId = 0;
        private void contactDetailGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = contactDetailGridView.Rows[e.RowIndex];
                 CId = Convert.ToInt32((row.Cells["CId"].Value.ToString()));
                 cIdTextBox.Text = CId.ToString();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (cIdTextBox.Text != "" && cIdTextBox.Text != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete CID "+CId+" ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    MessageBox.Show(mobileSMSController.contactInfoDelete(Convert.ToInt32(cIdTextBox.Text)));
                    mobileSMSController.contactDeatilSMSDataGridView().Clear();
                    contactDetailGridView.DataSource = mobileSMSController.contactDeatilSMSDataGridView();
                    rowCountTextBox.Text = contactDetailGridView.Rows.Count.ToString();
                    cIdTextBox.Text = String.Empty;
                    
                }
            }
            else
            {
                MessageBox.Show("Select row");
            }
            

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (CId > 0)
            {
                if (ecf == null || ecf.IsDisposed)
                {
                    ecf = new EditContactInfoForm(CId);
                    ecf.Show();
                }
                else
                {
                    ecf.WindowState = FormWindowState.Normal;
                    ecf.Show();
                    ecf.Focus();

                }

            }
            else
            {
                MessageBox.Show("Select row");
            }

        }

        private void companyNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

             mobileSMSController.searchByCompanyNamecontactDeatilSMSDataGridView(companyNameTextBox.Text.Trim()).Clear();
            contactDetailGridView.DataSource = mobileSMSController.searchByCompanyNamecontactDeatilSMSDataGridView(companyNameTextBox.Text.Trim());
            rowCountTextBox.Text = contactDetailGridView.Rows.Count.ToString();

        }


        private void personNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            mobileSMSController.searchByPersonNamecontactDeatilSMSDataGridView(personNameTextBox.Text.Trim()).Clear();
            contactDetailGridView.DataSource = mobileSMSController.searchByPersonNamecontactDeatilSMSDataGridView(personNameTextBox.Text.Trim());
            rowCountTextBox.Text = contactDetailGridView.Rows.Count.ToString();

        }

        private void mobileNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            mobileSMSController.searchByMobileNamecontactDeatilSMSDataGridView(mobileNoTextBox.Text.Trim()).Clear();
            contactDetailGridView.DataSource = mobileSMSController.searchByMobileNamecontactDeatilSMSDataGridView(mobileNoTextBox.Text.Trim());
            rowCountTextBox.Text = contactDetailGridView.Rows.Count.ToString();

        }

        private void areaNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mobileSMSController.searchByAreaNamecontactDeatilSMSDataGridView(areaNameCombo.Text.Trim()).Clear();
            contactDetailGridView.DataSource = mobileSMSController.searchByAreaNamecontactDeatilSMSDataGridView(areaNameCombo.Text.Trim());
            rowCountTextBox.Text = contactDetailGridView.Rows.Count.ToString();
        }

        private void addContactInfo_Click_1(object sender, EventArgs e)
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
    }
}
