﻿namespace IRCSharp
{
    partial class IRCApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StatusTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StatusTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 726);
            this.tabControl1.TabIndex = 1;
            // 
            // StatusTab
            // 
            this.StatusTab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatusTab.Location = new System.Drawing.Point(4, 25);
            this.StatusTab.Name = "StatusTab";
            this.StatusTab.Padding = new System.Windows.Forms.Padding(3);
            this.StatusTab.Size = new System.Drawing.Size(908, 697);
            this.StatusTab.TabIndex = 0;
            this.StatusTab.Text = "Status";
            // 
            // IRCApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(916, 726);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "IRCApp";
            this.Text = "IRCsharp";
            this.Load += new System.EventHandler(this.IRCApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StatusTab;
    }
}

