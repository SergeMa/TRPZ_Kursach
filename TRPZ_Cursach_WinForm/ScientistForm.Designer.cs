namespace TRPZ_Cursach_WinForm
{
    partial class ScientistForm
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
            tabControl1 = new TabControl();
            Project = new TabPage();
            splitContainer1 = new SplitContainer();
            Project_DataGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            CreateProject_Button = new Button();
            EditProject_Button = new Button();
            DeleteProject_Button = new Button();
            Change_Log = new TabPage();
            Change_Log_DataGridView = new DataGridView();
            Media_Reviews = new TabPage();
            splitContainer5 = new SplitContainer();
            Media_dataGridView = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            Account_Tab = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            Name_Label = new Label();
            label4 = new Label();
            Surname_Label = new Label();
            label6 = new Label();
            Institution_Label = new Label();
            Password_Label = new Label();
            Password_TextBox = new TextBox();
            Change_Password_Button = new Button();
            SignOut_Button = new Button();
            dataGridView1 = new DataGridView();
            tabPage1 = new TabPage();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tabControl2 = new TabControl();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            splitContainer3 = new SplitContainer();
            tabControl1.SuspendLayout();
            Project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Project_DataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            Change_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Change_Log_DataGridView).BeginInit();
            Media_Reviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Media_dataGridView).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            Account_Tab.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Project);
            tabControl1.Controls.Add(Change_Log);
            tabControl1.Controls.Add(Media_Reviews);
            tabControl1.Controls.Add(Account_Tab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(876, 477);
            tabControl1.TabIndex = 0;
            // 
            // Project
            // 
            Project.Controls.Add(splitContainer1);
            Project.Location = new Point(4, 29);
            Project.Name = "Project";
            Project.Padding = new Padding(3);
            Project.Size = new Size(868, 444);
            Project.TabIndex = 0;
            Project.Text = "Projects";
            Project.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Project_DataGridView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(862, 438);
            splitContainer1.SplitterDistance = 342;
            splitContainer1.TabIndex = 0;
            // 
            // Project_DataGridView
            // 
            Project_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Project_DataGridView.Dock = DockStyle.Fill;
            Project_DataGridView.Location = new Point(0, 0);
            Project_DataGridView.MultiSelect = false;
            Project_DataGridView.Name = "Project_DataGridView";
            Project_DataGridView.ReadOnly = true;
            Project_DataGridView.RowHeadersWidth = 51;
            Project_DataGridView.RowTemplate.Height = 29;
            Project_DataGridView.Size = new Size(862, 342);
            Project_DataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(CreateProject_Button, 0, 0);
            tableLayoutPanel1.Controls.Add(EditProject_Button, 1, 0);
            tableLayoutPanel1.Controls.Add(DeleteProject_Button, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(862, 92);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CreateProject_Button
            // 
            CreateProject_Button.Dock = DockStyle.Fill;
            CreateProject_Button.Location = new Point(3, 3);
            CreateProject_Button.Name = "CreateProject_Button";
            CreateProject_Button.Size = new Size(281, 86);
            CreateProject_Button.TabIndex = 0;
            CreateProject_Button.Text = "Create project";
            CreateProject_Button.UseVisualStyleBackColor = true;
            CreateProject_Button.Click += CreateProject_Button_Click;
            // 
            // EditProject_Button
            // 
            EditProject_Button.Dock = DockStyle.Fill;
            EditProject_Button.Location = new Point(290, 3);
            EditProject_Button.Name = "EditProject_Button";
            EditProject_Button.Size = new Size(281, 86);
            EditProject_Button.TabIndex = 1;
            EditProject_Button.Text = "Edit project";
            EditProject_Button.UseVisualStyleBackColor = true;
            EditProject_Button.Click += EditProject_Button_Click;
            // 
            // DeleteProject_Button
            // 
            DeleteProject_Button.Dock = DockStyle.Fill;
            DeleteProject_Button.Location = new Point(577, 3);
            DeleteProject_Button.Name = "DeleteProject_Button";
            DeleteProject_Button.Size = new Size(282, 86);
            DeleteProject_Button.TabIndex = 2;
            DeleteProject_Button.Text = "Delete project";
            DeleteProject_Button.UseVisualStyleBackColor = true;
            DeleteProject_Button.Click += DeleteProject_Button_Click;
            // 
            // Change_Log
            // 
            Change_Log.Controls.Add(Change_Log_DataGridView);
            Change_Log.Location = new Point(4, 29);
            Change_Log.Name = "Change_Log";
            Change_Log.Padding = new Padding(3);
            Change_Log.Size = new Size(868, 444);
            Change_Log.TabIndex = 1;
            Change_Log.Text = "Change Log";
            Change_Log.UseVisualStyleBackColor = true;
            // 
            // Change_Log_DataGridView
            // 
            Change_Log_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Change_Log_DataGridView.Dock = DockStyle.Fill;
            Change_Log_DataGridView.Location = new Point(3, 3);
            Change_Log_DataGridView.Name = "Change_Log_DataGridView";
            Change_Log_DataGridView.RowHeadersWidth = 51;
            Change_Log_DataGridView.RowTemplate.Height = 29;
            Change_Log_DataGridView.Size = new Size(862, 438);
            Change_Log_DataGridView.TabIndex = 1;
            // 
            // Media_Reviews
            // 
            Media_Reviews.Controls.Add(splitContainer5);
            Media_Reviews.Location = new Point(4, 29);
            Media_Reviews.Name = "Media_Reviews";
            Media_Reviews.Size = new Size(868, 444);
            Media_Reviews.TabIndex = 2;
            Media_Reviews.Text = "Media Reviews";
            Media_Reviews.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(Media_dataGridView);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(tableLayoutPanel5);
            splitContainer5.Size = new Size(868, 444);
            splitContainer5.SplitterDistance = 324;
            splitContainer5.TabIndex = 0;
            // 
            // Media_dataGridView
            // 
            Media_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Media_dataGridView.Dock = DockStyle.Fill;
            Media_dataGridView.Location = new Point(0, 0);
            Media_dataGridView.Name = "Media_dataGridView";
            Media_dataGridView.RowHeadersWidth = 51;
            Media_dataGridView.RowTemplate.Height = 29;
            Media_dataGridView.Size = new Size(868, 324);
            Media_dataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(button10, 0, 0);
            tableLayoutPanel5.Controls.Add(button11, 1, 0);
            tableLayoutPanel5.Controls.Add(button12, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(868, 116);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(3, 3);
            button10.Name = "button10";
            button10.Size = new Size(283, 110);
            button10.TabIndex = 0;
            button10.Text = "Add media review";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(292, 3);
            button11.Name = "button11";
            button11.Size = new Size(283, 110);
            button11.TabIndex = 1;
            button11.Text = "Edit media review";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(581, 3);
            button12.Name = "button12";
            button12.Size = new Size(284, 110);
            button12.TabIndex = 2;
            button12.Text = "Remove media review";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // Account_Tab
            // 
            Account_Tab.Controls.Add(tableLayoutPanel4);
            Account_Tab.Location = new Point(4, 29);
            Account_Tab.Name = "Account_Tab";
            Account_Tab.Padding = new Padding(3);
            Account_Tab.Size = new Size(868, 444);
            Account_Tab.TabIndex = 3;
            Account_Tab.Text = "Manage account";
            Account_Tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(label1, 1, 0);
            tableLayoutPanel4.Controls.Add(label2, 0, 1);
            tableLayoutPanel4.Controls.Add(Name_Label, 1, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 2);
            tableLayoutPanel4.Controls.Add(Surname_Label, 1, 2);
            tableLayoutPanel4.Controls.Add(label6, 0, 3);
            tableLayoutPanel4.Controls.Add(Institution_Label, 1, 3);
            tableLayoutPanel4.Controls.Add(Password_Label, 0, 4);
            tableLayoutPanel4.Controls.Add(Password_TextBox, 1, 4);
            tableLayoutPanel4.Controls.Add(Change_Password_Button, 2, 4);
            tableLayoutPanel4.Controls.Add(SignOut_Button, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(862, 438);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(290, 0);
            label1.Name = "label1";
            label1.Size = new Size(281, 87);
            label1.TabIndex = 0;
            label1.Text = "Account info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 87);
            label2.Name = "label2";
            label2.Size = new Size(281, 87);
            label2.TabIndex = 1;
            label2.Text = "Name: ";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // Name_Label
            // 
            Name_Label.AutoSize = true;
            Name_Label.Dock = DockStyle.Fill;
            Name_Label.Location = new Point(290, 87);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(281, 87);
            Name_Label.TabIndex = 2;
            Name_Label.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 174);
            label4.Name = "label4";
            label4.Size = new Size(281, 87);
            label4.TabIndex = 3;
            label4.Text = "Surname: ";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // Surname_Label
            // 
            Surname_Label.AutoSize = true;
            Surname_Label.Dock = DockStyle.Fill;
            Surname_Label.Location = new Point(290, 174);
            Surname_Label.Name = "Surname_Label";
            Surname_Label.Size = new Size(281, 87);
            Surname_Label.TabIndex = 4;
            Surname_Label.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 261);
            label6.Name = "label6";
            label6.Size = new Size(281, 87);
            label6.TabIndex = 5;
            label6.Text = "Institution: ";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // Institution_Label
            // 
            Institution_Label.AutoSize = true;
            Institution_Label.Dock = DockStyle.Fill;
            Institution_Label.Location = new Point(290, 261);
            Institution_Label.Name = "Institution_Label";
            Institution_Label.Size = new Size(281, 87);
            Institution_Label.TabIndex = 6;
            Institution_Label.Text = "label7";
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Dock = DockStyle.Fill;
            Password_Label.Location = new Point(3, 348);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(281, 90);
            Password_Label.TabIndex = 7;
            Password_Label.Text = "Set new password: ";
            Password_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Dock = DockStyle.Fill;
            Password_TextBox.Location = new Point(290, 351);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.Size = new Size(281, 27);
            Password_TextBox.TabIndex = 8;
            // 
            // Change_Password_Button
            // 
            Change_Password_Button.Location = new Point(577, 351);
            Change_Password_Button.Name = "Change_Password_Button";
            Change_Password_Button.Size = new Size(156, 27);
            Change_Password_Button.TabIndex = 9;
            Change_Password_Button.Text = "Change password";
            Change_Password_Button.UseVisualStyleBackColor = true;
            Change_Password_Button.Click += Change_Password_Button_Click;
            // 
            // SignOut_Button
            // 
            SignOut_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SignOut_Button.Location = new Point(766, 3);
            SignOut_Button.Name = "SignOut_Button";
            SignOut_Button.Size = new Size(93, 28);
            SignOut_Button.TabIndex = 10;
            SignOut_Button.Text = "Sign out";
            SignOut_Button.UseVisualStyleBackColor = true;
            SignOut_Button.Click += Sign_Out_Button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(150, 50);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 100);
            tabPage1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView1);
            splitContainer2.Size = new Size(150, 100);
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(44, 94);
            button1.TabIndex = 0;
            button1.Text = "Create project";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(53, 3);
            button2.Name = "button2";
            button2.Size = new Size(44, 94);
            button2.TabIndex = 1;
            button2.Text = "Edit project";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(200, 100);
            tabControl2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(150, 50);
            dataGridView2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(44, 94);
            button3.TabIndex = 0;
            button3.Text = "Create project";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(53, 3);
            button4.Name = "button4";
            button4.Size = new Size(44, 94);
            button4.TabIndex = 1;
            button4.Text = "Edit project";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(103, 3);
            button5.Name = "button5";
            button5.Size = new Size(44, 94);
            button5.TabIndex = 2;
            button5.Text = "Delete project";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(153, 3);
            button6.Name = "button6";
            button6.Size = new Size(44, 94);
            button6.TabIndex = 3;
            button6.Text = "Add project change";
            button6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(button3, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 3);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(dataGridView2);
            splitContainer3.Size = new Size(150, 100);
            splitContainer3.TabIndex = 0;
            // 
            // ScientistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 477);
            Controls.Add(tabControl1);
            Name = "ScientistForm";
            Text = "ScientistForm";
            tabControl1.ResumeLayout(false);
            Project.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Project_DataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            Change_Log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Change_Log_DataGridView).EndInit();
            Media_Reviews.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Media_dataGridView).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            Account_Tab.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Project;
        private TabPage Change_Log;
        private TabPage Media_Reviews;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button CreateProject_Button;
        private Button EditProject_Button;
        private DataGridView dataGridView1;
        private TabPage tabPage1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private TabControl tabControl2;
        private DataGridView dataGridView2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel3;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer5;
        private DataGridView Media_dataGridView;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button10;
        private Button button11;
        private Button button12;
        public DataGridView Project_DataGridView;
        public DataGridView Change_Log_DataGridView;
        private TabPage Account_Tab;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private Label Name_Label;
        private Label label4;
        private Label Surname_Label;
        private Label label6;
        private Label Institution_Label;
        private Label Password_Label;
        private TextBox Password_TextBox;
        private Button Change_Password_Button;
        private Button SignOut_Button;
        private Button DeleteProject_Button;
    }
}