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
    public partial class AreaForm : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSMSController = new MobileSMSController();
        int areaId = 0; 
        public AreaForm()
        {
            InitializeComponent();
        }

        private void AreaForm_Load(object sender, EventArgs e)
        {
            mobileSMSController.areaSMSDataGridView().Clear();
            areaNamedataGridView.DataSource = mobileSMSController.areaSMSDataGridView();
        }

        private void AreaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9-/\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (AreaTextBox.Text != "" || AreaTextBox.Text != string.Empty)
            {
                MessageBox.Show(mobileSMSController.areaSMSNameInsert(AreaTextBox.Text.ToUpper()));
                AreaTextBox.Text = "";
                mobileSMSController.areaSMSDataGridView().Clear();
                areaNamedataGridView.DataSource = mobileSMSController.areaSMSDataGridView();
            }
            else
            {
                MessageBox.Show("filed should not be Empty");

            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (AreaTextBox.Text != "" && areaId > 0)
            {
                MessageBox.Show(mobileSMSController.areaSMSNameDelete(AreaTextBox.Text.ToUpper()));
                AreaTextBox.Text = "";
                mobileSMSController.areaSMSDataGridView().Clear();
                areaNamedataGridView.DataSource = mobileSMSController.areaSMSDataGridView();

            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void areaNamedataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = areaNamedataGridView.Rows[e.RowIndex];
                AreaTextBox.Text = row.Cells["Area"].Value.ToString();
                areaId = Convert.ToInt32(row.Cells["AreaId"].Value.ToString());

            }
        }

        private void Upate_Click(object sender, EventArgs e)
        {
            if (AreaTextBox.Text != "" && areaId > 0)
            {

                MessageBox.Show(mobileSMSController.areaSMSNameUpdate(areaId, AreaTextBox.Text.ToUpper()));
                AreaTextBox.Text = "";
                mobileSMSController.areaSMSDataGridView().Clear();
                areaNamedataGridView.DataSource = mobileSMSController.areaSMSDataGridView();
                areaId = 0;
            }
            else
            {
                MessageBox.Show("Select row in sheet");

            }
        }

        private void AreaTextBox_TextChanged(object sender, EventArgs e)
        {
            AreaTextBox.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
