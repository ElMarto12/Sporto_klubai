namespace Sporto_klubai.Views.RegisteredViews
{
    partial class NutritionPlanViewLog
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
            foodLabel = new Label();
            foodData = new DataGridView();
            priceDBlabel = new Label();
            priceLabel = new Label();
            endDBlabel = new Label();
            beginDBlabel = new Label();
            endLabel = new Label();
            beginLabel = new Label();
            nutritionPlanDBlabel = new Label();
            nutritionPlanLabel = new Label();
            workerList = new ListBox();
            confirm_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)foodData).BeginInit();
            SuspendLayout();
            // 
            // foodLabel
            // 
            foodLabel.Anchor = AnchorStyles.None;
            foodLabel.AutoSize = true;
            foodLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            foodLabel.ForeColor = Color.Black;
            foodLabel.Location = new Point(583, 308);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new Size(94, 28);
            foodLabel.TabIndex = 31;
            foodLabel.Text = "Patiekalai";
            // 
            // foodData
            // 
            foodData.Anchor = AnchorStyles.None;
            foodData.BackgroundColor = SystemColors.Control;
            foodData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            foodData.Location = new Point(583, 353);
            foodData.Name = "foodData";
            foodData.RowHeadersWidth = 51;
            foodData.RowTemplate.Height = 29;
            foodData.Size = new Size(408, 134);
            foodData.TabIndex = 30;
            // 
            // priceDBlabel
            // 
            priceDBlabel.Anchor = AnchorStyles.None;
            priceDBlabel.AutoSize = true;
            priceDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            priceDBlabel.ForeColor = Color.Black;
            priceDBlabel.Location = new Point(754, 245);
            priceDBlabel.Name = "priceDBlabel";
            priceDBlabel.Size = new Size(0, 28);
            priceDBlabel.TabIndex = 29;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.None;
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.ForeColor = Color.Black;
            priceLabel.Location = new Point(583, 245);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(64, 28);
            priceLabel.TabIndex = 28;
            priceLabel.Text = "Kaina:";
            // 
            // endDBlabel
            // 
            endDBlabel.Anchor = AnchorStyles.None;
            endDBlabel.AutoSize = true;
            endDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            endDBlabel.ForeColor = Color.Black;
            endDBlabel.Location = new Point(754, 190);
            endDBlabel.Name = "endDBlabel";
            endDBlabel.Size = new Size(0, 28);
            endDBlabel.TabIndex = 27;
            // 
            // beginDBlabel
            // 
            beginDBlabel.Anchor = AnchorStyles.None;
            beginDBlabel.AutoSize = true;
            beginDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            beginDBlabel.ForeColor = Color.Black;
            beginDBlabel.Location = new Point(583, 190);
            beginDBlabel.Name = "beginDBlabel";
            beginDBlabel.Size = new Size(0, 28);
            beginDBlabel.TabIndex = 26;
            // 
            // endLabel
            // 
            endLabel.Anchor = AnchorStyles.None;
            endLabel.AutoSize = true;
            endLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            endLabel.ForeColor = Color.Black;
            endLabel.Location = new Point(754, 138);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(81, 28);
            endLabel.TabIndex = 25;
            endLabel.Text = "Pabaiga";
            // 
            // beginLabel
            // 
            beginLabel.Anchor = AnchorStyles.None;
            beginLabel.AutoSize = true;
            beginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            beginLabel.ForeColor = Color.Black;
            beginLabel.Location = new Point(583, 138);
            beginLabel.Name = "beginLabel";
            beginLabel.Size = new Size(76, 28);
            beginLabel.TabIndex = 24;
            beginLabel.Text = "Pradžia";
            // 
            // nutritionPlanDBlabel
            // 
            nutritionPlanDBlabel.Anchor = AnchorStyles.None;
            nutritionPlanDBlabel.AutoSize = true;
            nutritionPlanDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nutritionPlanDBlabel.ForeColor = Color.Black;
            nutritionPlanDBlabel.Location = new Point(583, 81);
            nutritionPlanDBlabel.Name = "nutritionPlanDBlabel";
            nutritionPlanDBlabel.Size = new Size(0, 28);
            nutritionPlanDBlabel.TabIndex = 23;
            // 
            // nutritionPlanLabel
            // 
            nutritionPlanLabel.Anchor = AnchorStyles.None;
            nutritionPlanLabel.AutoSize = true;
            nutritionPlanLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nutritionPlanLabel.ForeColor = Color.Black;
            nutritionPlanLabel.Location = new Point(583, 34);
            nutritionPlanLabel.Name = "nutritionPlanLabel";
            nutritionPlanLabel.Size = new Size(144, 28);
            nutritionPlanLabel.TabIndex = 22;
            nutritionPlanLabel.Text = "Mitybos Planas";
            // 
            // workerList
            // 
            workerList.Anchor = AnchorStyles.None;
            workerList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            workerList.FormattingEnabled = true;
            workerList.ItemHeight = 28;
            workerList.Location = new Point(99, 35);
            workerList.Name = "workerList";
            workerList.Size = new Size(395, 452);
            workerList.TabIndex = 21;
            workerList.SelectedIndexChanged += workerList_SelectedIndexChanged;
            // 
            // confirm_btn
            // 
            confirm_btn.Anchor = AnchorStyles.None;
            confirm_btn.Location = new Point(99, 512);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(892, 61);
            confirm_btn.TabIndex = 32;
            confirm_btn.Text = "Užsakyti";
            confirm_btn.UseVisualStyleBackColor = true;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // NutritionPlanViewLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1082, 585);
            Controls.Add(confirm_btn);
            Controls.Add(foodLabel);
            Controls.Add(foodData);
            Controls.Add(priceDBlabel);
            Controls.Add(priceLabel);
            Controls.Add(endDBlabel);
            Controls.Add(beginDBlabel);
            Controls.Add(endLabel);
            Controls.Add(beginLabel);
            Controls.Add(nutritionPlanDBlabel);
            Controls.Add(nutritionPlanLabel);
            Controls.Add(workerList);
            Name = "NutritionPlanViewLog";
            Text = "NutritionPlanViewLog";
            ((System.ComponentModel.ISupportInitialize)foodData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label foodLabel;
        private DataGridView foodData;
        private Label priceDBlabel;
        private Label priceLabel;
        private Label endDBlabel;
        private Label beginDBlabel;
        private Label endLabel;
        private Label beginLabel;
        private Label nutritionPlanDBlabel;
        private Label nutritionPlanLabel;
        private ListBox workerList;
        private Button confirm_btn;
    }
}