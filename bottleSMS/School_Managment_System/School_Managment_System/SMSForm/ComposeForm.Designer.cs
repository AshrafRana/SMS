namespace School_Managment_System
{
    partial class ComposeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.smsTitle = new MetroFramework.Controls.MetroComboBox();
            this.CountCharacter = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SendBttn = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.existButtn = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.existButtn);
            this.groupBox1.Controls.Add(this.smsTitle);
            this.groupBox1.Controls.Add(this.CountCharacter);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.SendBttn);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.messageTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 288);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customize";
            // 
            // smsTitle
            // 
            this.smsTitle.FormattingEnabled = true;
            this.smsTitle.ItemHeight = 23;
            this.smsTitle.Location = new System.Drawing.Point(71, 19);
            this.smsTitle.Name = "smsTitle";
            this.smsTitle.PromptText = "Select SMS Title";
            this.smsTitle.Size = new System.Drawing.Size(294, 29);
            this.smsTitle.TabIndex = 86;
            this.smsTitle.UseSelectable = true;
            this.smsTitle.SelectedIndexChanged += new System.EventHandler(this.singleSMSTitles_SelectedIndexChanged);
            // 
            // CountCharacter
            // 
            this.CountCharacter.AutoSize = true;
            this.CountCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CountCharacter.FontSize = MetroFramework.MetroLabelSize.Small;
            this.CountCharacter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CountCharacter.Location = new System.Drawing.Point(248, 207);
            this.CountCharacter.Name = "CountCharacter";
            this.CountCharacter.Size = new System.Drawing.Size(13, 15);
            this.CountCharacter.TabIndex = 85;
            this.CountCharacter.Text = "0";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(267, 207);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(100, 15);
            this.metroLabel9.TabIndex = 84;
            this.metroLabel9.Text = "Character(s) Used";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton1.Location = new System.Drawing.Point(35, 245);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(97, 32);
            this.metroButton1.TabIndex = 80;
            this.metroButton1.Text = "Clear";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SendBttn
            // 
            this.SendBttn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SendBttn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.SendBttn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.SendBttn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SendBttn.Location = new System.Drawing.Point(133, 245);
            this.SendBttn.Name = "SendBttn";
            this.SendBttn.Size = new System.Drawing.Size(128, 32);
            this.SendBttn.TabIndex = 81;
            this.SendBttn.Text = "Send";
            this.SendBttn.UseCustomBackColor = true;
            this.SendBttn.UseCustomForeColor = true;
            this.SendBttn.UseSelectable = true;
            this.SendBttn.UseStyleColors = true;
            this.SendBttn.Click += new System.EventHandler(this.SendBttn_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(5, 24);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 15);
            this.metroLabel7.TabIndex = 74;
            this.metroLabel7.Text = "SMS Title :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(6, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 15);
            this.metroLabel6.TabIndex = 77;
            this.metroLabel6.Text = "Message :";
            // 
            // messageTextBox
            // 
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(71, 60);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(295, 144);
            this.messageTextBox.TabIndex = 76;
            this.messageTextBox.Text = "";
            // 
            // existButtn
            // 
            this.existButtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.existButtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.existButtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.existButtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.existButtn.Location = new System.Drawing.Point(267, 245);
            this.existButtn.Name = "existButtn";
            this.existButtn.Size = new System.Drawing.Size(97, 32);
            this.existButtn.TabIndex = 87;
            this.existButtn.Text = "Exit";
            this.existButtn.UseCustomBackColor = true;
            this.existButtn.UseCustomForeColor = true;
            this.existButtn.UseSelectable = true;
            this.existButtn.UseStyleColors = true;
            this.existButtn.Click += new System.EventHandler(this.existButtn_Click);
            // 
            // ComposeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 363);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComposeForm";
            this.Resizable = false;
            this.Text = "Compose Form";
            this.Load += new System.EventHandler(this.ComposeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox smsTitle;
        private MetroFramework.Controls.MetroLabel CountCharacter;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton SendBttn;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private MetroFramework.Controls.MetroButton existButtn;
    }
}