namespace Sporto_klubai.Views
{
    partial class TrainingView
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
            gymList = new ListBox();
            trainingLabel = new Label();
            trainingData = new DataGridView();
            personalTraining_btn = new Button();
            groupTraining_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)trainingData).BeginInit();
            SuspendLayout();
            // 
            // gymList
            // 
            gymList.Anchor = AnchorStyles.None;
            gymList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gymList.FormattingEnabled = true;
            gymList.ItemHeight = 28;
            gymList.Location = new Point(101, 60);
            gymList.Name = "gymList";
            gymList.Size = new Size(395, 424);
            gymList.TabIndex = 10;
            gymList.SelectedIndexChanged += gymList_SelectedIndexChanged;
            // 
            // trainingLabel
            // 
            trainingLabel.Anchor = AnchorStyles.None;
            trainingLabel.AutoSize = true;
            trainingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            trainingLabel.Location = new Point(569, 60);
            trainingLabel.Name = "trainingLabel";
            trainingLabel.Size = new Size(108, 28);
            trainingLabel.TabIndex = 11;
            trainingLabel.Text = "Treniruotės";
            trainingLabel.Click += trainingLabel_Click;
            // 
            // trainingData
            // 
            trainingData.Anchor = AnchorStyles.None;
            trainingData.BackgroundColor = Color.White;
            trainingData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trainingData.Location = new Point(575, 116);
            trainingData.Name = "trainingData";
            trainingData.RowHeadersWidth = 51;
            trainingData.RowTemplate.Height = 29;
            trainingData.Size = new Size(395, 368);
            trainingData.TabIndex = 12;
            trainingData.CellContentClick += trainingData_CellContentClick;
            // 
            // personalTraining_btn
            // 
            personalTraining_btn.Anchor = AnchorStyles.None;
            personalTraining_btn.BackColor = Color.Gainsboro;
            personalTraining_btn.FlatAppearance.BorderSize = 0;
            personalTraining_btn.FlatStyle = FlatStyle.Flat;
            personalTraining_btn.Location = new Point(758, 63);
            personalTraining_btn.Name = "personalTraining_btn";
            personalTraining_btn.Size = new Size(94, 35);
            personalTraining_btn.TabIndex = 13;
            personalTraining_btn.Text = "Asmeninės";
            personalTraining_btn.UseVisualStyleBackColor = false;
            personalTraining_btn.Click += personalTraining_btn_Click;
            // 
            // groupTraining_btn
            // 
            groupTraining_btn.Anchor = AnchorStyles.None;
            groupTraining_btn.BackColor = Color.Gainsboro;
            groupTraining_btn.FlatAppearance.BorderSize = 0;
            groupTraining_btn.FlatStyle = FlatStyle.Flat;
            groupTraining_btn.Location = new Point(876, 63);
            groupTraining_btn.Name = "groupTraining_btn";
            groupTraining_btn.Size = new Size(94, 35);
            groupTraining_btn.TabIndex = 14;
            groupTraining_btn.Text = "Grupinės";
            groupTraining_btn.UseVisualStyleBackColor = false;
            groupTraining_btn.Click += groupTraining_btn_Click;
            // 
            // TrainingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1082, 585);
            Controls.Add(groupTraining_btn);
            Controls.Add(personalTraining_btn);
            Controls.Add(trainingData);
            Controls.Add(trainingLabel);
            Controls.Add(gymList);
            Name = "TrainingView";
            Text = "TrainingView";
            ((System.ComponentModel.ISupportInitialize)trainingData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox gymList;
        private Label trainingLabel;
        private DataGridView trainingData;
        private Button personalTraining_btn;
        private Button groupTraining_btn;
    }
}