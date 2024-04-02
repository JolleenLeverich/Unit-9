namespace LoginForm
{
    partial class Form2
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
            UserTextBx = new TextBox();
            PasswordTxtBx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // UserTextBx
            // 
            UserTextBx.Location = new Point(114, 102);
            UserTextBx.Name = "UserTextBx";
            UserTextBx.Size = new Size(144, 23);
            UserTextBx.TabIndex = 0;
            UserTextBx.TextChanged += textBox1_TextChanged;
            // 
            // PasswordTxtBx
            // 
            PasswordTxtBx.Location = new Point(114, 141);
            PasswordTxtBx.Name = "PasswordTxtBx";
            PasswordTxtBx.Size = new Size(144, 23);
            PasswordTxtBx.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 110);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 149);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(135, 231);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTxtBx);
            Controls.Add(UserTextBx);
            Name = "Form2";
            Text = "Form1";
           // Load += this.Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserTextBx;
        private TextBox PasswordTxtBx;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
