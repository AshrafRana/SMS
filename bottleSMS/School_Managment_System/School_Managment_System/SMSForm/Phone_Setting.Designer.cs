namespace School_Managment_System
{
    partial class Phone_Setting
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
            this.baudRateCombo = new MetroFramework.Controls.MetroComboBox();
            this.comPortComboBox = new MetroFramework.Controls.MetroComboBox();
            this.gsmName = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gsmModel = new MetroFramework.Controls.MetroTextBox();
            this.serialNo = new MetroFramework.Controls.MetroTextBox();
            this.revisionNo = new MetroFramework.Controls.MetroTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.gsmTimeOut = new MetroFramework.Controls.MetroTextBox();
            this.GSMConnect = new MetroFramework.Controls.MetroButton();
            this.GSMDisconnect = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // baudRateCombo
            // 
            this.baudRateCombo.FormattingEnabled = true;
            this.baudRateCombo.ItemHeight = 23;
            this.baudRateCombo.Location = new System.Drawing.Point(114, 106);
            this.baudRateCombo.Name = "baudRateCombo";
            this.baudRateCombo.PromptText = "Select Baud Rate";
            this.baudRateCombo.Size = new System.Drawing.Size(203, 29);
            this.baudRateCombo.TabIndex = 52;
            this.baudRateCombo.UseSelectable = true;
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.ItemHeight = 23;
            this.comPortComboBox.Location = new System.Drawing.Point(114, 69);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.PromptText = "Select COM Port";
            this.comPortComboBox.Size = new System.Drawing.Size(203, 29);
            this.comPortComboBox.TabIndex = 51;
            this.comPortComboBox.UseSelectable = true;
            // 
            // gsmName
            // 
            // 
            // 
            // 
            this.gsmName.CustomButton.Image = null;
            this.gsmName.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.gsmName.CustomButton.Name = "";
            this.gsmName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gsmName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gsmName.CustomButton.TabIndex = 1;
            this.gsmName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gsmName.CustomButton.UseSelectable = true;
            this.gsmName.Enabled = false;
            this.gsmName.Lines = new string[0];
            this.gsmName.Location = new System.Drawing.Point(114, 170);
            this.gsmName.MaxLength = 32767;
            this.gsmName.Name = "gsmName";
            this.gsmName.PasswordChar = '\0';
            this.gsmName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gsmName.SelectedText = "";
            this.gsmName.SelectionLength = 0;
            this.gsmName.SelectionStart = 0;
            this.gsmName.ShortcutsEnabled = true;
            this.gsmName.ShowButton = true;
            this.gsmName.ShowClearButton = true;
            this.gsmName.Size = new System.Drawing.Size(203, 23);
            this.gsmName.TabIndex = 11;
            this.gsmName.UseSelectable = true;
            this.gsmName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gsmName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "GSM Name :";
            // 
            // gsmModel
            // 
            // 
            // 
            // 
            this.gsmModel.CustomButton.Image = null;
            this.gsmModel.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.gsmModel.CustomButton.Name = "";
            this.gsmModel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gsmModel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gsmModel.CustomButton.TabIndex = 1;
            this.gsmModel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gsmModel.CustomButton.UseSelectable = true;
            this.gsmModel.Enabled = false;
            this.gsmModel.Lines = new string[0];
            this.gsmModel.Location = new System.Drawing.Point(114, 199);
            this.gsmModel.MaxLength = 32767;
            this.gsmModel.Name = "gsmModel";
            this.gsmModel.PasswordChar = '\0';
            this.gsmModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gsmModel.SelectedText = "";
            this.gsmModel.SelectionLength = 0;
            this.gsmModel.SelectionStart = 0;
            this.gsmModel.ShortcutsEnabled = true;
            this.gsmModel.ShowButton = true;
            this.gsmModel.ShowClearButton = true;
            this.gsmModel.Size = new System.Drawing.Size(203, 23);
            this.gsmModel.TabIndex = 12;
            this.gsmModel.UseSelectable = true;
            this.gsmModel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gsmModel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // serialNo
            // 
            // 
            // 
            // 
            this.serialNo.CustomButton.Image = null;
            this.serialNo.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.serialNo.CustomButton.Name = "";
            this.serialNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.serialNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.serialNo.CustomButton.TabIndex = 1;
            this.serialNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serialNo.CustomButton.UseSelectable = true;
            this.serialNo.Enabled = false;
            this.serialNo.Lines = new string[0];
            this.serialNo.Location = new System.Drawing.Point(114, 228);
            this.serialNo.MaxLength = 32767;
            this.serialNo.Name = "serialNo";
            this.serialNo.PasswordChar = '\0';
            this.serialNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serialNo.SelectedText = "";
            this.serialNo.SelectionLength = 0;
            this.serialNo.SelectionStart = 0;
            this.serialNo.ShortcutsEnabled = true;
            this.serialNo.ShowButton = true;
            this.serialNo.ShowClearButton = true;
            this.serialNo.Size = new System.Drawing.Size(203, 23);
            this.serialNo.TabIndex = 13;
            this.serialNo.UseSelectable = true;
            this.serialNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serialNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // revisionNo
            // 
            // 
            // 
            // 
            this.revisionNo.CustomButton.Image = null;
            this.revisionNo.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.revisionNo.CustomButton.Name = "";
            this.revisionNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.revisionNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.revisionNo.CustomButton.TabIndex = 1;
            this.revisionNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.revisionNo.CustomButton.UseSelectable = true;
            this.revisionNo.Enabled = false;
            this.revisionNo.Lines = new string[0];
            this.revisionNo.Location = new System.Drawing.Point(114, 257);
            this.revisionNo.MaxLength = 32767;
            this.revisionNo.Name = "revisionNo";
            this.revisionNo.PasswordChar = '\0';
            this.revisionNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.revisionNo.SelectedText = "";
            this.revisionNo.SelectionLength = 0;
            this.revisionNo.SelectionStart = 0;
            this.revisionNo.ShortcutsEnabled = true;
            this.revisionNo.ShowButton = true;
            this.revisionNo.ShowClearButton = true;
            this.revisionNo.Size = new System.Drawing.Size(203, 23);
            this.revisionNo.TabIndex = 14;
            this.revisionNo.UseSelectable = true;
            this.revisionNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.revisionNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Model No :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 233);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 16);
            this.label17.TabIndex = 16;
            this.label17.Text = "Serial No :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "Revision No :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(23, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 16);
            this.label19.TabIndex = 55;
            this.label19.Text = "COM Port :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(23, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 16);
            this.label20.TabIndex = 56;
            this.label20.Text = "Baud Rate :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(23, 141);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 16);
            this.label21.TabIndex = 58;
            this.label21.Text = "Time Out :";
            // 
            // gsmTimeOut
            // 
            // 
            // 
            // 
            this.gsmTimeOut.CustomButton.Image = null;
            this.gsmTimeOut.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.gsmTimeOut.CustomButton.Name = "";
            this.gsmTimeOut.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gsmTimeOut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gsmTimeOut.CustomButton.TabIndex = 1;
            this.gsmTimeOut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gsmTimeOut.CustomButton.UseSelectable = true;
            this.gsmTimeOut.Enabled = false;
            this.gsmTimeOut.Lines = new string[0];
            this.gsmTimeOut.Location = new System.Drawing.Point(114, 141);
            this.gsmTimeOut.MaxLength = 32767;
            this.gsmTimeOut.Name = "gsmTimeOut";
            this.gsmTimeOut.PasswordChar = '\0';
            this.gsmTimeOut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gsmTimeOut.SelectedText = "";
            this.gsmTimeOut.SelectionLength = 0;
            this.gsmTimeOut.SelectionStart = 0;
            this.gsmTimeOut.ShortcutsEnabled = true;
            this.gsmTimeOut.ShowButton = true;
            this.gsmTimeOut.ShowClearButton = true;
            this.gsmTimeOut.Size = new System.Drawing.Size(203, 23);
            this.gsmTimeOut.TabIndex = 57;
            this.gsmTimeOut.UseSelectable = true;
            this.gsmTimeOut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gsmTimeOut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GSMConnect
            // 
            this.GSMConnect.BackColor = System.Drawing.Color.LightSkyBlue;
            this.GSMConnect.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.GSMConnect.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.GSMConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GSMConnect.Location = new System.Drawing.Point(50, 312);
            this.GSMConnect.Name = "GSMConnect";
            this.GSMConnect.Size = new System.Drawing.Size(112, 32);
            this.GSMConnect.TabIndex = 59;
            this.GSMConnect.Text = "Connect";
            this.GSMConnect.UseCustomBackColor = true;
            this.GSMConnect.UseCustomForeColor = true;
            this.GSMConnect.UseSelectable = true;
            this.GSMConnect.UseStyleColors = true;
            this.GSMConnect.Click += new System.EventHandler(this.GSMConnect_Click);
            // 
            // GSMDisconnect
            // 
            this.GSMDisconnect.BackColor = System.Drawing.Color.LightSkyBlue;
            this.GSMDisconnect.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.GSMDisconnect.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.GSMDisconnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GSMDisconnect.Location = new System.Drawing.Point(177, 312);
            this.GSMDisconnect.Name = "GSMDisconnect";
            this.GSMDisconnect.Size = new System.Drawing.Size(112, 32);
            this.GSMDisconnect.TabIndex = 60;
            this.GSMDisconnect.Text = "Disconnect";
            this.GSMDisconnect.UseCustomBackColor = true;
            this.GSMDisconnect.UseCustomForeColor = true;
            this.GSMDisconnect.UseSelectable = true;
            this.GSMDisconnect.UseStyleColors = true;
            this.GSMDisconnect.Click += new System.EventHandler(this.GSMDisconnect_Click);
            // 
            // Phone_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 362);
            this.Controls.Add(this.GSMDisconnect);
            this.Controls.Add(this.GSMConnect);
            this.Controls.Add(this.baudRateCombo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.comPortComboBox);
            this.Controls.Add(this.gsmTimeOut);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.revisionNo);
            this.Controls.Add(this.serialNo);
            this.Controls.Add(this.gsmModel);
            this.Controls.Add(this.gsmName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Phone_Setting";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Connection Information";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox comPortComboBox;
        private MetroFramework.Controls.MetroComboBox baudRateCombo;
        private MetroFramework.Controls.MetroTextBox gsmName;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox gsmModel;
        private MetroFramework.Controls.MetroTextBox serialNo;
        private MetroFramework.Controls.MetroTextBox revisionNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private MetroFramework.Controls.MetroTextBox gsmTimeOut;
        private MetroFramework.Controls.MetroButton GSMConnect;
        private MetroFramework.Controls.MetroButton GSMDisconnect;
    }
}