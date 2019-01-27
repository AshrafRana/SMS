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
    public partial class SendBoxForm : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSmsController = new MobileSMSController();

        public SendBoxForm()
        {
            InitializeComponent();
        }

        private void SendBoxForm_Load(object sender, EventArgs e)
        {
            studentSentboxdataGridview.DataSource = mobileSmsController.selectAllSentSMSDataGridView();
            rowCountTextBox.Text = studentSentboxdataGridview.Rows.Count.ToString();
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            if (mobileSmsController.deleteAllSMSDataGridView())
            {
                MessageBox.Show("Delete All Records Successfully!");

                mobileSmsController.selectAllSentSMSDataGridView().Clear();
                studentSentboxdataGridview.DataSource = mobileSmsController.selectAllSentSMSDataGridView();

            }
            else
            {
                MessageBox.Show("Not Delete All Records");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
