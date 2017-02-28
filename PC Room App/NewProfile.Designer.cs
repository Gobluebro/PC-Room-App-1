﻿namespace PC_Room_App
{
    partial class formNewProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNewProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.txtWoWLoc = new System.Windows.Forms.TextBox();
            this.txtOWLoc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBrowseWoW = new System.Windows.Forms.Button();
            this.btnBrowseOW = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkWOW = new System.Windows.Forms.CheckBox();
            this.chkOW = new System.Windows.Forms.CheckBox();
            this.grpboxWOW = new System.Windows.Forms.GroupBox();
            this.btnWOWAddonsLoc = new System.Windows.Forms.Button();
            this.txtAddons = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpboxOW = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpboxWOW.SuspendLayout();
            this.grpboxOW.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "World of Warcraft Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Overwatch Location:";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(273, 40);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(279, 26);
            this.txtProfileName.TabIndex = 3;
            // 
            // txtWoWLoc
            // 
            this.txtWoWLoc.Location = new System.Drawing.Point(239, 25);
            this.txtWoWLoc.Name = "txtWoWLoc";
            this.txtWoWLoc.Size = new System.Drawing.Size(279, 26);
            this.txtWoWLoc.TabIndex = 4;
            // 
            // txtOWLoc
            // 
            this.txtOWLoc.Location = new System.Drawing.Point(239, 22);
            this.txtOWLoc.Name = "txtOWLoc";
            this.txtOWLoc.Size = new System.Drawing.Size(279, 26);
            this.txtOWLoc.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 86);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(378, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 86);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBrowseWoW
            // 
            this.btnBrowseWoW.Location = new System.Drawing.Point(524, 17);
            this.btnBrowseWoW.Name = "btnBrowseWoW";
            this.btnBrowseWoW.Size = new System.Drawing.Size(41, 34);
            this.btnBrowseWoW.TabIndex = 8;
            this.btnBrowseWoW.Text = "...";
            this.btnBrowseWoW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseWoW.UseVisualStyleBackColor = true;
            this.btnBrowseWoW.Click += new System.EventHandler(this.btnBrowseWoW_Click);
            // 
            // btnBrowseOW
            // 
            this.btnBrowseOW.Location = new System.Drawing.Point(524, 19);
            this.btnBrowseOW.Name = "btnBrowseOW";
            this.btnBrowseOW.Size = new System.Drawing.Size(41, 35);
            this.btnBrowseOW.TabIndex = 9;
            this.btnBrowseOW.Text = "...";
            this.btnBrowseOW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseOW.UseVisualStyleBackColor = true;
            this.btnBrowseOW.Click += new System.EventHandler(this.btnBrowseOW_Click);
            // 
            // chkWOW
            // 
            this.chkWOW.AutoSize = true;
            this.chkWOW.Location = new System.Drawing.Point(273, 78);
            this.chkWOW.Name = "chkWOW";
            this.chkWOW.Size = new System.Drawing.Size(159, 24);
            this.chkWOW.TabIndex = 10;
            this.chkWOW.Text = "World of Warcraft";
            this.chkWOW.UseVisualStyleBackColor = true;
            this.chkWOW.CheckedChanged += new System.EventHandler(this.chkWOW_CheckedChanged);
            // 
            // chkOW
            // 
            this.chkOW.AutoSize = true;
            this.chkOW.Location = new System.Drawing.Point(442, 78);
            this.chkOW.Name = "chkOW";
            this.chkOW.Size = new System.Drawing.Size(110, 24);
            this.chkOW.TabIndex = 11;
            this.chkOW.Text = "Overwatch";
            this.chkOW.UseVisualStyleBackColor = true;
            this.chkOW.CheckedChanged += new System.EventHandler(this.chkOW_CheckedChanged);
            // 
            // grpboxWOW
            // 
            this.grpboxWOW.Controls.Add(this.btnWOWAddonsLoc);
            this.grpboxWOW.Controls.Add(this.txtAddons);
            this.grpboxWOW.Controls.Add(this.label4);
            this.grpboxWOW.Controls.Add(this.label2);
            this.grpboxWOW.Controls.Add(this.txtWoWLoc);
            this.grpboxWOW.Controls.Add(this.btnBrowseWoW);
            this.grpboxWOW.Location = new System.Drawing.Point(12, 108);
            this.grpboxWOW.Name = "grpboxWOW";
            this.grpboxWOW.Size = new System.Drawing.Size(575, 97);
            this.grpboxWOW.TabIndex = 12;
            this.grpboxWOW.TabStop = false;
            this.grpboxWOW.Text = "WoW Information";
            this.grpboxWOW.Visible = false;
            // 
            // btnWOWAddonsLoc
            // 
            this.btnWOWAddonsLoc.Location = new System.Drawing.Point(524, 53);
            this.btnWOWAddonsLoc.Name = "btnWOWAddonsLoc";
            this.btnWOWAddonsLoc.Size = new System.Drawing.Size(41, 35);
            this.btnWOWAddonsLoc.TabIndex = 11;
            this.btnWOWAddonsLoc.Text = "...";
            this.btnWOWAddonsLoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWOWAddonsLoc.UseVisualStyleBackColor = true;
            this.btnWOWAddonsLoc.Click += new System.EventHandler(this.btnWOWAddonsLoc_Click);
            // 
            // txtAddons
            // 
            this.txtAddons.Location = new System.Drawing.Point(239, 57);
            this.txtAddons.Name = "txtAddons";
            this.txtAddons.Size = new System.Drawing.Size(279, 26);
            this.txtAddons.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Addons Location:";
            // 
            // grpboxOW
            // 
            this.grpboxOW.Controls.Add(this.comboBox1);
            this.grpboxOW.Controls.Add(this.label5);
            this.grpboxOW.Controls.Add(this.btnBrowseOW);
            this.grpboxOW.Controls.Add(this.txtOWLoc);
            this.grpboxOW.Controls.Add(this.label3);
            this.grpboxOW.Location = new System.Drawing.Point(12, 223);
            this.grpboxOW.Name = "grpboxOW";
            this.grpboxOW.Size = new System.Drawing.Size(575, 100);
            this.grpboxOW.TabIndex = 13;
            this.grpboxOW.TabStop = false;
            this.grpboxOW.Text = "Overwatch Information";
            this.grpboxOW.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Language:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "한국어"});
            this.comboBox1.Location = new System.Drawing.Point(239, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // formNewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 470);
            this.Controls.Add(this.grpboxOW);
            this.Controls.Add(this.grpboxWOW);
            this.Controls.Add(this.chkOW);
            this.Controls.Add(this.chkWOW);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(611, 526);
            this.MinimumSize = new System.Drawing.Size(611, 526);
            this.Name = "formNewProfile";
            this.Text = "Create a New Profile";
            this.grpboxWOW.ResumeLayout(false);
            this.grpboxWOW.PerformLayout();
            this.grpboxOW.ResumeLayout(false);
            this.grpboxOW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.TextBox txtWoWLoc;
        private System.Windows.Forms.TextBox txtOWLoc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBrowseWoW;
        private System.Windows.Forms.Button btnBrowseOW;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkWOW;
        private System.Windows.Forms.CheckBox chkOW;
        private System.Windows.Forms.GroupBox grpboxWOW;
        private System.Windows.Forms.GroupBox grpboxOW;
        private System.Windows.Forms.Button btnWOWAddonsLoc;
        private System.Windows.Forms.TextBox txtAddons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}