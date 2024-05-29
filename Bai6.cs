using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab04
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private async void btn_Get_Click(object sender, EventArgs e)
        {
            string url = tb_Url.Text;
            string token = tb_Token.Text;

            if(url == "")
            {
                MessageBox.Show("Please enter URL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(token == "")
            {
                MessageBox.Show("Please enter token!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                    // Using the provided URL directly, assuming it's correct and points to the user info API
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        rtb_Message.Text = content;  // Assuming rtb_Message is a RichTextBox or similar control to display response
                    }
                    else
                    {
                        rtb_Message.Text = $"Không thể nhận dữ liệu. !";
                    }
                }    
            }

            catch (Exception ex)
            {
                rtb_Message.Text = $"Token not is no longer active!\n{ex.Message}";
            }
        }
    }
}
