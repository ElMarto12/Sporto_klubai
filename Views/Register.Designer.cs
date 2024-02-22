namespace Sporto_klubai
{
    partial class Register
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
            panelRegister = new Panel();
            continue1_btn = new Button();
            passwordTxt_box = new TextBox();
            passwordLabel = new Label();
            lastNameTxt_box = new TextBox();
            lastNameLabel = new Label();
            nameTxt_box = new TextBox();
            nameLabel = new Label();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(continue1_btn);
            panelRegister.Controls.Add(passwordTxt_box);
            panelRegister.Controls.Add(passwordLabel);
            panelRegister.Controls.Add(lastNameTxt_box);
            panelRegister.Controls.Add(lastNameLabel);
            panelRegister.Controls.Add(nameTxt_box);
            panelRegister.Controls.Add(nameLabel);
            panelRegister.Dock = DockStyle.Fill;
            panelRegister.Location = new Point(0, 0);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(1087, 590);
            panelRegister.TabIndex = 0;
            // 
            // continue1_btn
            // 
            continue1_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            continue1_btn.Location = new Point(880, 475);
            continue1_btn.Name = "continue1_btn";
            continue1_btn.Size = new Size(122, 64);
            continue1_btn.TabIndex = 13;
            continue1_btn.Text = "Toliau";
            continue1_btn.UseVisualStyleBackColor = true;
            continue1_btn.Click += continue1_btn_Click;
            // 
            // passwordTxt_box
            // 
            passwordTxt_box.Anchor = AnchorStyles.None;
            passwordTxt_box.Location = new Point(387, 315);
            passwordTxt_box.Multiline = true;
            passwordTxt_box.Name = "passwordTxt_box";
            passwordTxt_box.Size = new Size(270, 34);
            passwordTxt_box.TabIndex = 12;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(387, 278);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(113, 28);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Slaptažodis";
            // 
            // lastNameTxt_box
            // 
            lastNameTxt_box.Anchor = AnchorStyles.None;
            lastNameTxt_box.Location = new Point(387, 220);
            lastNameTxt_box.Multiline = true;
            lastNameTxt_box.Name = "lastNameTxt_box";
            lastNameTxt_box.Size = new Size(270, 34);
            lastNameTxt_box.TabIndex = 10;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.None;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(387, 184);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(81, 28);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Text = "Pavardė";
            // 
            // nameTxt_box
            // 
            nameTxt_box.Anchor = AnchorStyles.None;
            nameTxt_box.Location = new Point(387, 122);
            nameTxt_box.Multiline = true;
            nameTxt_box.Name = "nameTxt_box";
            nameTxt_box.Size = new Size(270, 34);
            nameTxt_box.TabIndex = 8;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(388, 85);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(70, 28);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Vardas";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1087, 590);
            Controls.Add(panelRegister);
            Name = "Register";
            Text = "Register";
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRegister;
        private Button continue1_btn;
        private TextBox passwordTxt_box;
        private Label passwordLabel;
        private TextBox lastNameTxt_box;
        private Label lastNameLabel;
        private TextBox nameTxt_box;
        private Label nameLabel;
    }
}