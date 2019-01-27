namespace School_Managment_System
{
    partial class AreaForm
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
            this.Delete = new MetroFramework.Controls.MetroButton();
            this.Upate = new MetroFramework.Controls.MetroButton();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AreaTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.areaNamedataGridView = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaNamedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.exitButton);
            this.panel4.Controls.Add(this.Delete);
            this.panel4.Controls.Add(this.Upate);
            this.panel4.Controls.Add(this.Save);
            this.panel4.Location = new System.Drawing.Point(340, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 173);
            this.panel4.TabIndex = 28;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.exitButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(13, 130);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 32);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseCustomBackColor = true;
            this.exitButton.UseCustomForeColor = true;
            this.exitButton.UseMnemonic = false;
            this.exitButton.UseSelectable = true;
            this.exitButton.UseStyleColors = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Delete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete.Location = new System.Drawing.Point(13, 92);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 32);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseCustomBackColor = true;
            this.Delete.UseCustomForeColor = true;
            this.Delete.UseMnemonic = false;
            this.Delete.UseSelectable = true;
            this.Delete.UseStyleColors = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Upate
            // 
            this.Upate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Upate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Upate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Upate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Upate.Location = new System.Drawing.Point(13, 54);
            this.Upate.Name = "Upate";
            this.Upate.Size = new System.Drawing.Size(94, 32);
            this.Upate.TabIndex = 4;
            this.Upate.Text = "Update";
            this.Upate.UseCustomBackColor = true;
            this.Upate.UseCustomForeColor = true;
            this.Upate.UseSelectable = true;
            this.Upate.UseStyleColors = true;
            this.Upate.Click += new System.EventHandler(this.Upate_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Save.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save.Location = new System.Drawing.Point(13, 16);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 32);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseCustomBackColor = true;
            this.Save.UseCustomForeColor = true;
            this.Save.UseSelectable = true;
            this.Save.UseStyleColors = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AreaTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 95);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // AreaTextBox
            // 
            // 
            // 
            // 
            this.AreaTextBox.CustomButton.Image = null;
            this.AreaTextBox.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.AreaTextBox.CustomButton.Name = "";
            this.AreaTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AreaTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AreaTextBox.CustomButton.TabIndex = 1;
            this.AreaTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AreaTextBox.CustomButton.UseSelectable = true;
            this.AreaTextBox.Lines = new string[0];
            this.AreaTextBox.Location = new System.Drawing.Point(137, 34);
            this.AreaTextBox.MaxLength = 32767;
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.PasswordChar = '\0';
            this.AreaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AreaTextBox.SelectedText = "";
            this.AreaTextBox.SelectionLength = 0;
            this.AreaTextBox.SelectionStart = 0;
            this.AreaTextBox.ShortcutsEnabled = true;
            this.AreaTextBox.ShowButton = true;
            this.AreaTextBox.ShowClearButton = true;
            this.AreaTextBox.Size = new System.Drawing.Size(290, 23);
            this.AreaTextBox.TabIndex = 1;
            this.AreaTextBox.UseSelectable = true;
            this.AreaTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AreaTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.AreaTextBox.TextChanged += new System.EventHandler(this.AreaTextBox_TextChanged);
            this.AreaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AreaTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Area Name";
            // 
            // areaNamedataGridView
            // 
            this.areaNamedataGridView.AllowUserToAddRows = false;
            this.areaNamedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.areaNamedataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.areaNamedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.areaNamedataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.areaNamedataGridView.Location = new System.Drawing.Point(12, 164);
            this.areaNamedataGridView.Name = "areaNamedataGridView";
            this.areaNamedataGridView.ReadOnly = true;
            this.areaNamedataGridView.Size = new System.Drawing.Size(322, 173);
            this.areaNamedataGridView.TabIndex = 2;
            this.areaNamedataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.areaNamedataGridView_RowHeaderMouseDoubleClick);
            // 
            // AreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 347);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.areaNamedataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AreaForm";
            this.Resizable = false;
            this.Text = "Area Form";
            this.Load += new System.EventHandler(this.AreaForm_Load);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaNamedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton Delete;
        private MetroFramework.Controls.MetroButton Upate;
        private MetroFramework.Controls.MetroButton Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox AreaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView areaNamedataGridView;
    }
}