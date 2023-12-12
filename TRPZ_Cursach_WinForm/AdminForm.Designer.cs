namespace TRPZ_Cursach_WinForm
{
    partial class AdminForm
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
            Action_Tab = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            institution_Name_Label = new Label();
            Sign_Out_Button = new Button();
            label3 = new Label();
            Password_TextBox = new TextBox();
            Change_Password_Button = new Button();
            Scientist_Tab = new TabPage();
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            Scientist_dataGridView = new DataGridView();
            Add_Scientist = new Button();
            splitContainer2 = new SplitContainer();
            Mentor_dataGridView = new DataGridView();
            Add_Mentor = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Activity_dataGridView = new DataGridView();
            Action_Tab.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            Scientist_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Scientist_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Mentor_dataGridView).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Activity_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Action_Tab
            // 
            Action_Tab.Controls.Add(tableLayoutPanel1);
            Action_Tab.Location = new Point(4, 29);
            Action_Tab.Name = "Action_Tab";
            Action_Tab.Size = new Size(792, 417);
            Action_Tab.TabIndex = 2;
            Action_Tab.Text = "Actions";
            Action_Tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(institution_Name_Label, 1, 1);
            tableLayoutPanel1.Controls.Add(Sign_Out_Button, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(Password_TextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(Change_Password_Button, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(792, 417);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(266, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 104);
            label1.TabIndex = 0;
            label1.Text = "Manage institution account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 104);
            label2.Name = "label2";
            label2.Size = new Size(257, 104);
            label2.TabIndex = 1;
            label2.Text = "Institution name: ";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // institution_Name_Label
            // 
            institution_Name_Label.AutoSize = true;
            institution_Name_Label.Dock = DockStyle.Fill;
            institution_Name_Label.Location = new Point(266, 104);
            institution_Name_Label.Name = "institution_Name_Label";
            institution_Name_Label.Size = new Size(258, 104);
            institution_Name_Label.TabIndex = 2;
            institution_Name_Label.Text = "label3";
            // 
            // Sign_Out_Button
            // 
            Sign_Out_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Sign_Out_Button.Location = new Point(703, 3);
            Sign_Out_Button.Name = "Sign_Out_Button";
            Sign_Out_Button.Size = new Size(86, 28);
            Sign_Out_Button.TabIndex = 4;
            Sign_Out_Button.Text = "Sign out";
            Sign_Out_Button.UseVisualStyleBackColor = true;
            Sign_Out_Button.Click += Sign_Out_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 208);
            label3.Name = "label3";
            label3.Size = new Size(257, 104);
            label3.TabIndex = 5;
            label3.Text = "Change password: ";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Dock = DockStyle.Top;
            Password_TextBox.Location = new Point(266, 211);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.Size = new Size(258, 27);
            Password_TextBox.TabIndex = 6;
            // 
            // Change_Password_Button
            // 
            Change_Password_Button.Dock = DockStyle.Top;
            Change_Password_Button.Location = new Point(530, 211);
            Change_Password_Button.Name = "Change_Password_Button";
            Change_Password_Button.Size = new Size(259, 29);
            Change_Password_Button.TabIndex = 7;
            Change_Password_Button.Text = "Change password";
            Change_Password_Button.UseVisualStyleBackColor = true;
            Change_Password_Button.Click += Change_Password_Button_Click;
            // 
            // Scientist_Tab
            // 
            Scientist_Tab.Controls.Add(splitContainer1);
            Scientist_Tab.Location = new Point(4, 29);
            Scientist_Tab.Name = "Scientist_Tab";
            Scientist_Tab.Padding = new Padding(3);
            Scientist_Tab.Size = new Size(792, 417);
            Scientist_Tab.TabIndex = 0;
            Scientist_Tab.Text = "People";
            Scientist_Tab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(786, 411);
            splitContainer1.SplitterDistance = 365;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(Scientist_dataGridView);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(Add_Scientist);
            splitContainer3.Size = new Size(365, 411);
            splitContainer3.SplitterDistance = 333;
            splitContainer3.TabIndex = 1;
            // 
            // Scientist_dataGridView
            // 
            Scientist_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Scientist_dataGridView.Dock = DockStyle.Fill;
            Scientist_dataGridView.Location = new Point(0, 0);
            Scientist_dataGridView.Name = "Scientist_dataGridView";
            Scientist_dataGridView.RowHeadersWidth = 51;
            Scientist_dataGridView.RowTemplate.Height = 29;
            Scientist_dataGridView.Size = new Size(365, 333);
            Scientist_dataGridView.TabIndex = 0;
            // 
            // Add_Scientist
            // 
            Add_Scientist.Dock = DockStyle.Fill;
            Add_Scientist.Location = new Point(0, 0);
            Add_Scientist.Name = "Add_Scientist";
            Add_Scientist.Size = new Size(365, 74);
            Add_Scientist.TabIndex = 0;
            Add_Scientist.Text = "Add scientist";
            Add_Scientist.UseVisualStyleBackColor = true;
            Add_Scientist.Click += Add_Scientist_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(Mentor_dataGridView);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(Add_Mentor);
            splitContainer2.Size = new Size(417, 411);
            splitContainer2.SplitterDistance = 334;
            splitContainer2.TabIndex = 1;
            // 
            // Mentor_dataGridView
            // 
            Mentor_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Mentor_dataGridView.Dock = DockStyle.Fill;
            Mentor_dataGridView.Location = new Point(0, 0);
            Mentor_dataGridView.Name = "Mentor_dataGridView";
            Mentor_dataGridView.RowHeadersWidth = 51;
            Mentor_dataGridView.RowTemplate.Height = 29;
            Mentor_dataGridView.Size = new Size(417, 334);
            Mentor_dataGridView.TabIndex = 0;
            // 
            // Add_Mentor
            // 
            Add_Mentor.Dock = DockStyle.Fill;
            Add_Mentor.Location = new Point(0, 0);
            Add_Mentor.Name = "Add_Mentor";
            Add_Mentor.Size = new Size(417, 73);
            Add_Mentor.TabIndex = 0;
            Add_Mentor.Text = "Add mentor";
            Add_Mentor.UseVisualStyleBackColor = true;
            Add_Mentor.Click += Add_Mentor_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Scientist_Tab);
            tabControl1.Controls.Add(Action_Tab);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Activity_dataGridView);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Activity";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Activity_dataGridView
            // 
            Activity_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Activity_dataGridView.Dock = DockStyle.Fill;
            Activity_dataGridView.Location = new Point(0, 0);
            Activity_dataGridView.Name = "Activity_dataGridView";
            Activity_dataGridView.RowHeadersWidth = 51;
            Activity_dataGridView.RowTemplate.Height = 29;
            Activity_dataGridView.Size = new Size(792, 417);
            Activity_dataGridView.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "Admin form";
            Action_Tab.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            Scientist_Tab.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Scientist_dataGridView).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Mentor_dataGridView).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Activity_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage Action_Tab;
        private TabPage Scientist_Tab;
        private TabControl tabControl1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label institution_Name_Label;
        private Button Sign_Out_Button;
        private Label label3;
        private TextBox Password_TextBox;
        private Button Change_Password_Button;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer3;
        private DataGridView Scientist_dataGridView;
        private Button Add_Scientist;
        private SplitContainer splitContainer2;
        private DataGridView Mentor_dataGridView;
        private Button Add_Mentor;
        private TabPage tabPage1;
        private DataGridView Activity_dataGridView;
    }
}