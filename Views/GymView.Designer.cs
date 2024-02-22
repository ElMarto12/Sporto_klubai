namespace Sporto_klubai.Views
{
    partial class GymView
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
            workTimeLabel = new Label();
            workTimeData = new DataGridView();
            workerLabel = new Label();
            workerSqlLabel = new Label();
            contactsLabel = new Label();
            phoneNumberLabel = new Label();
            emailLabel = new Label();
            addressLabel = new Label();
            gymList = new ListBox();
            workerLastLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)workTimeData).BeginInit();
            SuspendLayout();
            // 
            // workTimeLabel
            // 
            workTimeLabel.Anchor = AnchorStyles.None;
            workTimeLabel.AutoSize = true;
            workTimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            workTimeLabel.Location = new Point(612, 116);
            workTimeLabel.Name = "workTimeLabel";
            workTimeLabel.Size = new Size(124, 28);
            workTimeLabel.TabIndex = 1;
            workTimeLabel.Text = "Darbo Laikas";
            // 
            // workTimeData
            // 
            workTimeData.Anchor = AnchorStyles.None;
            workTimeData.BackgroundColor = SystemColors.Control;
            workTimeData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            workTimeData.ColumnHeadersHeight = 29;
            workTimeData.Location = new Point(612, 161);
            workTimeData.Name = "workTimeData";
            workTimeData.RowHeadersWidth = 51;
            workTimeData.RowTemplate.Height = 29;
            workTimeData.Size = new Size(501, 125);
            workTimeData.TabIndex = 2;
            // 
            // workerLabel
            // 
            workerLabel.Anchor = AnchorStyles.None;
            workerLabel.AutoSize = true;
            workerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            workerLabel.Location = new Point(612, 323);
            workerLabel.Name = "workerLabel";
            workerLabel.Size = new Size(107, 28);
            workerLabel.TabIndex = 3;
            workerLabel.Text = "Dietologas";
            // 
            // workerSqlLabel
            // 
            workerSqlLabel.Anchor = AnchorStyles.None;
            workerSqlLabel.AutoSize = true;
            workerSqlLabel.Location = new Point(612, 369);
            workerSqlLabel.Name = "workerSqlLabel";
            workerSqlLabel.Size = new Size(0, 20);
            workerSqlLabel.TabIndex = 4;
            // 
            // contactsLabel
            // 
            contactsLabel.Anchor = AnchorStyles.None;
            contactsLabel.AutoSize = true;
            contactsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contactsLabel.Location = new Point(612, 412);
            contactsLabel.Name = "contactsLabel";
            contactsLabel.Size = new Size(96, 28);
            contactsLabel.TabIndex = 5;
            contactsLabel.Text = "Kontaktai";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.None;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(612, 462);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(0, 20);
            phoneNumberLabel.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(612, 514);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(0, 20);
            emailLabel.TabIndex = 7;
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.None;
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(612, 574);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(0, 20);
            addressLabel.TabIndex = 8;
            // 
            // gymList
            // 
            gymList.Anchor = AnchorStyles.None;
            gymList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gymList.FormattingEnabled = true;
            gymList.ItemHeight = 28;
            gymList.Location = new Point(132, 116);
            gymList.Name = "gymList";
            gymList.Size = new Size(395, 424);
            gymList.TabIndex = 9;
            gymList.SelectedIndexChanged += gymList_SelectedIndexChanged;
            // 
            // workerLastLabel
            // 
            workerLastLabel.Anchor = AnchorStyles.None;
            workerLastLabel.AutoSize = true;
            workerLastLabel.Location = new Point(691, 369);
            workerLastLabel.Name = "workerLastLabel";
            workerLastLabel.Size = new Size(0, 20);
            workerLastLabel.TabIndex = 10;
            // 
            // GymView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1201, 718);
            Controls.Add(workerLastLabel);
            Controls.Add(gymList);
            Controls.Add(addressLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(contactsLabel);
            Controls.Add(workerSqlLabel);
            Controls.Add(workerLabel);
            Controls.Add(workTimeData);
            Controls.Add(workTimeLabel);
            Name = "GymView";
            Text = "GymView";
            ((System.ComponentModel.ISupportInitialize)workTimeData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label workTimeLabel;
        private DataGridView workTimeData;
        private Label workerLabel;
        private Label workerSqlLabel;
        private Label contactsLabel;
        private Label phoneNumberLabel;
        private Label emailLabel;
        private Label addressLabel;
        private ListBox gymList;
        private Label workerLastLabel;
    }
}