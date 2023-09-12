
namespace contactProj
{
    partial class ContactControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFullName = new System.Windows.Forms.Label();
            this.PhoneListView = new System.Windows.Forms.ListView();
            this.EmailListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(141, 12);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(48, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "fullName";
            // 
            // PhoneListView
            // 
            this.PhoneListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneListView.HideSelection = false;
            this.PhoneListView.Location = new System.Drawing.Point(3, 3);
            this.PhoneListView.Name = "PhoneListView";
            this.PhoneListView.Size = new System.Drawing.Size(144, 135);
            this.PhoneListView.TabIndex = 1;
            this.PhoneListView.UseCompatibleStateImageBehavior = false;
            this.PhoneListView.View = System.Windows.Forms.View.List;
            // 
            // EmailListView
            // 
            this.EmailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailListView.HideSelection = false;
            this.EmailListView.Location = new System.Drawing.Point(153, 3);
            this.EmailListView.Name = "EmailListView";
            this.EmailListView.Size = new System.Drawing.Size(144, 135);
            this.EmailListView.TabIndex = 1;
            this.EmailListView.UseCompatibleStateImageBehavior = false;
            this.EmailListView.View = System.Windows.Forms.View.List;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.EmailListView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PhoneListView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 141);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblFullName);
            this.Name = "ContactControl";
            this.Size = new System.Drawing.Size(330, 194);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.ListView PhoneListView;
        private System.Windows.Forms.ListView EmailListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
