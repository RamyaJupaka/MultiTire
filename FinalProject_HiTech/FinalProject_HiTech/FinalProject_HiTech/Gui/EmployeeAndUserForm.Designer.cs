namespace FinalProject_HiTech.Gui
{
    partial class EmployeeAndUserForm
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
            this.buttonEmployeeExit = new System.Windows.Forms.Button();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEmployeeListALL = new System.Windows.Forms.Button();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.textBox1EmployeeSearch = new System.Windows.Forms.TextBox();
            this.buttonEmployeeSearch = new System.Windows.Forms.Button();
            this.buttonEmployeeDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.buttonEmployeeUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEmployeeSave = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonUserEXIT = new System.Windows.Forms.Button();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxrepsw = new System.Windows.Forms.TextBox();
            this.textBoxpsw = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUserList = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxToSearchInput = new System.Windows.Forms.TextBox();
            this.buttonUserSearch = new System.Windows.Forms.Button();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTOsearch = new System.Windows.Forms.ComboBox();
            this.buttonUserUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUserFname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonUserSave = new System.Windows.Forms.Button();
            this.textBoxUserLname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxUserJobTitle = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 734);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonEmployeeExit);
            this.tabPage1.Controls.Add(this.listViewEmployee);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1050, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonEmployeeExit
            // 
            this.buttonEmployeeExit.Location = new System.Drawing.Point(827, 585);
            this.buttonEmployeeExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmployeeExit.Name = "buttonEmployeeExit";
            this.buttonEmployeeExit.Size = new System.Drawing.Size(121, 33);
            this.buttonEmployeeExit.TabIndex = 54;
            this.buttonEmployeeExit.Text = "E&xit";
            this.buttonEmployeeExit.UseVisualStyleBackColor = true;
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.HideSelection = false;
            this.listViewEmployee.Location = new System.Drawing.Point(148, 370);
            this.listViewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(608, 248);
            this.listViewEmployee.TabIndex = 53;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee ID";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 146;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Job Title";
            this.columnHeader4.Width = 145;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonEmployeeListALL);
            this.groupBox1.Controls.Add(this.textBoxEmpID);
            this.groupBox1.Controls.Add(this.textBox1EmployeeSearch);
            this.groupBox1.Controls.Add(this.buttonEmployeeSearch);
            this.groupBox1.Controls.Add(this.buttonEmployeeDelete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxEmployee);
            this.groupBox1.Controls.Add(this.buttonEmployeeUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonEmployeeSave);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxJobTitle);
            this.groupBox1.Location = new System.Drawing.Point(11, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 296);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Employee ID";
            // 
            // buttonEmployeeListALL
            // 
            this.buttonEmployeeListALL.Location = new System.Drawing.Point(358, 231);
            this.buttonEmployeeListALL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmployeeListALL.Name = "buttonEmployeeListALL";
            this.buttonEmployeeListALL.Size = new System.Drawing.Size(444, 60);
            this.buttonEmployeeListALL.TabIndex = 50;
            this.buttonEmployeeListALL.Text = "List All Employee";
            this.buttonEmployeeListALL.UseVisualStyleBackColor = true;
            this.buttonEmployeeListALL.Click += new System.EventHandler(this.ButtonEmployeeListALL_Click);
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Location = new System.Drawing.Point(71, 86);
            this.textBoxEmpID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(162, 22);
            this.textBoxEmpID.TabIndex = 32;
            this.textBoxEmpID.Tag = "1";
            // 
            // textBox1EmployeeSearch
            // 
            this.textBox1EmployeeSearch.Location = new System.Drawing.Point(378, 169);
            this.textBox1EmployeeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1EmployeeSearch.Name = "textBox1EmployeeSearch";
            this.textBox1EmployeeSearch.Size = new System.Drawing.Size(257, 22);
            this.textBox1EmployeeSearch.TabIndex = 45;
            // 
            // buttonEmployeeSearch
            // 
            this.buttonEmployeeSearch.Location = new System.Drawing.Point(685, 155);
            this.buttonEmployeeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmployeeSearch.Name = "buttonEmployeeSearch";
            this.buttonEmployeeSearch.Size = new System.Drawing.Size(144, 58);
            this.buttonEmployeeSearch.TabIndex = 47;
            this.buttonEmployeeSearch.Text = "Search";
            this.buttonEmployeeSearch.UseVisualStyleBackColor = true;
            this.buttonEmployeeSearch.Click += new System.EventHandler(this.ButtonEmployeeSearch_Click);
            // 
            // buttonEmployeeDelete
            // 
            this.buttonEmployeeDelete.Location = new System.Drawing.Point(900, 231);
            this.buttonEmployeeDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmployeeDelete.Name = "buttonEmployeeDelete";
            this.buttonEmployeeDelete.Size = new System.Drawing.Size(117, 60);
            this.buttonEmployeeDelete.TabIndex = 49;
            this.buttonEmployeeDelete.Text = "Delete";
            this.buttonEmployeeDelete.UseVisualStyleBackColor = true;
            this.buttonEmployeeDelete.Click += new System.EventHandler(this.ButtonEmployeeDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 46;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Items.AddRange(new object[] {
            "Select the Search option",
            "Employee ID",
            "First Name",
            "Last Name",
            "Job Title"});
            this.comboBoxEmployee.Location = new System.Drawing.Point(115, 163);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(244, 24);
            this.comboBoxEmployee.TabIndex = 44;
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEmployee_SelectedIndexChanged);
            // 
            // buttonEmployeeUpdate
            // 
            this.buttonEmployeeUpdate.Location = new System.Drawing.Point(210, 231);
            this.buttonEmployeeUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmployeeUpdate.Name = "buttonEmployeeUpdate";
            this.buttonEmployeeUpdate.Size = new System.Drawing.Size(117, 60);
            this.buttonEmployeeUpdate.TabIndex = 48;
            this.buttonEmployeeUpdate.Text = "Update";
            this.buttonEmployeeUpdate.UseVisualStyleBackColor = true;
            this.buttonEmployeeUpdate.Click += new System.EventHandler(this.ButtonEmployeeUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Search By";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(342, 86);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(162, 22);
            this.textBoxFirstName.TabIndex = 34;
            this.textBoxFirstName.Tag = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Last Name";
            // 
            // buttonEmployeeSave
            // 
            this.buttonEmployeeSave.Location = new System.Drawing.Point(48, 231);
            this.buttonEmployeeSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmployeeSave.Name = "buttonEmployeeSave";
            this.buttonEmployeeSave.Size = new System.Drawing.Size(117, 60);
            this.buttonEmployeeSave.TabIndex = 40;
            this.buttonEmployeeSave.Text = "&Save";
            this.buttonEmployeeSave.UseVisualStyleBackColor = true;
            this.buttonEmployeeSave.Click += new System.EventHandler(this.ButtonEmployeeSave_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(570, 86);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(162, 22);
            this.textBoxLastName.TabIndex = 36;
            this.textBoxLastName.Tag = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(791, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Job Title";
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(794, 86);
            this.textBoxJobTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(162, 22);
            this.textBoxJobTitle.TabIndex = 38;
            this.textBoxJobTitle.Tag = "4";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonUserEXIT);
            this.tabPage2.Controls.Add(this.listViewUser);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1050, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonUserEXIT
            // 
            this.buttonUserEXIT.Location = new System.Drawing.Point(801, 590);
            this.buttonUserEXIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserEXIT.Name = "buttonUserEXIT";
            this.buttonUserEXIT.Size = new System.Drawing.Size(121, 33);
            this.buttonUserEXIT.TabIndex = 56;
            this.buttonUserEXIT.Text = "E&xit";
            this.buttonUserEXIT.UseVisualStyleBackColor = true;
            // 
            // listViewUser
            // 
            this.listViewUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewUser.GridLines = true;
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(122, 375);
            this.listViewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(608, 248);
            this.listViewUser.TabIndex = 55;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "User ID";
            this.columnHeader5.Width = 165;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "First Name";
            this.columnHeader6.Width = 146;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Last Name";
            this.columnHeader7.Width = 146;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Job Title";
            this.columnHeader8.Width = 145;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxrepsw);
            this.groupBox2.Controls.Add(this.textBoxpsw);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonUserList);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxUserID);
            this.groupBox2.Controls.Add(this.textBoxToSearchInput);
            this.groupBox2.Controls.Add(this.buttonUserSearch);
            this.groupBox2.Controls.Add(this.buttonUserDelete);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxTOsearch);
            this.groupBox2.Controls.Add(this.buttonUserUpdate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxUserFname);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.buttonUserSave);
            this.groupBox2.Controls.Add(this.textBoxUserLname);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxUserJobTitle);
            this.groupBox2.Location = new System.Drawing.Point(7, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1043, 296);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users Info";
            // 
            // textBoxrepsw
            // 
            this.textBoxrepsw.Location = new System.Drawing.Point(909, 86);
            this.textBoxrepsw.Name = "textBoxrepsw";
            this.textBoxrepsw.Size = new System.Drawing.Size(100, 22);
            this.textBoxrepsw.TabIndex = 59;
            // 
            // textBoxpsw
            // 
            this.textBoxpsw.Location = new System.Drawing.Point(789, 86);
            this.textBoxpsw.Name = "textBoxpsw";
            this.textBoxpsw.Size = new System.Drawing.Size(100, 22);
            this.textBoxpsw.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(906, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 57;
            this.label13.Text = "Re-Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "User ID";
            // 
            // buttonUserList
            // 
            this.buttonUserList.Location = new System.Drawing.Point(358, 231);
            this.buttonUserList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserList.Name = "buttonUserList";
            this.buttonUserList.Size = new System.Drawing.Size(444, 60);
            this.buttonUserList.TabIndex = 50;
            this.buttonUserList.Text = "List All User";
            this.buttonUserList.UseVisualStyleBackColor = true;
            this.buttonUserList.Click += new System.EventHandler(this.ButtonUserList_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(791, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 58;
            this.label14.Text = "Password";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(9, 86);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(162, 22);
            this.textBoxUserID.TabIndex = 32;
            this.textBoxUserID.Tag = "1";
            // 
            // textBoxToSearchInput
            // 
            this.textBoxToSearchInput.Location = new System.Drawing.Point(378, 169);
            this.textBoxToSearchInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxToSearchInput.Name = "textBoxToSearchInput";
            this.textBoxToSearchInput.Size = new System.Drawing.Size(257, 22);
            this.textBoxToSearchInput.TabIndex = 45;
            // 
            // buttonUserSearch
            // 
            this.buttonUserSearch.Location = new System.Drawing.Point(685, 155);
            this.buttonUserSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserSearch.Name = "buttonUserSearch";
            this.buttonUserSearch.Size = new System.Drawing.Size(144, 58);
            this.buttonUserSearch.TabIndex = 47;
            this.buttonUserSearch.Text = "Search";
            this.buttonUserSearch.UseVisualStyleBackColor = true;
            this.buttonUserSearch.Click += new System.EventHandler(this.ButtonUserSearch_Click);
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.Location = new System.Drawing.Point(900, 231);
            this.buttonUserDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(117, 60);
            this.buttonUserDelete.TabIndex = 49;
            this.buttonUserDelete.Text = "Delete";
            this.buttonUserDelete.UseVisualStyleBackColor = true;
            this.buttonUserDelete.Click += new System.EventHandler(this.ButtonUserDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "label9";
            // 
            // comboBoxTOsearch
            // 
            this.comboBoxTOsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTOsearch.FormattingEnabled = true;
            this.comboBoxTOsearch.Items.AddRange(new object[] {
            "Select the Search option",
            "User ID",
            "First Name",
            "Last Name",
            "Job Title"});
            this.comboBoxTOsearch.Location = new System.Drawing.Point(96, 167);
            this.comboBoxTOsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTOsearch.Name = "comboBoxTOsearch";
            this.comboBoxTOsearch.Size = new System.Drawing.Size(244, 24);
            this.comboBoxTOsearch.TabIndex = 44;
            this.comboBoxTOsearch.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTOsearch_SelectedIndexChanged);
            // 
            // buttonUserUpdate
            // 
            this.buttonUserUpdate.Location = new System.Drawing.Point(210, 231);
            this.buttonUserUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserUpdate.Name = "buttonUserUpdate";
            this.buttonUserUpdate.Size = new System.Drawing.Size(117, 60);
            this.buttonUserUpdate.TabIndex = 48;
            this.buttonUserUpdate.Text = "Update";
            this.buttonUserUpdate.UseVisualStyleBackColor = true;
            this.buttonUserUpdate.Click += new System.EventHandler(this.ButtonUserUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Search By";
            // 
            // textBoxUserFname
            // 
            this.textBoxUserFname.Location = new System.Drawing.Point(232, 86);
            this.textBoxUserFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserFname.Name = "textBoxUserFname";
            this.textBoxUserFname.Size = new System.Drawing.Size(162, 22);
            this.textBoxUserFname.TabIndex = 34;
            this.textBoxUserFname.Tag = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Last Name";
            // 
            // buttonUserSave
            // 
            this.buttonUserSave.Location = new System.Drawing.Point(48, 231);
            this.buttonUserSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserSave.Name = "buttonUserSave";
            this.buttonUserSave.Size = new System.Drawing.Size(117, 60);
            this.buttonUserSave.TabIndex = 40;
            this.buttonUserSave.Text = "&Save";
            this.buttonUserSave.UseVisualStyleBackColor = true;
            this.buttonUserSave.Click += new System.EventHandler(this.ButtonUserSave_Click);
            // 
            // textBoxUserLname
            // 
            this.textBoxUserLname.Location = new System.Drawing.Point(429, 86);
            this.textBoxUserLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserLname.Name = "textBoxUserLname";
            this.textBoxUserLname.Size = new System.Drawing.Size(162, 22);
            this.textBoxUserLname.TabIndex = 36;
            this.textBoxUserLname.Tag = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(635, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Job Title";
            // 
            // textBoxUserJobTitle
            // 
            this.textBoxUserJobTitle.Location = new System.Drawing.Point(621, 86);
            this.textBoxUserJobTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserJobTitle.Name = "textBoxUserJobTitle";
            this.textBoxUserJobTitle.Size = new System.Drawing.Size(162, 22);
            this.textBoxUserJobTitle.TabIndex = 38;
            this.textBoxUserJobTitle.Tag = "4";
            // 
            // EmployeeAndUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 745);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeAndUserForm";
            this.Text = "EmployeeAndUserForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonEmployeeExit;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEmployeeListALL;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.TextBox textBox1EmployeeSearch;
        private System.Windows.Forms.Button buttonEmployeeSearch;
        private System.Windows.Forms.Button buttonEmployeeDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Button buttonEmployeeUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEmployeeSave;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonUserEXIT;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUserList;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxToSearchInput;
        private System.Windows.Forms.Button buttonUserSearch;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTOsearch;
        private System.Windows.Forms.Button buttonUserUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUserFname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonUserSave;
        private System.Windows.Forms.TextBox textBoxUserLname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxUserJobTitle;
        private System.Windows.Forms.TextBox textBoxrepsw;
        private System.Windows.Forms.TextBox textBoxpsw;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}