namespace _22520853_Lab04
{
    partial class Menu
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
            btn_Bai01 = new Button();
            btn_Bai02 = new Button();
            btn_Bai5 = new Button();
            btn_Bai6 = new Button();
            btn_Bai3 = new Button();
            SuspendLayout();
            // 
            // btn_Bai01
            // 
            btn_Bai01.Location = new Point(72, 40);
            btn_Bai01.Name = "btn_Bai01";
            btn_Bai01.Size = new Size(106, 42);
            btn_Bai01.TabIndex = 0;
            btn_Bai01.Text = "Bài 1";
            btn_Bai01.UseVisualStyleBackColor = true;
            btn_Bai01.Click += btn_Bai01_Click;
            // 
            // btn_Bai02
            // 
            btn_Bai02.Location = new Point(72, 117);
            btn_Bai02.Name = "btn_Bai02";
            btn_Bai02.Size = new Size(106, 42);
            btn_Bai02.TabIndex = 1;
            btn_Bai02.Text = "Bài 2";
            btn_Bai02.UseVisualStyleBackColor = true;
            btn_Bai02.Click += btn_Bai02_Click;
            // 
            // btn_Bai5
            // 
            btn_Bai5.Location = new Point(253, 117);
            btn_Bai5.Name = "btn_Bai5";
            btn_Bai5.Size = new Size(106, 42);
            btn_Bai5.TabIndex = 2;
            btn_Bai5.Text = "Bài 5";
            btn_Bai5.UseVisualStyleBackColor = true;
            btn_Bai5.Click += btn_Bai5_Click;
            // 
            // btn_Bai6
            // 
            btn_Bai6.Location = new Point(253, 190);
            btn_Bai6.Name = "btn_Bai6";
            btn_Bai6.Size = new Size(106, 42);
            btn_Bai6.TabIndex = 3;
            btn_Bai6.Text = "Bài 6";
            btn_Bai6.UseVisualStyleBackColor = true;
            btn_Bai6.Click += btn_Bai6_Click;
            // 
            // btn_Bai3
            // 
            btn_Bai3.Location = new Point(72, 190);
            btn_Bai3.Name = "btn_Bai3";
            btn_Bai3.Size = new Size(106, 42);
            btn_Bai3.TabIndex = 4;
            btn_Bai3.Text = "Bài 3";
            btn_Bai3.UseVisualStyleBackColor = true;
            btn_Bai3.Click += btn_Bai3_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Bai3);
            Controls.Add(btn_Bai6);
            Controls.Add(btn_Bai5);
            Controls.Add(btn_Bai02);
            Controls.Add(btn_Bai01);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Bai01;
        private Button btn_Bai2;
        private Button btn_Bai02;
        private Button btn_Bai5;
        private Button btn_Bai6;
        private Button btn_Bai3;
    }
}
