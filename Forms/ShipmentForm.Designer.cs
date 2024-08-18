namespace StorageApp1.Forms
{
    partial class ShipmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentForm));
            panel1 = new Panel();
            labelTotalShipmentPrice = new Label();
            label9 = new Label();
            buttonCancel = new Button();
            button1 = new Button();
            label3 = new Label();
            textBoxQuantity = new TextBox();
            label2 = new Label();
            labelProductInfo = new Label();
            label1 = new Label();
            comboBoxProducts = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTotalShipmentPrice);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxQuantity);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelProductInfo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxProducts);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 358);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // labelTotalShipmentPrice
            // 
            labelTotalShipmentPrice.AutoSize = true;
            labelTotalShipmentPrice.Font = new Font("Segoe UI", 14F);
            labelTotalShipmentPrice.Location = new Point(201, 204);
            labelTotalShipmentPrice.Name = "labelTotalShipmentPrice";
            labelTotalShipmentPrice.Size = new Size(0, 38);
            labelTotalShipmentPrice.TabIndex = 21;
            labelTotalShipmentPrice.Click += labelTotalShipmentPrice_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(12, 204);
            label9.Name = "label9";
            label9.Size = new Size(198, 38);
            label9.TabIndex = 20;
            label9.Text = "Загальна ціна:";
            label9.Click += label9_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom;
            buttonCancel.Font = new Font("Segoe UI", 14F);
            buttonCancel.Location = new Point(320, 269);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(292, 77);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Головне меню";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(12, 269);
            button1.Name = "button1";
            button1.Size = new Size(292, 77);
            button1.TabIndex = 8;
            button1.Text = "Відвантажити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(169, 38);
            label3.TabIndex = 7;
            label3.Text = "Інформація:";
            label3.Click += label3_Click;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxQuantity.BorderStyle = BorderStyle.FixedSingle;
            textBoxQuantity.Font = new Font("Segoe UI", 12F);
            textBoxQuantity.Location = new Point(332, 153);
            textBoxQuantity.Multiline = true;
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(280, 38);
            textBoxQuantity.TabIndex = 6;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(314, 38);
            label2.TabIndex = 5;
            label2.Text = "Кількість для відгрузки:";
            // 
            // labelProductInfo
            // 
            labelProductInfo.AutoSize = true;
            labelProductInfo.Font = new Font("Segoe UI", 14F);
            labelProductInfo.Location = new Point(187, 66);
            labelProductInfo.Name = "labelProductInfo";
            labelProductInfo.Size = new Size(0, 38);
            labelProductInfo.TabIndex = 4;
            labelProductInfo.Click += labelProductInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(214, 38);
            label1.TabIndex = 3;
            label1.Text = "Виберіть товар:";
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducts.Font = new Font("Segoe UI", 12F);
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(232, 10);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(380, 40);
            comboBoxProducts.TabIndex = 2;
            comboBoxProducts.SelectedIndexChanged += comboBoxProducts_SelectedIndexChanged;
            // 
            // ShipmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 358);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShipmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Видаткова накладна";
            FormClosing += ShipmentForm_FormClosing;
            Load += ShipmentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxProducts;
        private Label label1;
        private Label labelProductInfo;
        private TextBox textBoxQuantity;
        private Label label2;
        private Label label3;
        private Button buttonCancel;
        private Button button1;
        private Label labelTotalShipmentPrice;
        private Label label9;
    }
}