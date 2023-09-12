
namespace contactProj
{
    partial class emailWin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteEmail = new System.Windows.Forms.Button();
            this.btnUpdateEmail = new System.Windows.Forms.Button();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.cbxEmailHidden = new System.Windows.Forms.ComboBox();
            this.dgvEmails = new System.Windows.Forms.DataGridView();
            this.cbxContactsHidden = new System.Windows.Forms.ComboBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmailAdd = new System.Windows.Forms.TextBox();
            this.txbEmailUpdate = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteEmail
            // 
            this.btnDeleteEmail.Location = new System.Drawing.Point(529, 272);
            this.btnDeleteEmail.Name = "btnDeleteEmail";
            this.btnDeleteEmail.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteEmail.TabIndex = 13;
            this.btnDeleteEmail.Text = "Delete";
            this.btnDeleteEmail.UseVisualStyleBackColor = true;
            this.btnDeleteEmail.Click += new System.EventHandler(this.btnDeleteEmail_Click);
            // 
            // btnUpdateEmail
            // 
            this.btnUpdateEmail.Location = new System.Drawing.Point(529, 234);
            this.btnUpdateEmail.Name = "btnUpdateEmail";
            this.btnUpdateEmail.Size = new System.Drawing.Size(89, 23);
            this.btnUpdateEmail.TabIndex = 14;
            this.btnUpdateEmail.Text = "Update";
            this.btnUpdateEmail.UseVisualStyleBackColor = true;
            this.btnUpdateEmail.Click += new System.EventHandler(this.btnUpdateEmail_Click);
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Location = new System.Drawing.Point(351, 234);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(89, 23);
            this.btnAddEmail.TabIndex = 15;
            this.btnAddEmail.Text = "Add";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // cbxEmailHidden
            // 
            this.cbxEmailHidden.FormattingEnabled = true;
            this.cbxEmailHidden.Location = new System.Drawing.Point(426, 110);
            this.cbxEmailHidden.Name = "cbxEmailHidden";
            this.cbxEmailHidden.Size = new System.Drawing.Size(121, 21);
            this.cbxEmailHidden.TabIndex = 8;
            this.cbxEmailHidden.Visible = false;
            this.cbxEmailHidden.SelectedIndexChanged += new System.EventHandler(this.cbxEmailHidden_SelectedIndexChanged);
            // 
            // dgvEmails
            // 
            this.dgvEmails.AllowUserToAddRows = false;
            this.dgvEmails.AllowUserToDeleteRows = false;
            this.dgvEmails.AutoGenerateColumns = false;
            this.dgvEmails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn});
            this.dgvEmails.DataSource = this.emailTBLBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmails.Location = new System.Drawing.Point(351, 51);
            this.dgvEmails.Name = "dgvEmails";
            this.dgvEmails.ReadOnly = true;
            this.dgvEmails.RowHeadersVisible = false;
            this.dgvEmails.Size = new System.Drawing.Size(267, 124);
            this.dgvEmails.TabIndex = 10;
            // 
            // cbxContactsHidden
            // 
            this.cbxContactsHidden.FormattingEnabled = true;
            this.cbxContactsHidden.Location = new System.Drawing.Point(123, 110);
            this.cbxContactsHidden.Name = "cbxContactsHidden";
            this.cbxContactsHidden.Size = new System.Drawing.Size(121, 21);
            this.cbxContactsHidden.TabIndex = 9;
            this.cbxContactsHidden.Visible = false;
            this.cbxContactsHidden.SelectedIndexChanged += new System.EventHandler(this.cbxContactsHidden_SelectedIndexChanged);
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvContacts.AutoGenerateColumns = false;
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn});
            this.dgvContacts.DataSource = this.contactTBLBindingSource;
            this.dgvContacts.Location = new System.Drawing.Point(77, 51);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.Size = new System.Drawing.Size(240, 278);
            this.dgvContacts.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Contact";
            // 
            // txbEmailAdd
            // 
            this.txbEmailAdd.Location = new System.Drawing.Point(351, 191);
            this.txbEmailAdd.MaxLength = 45;
            this.txbEmailAdd.Name = "txbEmailAdd";
            this.txbEmailAdd.Size = new System.Drawing.Size(100, 20);
            this.txbEmailAdd.TabIndex = 16;
            // 
            // txbEmailUpdate
            // 
            this.txbEmailUpdate.Location = new System.Drawing.Point(518, 191);
            this.txbEmailUpdate.MaxLength = 45;
            this.txbEmailUpdate.Name = "txbEmailUpdate";
            this.txbEmailUpdate.Size = new System.Drawing.Size(100, 20);
            this.txbEmailUpdate.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "שם מלא";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactTBLBindingSource
            // 
            this.contactTBLBindingSource.DataSource = typeof(contactProj.contactTBL);
            // 
            // emailTBLBindingSource
            // 
            this.emailTBLBindingSource.DataSource = typeof(contactProj.emailTBL);
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbEmailUpdate);
            this.Controls.Add(this.txbEmailAdd);
            this.Controls.Add(this.btnDeleteEmail);
            this.Controls.Add(this.btnUpdateEmail);
            this.Controls.Add(this.btnAddEmail);
            this.Controls.Add(this.cbxEmailHidden);
            this.Controls.Add(this.dgvEmails);
            this.Controls.Add(this.cbxContactsHidden);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "emailWin";
            this.Text = "emailWin";
            this.Load += new System.EventHandler(this.emailWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteEmail;
        private System.Windows.Forms.Button btnUpdateEmail;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.ComboBox cbxEmailHidden;
        private System.Windows.Forms.DataGridView dgvEmails;
        private System.Windows.Forms.ComboBox cbxContactsHidden;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmailAdd;
        private System.Windows.Forms.TextBox txbEmailUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactTBLBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource emailTBLBindingSource;
    }
}