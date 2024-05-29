namespace _22520853_Lab04
{
    partial class Bai6
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
            label1 = new Label();
            label2 = new Label();
            tb_Url = new TextBox();
            tb_Token = new TextBox();
            btn_Get = new Button();
            rtb_Message = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 0;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 79);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "Token";
            // 
            // tb_Url
            // 
            tb_Url.Location = new Point(113, 32);
            tb_Url.Name = "tb_Url";
            tb_Url.Size = new Size(500, 27);
            tb_Url.TabIndex = 2;
            // 
            // tb_Token
            // 
            tb_Token.Location = new Point(113, 80);
            tb_Token.Name = "tb_Token";
            tb_Token.Size = new Size(500, 27);
            tb_Token.TabIndex = 3;
            // 
            // btn_Get
            // 
            btn_Get.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Get.Location = new Point(633, 69);
            btn_Get.Name = "btn_Get";
            btn_Get.Size = new Size(115, 38);
            btn_Get.TabIndex = 4;
            btn_Get.Text = "Get";
            btn_Get.UseVisualStyleBackColor = true;
            btn_Get.Click += btn_Get_Click;
            // 
            // rtb_Message
            // 
            rtb_Message.Location = new Point(33, 133);
            rtb_Message.Name = "rtb_Message";
            rtb_Message.Size = new Size(715, 285);
            rtb_Message.TabIndex = 5;
            rtb_Message.Text = "";
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_Message);
            Controls.Add(btn_Get);
            Controls.Add(tb_Token);
            Controls.Add(tb_Url);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_Url;
        private TextBox tb_Token;
        private Button btn_Get;
        private RichTextBox rtb_Message;
    }
}