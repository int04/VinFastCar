using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinFastCar
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            lblStatus.Text = "Đang đăng nhập...";

            try
            {
                using var client = new HttpClient();

                var url = "https://vin3s.au.auth0.com/oauth/token";

                var payload = new
                {
                    client_id = "jE5xt50qC7oIh1f32qMzA6hGznIU5mgH",
                    username = username,
                    password = password,
                    scope = "offline_access openid profile email read:current_user_metadata",
                    audience = "https://mobile.connected-car.vinfast.vn",
                    grant_type = "password"
                };

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(url),
                    Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json")
                };

                request.Headers.Host = "vin3s.au.auth0.com";
                request.Headers.Connection.Add("keep-alive");
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
                request.Headers.TryAddWithoutValidation("auth0-client", "eyJuYW1lIjoiQXV0aDAuc3dpZnQiLCJ2ZXJzaW9uIjoiMi4zLjIiLCJlbnYiOnsiaU9TIjoiMTguNCIsInN3aWZ0IjoiNS54In19");
                request.Headers.TryAddWithoutValidation("user-agent", "F00C4D95-3A3E-48E0-AD02-B52319C3C53A");
                request.Headers.TryAddWithoutValidation("accept-language", "vi-VN,vi;q=0.9");
                request.Headers.TryAddWithoutValidation("Cookie", "did=s%3Av0%3Ad519ff49-041b-4069-9120-b7937a3002bb.VMfKlgnKfPErmnaIV8P4spNG%2BIvc6T7vLeSmgmf%2B6rs; did_compat=s%3Av0%3Ad519ff49-041b-4069-9120-b7937a3002bb.VMfKlgnKfPErmnaIV8P4spNG%2BIvc6T7vLeSmgmf%2B6rs");

                var response = await client.SendAsync(request);
                var responseContent = await response.Content.ReadAsStringAsync();

                txtTokenRaw.Text = responseContent;

                var jsonDoc = JsonDocument.Parse(responseContent);
                if (jsonDoc.RootElement.TryGetProperty("access_token", out var tokenElement))
                {
                    string accessToken = tokenElement.GetString();
                    lblStatus.Text = "Đăng nhập thành công!";
                    MessageBox.Show("Đăng nhập thành công, Ấn ok để xem lịch sử.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gán token cho biến toàn cục, lưu file, truyền sang form khác...
                    // Ví dụ: Global.AccessToken = accessToken;
                    var newForm = new Form1(accessToken);
                    newForm.Show();
                }
                else
                {
                    string error = jsonDoc.RootElement.TryGetProperty("error_description", out var errorDesc)
                        ? errorDesc.GetString()
                        : "Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản và mật khẩu.";

                    lblStatus.Text = "Lỗi: " + error;
                    MessageBox.Show(error, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Lỗi khi gọi API.";
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
