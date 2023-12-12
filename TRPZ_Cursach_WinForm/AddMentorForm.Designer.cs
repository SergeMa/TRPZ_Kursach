﻿namespace TRPZ_Cursach_WinForm
{
    partial class AddMentorForm
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
            Add_Mentor_Button = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Mentor_ID_Label = new Label();
            Name_label = new Label();
            Surname_label = new Label();
            label4 = new Label();
            Scientist_Label = new Label();
            Institution_Id_Label = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Add_Mentor_Button
            // 
            Add_Mentor_Button.Dock = DockStyle.Fill;
            Add_Mentor_Button.Location = new Point(807, 52);
            Add_Mentor_Button.Name = "Add_Mentor_Button";
            Add_Mentor_Button.Size = new Size(197, 43);
            Add_Mentor_Button.TabIndex = 9;
            Add_Mentor_Button.Text = "Add Mentor";
            Add_Mentor_Button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(Mentor_ID_Label, 0, 0);
            tableLayoutPanel1.Controls.Add(Name_label, 1, 0);
            tableLayoutPanel1.Controls.Add(Surname_label, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(Scientist_Label, 0, 1);
            tableLayoutPanel1.Controls.Add(Institution_Id_Label, 3, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(Add_Mentor_Button, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1007, 98);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Mentor_ID_Label
            // 
            Mentor_ID_Label.AutoSize = true;
            Mentor_ID_Label.Dock = DockStyle.Fill;
            Mentor_ID_Label.Location = new Point(3, 0);
            Mentor_ID_Label.Name = "Mentor_ID_Label";
            Mentor_ID_Label.Size = new Size(195, 49);
            Mentor_ID_Label.TabIndex = 0;
            Mentor_ID_Label.Text = "ID";
            Mentor_ID_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Dock = DockStyle.Fill;
            Name_label.Location = new Point(204, 0);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(195, 49);
            Name_label.TabIndex = 1;
            Name_label.Text = "Name";
            Name_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Surname_label
            // 
            Surname_label.AutoSize = true;
            Surname_label.Dock = DockStyle.Fill;
            Surname_label.Location = new Point(405, 0);
            Surname_label.Name = "Surname_label";
            Surname_label.Size = new Size(195, 49);
            Surname_label.TabIndex = 2;
            Surname_label.Text = "Surname";
            Surname_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(606, 0);
            label4.Name = "label4";
            label4.Size = new Size(195, 49);
            label4.TabIndex = 3;
            label4.Text = "Institution ID";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Scientist_Label
            // 
            Scientist_Label.AutoSize = true;
            Scientist_Label.Dock = DockStyle.Fill;
            Scientist_Label.Location = new Point(3, 49);
            Scientist_Label.Name = "Scientist_Label";
            Scientist_Label.Size = new Size(195, 49);
            Scientist_Label.TabIndex = 5;
            Scientist_Label.Text = "label6";
            Scientist_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Institution_Id_Label
            // 
            Institution_Id_Label.AutoSize = true;
            Institution_Id_Label.Dock = DockStyle.Fill;
            Institution_Id_Label.Location = new Point(606, 49);
            Institution_Id_Label.Name = "Institution_Id_Label";
            Institution_Id_Label.Size = new Size(195, 49);
            Institution_Id_Label.TabIndex = 6;
            Institution_Id_Label.Text = "label7";
            Institution_Id_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(405, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(204, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 27);
            textBox2.TabIndex = 8;
            // 
            // AddMentorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 98);
            Controls.Add(tableLayoutPanel1);
            Name = "AddMentorForm";
            Text = "AddMentorForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Add_Mentor_Button;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Mentor_ID_Label;
        private Label Name_label;
        private Label Surname_label;
        private Label label4;
        private Label Scientist_Label;
        private Label Institution_Id_Label;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}