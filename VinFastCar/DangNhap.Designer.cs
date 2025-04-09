namespace VinFastCar
{
    partial class DangNhap
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblStatus = new Label();
            label4 = new Label();
            txtTokenRaw = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 72);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 121);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(258, 69);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(382, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(258, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(382, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(353, 186);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 54);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(294, 266);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(278, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Sử dụng tài khoản VinFast để đăng nhập.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 397);
            label4.Name = "label4";
            label4.Size = new Size(754, 20);
            label4.TabIndex = 6;
            label4.Text = "Các bạn yên tâm sử dụng. Mã nguồn úng dụng này được chia sẻ miễn phí tại https://github.com/int04/VinFastCar";
            // 
            // txtTokenRaw
            // 
            txtTokenRaw.Location = new Point(339, 316);
            txtTokenRaw.Name = "txtTokenRaw";
            txtTokenRaw.Size = new Size(508, 63);
            txtTokenRaw.TabIndex = 7;
            txtTokenRaw.Text = "";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 426);
            Controls.Add(txtTokenRaw);
            Controls.Add(label4);
            Controls.Add(lblStatus);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangNhap";
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblStatus;
        private Label label4;
        private RichTextBox txtTokenRaw;
    }
}