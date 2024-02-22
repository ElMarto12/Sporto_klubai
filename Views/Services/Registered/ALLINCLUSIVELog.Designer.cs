namespace Sporto_klubai.Views.Services.Registered
{
    partial class ALLINCLUSIVELog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALLINCLUSIVELog));
            durationDBlabel = new Panel();
            check_btn = new Button();
            priceDBlabel = new Label();
            duration = new Label();
            priceLabel = new Label();
            durationLabel = new Label();
            back_btn = new Button();
            servicesData = new DataGridView();
            servicesLabel = new Label();
            durationDBlabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicesData).BeginInit();
            SuspendLayout();
            // 
            // durationDBlabel
            // 
            durationDBlabel.BackColor = Color.Silver;
            durationDBlabel.Controls.Add(check_btn);
            durationDBlabel.Controls.Add(priceDBlabel);
            durationDBlabel.Controls.Add(duration);
            durationDBlabel.Controls.Add(priceLabel);
            durationDBlabel.Controls.Add(durationLabel);
            durationDBlabel.Controls.Add(back_btn);
            durationDBlabel.Controls.Add(servicesData);
            durationDBlabel.Controls.Add(servicesLabel);
            durationDBlabel.Dock = DockStyle.Fill;
            durationDBlabel.Location = new Point(0, 0);
            durationDBlabel.Name = "durationDBlabel";
            durationDBlabel.Size = new Size(1064, 538);
            durationDBlabel.TabIndex = 2;
            // 
            // check_btn
            // 
            check_btn.Anchor = AnchorStyles.None;
            check_btn.Location = new Point(277, 383);
            check_btn.Name = "check_btn";
            check_btn.Size = new Size(551, 53);
            check_btn.TabIndex = 26;
            check_btn.Text = "Užsakyti";
            check_btn.UseVisualStyleBackColor = true;
            check_btn.Click += check_btn_Click;
            // 
            // priceDBlabel
            // 
            priceDBlabel.Anchor = AnchorStyles.None;
            priceDBlabel.AutoSize = true;
            priceDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            priceDBlabel.Location = new Point(579, 329);
            priceDBlabel.Name = "priceDBlabel";
            priceDBlabel.Size = new Size(0, 28);
            priceDBlabel.TabIndex = 23;
            // 
            // duration
            // 
            duration.Anchor = AnchorStyles.None;
            duration.AutoSize = true;
            duration.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            duration.Location = new Point(277, 329);
            duration.Name = "duration";
            duration.Size = new Size(0, 28);
            duration.TabIndex = 22;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.None;
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(579, 280);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(60, 28);
            priceLabel.TabIndex = 21;
            priceLabel.Text = "Kaina";
            // 
            // durationLabel
            // 
            durationLabel.Anchor = AnchorStyles.None;
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            durationLabel.Location = new Point(277, 280);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(107, 28);
            durationLabel.TabIndex = 20;
            durationLabel.Text = "Laikotarpis";
            // 
            // back_btn
            // 
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Image = (Image)resources.GetObject("back_btn.Image");
            back_btn.Location = new Point(50, 39);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(61, 59);
            back_btn.TabIndex = 19;
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // servicesData
            // 
            servicesData.Anchor = AnchorStyles.None;
            servicesData.BackgroundColor = SystemColors.Control;
            servicesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesData.Location = new Point(277, 128);
            servicesData.Name = "servicesData";
            servicesData.RowHeadersWidth = 51;
            servicesData.RowTemplate.Height = 29;
            servicesData.Size = new Size(551, 127);
            servicesData.TabIndex = 1;
            // 
            // servicesLabel
            // 
            servicesLabel.Anchor = AnchorStyles.None;
            servicesLabel.AutoSize = true;
            servicesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            servicesLabel.Location = new Point(277, 87);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new Size(98, 28);
            servicesLabel.TabIndex = 0;
            servicesLabel.Text = "Paslaugos";
            // 
            // ALLINCLUSIVELog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1064, 538);
            Controls.Add(durationDBlabel);
            Name = "ALLINCLUSIVELog";
            Text = "ALLINCLUSIVELog";
            durationDBlabel.ResumeLayout(false);
            durationDBlabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)servicesData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel durationDBlabel;
        private Label priceDBlabel;
        private Label duration;
        private Label priceLabel;
        private Label durationLabel;
        private Button back_btn;
        private DataGridView servicesData;
        private Label servicesLabel;
        private Button check_btn;
    }
}