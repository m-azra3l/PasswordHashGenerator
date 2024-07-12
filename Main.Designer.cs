namespace PasswordHashGenerator
{
    partial class Main
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
            updateBtn = new Button();
            passwordKey = new TextBox();
            password = new TextBox();
            passwordHash = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.SeaGreen;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(46, 276);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(464, 52);
            updateBtn.TabIndex = 35;
            updateBtn.Text = "Generate";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // passwordKey
            // 
            passwordKey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordKey.Location = new Point(46, 209);
            passwordKey.Name = "passwordKey";
            passwordKey.PlaceholderText = "Password Key";
            passwordKey.ReadOnly = true;
            passwordKey.Size = new Size(464, 39);
            passwordKey.TabIndex = 34;
            passwordKey.TextAlign = HorizontalAlignment.Center;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(46, 51);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(464, 39);
            password.TabIndex = 33;
            password.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordHash
            // 
            passwordHash.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordHash.Location = new Point(46, 130);
            passwordHash.Name = "passwordHash";
            passwordHash.PlaceholderText = "Password Hash";
            passwordHash.ReadOnly = true;
            passwordHash.Size = new Size(464, 39);
            passwordHash.TabIndex = 36;
            passwordHash.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 102);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 37;
            label1.Text = "Password Hash";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 181);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 38;
            label2.Text = "Password Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 23);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 39;
            label3.Text = "Enter Password";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(46, 359);
            button1.Name = "button1";
            button1.Size = new Size(464, 52);
            button1.TabIndex = 40;
            button1.Text = "Test Hash";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.ForeColor = Color.White;
            button2.Location = new Point(46, 359);
            button2.Name = "button2";
            button2.Size = new Size(230, 52);
            button2.TabIndex = 41;
            button2.Text = "Test";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button3.Location = new Point(280, 359);
            button3.Name = "button3";
            button3.Size = new Size(230, 52);
            button3.TabIndex = 42;
            button3.Text = "End Test";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 451);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordHash);
            Controls.Add(updateBtn);
            Controls.Add(passwordKey);
            Controls.Add(password);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Hash Generetor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateBtn;
        public TextBox passwordKey;
        public TextBox password;
        public TextBox passwordHash;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}