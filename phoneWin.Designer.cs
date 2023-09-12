
namespace contactProj
{
    partial class phoneWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.cbxContactsHidden = new System.Windows.Forms.ComboBox();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.txbPhoneAdd = new System.Windows.Forms.MaskedTextBox();
            this.cbxPhoneHidden = new System.Windows.Forms.ComboBox();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.txbPhoneUpdate = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Contact";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvContacts.AutoGenerateColumns = false;
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn});
            this.dgvContacts.DataSource = this.contactTBLBindingSource;
            this.dgvContacts.Location = new System.Drawing.Point(29, 45);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.Size = new System.Drawing.Size(240, 278);
            this.dgvContacts.TabIndex = 1;
            // 
            // cbxContactsHidden
            // 
            this.cbxContactsHidden.FormattingEnabled = true;
            this.cbxContactsHidden.Location = new System.Drawing.Point(75, 104);
            this.cbxContactsHidden.Name = "cbxContactsHidden";
            this.cbxContactsHidden.Size = new System.Drawing.Size(121, 21);
            this.cbxContactsHidden.TabIndex = 2;
            this.cbxContactsHidden.Visible = false;
            this.cbxContactsHidden.SelectedIndexChanged += new System.EventHandler(this.cbxContactsHidden_SelectedIndexChanged);
            // 
            // dgvPhones
            // 
            this.dgvPhones.AllowUserToAddRows = false;
            this.dgvPhones.AllowUserToDeleteRows = false;
            this.dgvPhones.AutoGenerateColumns = false;
            this.dgvPhones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneDataGridViewTextBoxColumn});
            this.dgvPhones.DataSource = this.phoneTBLBindingSource;
            this.dgvPhones.Location = new System.Drawing.Point(303, 45);
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.ReadOnly = true;
            this.dgvPhones.RowHeadersVisible = false;
            this.dgvPhones.Size = new System.Drawing.Size(240, 124);
            this.dgvPhones.TabIndex = 3;
            // 
            // txbPhoneAdd
            // 
            this.txbPhoneAdd.Location = new System.Drawing.Point(303, 190);
            this.txbPhoneAdd.Mask = "(999) 000-0000";
            this.txbPhoneAdd.Name = "txbPhoneAdd";
            this.txbPhoneAdd.Size = new System.Drawing.Size(89, 20);
            this.txbPhoneAdd.TabIndex = 4;
            this.txbPhoneAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxPhoneHidden
            // 
            this.cbxPhoneHidden.FormattingEnabled = true;
            this.cbxPhoneHidden.Location = new System.Drawing.Point(378, 104);
            this.cbxPhoneHidden.Name = "cbxPhoneHidden";
            this.cbxPhoneHidden.Size = new System.Drawing.Size(121, 21);
            this.cbxPhoneHidden.TabIndex = 2;
            this.cbxPhoneHidden.Visible = false;
            this.cbxPhoneHidden.SelectedIndexChanged += new System.EventHandler(this.cbxPhoneHidden_SelectedIndexChanged);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(303, 228);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(89, 23);
            this.btnAddPhone.TabIndex = 5;
            this.btnAddPhone.Text = "Add";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // txbPhoneUpdate
            // 
            this.txbPhoneUpdate.Location = new System.Drawing.Point(431, 190);
            this.txbPhoneUpdate.Mask = "(999) 000-0000";
            this.txbPhoneUpdate.Name = "txbPhoneUpdate";
            this.txbPhoneUpdate.Size = new System.Drawing.Size(89, 20);
            this.txbPhoneUpdate.TabIndex = 4;
            this.txbPhoneUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(431, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(431, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.phoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.phoneDataGridViewTextBoxColumn.HeaderText = "מס טלפון";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneTBLBindingSource
            // 
            this.phoneTBLBindingSource.DataSource = typeof(contactProj.phoneTBL);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fullNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "שם מלא";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactTBLBindingSource
            // 
            this.contactTBLBindingSource.DataSource = typeof(contactProj.contactTBL);
            // 
            // phoneWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(565, 368);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.cbxPhoneHidden);
            this.Controls.Add(this.txbPhoneUpdate);
            this.Controls.Add(this.txbPhoneAdd);
            this.Controls.Add(this.dgvPhones);
            this.Controls.Add(this.cbxContactsHidden);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "phoneWin";
            this.Text = "phoneWin";
            this.Load += new System.EventHandler(this.phoneWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactTBLBindingSource;
        private System.Windows.Forms.ComboBox cbxContactsHidden;
        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource phoneTBLBindingSource;
        private System.Windows.Forms.MaskedTextBox txbPhoneAdd;
        private System.Windows.Forms.ComboBox cbxPhoneHidden;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.MaskedTextBox txbPhoneUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}