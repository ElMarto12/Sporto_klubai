namespace Sporto_klubai.Views
{
    partial class PersonalData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalData));
            panelPersonalData = new Panel();
            confirm_btn = new Button();
            back_btn = new Button();
            injuryTxt_box = new TextBox();
            injuriesLabel = new Label();
            weightTxt_box = new TextBox();
            heightTxt_box = new TextBox();
            weightLabel = new Label();
            heightLabel = new Label();
            pCodeTxt_box = new TextBox();
            personCodeLabel = new Label();
            bankTxt_box = new TextBox();
            bankLabel = new Label();
            womenRadio = new RadioButton();
            maleRadio = new RadioButton();
            dateLabel = new Label();
            dateTime = new DateTimePicker();
            phoneTxt_box = new TextBox();
            phoneLabel = new Label();
            emailTxt_box = new TextBox();
            emailLabel = new Label();
            panelPersonalData.SuspendLayout();
            SuspendLayout();
            // 
            // panelPersonalData
            // 
            panelPersonalData.Controls.Add(confirm_btn);
            panelPersonalData.Controls.Add(back_btn);
            panelPersonalData.Controls.Add(injuryTxt_box);
            panelPersonalData.Controls.Add(injuriesLabel);
            panelPersonalData.Controls.Add(weightTxt_box);
            panelPersonalData.Controls.Add(heightTxt_box);
            panelPersonalData.Controls.Add(weightLabel);
            panelPersonalData.Controls.Add(heightLabel);
            panelPersonalData.Controls.Add(pCodeTxt_box);
            panelPersonalData.Controls.Add(personCodeLabel);
            panelPersonalData.Controls.Add(bankTxt_box);
            panelPersonalData.Controls.Add(bankLabel);
            panelPersonalData.Controls.Add(womenRadio);
            panelPersonalData.Controls.Add(maleRadio);
            panelPersonalData.Controls.Add(dateLabel);
            panelPersonalData.Controls.Add(dateTime);
            panelPersonalData.Controls.Add(phoneTxt_box);
            panelPersonalData.Controls.Add(phoneLabel);
            panelPersonalData.Controls.Add(emailTxt_box);
            panelPersonalData.Controls.Add(emailLabel);
            panelPersonalData.Dock = DockStyle.Fill;
            panelPersonalData.Location = new Point(0, 0);
            panelPersonalData.Name = "panelPersonalData";
            panelPersonalData.Size = new Size(1087, 590);
            panelPersonalData.TabIndex = 0;
            panelPersonalData.Paint += panelPersonalData_Paint;
            // 
            // confirm_btn
            // 
            confirm_btn.Anchor = AnchorStyles.None;
            confirm_btn.Location = new Point(152, 509);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(796, 58);
            confirm_btn.TabIndex = 19;
            confirm_btn.Text = "Patvirtinti";
            confirm_btn.UseVisualStyleBackColor = true;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // back_btn
            // 
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Image = (Image)resources.GetObject("back_btn.Image");
            back_btn.Location = new Point(28, 24);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(61, 59);
            back_btn.TabIndex = 18;
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // injuryTxt_box
            // 
            injuryTxt_box.Anchor = AnchorStyles.None;
            injuryTxt_box.Location = new Point(640, 371);
            injuryTxt_box.Multiline = true;
            injuryTxt_box.Name = "injuryTxt_box";
            injuryTxt_box.Size = new Size(308, 88);
            injuryTxt_box.TabIndex = 17;
            // 
            // injuriesLabel
            // 
            injuriesLabel.Anchor = AnchorStyles.None;
            injuriesLabel.AutoSize = true;
            injuriesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            injuriesLabel.Location = new Point(640, 331);
            injuriesLabel.Name = "injuriesLabel";
            injuriesLabel.Size = new Size(85, 28);
            injuriesLabel.TabIndex = 16;
            injuriesLabel.Text = "Traumos";
            // 
            // weightTxt_box
            // 
            weightTxt_box.Anchor = AnchorStyles.None;
            weightTxt_box.Location = new Point(773, 261);
            weightTxt_box.Multiline = true;
            weightTxt_box.Name = "weightTxt_box";
            weightTxt_box.Size = new Size(80, 40);
            weightTxt_box.TabIndex = 15;
            // 
            // heightTxt_box
            // 
            heightTxt_box.Anchor = AnchorStyles.None;
            heightTxt_box.Location = new Point(640, 261);
            heightTxt_box.Multiline = true;
            heightTxt_box.Name = "heightTxt_box";
            heightTxt_box.Size = new Size(80, 40);
            heightTxt_box.TabIndex = 14;
            // 
            // weightLabel
            // 
            weightLabel.Anchor = AnchorStyles.None;
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            weightLabel.Location = new Point(773, 220);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(65, 28);
            weightLabel.TabIndex = 13;
            weightLabel.Text = "Svoris";
            // 
            // heightLabel
            // 
            heightLabel.Anchor = AnchorStyles.None;
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            heightLabel.Location = new Point(640, 220);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(51, 28);
            heightLabel.TabIndex = 12;
            heightLabel.Text = "Ūgis";
            // 
            // pCodeTxt_box
            // 
            pCodeTxt_box.Anchor = AnchorStyles.None;
            pCodeTxt_box.Location = new Point(154, 419);
            pCodeTxt_box.Multiline = true;
            pCodeTxt_box.Name = "pCodeTxt_box";
            pCodeTxt_box.Size = new Size(315, 40);
            pCodeTxt_box.TabIndex = 11;
            // 
            // personCodeLabel
            // 
            personCodeLabel.Anchor = AnchorStyles.None;
            personCodeLabel.AutoSize = true;
            personCodeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            personCodeLabel.Location = new Point(154, 384);
            personCodeLabel.Name = "personCodeLabel";
            personCodeLabel.Size = new Size(138, 28);
            personCodeLabel.TabIndex = 10;
            personCodeLabel.Text = "Asmens Kodas";
            // 
            // bankTxt_box
            // 
            bankTxt_box.Anchor = AnchorStyles.None;
            bankTxt_box.Location = new Point(154, 319);
            bankTxt_box.Multiline = true;
            bankTxt_box.Name = "bankTxt_box";
            bankTxt_box.Size = new Size(315, 40);
            bankTxt_box.TabIndex = 9;
            // 
            // bankLabel
            // 
            bankLabel.Anchor = AnchorStyles.None;
            bankLabel.AutoSize = true;
            bankLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bankLabel.Location = new Point(154, 273);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new Size(230, 28);
            bankLabel.TabIndex = 8;
            bankLabel.Text = "Banko Sąskaitos Numeris";
            // 
            // womenRadio
            // 
            womenRadio.Anchor = AnchorStyles.None;
            womenRadio.AutoSize = true;
            womenRadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            womenRadio.Location = new Point(773, 162);
            womenRadio.Name = "womenRadio";
            womenRadio.Size = new Size(100, 32);
            womenRadio.TabIndex = 7;
            womenRadio.TabStop = true;
            womenRadio.Text = "Moteris";
            womenRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            maleRadio.Anchor = AnchorStyles.None;
            maleRadio.AutoSize = true;
            maleRadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maleRadio.Location = new Point(640, 161);
            maleRadio.Name = "maleRadio";
            maleRadio.Size = new Size(80, 32);
            maleRadio.TabIndex = 6;
            maleRadio.TabStop = true;
            maleRadio.Text = "Vyras";
            maleRadio.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.None;
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(635, 55);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(128, 28);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Gimimo Data";
            // 
            // dateTime
            // 
            dateTime.Anchor = AnchorStyles.None;
            dateTime.Location = new Point(635, 100);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(313, 27);
            dateTime.TabIndex = 4;
            // 
            // phoneTxt_box
            // 
            phoneTxt_box.Anchor = AnchorStyles.None;
            phoneTxt_box.Location = new Point(152, 208);
            phoneTxt_box.Multiline = true;
            phoneTxt_box.Name = "phoneTxt_box";
            phoneTxt_box.Size = new Size(315, 40);
            phoneTxt_box.TabIndex = 3;
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = AnchorStyles.None;
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(154, 165);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(164, 28);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "Telefono Numeris";
            // 
            // emailTxt_box
            // 
            emailTxt_box.Anchor = AnchorStyles.None;
            emailTxt_box.Location = new Point(152, 102);
            emailTxt_box.Multiline = true;
            emailTxt_box.Name = "emailTxt_box";
            emailTxt_box.Size = new Size(315, 40);
            emailTxt_box.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(154, 55);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(171, 28);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Elektroninis Paštas";
            // 
            // PersonalData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1087, 590);
            Controls.Add(panelPersonalData);
            Name = "PersonalData";
            Text = "PersonalData";
            panelPersonalData.ResumeLayout(false);
            panelPersonalData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPersonalData;
        private TextBox injuryTxt_box;
        private Label injuriesLabel;
        private TextBox weightTxt_box;
        private TextBox heightTxt_box;
        private Label weightLabel;
        private Label heightLabel;
        private TextBox pCodeTxt_box;
        private Label personCodeLabel;
        private TextBox bankTxt_box;
        private Label bankLabel;
        private RadioButton womenRadio;
        private RadioButton maleRadio;
        private Label dateLabel;
        private DateTimePicker dateTime;
        private TextBox phoneTxt_box;
        private Label phoneLabel;
        private TextBox emailTxt_box;
        private Label emailLabel;
        private Button back_btn;
        private Button confirm_btn;
    }
}