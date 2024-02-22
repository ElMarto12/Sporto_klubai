namespace Sporto_klubai.Views.Services
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            serviceAllEnclusive = new Panel();
            serviceAllInclusive_btn = new Button();
            serviceBasic = new Panel();
            serviceBasic_btn = new Button();
            serviceAmatuer = new Panel();
            serviceAmatuer_btn = new Button();
            servicePanel = new Panel();
            serviceAllEnclusive.SuspendLayout();
            serviceBasic.SuspendLayout();
            serviceAmatuer.SuspendLayout();
            servicePanel.SuspendLayout();
            SuspendLayout();
            // 
            // serviceAllEnclusive
            // 
            serviceAllEnclusive.Anchor = AnchorStyles.None;
            serviceAllEnclusive.BackColor = Color.DarkGray;
            serviceAllEnclusive.BackgroundImage = (Image)resources.GetObject("serviceAllEnclusive.BackgroundImage");
            serviceAllEnclusive.Controls.Add(serviceAllInclusive_btn);
            serviceAllEnclusive.Location = new Point(751, 66);
            serviceAllEnclusive.Name = "serviceAllEnclusive";
            serviceAllEnclusive.Size = new Size(250, 446);
            serviceAllEnclusive.TabIndex = 2;
            // 
            // serviceAllInclusive_btn
            // 
            serviceAllInclusive_btn.BackColor = Color.LightGray;
            serviceAllInclusive_btn.Dock = DockStyle.Bottom;
            serviceAllInclusive_btn.FlatAppearance.BorderSize = 0;
            serviceAllInclusive_btn.FlatStyle = FlatStyle.Flat;
            serviceAllInclusive_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            serviceAllInclusive_btn.Location = new Point(0, 373);
            serviceAllInclusive_btn.Name = "serviceAllInclusive_btn";
            serviceAllInclusive_btn.Size = new Size(250, 73);
            serviceAllInclusive_btn.TabIndex = 1;
            serviceAllInclusive_btn.Text = "VISKAS ĮSKAIČIUOTA";
            serviceAllInclusive_btn.UseVisualStyleBackColor = false;
            serviceAllInclusive_btn.Click += serviceAllInclusive_btn_Click;
            // 
            // serviceBasic
            // 
            serviceBasic.Anchor = AnchorStyles.None;
            serviceBasic.BackColor = Color.DarkGray;
            serviceBasic.BackgroundImage = (Image)resources.GetObject("serviceBasic.BackgroundImage");
            serviceBasic.Controls.Add(serviceBasic_btn);
            serviceBasic.Location = new Point(81, 66);
            serviceBasic.Name = "serviceBasic";
            serviceBasic.Size = new Size(250, 446);
            serviceBasic.TabIndex = 0;
            // 
            // serviceBasic_btn
            // 
            serviceBasic_btn.BackColor = Color.LightGray;
            serviceBasic_btn.Dock = DockStyle.Bottom;
            serviceBasic_btn.FlatAppearance.BorderSize = 0;
            serviceBasic_btn.FlatStyle = FlatStyle.Flat;
            serviceBasic_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            serviceBasic_btn.Location = new Point(0, 373);
            serviceBasic_btn.Name = "serviceBasic_btn";
            serviceBasic_btn.Size = new Size(250, 73);
            serviceBasic_btn.TabIndex = 0;
            serviceBasic_btn.Text = "BASIC";
            serviceBasic_btn.UseVisualStyleBackColor = false;
            serviceBasic_btn.Click += serviceBasic_btn_Click;
            // 
            // serviceAmatuer
            // 
            serviceAmatuer.Anchor = AnchorStyles.None;
            serviceAmatuer.BackColor = Color.DarkGray;
            serviceAmatuer.BackgroundImage = (Image)resources.GetObject("serviceAmatuer.BackgroundImage");
            serviceAmatuer.Controls.Add(serviceAmatuer_btn);
            serviceAmatuer.Location = new Point(418, 66);
            serviceAmatuer.Name = "serviceAmatuer";
            serviceAmatuer.Size = new Size(250, 446);
            serviceAmatuer.TabIndex = 1;
            // 
            // serviceAmatuer_btn
            // 
            serviceAmatuer_btn.BackColor = Color.LightGray;
            serviceAmatuer_btn.Dock = DockStyle.Bottom;
            serviceAmatuer_btn.FlatAppearance.BorderSize = 0;
            serviceAmatuer_btn.FlatStyle = FlatStyle.Flat;
            serviceAmatuer_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            serviceAmatuer_btn.Location = new Point(0, 373);
            serviceAmatuer_btn.Name = "serviceAmatuer_btn";
            serviceAmatuer_btn.Size = new Size(250, 73);
            serviceAmatuer_btn.TabIndex = 1;
            serviceAmatuer_btn.Text = "PAŽENGUSIEMS";
            serviceAmatuer_btn.UseVisualStyleBackColor = false;
            serviceAmatuer_btn.Click += serviceAmatuer_btn_Click;
            // 
            // servicePanel
            // 
            servicePanel.BackColor = Color.Silver;
            servicePanel.Controls.Add(serviceAllEnclusive);
            servicePanel.Controls.Add(serviceBasic);
            servicePanel.Controls.Add(serviceAmatuer);
            servicePanel.Dock = DockStyle.Fill;
            servicePanel.Location = new Point(0, 0);
            servicePanel.Name = "servicePanel";
            servicePanel.Size = new Size(1082, 585);
            servicePanel.TabIndex = 4;
            // 
            // Services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 585);
            Controls.Add(servicePanel);
            Name = "Services";
            Text = "Services";
            serviceAllEnclusive.ResumeLayout(false);
            serviceBasic.ResumeLayout(false);
            serviceAmatuer.ResumeLayout(false);
            servicePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel serviceAllEnclusive;
        private Button serviceAllInclusive_btn;
        private Panel serviceBasic;
        private Button serviceBasic_btn;
        private Panel serviceAmatuer;
        private Button serviceAmatuer_btn;
        private Panel servicePanel;
    }
}