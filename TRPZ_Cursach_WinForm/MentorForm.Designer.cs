namespace TRPZ_Cursach_WinForm
{
    partial class MentorForm
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
            Project_Tab = new TabPage();
            Project_DataGridView = new DataGridView();
            Change_Log = new TabPage();
            Change_Log_DataGridView = new DataGridView();
            Media = new TabPage();
            splitContainer1 = new SplitContainer();
            Media_dataGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            AddReview_Button = new Button();
            EditReview_Button = new Button();
            DeleteReview_Button = new Button();
            Account = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            Name_Label = new Label();
            label5 = new Label();
            Surname_Label = new Label();
            label6 = new Label();
            Institution_Label = new Label();
            Password_Label = new Label();
            Password_TextBox = new TextBox();
            Change_Password_Button = new Button();
            SignOut_Button = new Button();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            Project_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Project_DataGridView).BeginInit();
            Change_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Change_Log_DataGridView).BeginInit();
            Media.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Media_dataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            Account.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Project_Tab);
            tabControl1.Controls.Add(Change_Log);
            tabControl1.Controls.Add(Media);
            tabControl1.Controls.Add(Account);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(820, 458);
            tabControl1.TabIndex = 0;
            // 
            // Project_Tab
            // 
            Project_Tab.Controls.Add(Project_DataGridView);
            Project_Tab.Location = new Point(4, 29);
            Project_Tab.Name = "Project_Tab";
            Project_Tab.Padding = new Padding(3);
            Project_Tab.Size = new Size(812, 425);
            Project_Tab.TabIndex = 0;
            Project_Tab.Text = "Project";
            Project_Tab.UseVisualStyleBackColor = true;
            // 
            // Project_DataGridView
            // 
            Project_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Project_DataGridView.Dock = DockStyle.Fill;
            Project_DataGridView.Location = new Point(3, 3);
            Project_DataGridView.MultiSelect = false;
            Project_DataGridView.Name = "Project_DataGridView";
            Project_DataGridView.ReadOnly = true;
            Project_DataGridView.RowHeadersWidth = 51;
            Project_DataGridView.RowTemplate.Height = 29;
            Project_DataGridView.Size = new Size(806, 419);
            Project_DataGridView.TabIndex = 2;
            // 
            // Change_Log
            // 
            Change_Log.Controls.Add(Change_Log_DataGridView);
            Change_Log.Location = new Point(4, 29);
            Change_Log.Name = "Change_Log";
            Change_Log.Padding = new Padding(3);
            Change_Log.Size = new Size(812, 425);
            Change_Log.TabIndex = 1;
            Change_Log.Text = "Change log";
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
            Change_Log_DataGridView.Size = new Size(806, 419);
            Change_Log_DataGridView.TabIndex = 2;
            // 
            // Media
            // 
            Media.Controls.Add(splitContainer1);
            Media.Location = new Point(4, 29);
            Media.Name = "Media";
            Media.Padding = new Padding(3);
            Media.Size = new Size(812, 425);
            Media.TabIndex = 2;
            Media.Text = "Media Reviews";
            Media.UseVisualStyleBackColor = true;
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
            splitContainer1.Panel1.Controls.Add(Media_dataGridView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(806, 419);
            splitContainer1.SplitterDistance = 317;
            splitContainer1.TabIndex = 0;
            // 
            // Media_dataGridView
            // 
            Media_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Media_dataGridView.Dock = DockStyle.Fill;
            Media_dataGridView.Location = new Point(0, 0);
            Media_dataGridView.Name = "Media_dataGridView";
            Media_dataGridView.RowHeadersWidth = 51;
            Media_dataGridView.RowTemplate.Height = 29;
            Media_dataGridView.Size = new Size(806, 317);
            Media_dataGridView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(AddReview_Button, 0, 0);
            tableLayoutPanel1.Controls.Add(EditReview_Button, 1, 0);
            tableLayoutPanel1.Controls.Add(DeleteReview_Button, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(806, 98);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // AddReview_Button
            // 
            AddReview_Button.Dock = DockStyle.Fill;
            AddReview_Button.Location = new Point(3, 3);
            AddReview_Button.Name = "AddReview_Button";
            AddReview_Button.Size = new Size(262, 92);
            AddReview_Button.TabIndex = 0;
            AddReview_Button.Text = "Add review";
            AddReview_Button.UseVisualStyleBackColor = true;
            AddReview_Button.Click += AddReview_Button_Click;
            // 
            // EditReview_Button
            // 
            EditReview_Button.Dock = DockStyle.Fill;
            EditReview_Button.Location = new Point(271, 3);
            EditReview_Button.Name = "EditReview_Button";
            EditReview_Button.Size = new Size(262, 92);
            EditReview_Button.TabIndex = 1;
            EditReview_Button.Text = "Edit review";
            EditReview_Button.UseVisualStyleBackColor = true;
            EditReview_Button.Click += EditReview_Button_Click;
            // 
            // DeleteReview_Button
            // 
            DeleteReview_Button.Dock = DockStyle.Fill;
            DeleteReview_Button.Location = new Point(539, 3);
            DeleteReview_Button.Name = "DeleteReview_Button";
            DeleteReview_Button.Size = new Size(264, 92);
            DeleteReview_Button.TabIndex = 2;
            DeleteReview_Button.Text = "Delete review";
            DeleteReview_Button.UseVisualStyleBackColor = true;
            DeleteReview_Button.Click += DeleteReview_Button_Click;
            // 
            // Account
            // 
            Account.Controls.Add(tableLayoutPanel2);
            Account.Location = new Point(4, 29);
            Account.Name = "Account";
            Account.Padding = new Padding(3);
            Account.Size = new Size(812, 425);
            Account.TabIndex = 3;
            Account.Text = "Manage account";
            Account.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(Name_Label, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(Surname_Label, 1, 2);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(Institution_Label, 1, 3);
            tableLayoutPanel2.Controls.Add(Password_Label, 0, 4);
            tableLayoutPanel2.Controls.Add(Password_TextBox, 1, 4);
            tableLayoutPanel2.Controls.Add(Change_Password_Button, 2, 4);
            tableLayoutPanel2.Controls.Add(SignOut_Button, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(806, 419);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(271, 0);
            label3.Name = "label3";
            label3.Size = new Size(262, 83);
            label3.TabIndex = 0;
            label3.Text = "Account info";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 83);
            label4.Name = "label4";
            label4.Size = new Size(262, 83);
            label4.TabIndex = 1;
            label4.Text = "Name: ";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // Name_Label
            // 
            Name_Label.AutoSize = true;
            Name_Label.Dock = DockStyle.Fill;
            Name_Label.Location = new Point(271, 83);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(262, 83);
            Name_Label.TabIndex = 2;
            Name_Label.Text = "label3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 166);
            label5.Name = "label5";
            label5.Size = new Size(262, 83);
            label5.TabIndex = 3;
            label5.Text = "Surname: ";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // Surname_Label
            // 
            Surname_Label.AutoSize = true;
            Surname_Label.Dock = DockStyle.Fill;
            Surname_Label.Location = new Point(271, 166);
            Surname_Label.Name = "Surname_Label";
            Surname_Label.Size = new Size(262, 83);
            Surname_Label.TabIndex = 4;
            Surname_Label.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 249);
            label6.Name = "label6";
            label6.Size = new Size(262, 83);
            label6.TabIndex = 5;
            label6.Text = "Institution: ";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // Institution_Label
            // 
            Institution_Label.AutoSize = true;
            Institution_Label.Dock = DockStyle.Fill;
            Institution_Label.Location = new Point(271, 249);
            Institution_Label.Name = "Institution_Label";
            Institution_Label.Size = new Size(262, 83);
            Institution_Label.TabIndex = 6;
            Institution_Label.Text = "label7";
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Dock = DockStyle.Fill;
            Password_Label.Location = new Point(3, 332);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(262, 87);
            Password_Label.TabIndex = 7;
            Password_Label.Text = "Set new password: ";
            Password_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Dock = DockStyle.Fill;
            Password_TextBox.Location = new Point(271, 335);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.Size = new Size(262, 27);
            Password_TextBox.TabIndex = 8;
            // 
            // Change_Password_Button
            // 
            Change_Password_Button.Location = new Point(539, 335);
            Change_Password_Button.Name = "Change_Password_Button";
            Change_Password_Button.Size = new Size(156, 27);
            Change_Password_Button.TabIndex = 9;
            Change_Password_Button.Text = "Change password";
            Change_Password_Button.UseVisualStyleBackColor = true;
            Change_Password_Button.Click += Change_Password_Button_Click_1;
            // 
            // SignOut_Button
            // 
            SignOut_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SignOut_Button.Location = new Point(710, 3);
            SignOut_Button.Name = "SignOut_Button";
            SignOut_Button.Size = new Size(93, 28);
            SignOut_Button.TabIndex = 10;
            SignOut_Button.Text = "Sign out";
            SignOut_Button.UseVisualStyleBackColor = true;
            SignOut_Button.Click += Sign_Out_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(69, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 100);
            label1.TabIndex = 0;
            label1.Text = "Account info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(60, 60);
            label2.TabIndex = 1;
            label2.Text = "Name: ";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(label1, 1, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // MentorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 458);
            Controls.Add(tabControl1);
            Name = "MentorForm";
            Text = "MentorForm";
            tabControl1.ResumeLayout(false);
            Project_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Project_DataGridView).EndInit();
            Change_Log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Change_Log_DataGridView).EndInit();
            Media.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Media_dataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            Account.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Project_Tab;
        private TabPage Change_Log;
        private TabPage Media;
        private TabPage Account;
        public DataGridView Change_Log_DataGridView;
        public DataGridView Project_DataGridView;
        private SplitContainer splitContainer1;
        private DataGridView Media_dataGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddReview_Button;
        private Button EditReview_Button;
        private Button DeleteReview_Button;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private Label Name_Label;
        private Label label5;
        private Label Surname_Label;
        private Label label6;
        private Label Institution_Label;
        private Label Password_Label;
        private TextBox Password_TextBox;
        private Button Change_Password_Button;
        private Button SignOut_Button;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
    }
}