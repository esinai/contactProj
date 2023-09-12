
namespace contactProj
{
    partial class reportWin
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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNumOfContacts = new System.Windows.Forms.Label();
            this.lblAvgPhone = new System.Windows.Forms.Label();
            this.lblAvgEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanel.Location = new System.Drawing.Point(12, 33);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(583, 263);
            this.flowPanel.TabIndex = 1;
            // 
            // lblNumOfContacts
            // 
            this.lblNumOfContacts.AutoSize = true;
            this.lblNumOfContacts.Location = new System.Drawing.Point(29, 14);
            this.lblNumOfContacts.Name = "lblNumOfContacts";
            this.lblNumOfContacts.Size = new System.Drawing.Size(35, 13);
            this.lblNumOfContacts.TabIndex = 2;
            this.lblNumOfContacts.Text = "label1";
            // 
            // lblAvgPhone
            // 
            this.lblAvgPhone.AutoSize = true;
            this.lblAvgPhone.Location = new System.Drawing.Point(260, 14);
            this.lblAvgPhone.Name = "lblAvgPhone";
            this.lblAvgPhone.Size = new System.Drawing.Size(35, 13);
            this.lblAvgPhone.TabIndex = 3;
            this.lblAvgPhone.Text = "label2";
            // 
            // lblAvgEmail
            // 
            this.lblAvgEmail.AutoSize = true;
            this.lblAvgEmail.Location = new System.Drawing.Point(537, 13);
            this.lblAvgEmail.Name = "lblAvgEmail";
            this.lblAvgEmail.Size = new System.Drawing.Size(35, 13);
            this.lblAvgEmail.TabIndex = 4;
            this.lblAvgEmail.Text = "label3";
            // 
            // reportWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(607, 308);
            this.Controls.Add(this.lblAvgEmail);
            this.Controls.Add(this.lblAvgPhone);
            this.Controls.Add(this.lblNumOfContacts);
            this.Controls.Add(this.flowPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportWin";
            this.Text = "reportWin";
            this.Load += new System.EventHandler(this.reportWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Label lblNumOfContacts;
        private System.Windows.Forms.Label lblAvgPhone;
        private System.Windows.Forms.Label lblAvgEmail;
    }
}