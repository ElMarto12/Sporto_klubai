namespace Sporto_klubai
{
    partial class Login
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
            username_box = new TextBox();
            password_box = new TextBox();
            username_lbl = new Label();
            password_lbl = new Label();
            tryLogin_btn = new Button();
            register_btn = new Button();
            panelLogin = new Panel();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // username_box
            // 
            username_box.Anchor = AnchorStyles.None;
            username_box.Location = new Point(365, 134);
            username_box.Multiline = true;
            username_box.Name = "username_box";
            username_box.Size = new Size(349, 39);
            username_box.TabIndex = 0;
            // 
            // password_box
            // 
            password_box.Anchor = AnchorStyles.None;
            password_box.Location = new Point(365, 252);
            password_box.Multiline = true;
            password_box.Name = "password_box";
            password_box.Size = new Size(349, 40);
            password_box.TabIndex = 0;
            password_box.TabStop = false;
            password_box.UseSystemPasswordChar = true;
            password_box.TextChanged += password_box_TextChanged;
            // 
            // username_lbl
            // 
            username_lbl.Anchor = AnchorStyles.None;
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.Location = new Point(365, 90);
            username_lbl.Margin = new Padding(0, 0, 3, 0);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(183, 28);
            username_lbl.TabIndex = 2;
            username_lbl.Text = "Prisijungimo vardas";
            // 
            // password_lbl
            // 
            password_lbl.Anchor = AnchorStyles.None;
            password_lbl.AutoSize = true;
            password_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_lbl.Location = new Point(365, 208);
            password_lbl.Margin = new Padding(0);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(113, 28);
            password_lbl.TabIndex = 3;
            password_lbl.Text = "Slaptažodis";
            // 
            // tryLogin_btn
            // 
            tryLogin_btn.Anchor = AnchorStyles.None;
            tryLogin_btn.Location = new Point(365, 329);
            tryLogin_btn.Name = "tryLogin_btn";
            tryLogin_btn.Size = new Size(349, 44);
            tryLogin_btn.TabIndex = 4;
            tryLogin_btn.Text = "Prisijungti";
            tryLogin_btn.UseVisualStyleBackColor = true;
            tryLogin_btn.Click += tryLogin_btn_Click;
            // 
            // register_btn
            // 
            register_btn.Anchor = AnchorStyles.None;
            register_btn.Location = new Point(365, 389);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(349, 44);
            register_btn.TabIndex = 5;
            register_btn.Text = "Užsiregistruoti\r\n";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(username_box);
            panelLogin.Controls.Add(register_btn);
            panelLogin.Controls.Add(username_lbl);
            panelLogin.Controls.Add(tryLogin_btn);
            panelLogin.Controls.Add(password_lbl);
            panelLogin.Controls.Add(password_box);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1082, 585);
            panelLogin.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1082, 585);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Prisijungimas";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox username_box;
        private TextBox password_box;
        private Label username_lbl;
        private Label password_lbl;
        private Button tryLogin_btn;
        private Button register_btn;
        private Panel panelLogin;
    }
}