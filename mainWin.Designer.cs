﻿
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAddLastName = new System.Windows.Forms.TextBox();
            this.txbAddFirstName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbLNUpdate = new System.Windows.Forms.TextBox();
            this.txbFNUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxContacts = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddContact);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txbAddLastName);
            this.tabPage1.Controls.Add(this.txbAddFirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Contact";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(83, 102);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(100, 23);
            this.btnAddContact.TabIndex = 3;
            this.btnAddContact.Text = "Add";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(200, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txbAddLastName
            // 
            this.txbAddLastName.Location = new System.Drawing.Point(83, 75);
            this.txbAddLastName.MaxLength = 45;
            this.txbAddLastName.Name = "txbAddLastName";
            this.txbAddLastName.Size = new System.Drawing.Size(100, 20);
            this.txbAddLastName.TabIndex = 0;
            // 
            // txbAddFirstName
            // 
            this.txbAddFirstName.Location = new System.Drawing.Point(83, 49);
            this.txbAddFirstName.MaxLength = 45;
            this.txbAddFirstName.Name = "txbAddFirstName";
            this.txbAddFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbAddFirstName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdateContact);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txbLNUpdate);
            this.tabPage2.Controls.Add(this.txbFNUpdate);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbxContacts);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Contact";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.Location = new System.Drawing.Point(165, 141);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateContact.TabIndex = 8;
            this.btnUpdateContact.Text = "Update";
            this.btnUpdateContact.UseVisualStyleBackColor = true;
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "First Name";
            // 
            // txbLNUpdate
            // 
            this.txbLNUpdate.Location = new System.Drawing.Point(165, 114);
            this.txbLNUpdate.MaxLength = 45;
            this.txbLNUpdate.Name = "txbLNUpdate";
            this.txbLNUpdate.Size = new System.Drawing.Size(100, 20);
            this.txbLNUpdate.TabIndex = 4;
            // 
            // txbFNUpdate
            // 
            this.txbFNUpdate.Location = new System.Drawing.Point(165, 88);
            this.txbFNUpdate.MaxLength = 45;
            this.txbFNUpdate.Name = "txbFNUpdate";
            this.txbFNUpdate.Size = new System.Drawing.Size(100, 20);
            this.txbFNUpdate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Contact";
            // 
            // cbxContacts
            // 
            this.cbxContacts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContacts.FormattingEnabled = true;
            this.cbxContacts.Location = new System.Drawing.Point(144, 50);
            this.cbxContacts.Name = "cbxContacts";
            this.cbxContacts.Size = new System.Drawing.Size(121, 21);
            this.cbxContacts.TabIndex = 0;
            this.cbxContacts.SelectedIndexChanged += new System.EventHandler(this.cbxContacts_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(950, 515);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "List Of Contacts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainWin";
            this.Text = "Contacts Project Demo";
            this.Load += new System.EventHandler(this.mainWin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAddLastName;
        private System.Windows.Forms.TextBox txbAddFirstName;
        private System.Windows.Forms.ComboBox cbxContacts;
        private System.Windows.Forms.Button btnUpdateContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbLNUpdate;
        private System.Windows.Forms.TextBox txbFNUpdate;
        private System.Windows.Forms.Label label4;
    }
}
