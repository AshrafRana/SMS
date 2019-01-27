namespace School_Managment_System
{
    partial class UnSendBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.exit = new MetroFramework.Controls.MetroButton();
            this.resend = new MetroFramework.Controls.MetroButton();
            this.deleteUnsentSMS = new MetroFramework.Controls.MetroButton();
            this.studentUnsentboxdataGridview = new System.Windows.Forms.DataGridView();
            this.rowCountTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentUnsentboxdataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.exit);
            this.panel4.Controls.Add(this.resend);
            this.panel4.Controls.Add(this.deleteUnsentSMS);
            this.panel4.Location = new System.Drawing.Point(7, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(623, 66);
            this.panel4.TabIndex = 105;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.exit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.Location = new System.Drawing.Point(383, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(112, 32);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseCustomBackColor = true;
            this.exit.UseCustomForeColor = true;
            this.exit.UseMnemonic = false;
            this.exit.UseSelectable = true;
            this.exit.UseStyleColors = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // resend
            // 
            this.resend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.resend.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resend.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.resend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resend.Location = new System.Drawing.Point(117, 13);
            this.resend.Name = "resend";
            this.resend.Size = new System.Drawing.Size(112, 32);
            this.resend.TabIndex = 16;
            this.resend.Text = "Re-Send";
            this.resend.UseCustomBackColor = true;
            this.resend.UseCustomForeColor = true;
            this.resend.UseSelectable = true;
            this.resend.UseStyleColors = true;
            // 
            // deleteUnsentSMS
            // 
            this.deleteUnsentSMS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteUnsentSMS.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.deleteUnsentSMS.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.deleteUnsentSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteUnsentSMS.Location = new System.Drawing.Point(251, 13);
            this.deleteUnsentSMS.Name = "deleteUnsentSMS";
            this.deleteUnsentSMS.Size = new System.Drawing.Size(112, 32);
            this.deleteUnsentSMS.TabIndex = 14;
            this.deleteUnsentSMS.Text = "Delete All";
            this.deleteUnsentSMS.UseCustomBackColor = true;
            this.deleteUnsentSMS.UseCustomForeColor = true;
            this.deleteUnsentSMS.UseMnemonic = false;
            this.deleteUnsentSMS.UseSelectable = true;
            this.deleteUnsentSMS.UseStyleColors = true;
            this.deleteUnsentSMS.Click += new System.EventHandler(this.deleteUnsentSMS_Click);
            // 
            // studentUnsentboxdataGridview
            // 
            this.studentUnsentboxdataGridview.AllowUserToAddRows = false;
            this.studentUnsentboxdataGridview.AllowUserToDeleteRows = false;
            this.studentUnsentboxdataGridview.AllowUserToResizeColumns = false;
            this.studentUnsentboxdataGridview.AllowUserToResizeRows = false;
            this.studentUnsentboxdataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentUnsentboxdataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentUnsentboxdataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentUnsentboxdataGridview.Location = new System.Drawing.Point(7, 63);
            this.studentUnsentboxdataGridview.Name = "studentUnsentboxdataGridview";
            this.studentUnsentboxdataGridview.ReadOnly = true;
            this.studentUnsentboxdataGridview.Size = new System.Drawing.Size(623, 273);
            this.studentUnsentboxdataGridview.TabIndex = 104;
            // 
            // rowCountTextBox
            // 
            this.rowCountTextBox.AutoSize = true;
            this.rowCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowCountTextBox.Location = new System.Drawing.Point(571, 35);
            this.rowCountTextBox.Name = "rowCountTextBox";
            this.rowCountTextBox.Size = new System.Drawing.Size(21, 24);
            this.rowCountTextBox.TabIndex = 107;
            this.rowCountTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 106;
            this.label1.Text = "Total";
            // 
            // UnSendBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 417);
            this.Controls.Add(this.rowCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.studentUnsentboxdataGridview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnSendBoxForm";
            this.Resizable = false;
            this.Text = "Un Send Box Form";
            this.Load += new System.EventHandler(this.UnSendBoxForm_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentUnsentboxdataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroButton exit;
        private MetroFramework.Controls.MetroButton resend;
        private MetroFramework.Controls.MetroButton deleteUnsentSMS;
        private System.Windows.Forms.DataGridView studentUnsentboxdataGridview;
        private System.Windows.Forms.Label rowCountTextBox;
        private System.Windows.Forms.Label label1;
    }
}