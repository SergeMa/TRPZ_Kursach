namespace TRPZ_Cursach_WinForm
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Login_TextBox = new TextBox();
            Login_Label = new Label();
            Password_Label = new Label();
            Password_TextBox = new TextBox();
            Login_Button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Login_TextBox
            // 
            Login_TextBox.Location = new Point(134, 12);
            Login_TextBox.Name = "Login_TextBox";
            Login_TextBox.PlaceholderText = "MyLogin";
            Login_TextBox.Size = new Size(196, 27);
            Login_TextBox.TabIndex = 0;
            // 
            // Login_Label
            // 
            Login_Label.Location = new Point(31, 12);
            Login_Label.Name = "Login_Label";
            Login_Label.Size = new Size(74, 27);
            Login_Label.TabIndex = 1;
            Login_Label.Text = "Login";
            Login_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Password_Label
            // 
            Password_Label.Location = new Point(31, 45);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(74, 27);
            Password_Label.TabIndex = 3;
            Password_Label.Text = "Password";
            Password_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Location = new Point(134, 45);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PasswordChar = '*';
            Password_TextBox.PlaceholderText = "MyPassword123";
            Password_TextBox.Size = new Size(196, 27);
            Password_TextBox.TabIndex = 2;
            // 
            // Login_Button
            // 
            Login_Button.Location = new Point(31, 96);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(299, 29);
            Login_Button.TabIndex = 4;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(31, 140);
            button1.Name = "button1";
            button1.Size = new Size(299, 29);
            button1.TabIndex = 5;
            button1.Text = "Continue as visitor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(365, 181);
            Controls.Add(button1);
            Controls.Add(Login_Button);
            Controls.Add(Password_Label);
            Controls.Add(Password_TextBox);
            Controls.Add(Login_Label);
            Controls.Add(Login_TextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login_Form";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Login_TextBox;
        private Label Login_Label;
        private Label Password_Label;
        private TextBox Password_TextBox;
        private Button Login_Button;
        private Button button1;
    }
}