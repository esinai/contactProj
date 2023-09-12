
namespace contactProj
{
    partial class mainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contactManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenContactWin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateContact = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListOfContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhoneWin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenEmailWin = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnOpenReportWin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactManagerToolStripMenuItem,
            this.phoneManagerToolStripMenuItem,
            this.btnOpenEmailWin,
            this.btnOpenReportWin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contactManagerToolStripMenuItem
            // 
            this.contactManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenContactWin,
            this.btnUpdateContact,
            this.btnListOfContacts});
            this.contactManagerToolStripMenuItem.Name = "contactManagerToolStripMenuItem";
            this.contactManagerToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.contactManagerToolStripMenuItem.Text = "Contact Manager";
            // 
            // btnOpenContactWin
            // 
            this.btnOpenContactWin.Name = "btnOpenContactWin";
            this.btnOpenContactWin.Size = new System.Drawing.Size(201, 22);
            this.btnOpenContactWin.Text = "Add Contact";
            this.btnOpenContactWin.Click += new System.EventHandler(this.btnOpenContactWin_Click);
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(201, 22);
            this.btnUpdateContact.Text = "Update / Delete Contact";
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // btnListOfContacts
            // 
            this.btnListOfContacts.Name = "btnListOfContacts";
            this.btnListOfContacts.Size = new System.Drawing.Size(201, 22);
            this.btnListOfContacts.Text = "List of contacts";
            this.btnListOfContacts.Click += new System.EventHandler(this.btnListOfContacts_Click);
            // 
            // phoneManagerToolStripMenuItem
            // 
            this.phoneManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPhoneWin});
            this.phoneManagerToolStripMenuItem.Name = "phoneManagerToolStripMenuItem";
            this.phoneManagerToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.phoneManagerToolStripMenuItem.Text = "Phone Manager";
            // 
            // btnPhoneWin
            // 
            this.btnPhoneWin.Name = "btnPhoneWin";
            this.btnPhoneWin.Size = new System.Drawing.Size(182, 22);
            this.btnPhoneWin.Text = "Add / Modify Phone";
            this.btnPhoneWin.Click += new System.EventHandler(this.btnPhoneWin_Click);
            // 
            // btnOpenEmailWin
            // 
            this.btnOpenEmailWin.Name = "btnOpenEmailWin";
            this.btnOpenEmailWin.Size = new System.Drawing.Size(98, 20);
            this.btnOpenEmailWin.Text = "Email Manager";
            this.btnOpenEmailWin.Click += new System.EventHandler(this.btnOpenEmailWin_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(589, 314);
            this.mainPanel.TabIndex = 1;
            // 
            // btnOpenReportWin
            // 
            this.btnOpenReportWin.Name = "btnOpenReportWin";
            this.btnOpenReportWin.Size = new System.Drawing.Size(54, 20);
            this.btnOpenReportWin.Text = "Report";
            this.btnOpenReportWin.Click += new System.EventHandler(this.btnOpenReportWin_Click);
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 338);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainWin";
            this.Text = "mainWin";
            this.Load += new System.EventHandler(this.mainWin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contactManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpenContactWin;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateContact;
        private System.Windows.Forms.ToolStripMenuItem btnListOfContacts;
        private System.Windows.Forms.ToolStripMenuItem phoneManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpenEmailWin;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem btnPhoneWin;
        private System.Windows.Forms.ToolStripMenuItem btnOpenReportWin;
    }
}