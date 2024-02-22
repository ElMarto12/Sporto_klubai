namespace Sporto_klubai.Views
{
    partial class NutritionPlanView
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
            workerList = new ListBox();
            nutritionPlanLabel = new Label();
            nutritionPlanDBlabel = new Label();
            beginLabel = new Label();
            endLabel = new Label();
            beginDBlabel = new Label();
            endDBlabel = new Label();
            priceLabel = new Label();
            priceDBlabel = new Label();
            foodData = new DataGridView();
            foodLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)foodData).BeginInit();
            SuspendLayout();
            // 
            // workerList
            // 
            workerList.Anchor = AnchorStyles.None;
            workerList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            workerList.FormattingEnabled = true;
            workerList.ItemHeight = 28;
            workerList.Location = new Point(92, 58);
            workerList.Name = "workerList";
            workerList.Size = new Size(395, 452);
            workerList.TabIndex = 10;
            workerList.SelectedIndexChanged += workerList_SelectedIndexChanged;
            // 
            // nutritionPlanLabel
            // 
            nutritionPlanLabel.Anchor = AnchorStyles.None;
            nutritionPlanLabel.AutoSize = true;
            nutritionPlanLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nutritionPlanLabel.ForeColor = Color.Black;
            nutritionPlanLabel.Location = new Point(576, 57);
            nutritionPlanLabel.Name = "nutritionPlanLabel";
            nutritionPlanLabel.Size = new Size(144, 28);
            nutritionPlanLabel.TabIndex = 11;
            nutritionPlanLabel.Text = "Mitybos Planas";
            // 
            // nutritionPlanDBlabel
            // 
            nutritionPlanDBlabel.Anchor = AnchorStyles.None;
            nutritionPlanDBlabel.AutoSize = true;
            nutritionPlanDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nutritionPlanDBlabel.ForeColor = Color.Black;
            nutritionPlanDBlabel.Location = new Point(576, 104);
            nutritionPlanDBlabel.Name = "nutritionPlanDBlabel";
            nutritionPlanDBlabel.Size = new Size(0, 28);
            nutritionPlanDBlabel.TabIndex = 12;
            // 
            // beginLabel
            // 
            beginLabel.Anchor = AnchorStyles.None;
            beginLabel.AutoSize = true;
            beginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            beginLabel.ForeColor = Color.Black;
            beginLabel.Location = new Point(576, 161);
            beginLabel.Name = "beginLabel";
            beginLabel.Size = new Size(76, 28);
            beginLabel.TabIndex = 13;
            beginLabel.Text = "Pradžia";
            // 
            // endLabel
            // 
            endLabel.Anchor = AnchorStyles.None;
            endLabel.AutoSize = true;
            endLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            endLabel.ForeColor = Color.Black;
            endLabel.Location = new Point(747, 161);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(81, 28);
            endLabel.TabIndex = 14;
            endLabel.Text = "Pabaiga";
            // 
            // beginDBlabel
            // 
            beginDBlabel.Anchor = AnchorStyles.None;
            beginDBlabel.AutoSize = true;
            beginDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            beginDBlabel.ForeColor = Color.Black;
            beginDBlabel.Location = new Point(576, 213);
            beginDBlabel.Name = "beginDBlabel";
            beginDBlabel.Size = new Size(0, 28);
            beginDBlabel.TabIndex = 15;
            // 
            // endDBlabel
            // 
            endDBlabel.Anchor = AnchorStyles.None;
            endDBlabel.AutoSize = true;
            endDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            endDBlabel.ForeColor = Color.Black;
            endDBlabel.Location = new Point(747, 213);
            endDBlabel.Name = "endDBlabel";
            endDBlabel.Size = new Size(0, 28);
            endDBlabel.TabIndex = 16;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.None;
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.ForeColor = Color.Black;
            priceLabel.Location = new Point(576, 268);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(64, 28);
            priceLabel.TabIndex = 17;
            priceLabel.Text = "Kaina:";
            // 
            // priceDBlabel
            // 
            priceDBlabel.Anchor = AnchorStyles.None;
            priceDBlabel.AutoSize = true;
            priceDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            priceDBlabel.ForeColor = Color.Black;
            priceDBlabel.Location = new Point(747, 268);
            priceDBlabel.Name = "priceDBlabel";
            priceDBlabel.Size = new Size(0, 28);
            priceDBlabel.TabIndex = 18;
            // 
            // foodData
            // 
            foodData.Anchor = AnchorStyles.None;
            foodData.BackgroundColor = SystemColors.Control;
            foodData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            foodData.Location = new Point(576, 376);
            foodData.Name = "foodData";
            foodData.RowHeadersWidth = 51;
            foodData.RowTemplate.Height = 29;
            foodData.Size = new Size(408, 134);
            foodData.TabIndex = 19;
            // 
            // foodLabel
            // 
            foodLabel.Anchor = AnchorStyles.None;
            foodLabel.AutoSize = true;
            foodLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            foodLabel.ForeColor = Color.Black;
            foodLabel.Location = new Point(576, 331);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new Size(94, 28);
            foodLabel.TabIndex = 20;
            foodLabel.Text = "Patiekalai";
            // 
            // NutritionPlanView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1082, 585);
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
            ForeColor = Color.Silver;
            Name = "NutritionPlanView";
            Text = "NutritionPlanView";
            ((System.ComponentModel.ISupportInitialize)foodData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox workerList;
        private Label nutritionPlanLabel;
        private Label nutritionPlanDBlabel;
        private Label beginLabel;
        private Label endLabel;
        private Label beginDBlabel;
        private Label endDBlabel;
        private Label priceLabel;
        private Label priceDBlabel;
        private DataGridView foodData;
        private Label foodLabel;
    }
}