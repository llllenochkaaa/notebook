namespace notebook
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.friendslist = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfWorkOrStudyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acquaintanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendslist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 40);
            this.panel1.TabIndex = 27;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Location = new System.Drawing.Point(3, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(118, 24);
            this.Title.TabIndex = 6;
            this.Title.Text = "My friends";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.friendToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.loadToolStripMenuItem,
            this.toolStripMenuItem2,
            this.clearToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(130, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // friendToolStripMenuItem
            // 
            this.friendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripMenuItem3,
            this.editToolStripMenuItem,
            this.toolStripMenuItem4,
            this.deleteToolStripMenuItem});
            this.friendToolStripMenuItem.Name = "friendToolStripMenuItem";
            this.friendToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.friendToolStripMenuItem.Text = "Friend";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(140, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(140, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Location = new System.Drawing.Point(401, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 85);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Pink;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.Color.Maroon;
            this.searchButton.Location = new System.Drawing.Point(151, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 29);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(7, 22);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(374, 22);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sortComboBox);
            this.groupBox2.Location = new System.Drawing.Point(179, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 59);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort by:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(40, 20);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(121, 24);
            this.sortComboBox.TabIndex = 0;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayTextBox.Location = new System.Drawing.Point(147, 407);
            this.birthdayTextBox.Multiline = true;
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(362, 77);
            this.birthdayTextBox.TabIndex = 40;
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.Pink;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyButton.ForeColor = System.Drawing.Color.Maroon;
            this.copyButton.Location = new System.Drawing.Point(531, 425);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(108, 34);
            this.copyButton.TabIndex = 41;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // friendslist
            // 
            this.friendslist.AutoGenerateColumns = false;
            this.friendslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friendslist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.placeOfWorkOrStudyDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.acquaintanceDataGridViewTextBoxColumn});
            this.friendslist.DataSource = this.personBindingSource;
            this.friendslist.Location = new System.Drawing.Point(20, 141);
            this.friendslist.Name = "friendslist";
            this.friendslist.RowHeadersWidth = 51;
            this.friendslist.RowTemplate.Height = 24;
            this.friendslist.Size = new System.Drawing.Size(768, 260);
            this.friendslist.TabIndex = 42;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(notebook.Person);
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeOfWorkOrStudyDataGridViewTextBoxColumn
            // 
            this.placeOfWorkOrStudyDataGridViewTextBoxColumn.DataPropertyName = "PlaceOfWorkOrStudy";
            this.placeOfWorkOrStudyDataGridViewTextBoxColumn.HeaderText = "PlaceOfWorkOrStudy";
            this.placeOfWorkOrStudyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placeOfWorkOrStudyDataGridViewTextBoxColumn.Name = "placeOfWorkOrStudyDataGridViewTextBoxColumn";
            this.placeOfWorkOrStudyDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // acquaintanceDataGridViewTextBoxColumn
            // 
            this.acquaintanceDataGridViewTextBoxColumn.DataPropertyName = "Acquaintance";
            this.acquaintanceDataGridViewTextBoxColumn.HeaderText = "Acquaintance";
            this.acquaintanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acquaintanceDataGridViewTextBoxColumn.Name = "acquaintanceDataGridViewTextBoxColumn";
            this.acquaintanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.friendslist);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Notebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendslist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem friendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastAddedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.DataGridView friendslist;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfWorkOrStudyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acquaintanceDataGridViewTextBoxColumn;
    }
}