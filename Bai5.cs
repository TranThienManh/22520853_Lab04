using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _22520853_Lab04
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            string url = tb_URL.Text;
            string username = tb_Username.Text.Trim();
            string password = tb_Password.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    // Get the access token
                    var content = new FormUrlEncodedContent(new[]
                    {
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password)
                });

                    var response = await client.PostAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();
                    var responseObject = JObject.Parse(responseString);

                    if (!response.IsSuccessStatusCode)
                    {
                        var detail = responseObject["detail"].ToString();
                        rtb_Login.Text = $"Đăng nhập thất bại!\n{detail}";
                        return;
                    }

                    var tokenType = responseObject["token_type"].ToString();
                    var accessToken = responseObject["access_token"].ToString();
                    rtb_Login.Text = $"Token_type: {tokenType}\nAccess_token: {accessToken}\n\nĐăng nhập thành công!";
                }
            }
            catch (Exception ex) 
            {
                rtb_Login.Text = $"Đăng nhập thất bại!\n{ex.Message}";
            }

        }

    }
}
