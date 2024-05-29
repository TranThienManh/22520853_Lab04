namespace _22520853_Lab04
{
    partial class Bai2
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
            btn_Download = new Button();
            rtb_WebResponse = new RichTextBox();
            tb_URL = new TextBox();
            tb_AddressSaving = new TextBox();
            SuspendLayout();
            // 
            // btn_Download
            // 
            btn_Download.Location = new Point(611, 19);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(94, 29);
            btn_Download.TabIndex = 3;
            btn_Download.Text = "Download";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += btn_Download_Click;
            // 
            // rtb_WebResponse
            // 
            rtb_WebResponse.Location = new Point(95, 112);
            rtb_WebResponse.Name = "rtb_WebResponse";
            rtb_WebResponse.Size = new Size(610, 366);
            rtb_WebResponse.TabIndex = 4;
            rtb_WebResponse.Text = "";
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(95, 19);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(495, 27);
            tb_URL.TabIndex = 1;
            // 
            // tb_AddressSaving
            // 
            tb_AddressSaving.Location = new Point(95, 65);
            tb_AddressSaving.Name = "tb_AddressSaving";
            tb_AddressSaving.Size = new Size(495, 27);
            tb_AddressSaving.TabIndex = 2;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(tb_AddressSaving);
            Controls.Add(btn_Download);
            Controls.Add(rtb_WebResponse);
            Controls.Add(tb_URL);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Download;
        private RichTextBox rtb_WebResponse;
        private TextBox tb_URL;
        private TextBox tb_AddressSaving;
    }
}