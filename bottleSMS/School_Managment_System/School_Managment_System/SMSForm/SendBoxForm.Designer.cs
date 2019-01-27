namespace School_Managment_System
{
    partial class SendBoxForm
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
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.deleteAll = new MetroFramework.Controls.MetroButton();
            this.studentSentboxdataGridview = new System.Windows.Forms.DataGridView();
            this.rowCountTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentSentboxdataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.exitButton);
            this.panel4.Controls.Add(this.deleteAll);
            this.panel4.Location = new System.Drawing.Point(6, 349);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(717, 66);
            this.panel4.TabIndex = 105;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.exitButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(333, 18);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 32);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseCustomBackColor = true;
            this.exitButton.UseCustomForeColor = true;
            this.exitButton.UseMnemonic = false;
            this.exitButton.UseSelectable = true;
            this.exitButton.UseStyleColors = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.BackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteAll.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.deleteAll.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.deleteAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteAll.Location = new System.Drawing.Point(147, 18);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(156, 32);
            this.deleteAll.TabIndex = 16;
            this.deleteAll.Text = "Delete All";
            this.deleteAll.UseCustomBackColor = true;
            this.deleteAll.UseCustomForeColor = true;
            this.deleteAll.UseSelectable = true;
            this.deleteAll.UseStyleColors = true;
            this.deleteAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // studentSentboxdataGridview
            // 
            this.studentSentboxdataGridview.AllowUserToAddRows = false;
            this.studentSentboxdataGridview.AllowUserToDeleteRows = false;
            this.studentSentboxdataGridview.AllowUserToResizeColumns = false;
            this.studentSentboxdataGridview.AllowUserToResizeRows = false;
            this.studentSentboxdataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentSentboxdataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentSentboxdataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentSentboxdataGridview.Location = new System.Drawing.Point(6, 53);
            this.studentSentboxdataGridview.Name = "studentSentboxdataGridview";
            this.studentSentboxdataGridview.ReadOnly = true;
            this.studentSentboxdataGridview.Size = new System.Drawing.Size(717, 290);
            this.studentSentboxdataGridview.TabIndex = 104;
            // 
            // rowCountTextBox
            // 
            this.rowCountTextBox.AutoSize = true;
            this.rowCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowCountTextBox.Location = new System.Drawing.Point(653, 26);
            this.rowCountTextBox.Name = "rowCountTextBox";
            this.rowCountTextBox.Size = new System.Drawing.Size(21, 24);
            this.rowCountTextBox.TabIndex = 109;
            this.rowCountTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 108;
            this.label1.Text = "Total";
            // 
            // SendBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 426);
            this.Controls.Add(this.rowCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.studentSentboxdataGridview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendBoxForm";
            this.Resizable = false;
            this.Text = "SMS Send Box Form";
            this.Load += new System.EventHandler(this.SendBoxForm_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentSentboxdataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton deleteAll;
        private System.Windows.Forms.DataGridView studentSentboxdataGridview;
        private System.Windows.Forms.Label rowCountTextBox;
        private System.Windows.Forms.Label label1;
    }
}