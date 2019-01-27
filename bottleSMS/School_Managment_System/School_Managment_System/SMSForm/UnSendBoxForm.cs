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
    public partial class UnSendBoxForm : MetroFramework.Forms.MetroForm
    {
        MobileSMSController mobileSmsController = new MobileSMSController();

        public UnSendBoxForm()
        {
            InitializeComponent();
        }

        private void UnSendBoxForm_Load(object sender, EventArgs e)
        {
            studentUnsentboxdataGridview.DataSource = mobileSmsController.selectAllUnsentSMSDataGridView();
            rowCountTextBox.Text = studentUnsentboxdataGridview.Rows.Count.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteUnsentSMS_Click(object sender, EventArgs e)
        {
            if (mobileSmsController.deleteAllSMSDataGridView())
            {
                MessageBox.Show("Delete All Records Successfully!");

                mobileSmsController.selectAllUnsentSMSDataGridView().Clear();
                studentUnsentboxdataGridview.DataSource = mobileSmsController.selectAllUnsentSMSDataGridView();

            }
            else
            {
                MessageBox.Show("Not Delete All Records");
            }
        }
    }
}
