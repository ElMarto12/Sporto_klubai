namespace Sporto_klubai
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            controlPanel = new Panel();
            nutritionPlan_btn = new Button();
            training_btn = new Button();
            services_btn = new Button();
            login_btn = new Button();
            inventory_btn = new Button();
            gymList_btn = new Button();
            home_btn = new Button();
            panelLogo = new Panel();
            panel1 = new Panel();
            minimize_btn = new Button();
            windowState_btn = new Button();
            exit_btn = new Button();
            windowName = new Label();
            panelWindow = new Panel();
            controlPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.Gray;
            controlPanel.Controls.Add(nutritionPlan_btn);
            controlPanel.Controls.Add(training_btn);
            controlPanel.Controls.Add(services_btn);
            controlPanel.Controls.Add(login_btn);
            controlPanel.Controls.Add(inventory_btn);
            controlPanel.Controls.Add(gymList_btn);
            controlPanel.Controls.Add(home_btn);
            controlPanel.Controls.Add(panelLogo);
            controlPanel.Dock = DockStyle.Left;
            controlPanel.ForeColor = SystemColors.ActiveCaptionText;
            controlPanel.Location = new Point(0, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(293, 777);
            controlPanel.TabIndex = 1;
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
            nutritionPlan_btn.Location = new Point(0, 565);
            nutritionPlan_btn.Margin = new Padding(21, 3, 3, 3);
            nutritionPlan_btn.Name = "nutritionPlan_btn";
            nutritionPlan_btn.Size = new Size(293, 84);
            nutritionPlan_btn.TabIndex = 9;
            nutritionPlan_btn.Text = " Mitybos Planai";
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
            training_btn.Location = new Point(0, 481);
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
            services_btn.Location = new Point(0, 397);
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
            // login_btn
            // 
            login_btn.BackColor = Color.Gray;
            login_btn.Dock = DockStyle.Bottom;
            login_btn.FlatAppearance.BorderColor = Color.Gray;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            login_btn.Image = (Image)resources.GetObject("login_btn.Image");
            login_btn.Location = new Point(0, 693);
            login_btn.Margin = new Padding(21, 3, 3, 3);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(293, 84);
            login_btn.TabIndex = 6;
            login_btn.Text = " Prisijungti";
            login_btn.TextAlign = ContentAlignment.MiddleLeft;
            login_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // inventory_btn
            // 
            inventory_btn.BackColor = Color.Gray;
            inventory_btn.Dock = DockStyle.Top;
            inventory_btn.FlatAppearance.BorderColor = Color.Gray;
            inventory_btn.FlatAppearance.BorderSize = 0;
            inventory_btn.FlatStyle = FlatStyle.Flat;
            inventory_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            inventory_btn.Image = (Image)resources.GetObject("inventory_btn.Image");
            inventory_btn.Location = new Point(0, 313);
            inventory_btn.Margin = new Padding(21, 3, 3, 3);
            inventory_btn.Name = "inventory_btn";
            inventory_btn.Size = new Size(293, 84);
            inventory_btn.TabIndex = 5;
            inventory_btn.Text = " Inventorius";
            inventory_btn.TextAlign = ContentAlignment.MiddleLeft;
            inventory_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            inventory_btn.UseVisualStyleBackColor = false;
            inventory_btn.Click += inventory_btn_Click;
            // 
            // gymList_btn
            // 
            gymList_btn.BackColor = Color.Gray;
            gymList_btn.Dock = DockStyle.Top;
            gymList_btn.FlatAppearance.BorderColor = Color.Gray;
            gymList_btn.FlatAppearance.BorderSize = 0;
            gymList_btn.FlatStyle = FlatStyle.Flat;
            gymList_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            gymList_btn.Image = (Image)resources.GetObject("gymList_btn.Image");
            gymList_btn.Location = new Point(0, 229);
            gymList_btn.Margin = new Padding(24, 3, 3, 3);
            gymList_btn.Name = "gymList_btn";
            gymList_btn.Size = new Size(293, 84);
            gymList_btn.TabIndex = 4;
            gymList_btn.Text = " Sporto Klubai";
            gymList_btn.TextAlign = ContentAlignment.MiddleLeft;
            gymList_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            gymList_btn.UseVisualStyleBackColor = false;
            gymList_btn.Click += gymList_btn_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(minimize_btn);
            panel1.Controls.Add(windowState_btn);
            panel1.Controls.Add(exit_btn);
            panel1.Controls.Add(windowName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(293, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 145);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // minimize_btn
            // 
            minimize_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize_btn.FlatAppearance.BorderSize = 0;
            minimize_btn.FlatStyle = FlatStyle.Flat;
            minimize_btn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minimize_btn.Image = (Image)resources.GetObject("minimize_btn.Image");
            minimize_btn.Location = new Point(873, 0);
            minimize_btn.Name = "minimize_btn";
            minimize_btn.Size = new Size(77, 50);
            minimize_btn.TabIndex = 3;
            minimize_btn.UseVisualStyleBackColor = true;
            minimize_btn.Click += minimize_btn_Click;
            // 
            // windowState_btn
            // 
            windowState_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            windowState_btn.FlatAppearance.BorderSize = 0;
            windowState_btn.FlatStyle = FlatStyle.Flat;
            windowState_btn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            windowState_btn.Location = new Point(949, 0);
            windowState_btn.Name = "windowState_btn";
            windowState_btn.Size = new Size(77, 50);
            windowState_btn.TabIndex = 2;
            windowState_btn.Text = "O";
            windowState_btn.UseVisualStyleBackColor = true;
            windowState_btn.Click += button1_Click;
            // 
            // exit_btn
            // 
            exit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exit_btn.Location = new Point(1023, 0);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(77, 50);
            exit_btn.TabIndex = 1;
            exit_btn.Text = "X";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
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
            // panelWindow
            // 
            panelWindow.Dock = DockStyle.Fill;
            panelWindow.Location = new Point(293, 145);
            panelWindow.Name = "panelWindow";
            panelWindow.Size = new Size(1100, 632);
            panelWindow.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1393, 777);
            Controls.Add(panelWindow);
            Controls.Add(panel1);
            Controls.Add(controlPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sporto Rojus";
            Load += Menu_Load;
            controlPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel controlPanel;
        private Button home_btn;
        private Panel panelLogo;
        private Panel panel1;
        private Button gymList_btn;
        private Button inventory_btn;
        private Label windowName;
        private Button login_btn;
        private Panel panelWindow;
        private Button exit_btn;
        private Button minimize_btn;
        private Button windowState_btn;
        private Button services_btn;
        private Button training_btn;
        private Button nutritionPlan_btn;
    }
}