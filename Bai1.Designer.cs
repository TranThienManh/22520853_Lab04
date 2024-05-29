namespace _22520853_Lab04
{
    partial class Bai1
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
            tb_URL = new TextBox();
            rtb_WebResponse = new RichTextBox();
            btn_Get = new Button();
            SuspendLayout();
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(47, 40);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(495, 27);
            tb_URL.TabIndex = 0;
            // 
            // rtb_WebResponse
            // 
            rtb_WebResponse.Location = new Point(47, 86);
            rtb_WebResponse.Name = "rtb_WebResponse";
            rtb_WebResponse.Size = new Size(610, 366);
            rtb_WebResponse.TabIndex = 2;
            rtb_WebResponse.Text = "";
            // 
            // btn_Get
            // 
            btn_Get.Location = new Point(563, 40);
            btn_Get.Name = "btn_Get";
            btn_Get.Size = new Size(94, 29);
            btn_Get.TabIndex = 2;
            btn_Get.Text = "Get";
            btn_Get.UseVisualStyleBackColor = true;
            btn_Get.Click += btn_Get_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 502);
            Controls.Add(btn_Get);
            Controls.Add(rtb_WebResponse);
            Controls.Add(tb_URL);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_URL;
        private RichTextBox rtb_WebResponse;
        private Button btn_Get;
    }
}