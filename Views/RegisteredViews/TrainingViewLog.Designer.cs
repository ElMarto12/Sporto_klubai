namespace Sporto_klubai.Views.RegisteredViews
{
    partial class TrainingViewLog
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
            groupTraining_btn = new Button();
            personalTraining_btn = new Button();
            trainingLabel = new Label();
            gymList = new ListBox();
            trainingList = new ListBox();
            trenerLabel = new Label();
            trenerList = new ListBox();
            confirm_btn = new Button();
            SuspendLayout();
            // 
            // groupTraining_btn
            // 
            groupTraining_btn.Anchor = AnchorStyles.None;
            groupTraining_btn.BackColor = Color.Gainsboro;
            groupTraining_btn.FlatAppearance.BorderSize = 0;
            groupTraining_btn.FlatStyle = FlatStyle.Flat;
            groupTraining_btn.Location = new Point(880, 62);
            groupTraining_btn.Name = "groupTraining_btn";
            groupTraining_btn.Size = new Size(94, 35);
            groupTraining_btn.TabIndex = 19;
            groupTraining_btn.Text = "Grupinės";
            groupTraining_btn.UseVisualStyleBackColor = false;
            groupTraining_btn.Click += groupTraining_btn_Click_1;
            // 
            // personalTraining_btn
            // 
            personalTraining_btn.Anchor = AnchorStyles.None;
            personalTraining_btn.BackColor = Color.Gainsboro;
            personalTraining_btn.FlatAppearance.BorderSize = 0;
            personalTraining_btn.FlatStyle = FlatStyle.Flat;
            personalTraining_btn.Location = new Point(762, 62);
            personalTraining_btn.Name = "personalTraining_btn";
            personalTraining_btn.Size = new Size(94, 35);
            personalTraining_btn.TabIndex = 18;
            personalTraining_btn.Text = "Asmeninės";
            personalTraining_btn.UseVisualStyleBackColor = false;
            personalTraining_btn.Click += personalTraining_btn_Click_1;
            // 
            // trainingLabel
            // 
            trainingLabel.Anchor = AnchorStyles.None;
            trainingLabel.AutoSize = true;
            trainingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            trainingLabel.Location = new Point(569, 59);
            trainingLabel.Name = "trainingLabel";
            trainingLabel.Size = new Size(108, 28);
            trainingLabel.TabIndex = 16;
            trainingLabel.Text = "Treniruotės";
            // 
            // gymList
            // 
            gymList.Anchor = AnchorStyles.None;
            gymList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gymList.FormattingEnabled = true;
            gymList.ItemHeight = 28;
            gymList.Location = new Point(105, 59);
            gymList.Name = "gymList";
            gymList.Size = new Size(395, 424);
            gymList.TabIndex = 15;
            gymList.SelectedIndexChanged += gymList_SelectedIndexChanged;
            // 
            // trainingList
            // 
            trainingList.Anchor = AnchorStyles.None;
            trainingList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            trainingList.FormattingEnabled = true;
            trainingList.ItemHeight = 28;
            trainingList.Location = new Point(573, 115);
            trainingList.Name = "trainingList";
            trainingList.Size = new Size(401, 116);
            trainingList.TabIndex = 20;
            trainingList.SelectedIndexChanged += trainingList_SelectedIndexChanged;
            // 
            // trenerLabel
            // 
            trenerLabel.Anchor = AnchorStyles.None;
            trenerLabel.AutoSize = true;
            trenerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            trenerLabel.Location = new Point(573, 265);
            trenerLabel.Name = "trenerLabel";
            trenerLabel.Size = new Size(85, 28);
            trenerLabel.TabIndex = 21;
            trenerLabel.Text = "Treneriai";
            // 
            // trenerList
            // 
            trenerList.Anchor = AnchorStyles.None;
            trenerList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            trenerList.FormattingEnabled = true;
            trenerList.ItemHeight = 28;
            trenerList.Location = new Point(573, 311);
            trenerList.Name = "trenerList";
            trenerList.Size = new Size(401, 172);
            trenerList.TabIndex = 22;
            trenerList.SelectedIndexChanged += trenerList_SelectedIndexChanged;
            // 
            // confirm_btn
            // 
            confirm_btn.Anchor = AnchorStyles.None;
            confirm_btn.Location = new Point(105, 510);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(869, 63);
            confirm_btn.TabIndex = 23;
            confirm_btn.Text = "Užsisakyti";
            confirm_btn.UseVisualStyleBackColor = true;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // TrainingViewLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1082, 585);
            Controls.Add(confirm_btn);
            Controls.Add(trenerList);
            Controls.Add(trenerLabel);
            Controls.Add(trainingList);
            Controls.Add(groupTraining_btn);
            Controls.Add(personalTraining_btn);
            Controls.Add(trainingLabel);
            Controls.Add(gymList);
            Name = "TrainingViewLog";
            Text = "TrainingViewLog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button groupTraining_btn;
        private Button personalTraining_btn;
        private Label trainingLabel;
        private ListBox gymList;
        private ListBox trainingList;
        private Label trenerLabel;
        private ListBox trenerList;
        private Button confirm_btn;
    }
}