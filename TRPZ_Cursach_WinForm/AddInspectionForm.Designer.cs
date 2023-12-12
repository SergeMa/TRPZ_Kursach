namespace TRPZ_Cursach_WinForm
{
    partial class AddInspectionForm
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
            inspection_Id = new Label();
            label2 = new Label();
            label3 = new Label();
            Inspection_label = new Label();
            Change_Log_Label = new Label();
            Inspection_TextBox = new TextBox();
            AddInspection_Button = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(inspection_Id, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(Inspection_label, 0, 1);
            tableLayoutPanel1.Controls.Add(Change_Log_Label, 1, 1);
            tableLayoutPanel1.Controls.Add(Inspection_TextBox, 2, 1);
            tableLayoutPanel1.Controls.Add(AddInspection_Button, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(753, 67);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // inspection_Id
            // 
            inspection_Id.AutoSize = true;
            inspection_Id.Dock = DockStyle.Fill;
            inspection_Id.Location = new Point(3, 0);
            inspection_Id.Name = "inspection_Id";
            inspection_Id.Size = new Size(182, 33);
            inspection_Id.TabIndex = 0;
            inspection_Id.Text = "Inspection ID";
            inspection_Id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(191, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 33);
            label2.TabIndex = 1;
            label2.Text = "Change log ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(379, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 33);
            label3.TabIndex = 2;
            label3.Text = "Inspection text";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inspection_label
            // 
            Inspection_label.AutoSize = true;
            Inspection_label.Dock = DockStyle.Fill;
            Inspection_label.Location = new Point(3, 33);
            Inspection_label.Name = "Inspection_label";
            Inspection_label.Size = new Size(182, 34);
            Inspection_label.TabIndex = 3;
            Inspection_label.Text = "label4";
            Inspection_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Change_Log_Label
            // 
            Change_Log_Label.AutoSize = true;
            Change_Log_Label.Dock = DockStyle.Fill;
            Change_Log_Label.Location = new Point(191, 33);
            Change_Log_Label.Name = "Change_Log_Label";
            Change_Log_Label.Size = new Size(182, 34);
            Change_Log_Label.TabIndex = 4;
            Change_Log_Label.Text = "label5";
            Change_Log_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inspection_TextBox
            // 
            Inspection_TextBox.Dock = DockStyle.Fill;
            Inspection_TextBox.Location = new Point(379, 36);
            Inspection_TextBox.Name = "Inspection_TextBox";
            Inspection_TextBox.Size = new Size(182, 27);
            Inspection_TextBox.TabIndex = 5;
            // 
            // AddInspection_Button
            // 
            AddInspection_Button.Dock = DockStyle.Fill;
            AddInspection_Button.Location = new Point(567, 36);
            AddInspection_Button.Name = "AddInspection_Button";
            AddInspection_Button.Size = new Size(183, 28);
            AddInspection_Button.TabIndex = 6;
            AddInspection_Button.Text = "Add inspection";
            AddInspection_Button.UseVisualStyleBackColor = true;
            AddInspection_Button.Click += AddInspection_Button_Click;
            // 
            // AddInspectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 67);
            Controls.Add(tableLayoutPanel1);
            Name = "AddInspectionForm";
            Text = "Add inspection";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label inspection_Id;
        private Label label2;
        private Label label3;
        private Label Inspection_label;
        private Label Change_Log_Label;
        private TextBox Inspection_TextBox;
        private Button AddInspection_Button;
    }
}