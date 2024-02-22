namespace Sporto_klubai
{
    partial class ClientMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMenu));
            panelLogo = new Panel();
            controlPanel = new Panel();
            nutritionPlan_btn = new Button();
            training_btn = new Button();
            services_btn = new Button();
            singOut_btn = new Button();
            home_btn = new Button();
            panelTop = new Panel();
            exitBtn = new Button();
            resizeBtn = new Button();
            minimizeBtn = new Button();
            windowName = new Label();
            windowPanel = new Panel();
            profile_btn = new Button();
            controlPanel.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(64, 64, 64);
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(293, 145);
            panelLogo.TabIndex = 2;
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.Gray;
            controlPanel.Controls.Add(profile_btn);
            controlPanel.Controls.Add(nutritionPlan_btn);
            controlPanel.Controls.Add(training_btn);
            controlPanel.Controls.Add(services_btn);
            controlPanel.Controls.Add(singOut_btn);
            controlPanel.Controls.Add(home_btn);
            controlPanel.Controls.Add(panelLogo);
            controlPanel.Dock = DockStyle.Left;
            controlPanel.ForeColor = SystemColors.ActiveCaptionText;
            controlPanel.Location = new Point(0, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(293, 947);
            controlPanel.TabIndex = 4;
            // 
            // nutritionPlan_btn
            // 
            nutritionPlan_btn.BackColor = Color.Gray;
            nutritionPlan_btn.Dock = DockStyle.Top;
            nutritionPlan_btn.FlatAppearance.BorderColor = Color.Gray;
            nutritionPlan_btn.FlatAppearance.BorderSize = 0;
            nutritionPlan_btn.FlatStyle = FlatStyle.Flat;
            nutritionPlan_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            nutritionPlan_btn.Image = (Image)resources.GetObject("nutritionPlan_btn.Image");
            nutritionPlan_btn.Location = new Point(0, 397);
            nutritionPlan_btn.Margin = new Padding(21, 3, 3, 3);
            nutritionPlan_btn.Name = "nutritionPlan_btn";
            nutritionPlan_btn.Size = new Size(293, 84);
            nutritionPlan_btn.TabIndex = 9;
            nutritionPlan_btn.Text = " Mitybos Planas";
            nutritionPlan_btn.TextAlign = ContentAlignment.MiddleLeft;
            nutritionPlan_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            nutritionPlan_btn.UseVisualStyleBackColor = false;
            nutritionPlan_btn.Click += nutritionPlan_btn_Click;
            // 
            // training_btn
            // 
            training_btn.BackColor = Color.Gray;
            training_btn.Dock = DockStyle.Top;
            training_btn.FlatAppearance.BorderColor = Color.Gray;
            training_btn.FlatAppearance.BorderSize = 0;
            training_btn.FlatStyle = FlatStyle.Flat;
            training_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            training_btn.Image = (Image)resources.GetObject("training_btn.Image");
            training_btn.Location = new Point(0, 313);
            training_btn.Margin = new Padding(21, 3, 3, 3);
            training_btn.Name = "training_btn";
            training_btn.Size = new Size(293, 84);
            training_btn.TabIndex = 8;
            training_btn.Text = " Treniruotės";
            training_btn.TextAlign = ContentAlignment.MiddleLeft;
            training_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            training_btn.UseVisualStyleBackColor = false;
            training_btn.Click += training_btn_Click;
            // 
            // services_btn
            // 
            services_btn.BackColor = Color.Gray;
            services_btn.Dock = DockStyle.Top;
            services_btn.FlatAppearance.BorderColor = Color.Gray;
            services_btn.FlatAppearance.BorderSize = 0;
            services_btn.FlatStyle = FlatStyle.Flat;
            services_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            services_btn.Image = (Image)resources.GetObject("services_btn.Image");
            services_btn.Location = new Point(0, 229);
            services_btn.Margin = new Padding(21, 3, 3, 3);
            services_btn.Name = "services_btn";
            services_btn.Size = new Size(293, 84);
            services_btn.TabIndex = 7;
            services_btn.Text = " Narystės";
            services_btn.TextAlign = ContentAlignment.MiddleLeft;
            services_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            services_btn.UseVisualStyleBackColor = false;
            services_btn.Click += services_btn_Click;
            // 
            // singOut_btn
            // 
            singOut_btn.BackColor = Color.Gray;
            singOut_btn.Dock = DockStyle.Bottom;
            singOut_btn.FlatAppearance.BorderColor = Color.Gray;
            singOut_btn.FlatAppearance.BorderSize = 0;
            singOut_btn.FlatStyle = FlatStyle.Flat;
            singOut_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            singOut_btn.Image = (Image)resources.GetObject("singOut_btn.Image");
            singOut_btn.Location = new Point(0, 863);
            singOut_btn.Margin = new Padding(21, 3, 3, 3);
            singOut_btn.Name = "singOut_btn";
            singOut_btn.Size = new Size(293, 84);
            singOut_btn.TabIndex = 6;
            singOut_btn.Text = " Atsijungti";
            singOut_btn.TextAlign = ContentAlignment.MiddleLeft;
            singOut_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            singOut_btn.UseVisualStyleBackColor = false;
            singOut_btn.Click += singOut_btn_Click;
            // 
            // home_btn
            // 
            home_btn.BackColor = Color.Gray;
            home_btn.Dock = DockStyle.Top;
            home_btn.FlatAppearance.BorderColor = Color.Gray;
            home_btn.FlatAppearance.BorderSize = 0;
            home_btn.FlatStyle = FlatStyle.Flat;
            home_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            home_btn.Image = (Image)resources.GetObject("home_btn.Image");
            home_btn.Location = new Point(0, 145);
            home_btn.Margin = new Padding(21, 3, 3, 3);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(293, 84);
            home_btn.TabIndex = 3;
            home_btn.Text = " Pagrindinis";
            home_btn.TextAlign = ContentAlignment.MiddleLeft;
            home_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            home_btn.UseVisualStyleBackColor = false;
            home_btn.Click += home_btn_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Gray;
            panelTop.Controls.Add(exitBtn);
            panelTop.Controls.Add(resizeBtn);
            panelTop.Controls.Add(minimizeBtn);
            panelTop.Controls.Add(windowName);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(293, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1380, 145);
            panelTop.TabIndex = 5;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.Location = new Point(1303, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(77, 50);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // resizeBtn
            // 
            resizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resizeBtn.FlatAppearance.BorderSize = 0;
            resizeBtn.FlatStyle = FlatStyle.Flat;
            resizeBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resizeBtn.Location = new Point(1231, 0);
            resizeBtn.Name = "resizeBtn";
            resizeBtn.Size = new Size(77, 50);
            resizeBtn.TabIndex = 5;
            resizeBtn.Text = "O";
            resizeBtn.UseVisualStyleBackColor = true;
            resizeBtn.Click += resizeBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minimizeBtn.Image = (Image)resources.GetObject("minimizeBtn.Image");
            minimizeBtn.Location = new Point(1160, 0);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(77, 50);
            minimizeBtn.TabIndex = 4;
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // windowName
            // 
            windowName.AutoSize = true;
            windowName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            windowName.Location = new Point(114, 47);
            windowName.Name = "windowName";
            windowName.Size = new Size(182, 38);
            windowName.TabIndex = 0;
            windowName.Text = "PAGRINDINIS";
            // 
            // windowPanel
            // 
            windowPanel.BackColor = Color.Silver;
            windowPanel.Dock = DockStyle.Fill;
            windowPanel.Location = new Point(293, 145);
            windowPanel.Name = "windowPanel";
            windowPanel.Size = new Size(1380, 802);
            windowPanel.TabIndex = 6;
            // 
            // profile_btn
            // 
            profile_btn.BackColor = Color.Gray;
            profile_btn.Dock = DockStyle.Bottom;
            profile_btn.FlatAppearance.BorderColor = Color.Gray;
            profile_btn.FlatAppearance.BorderSize = 0;
            profile_btn.FlatStyle = FlatStyle.Flat;
            profile_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            profile_btn.Image = (Image)resources.GetObject("profile_btn.Image");
            profile_btn.Location = new Point(0, 779);
            profile_btn.Margin = new Padding(21, 3, 3, 3);
            profile_btn.Name = "profile_btn";
            profile_btn.Size = new Size(293, 84);
            profile_btn.TabIndex = 10;
            profile_btn.Text = " Profilis";
            profile_btn.TextAlign = ContentAlignment.MiddleLeft;
            profile_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            profile_btn.UseVisualStyleBackColor = false;
            profile_btn.Click += profile_btn_Click;
            // 
            // ClientMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1673, 947);
            Controls.Add(windowPanel);
            Controls.Add(panelTop);
            Controls.Add(controlPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientMenu";
            Text = "ClientMenu";
            controlPanel.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Panel controlPanel;
        private Button training_btn;
        private Button services_btn;
        private Button singOut_btn;
        private Button home_btn;
        private Panel panelTop;
        private Label windowName;
        private Button minimizeBtn;
        private Button resizeBtn;
        private Button exitBtn;
        private Panel windowPanel;
        private Button nutritionPlan_btn;
        private Button profile_btn;
    }
}