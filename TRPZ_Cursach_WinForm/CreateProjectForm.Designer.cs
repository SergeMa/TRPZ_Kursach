namespace TRPZ_Cursach_WinForm
{
    partial class CreateProjectsForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ID_Label = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Label1 = new Label();
            Institution = new Label();
            Scientist = new Label();
            Mentor_comboBox = new ComboBox();
            Stage_comboBox = new ComboBox();
            Sphere_comboBox = new ComboBox();
            CreateProject_Button = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Controls.Add(ID_Label, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 7, 0);
            tableLayoutPanel1.Controls.Add(label7, 6, 0);
            tableLayoutPanel1.Controls.Add(label6, 5, 0);
            tableLayoutPanel1.Controls.Add(label5, 4, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(Label1, 0, 0);
            tableLayoutPanel1.Controls.Add(Institution, 7, 1);
            tableLayoutPanel1.Controls.Add(Scientist, 5, 1);
            tableLayoutPanel1.Controls.Add(Mentor_comboBox, 6, 1);
            tableLayoutPanel1.Controls.Add(Stage_comboBox, 4, 1);
            tableLayoutPanel1.Controls.Add(Sphere_comboBox, 3, 1);
            tableLayoutPanel1.Controls.Add(CreateProject_Button, 8, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1287, 119);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ID_Label
            // 
            ID_Label.AutoSize = true;
            ID_Label.Dock = DockStyle.Fill;
            ID_Label.Location = new Point(3, 59);
            ID_Label.Name = "ID_Label";
            ID_Label.Size = new Size(136, 60);
            ID_Label.TabIndex = 9;
            ID_Label.Text = "label10";
            ID_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(997, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 59);
            label8.TabIndex = 7;
            label8.Text = "Institution";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(855, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 59);
            label7.TabIndex = 6;
            label7.Text = "Mentor";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(713, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 59);
            label6.TabIndex = 5;
            label6.Text = "Scientist";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(571, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 59);
            label5.TabIndex = 4;
            label5.Text = "Development Stage";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(429, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 59);
            label4.TabIndex = 3;
            label4.Text = "Sphere";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(287, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 59);
            label3.TabIndex = 2;
            label3.Text = "Project description";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(145, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 59);
            label2.TabIndex = 1;
            label2.Text = "Project title";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Dock = DockStyle.Fill;
            Label1.Location = new Point(3, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(136, 59);
            Label1.TabIndex = 0;
            Label1.Text = "Project ID";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Institution
            // 
            Institution.AutoSize = true;
            Institution.Dock = DockStyle.Fill;
            Institution.Location = new Point(997, 59);
            Institution.Name = "Institution";
            Institution.Size = new Size(136, 60);
            Institution.TabIndex = 10;
            Institution.Text = "label9";
            // 
            // Scientist
            // 
            Scientist.AutoSize = true;
            Scientist.Dock = DockStyle.Fill;
            Scientist.Location = new Point(713, 59);
            Scientist.Name = "Scientist";
            Scientist.Size = new Size(136, 60);
            Scientist.TabIndex = 12;
            Scientist.Text = "label12";
            // 
            // Mentor_comboBox
            // 
            Mentor_comboBox.Dock = DockStyle.Fill;
            Mentor_comboBox.FormattingEnabled = true;
            Mentor_comboBox.Location = new Point(855, 62);
            Mentor_comboBox.Name = "Mentor_comboBox";
            Mentor_comboBox.Size = new Size(136, 28);
            Mentor_comboBox.TabIndex = 13;
            // 
            // Stage_comboBox
            // 
            Stage_comboBox.Dock = DockStyle.Fill;
            Stage_comboBox.FormattingEnabled = true;
            Stage_comboBox.Location = new Point(571, 62);
            Stage_comboBox.Name = "Stage_comboBox";
            Stage_comboBox.Size = new Size(136, 28);
            Stage_comboBox.TabIndex = 14;
            // 
            // Sphere_comboBox
            // 
            Sphere_comboBox.Dock = DockStyle.Fill;
            Sphere_comboBox.FormattingEnabled = true;
            Sphere_comboBox.Location = new Point(429, 62);
            Sphere_comboBox.Name = "Sphere_comboBox";
            Sphere_comboBox.Size = new Size(136, 28);
            Sphere_comboBox.TabIndex = 15;
            // 
            // CreateProject_Button
            // 
            CreateProject_Button.Dock = DockStyle.Fill;
            CreateProject_Button.Location = new Point(1139, 62);
            CreateProject_Button.Name = "CreateProject_Button";
            CreateProject_Button.Size = new Size(145, 54);
            CreateProject_Button.TabIndex = 16;
            CreateProject_Button.Text = "Create project";
            CreateProject_Button.UseVisualStyleBackColor = true;
            CreateProject_Button.Click += CreateProject_Button_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(145, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 27);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(287, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 27);
            textBox2.TabIndex = 18;
            // 
            // CreateProjectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 119);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateProjectsForm";
            Text = "Create project";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label ID_Label;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Label1;
        private Label Institution;
        private Label Scientist;
        private ComboBox Mentor_comboBox;
        private ComboBox Stage_comboBox;
        private ComboBox Sphere_comboBox;
        private Button CreateProject_Button;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}