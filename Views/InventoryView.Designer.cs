namespace Sporto_klubai.Views
{
    partial class InventoryView
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
            inventoryLabel = new Label();
            inventoryData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)inventoryData).BeginInit();
            SuspendLayout();
            // 
            // gymList
            // 
            gymList.Anchor = AnchorStyles.None;
            gymList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gymList.FormattingEnabled = true;
            gymList.ItemHeight = 28;
            gymList.Location = new Point(74, 55);
            gymList.Name = "gymList";
            gymList.Size = new Size(395, 424);
            gymList.TabIndex = 10;
            gymList.SelectedIndexChanged += gymList_SelectedIndexChanged;
            // 
            // inventoryLabel
            // 
            inventoryLabel.Anchor = AnchorStyles.None;
            inventoryLabel.AutoSize = true;
            inventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryLabel.Location = new Point(551, 60);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(109, 28);
            inventoryLabel.TabIndex = 11;
            inventoryLabel.Text = "Inventorius";
            // 
            // inventoryData
            // 
            inventoryData.Anchor = AnchorStyles.None;
            inventoryData.BackgroundColor = Color.White;
            inventoryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryData.Location = new Point(551, 104);
            inventoryData.Name = "inventoryData";
            inventoryData.RowHeadersWidth = 51;
            inventoryData.RowTemplate.Height = 29;
            inventoryData.Size = new Size(469, 375);
            inventoryData.TabIndex = 12;
            // 
            // InventoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1082, 585);
            Controls.Add(inventoryData);
            Controls.Add(inventoryLabel);
            Controls.Add(gymList);
            Name = "InventoryView";
            Text = "InventoryView";
            ((System.ComponentModel.ISupportInitialize)inventoryData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox gymList;
        private Label inventoryLabel;
        private DataGridView inventoryData;
    }
}