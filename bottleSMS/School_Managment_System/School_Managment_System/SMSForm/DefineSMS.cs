using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace School_Managment_System
{
    public partial class DefineSMS : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSMSController = new MobileSMSController();
        int MessgId = 0;
        public DefineSMS()
        {
            InitializeComponent();
        }

        private void smsTittle_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z-\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (smsTitle.Text != "")
            {
                MessageBox.Show(mobileSMSController.defineSMSInsert(smsTitle.Text, smsText.Text));
                smsTitle.Text = "";
                smsText.Text = "";
                mobileSMSController.defineSMSDataGridView().Clear();
                defineSMSdataGridView.DataSource = mobileSMSController.defineSMSDataGridView();

            }
            else
            {
                MessageBox.Show("filed should not be Empty");

            }
            
        }

        private void DefineSMS_Load(object sender, EventArgs e)
        {
            mobileSMSController.defineSMSDataGridView().Clear();
            defineSMSdataGridView.DataSource = mobileSMSController.defineSMSDataGridView();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (smsTitle.Text != "" && MessgId > 0)
            {

                MessageBox.Show(mobileSMSController.defineSMSTitlesDelete(smsTitle.Text));
                smsTitle.Text = "";
                smsText.Text = "";
                mobileSMSController.defineSMSDataGridView().Clear();
                defineSMSdataGridView.DataSource = mobileSMSController.defineSMSDataGridView();

            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
            
        }

        private void defineSMSdataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = defineSMSdataGridView.Rows[e.RowIndex];
                MessgId = Convert.ToInt32(row.Cells["MessgId"].Value.ToString());
                smsTitle.Text = row.Cells["SMSTitle"].Value.ToString();
                smsText.Text = row.Cells["Massege"].Value.ToString();
                

            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            if (smsTitle.Text != "" && MessgId > 0)
            {

                MessageBox.Show(mobileSMSController.defineSMSUpdate(MessgId, smsTitle.Text, smsText.Text));
                smsTitle.Text = "";
                smsText.Text = "";
                MessgId = 0;
                mobileSMSController.defineSMSDataGridView().Clear();
                defineSMSdataGridView.DataSource = mobileSMSController.defineSMSDataGridView();

            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smsText_TextChanged(object sender, EventArgs e)
        {

            smsTitle.CharacterCasing = CharacterCasing.Upper;
            
        }
    }
}
