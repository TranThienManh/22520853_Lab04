namespace _22520853_Lab04
{
    partial class Bai5
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
            URL = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_URL = new TextBox();
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            rtb_Login = new RichTextBox();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // URL
            // 
            URL.AutoSize = true;
            URL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            URL.Location = new Point(107, 28);
            URL.Name = "URL";
            URL.Size = new Size(49, 28);
            URL.TabIndex = 0;
            URL.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 76);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 125);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(250, 32);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(413, 27);
            tb_URL.TabIndex = 3;
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(250, 73);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(270, 27);
            tb_Username.TabIndex = 4;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(250, 122);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(270, 27);
            tb_Password.TabIndex = 5;
            // 
            // rtb_Login
            // 
            rtb_Login.Location = new Point(107, 169);
            rtb_Login.Name = "rtb_Login";
            rtb_Login.Size = new Size(556, 249);
            rtb_Login.TabIndex = 6;
            rtb_Login.Text = "";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(538, 73);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(125, 76);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Login);
            Controls.Add(rtb_Login);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(tb_URL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(URL);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label URL;
        private Label label2;
        private Label label3;
        private TextBox tb_URL;
        private TextBox tb_Username;
        private TextBox tb_Password;
        private RichTextBox rtb_Login;
        private Button btn_Login;
    }
}