namespace StorageApp1.Forms
{
    partial class RevenueInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueInvoice));
            textBoxYear = new TextBox();
            textBoxMonth = new TextBox();
            textBoxDay = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBoxCount = new TextBox();
            label4 = new Label();
            textBoxPrice = new TextBox();
            label3 = new Label();
            textBoxUnit = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            comboBoxName = new ComboBox();
            labelTotalShipmentPrice = new Label();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxYear
            // 
            textBoxYear.BorderStyle = BorderStyle.FixedSingle;
            textBoxYear.Font = new Font("Segoe UI", 10F);
            textBoxYear.Location = new Point(111, 348);
            textBoxYear.Multiline = true;
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(115, 32);
            textBoxYear.TabIndex = 16;
            // 
            // textBoxMonth
            // 
            textBoxMonth.BorderStyle = BorderStyle.FixedSingle;
            textBoxMonth.Font = new Font("Segoe UI", 10F);
            textBoxMonth.Location = new Point(111, 310);
            textBoxMonth.Multiline = true;
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(115, 32);
            textBoxMonth.TabIndex = 15;
            // 
            // textBoxDay
            // 
            textBoxDay.BorderStyle = BorderStyle.FixedSingle;
            textBoxDay.Font = new Font("Segoe UI", 10F);
            textBoxDay.Location = new Point(111, 272);
            textBoxDay.Multiline = true;
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(115, 32);
            textBoxDay.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 348);
            label7.Name = "label7";
            label7.Size = new Size(50, 32);
            label7.TabIndex = 13;
            label7.Text = "Рік:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 310);
            label6.Name = "label6";
            label6.Size = new Size(96, 32);
            label6.TabIndex = 12;
            label6.Text = "Місяць:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(11, 272);
            label5.Name = "label5";
            label5.Size = new Size(75, 32);
            label5.TabIndex = 11;
            label5.Text = "День:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(403, 393);
            button2.Name = "button2";
            button2.Size = new Size(237, 78);
            button2.TabIndex = 9;
            button2.Text = "Головне меню";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(146, 393);
            button1.Name = "button1";
            button1.Size = new Size(237, 78);
            button1.TabIndex = 8;
            button1.Text = "Зареєструвати / Оновити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBoxCount
            // 
            textBoxCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCount.BorderStyle = BorderStyle.FixedSingle;
            textBoxCount.Font = new Font("Segoe UI", 12F);
            textBoxCount.Location = new Point(209, 178);
            textBoxCount.Multiline = true;
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(574, 38);
            textBoxCount.TabIndex = 7;
            textBoxCount.TextChanged += textBoxCount_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(11, 175);
            label4.Name = "label4";
            label4.Size = new Size(134, 38);
            label4.TabIndex = 6;
            label4.Text = "Кількість:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrice.Font = new Font("Segoe UI", 12F);
            textBoxPrice.Location = new Point(209, 123);
            textBoxPrice.Multiline = true;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(574, 38);
            textBoxPrice.TabIndex = 5;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(11, 120);
            label3.Name = "label3";
            label3.Size = new Size(81, 38);
            label3.TabIndex = 4;
            label3.Text = "Ціна:";
            // 
            // textBoxUnit
            // 
            textBoxUnit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxUnit.BorderStyle = BorderStyle.FixedSingle;
            textBoxUnit.Font = new Font("Segoe UI", 12F);
            textBoxUnit.Location = new Point(210, 69);
            textBoxUnit.Multiline = true;
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.Size = new Size(574, 38);
            textBoxUnit.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(161, 38);
            label2.TabIndex = 2;
            label2.Text = "Од. виміру:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxName);
            panel1.Controls.Add(labelTotalShipmentPrice);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBoxYear);
            panel1.Controls.Add(textBoxMonth);
            panel1.Controls.Add(textBoxDay);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxCount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxUnit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 481);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // comboBoxName
            // 
            comboBoxName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxName.Font = new Font("Segoe UI", 12F);
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(209, 16);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(574, 40);
            comboBoxName.TabIndex = 20;
            comboBoxName.SelectedIndexChanged += comboBoxName_SelectedIndexChanged;
            comboBoxName.TextChanged += comboBoxName_TextChanged;
            // 
            // labelTotalShipmentPrice
            // 
            labelTotalShipmentPrice.AutoSize = true;
            labelTotalShipmentPrice.Font = new Font("Segoe UI", 12F);
            labelTotalShipmentPrice.Location = new Point(403, 272);
            labelTotalShipmentPrice.Name = "labelTotalShipmentPrice";
            labelTotalShipmentPrice.Size = new Size(0, 32);
            labelTotalShipmentPrice.TabIndex = 19;
            labelTotalShipmentPrice.TextChanged += labelTotalPrice_TextChanged;
            labelTotalShipmentPrice.Click += labelTotalPrice_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(403, 231);
            label9.Name = "label9";
            label9.Size = new Size(169, 32);
            label9.TabIndex = 18;
            label9.Text = "Загальна ціна:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(11, 231);
            label8.Name = "label8";
            label8.Size = new Size(225, 32);
            label8.TabIndex = 17;
            label8.Text = "Дата надходження:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 0;
            label1.Text = "Назва товару:";
            // 
            // RevenueInvoice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 481);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RevenueInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Прибуткова накладна";
            FormClosing += RevenueInvoice_FormClosing;
            Load += RevenueInvoice_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxYear;
        private TextBox textBoxMonth;
        private TextBox textBoxDay;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button2;
        private Button button1;
        private TextBox textBoxCount;
        private Label label4;
        private TextBox textBoxPrice;
        private Label label3;
        private TextBox textBoxUnit;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label labelTotalShipmentPrice;
        private ComboBox comboBoxName;
    }
}