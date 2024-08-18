namespace StorageApp1.Forms
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            panel1 = new Panel();
            label8 = new Label();
            buttonDelete = new Button();
            buttonCancel = new Button();
            buttonRefresh = new Button();
            textBoxYear = new TextBox();
            textBoxMonth = new TextBox();
            textBoxDay = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBoxQuantity = new TextBox();
            textBoxPrice = new TextBox();
            textBoxUnit = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(textBoxYear);
            panel1.Controls.Add(textBoxMonth);
            panel1.Controls.Add(textBoxDay);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxQuantity);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(textBoxUnit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 481);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(3, 201);
            label8.Name = "label8";
            label8.Size = new Size(369, 38);
            label8.TabIndex = 17;
            label8.Text = "Дата останнього завезення:";
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(510, 391);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(237, 78);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click_1;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom;
            buttonCancel.Font = new Font("Segoe UI", 12F);
            buttonCancel.Location = new Point(261, 391);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(237, 78);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click_1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Bottom;
            buttonRefresh.Font = new Font("Segoe UI", 12F);
            buttonRefresh.Location = new Point(12, 391);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(237, 78);
            buttonRefresh.TabIndex = 14;
            buttonRefresh.Text = "Оновити";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click_1;
            // 
            // textBoxYear
            // 
            textBoxYear.BorderStyle = BorderStyle.FixedSingle;
            textBoxYear.Font = new Font("Segoe UI", 10F);
            textBoxYear.Location = new Point(117, 337);
            textBoxYear.Multiline = true;
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(117, 32);
            textBoxYear.TabIndex = 13;
            textBoxYear.TextChanged += textBoxYear_TextChanged;
            // 
            // textBoxMonth
            // 
            textBoxMonth.BorderStyle = BorderStyle.FixedSingle;
            textBoxMonth.Font = new Font("Segoe UI", 10F);
            textBoxMonth.Location = new Point(117, 296);
            textBoxMonth.Multiline = true;
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(117, 32);
            textBoxMonth.TabIndex = 12;
            // 
            // textBoxDay
            // 
            textBoxDay.BorderStyle = BorderStyle.FixedSingle;
            textBoxDay.Font = new Font("Segoe UI", 10F);
            textBoxDay.Location = new Point(117, 255);
            textBoxDay.Multiline = true;
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(117, 32);
            textBoxDay.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 337);
            label7.Name = "label7";
            label7.Size = new Size(50, 32);
            label7.TabIndex = 10;
            label7.Text = "Рік:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 296);
            label6.Name = "label6";
            label6.Size = new Size(96, 32);
            label6.TabIndex = 9;
            label6.Text = "Місяць:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 255);
            label5.Name = "label5";
            label5.Size = new Size(75, 32);
            label5.TabIndex = 8;
            label5.Text = "День:";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxQuantity.BorderStyle = BorderStyle.FixedSingle;
            textBoxQuantity.Font = new Font("Segoe UI", 12F);
            textBoxQuantity.Location = new Point(167, 153);
            textBoxQuantity.Multiline = true;
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(584, 38);
            textBoxQuantity.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrice.Font = new Font("Segoe UI", 12F);
            textBoxPrice.Location = new Point(167, 105);
            textBoxPrice.Multiline = true;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(584, 38);
            textBoxPrice.TabIndex = 6;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // textBoxUnit
            // 
            textBoxUnit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUnit.BorderStyle = BorderStyle.FixedSingle;
            textBoxUnit.Font = new Font("Segoe UI", 12F);
            textBoxUnit.Location = new Point(167, 57);
            textBoxUnit.Multiline = true;
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.Size = new Size(584, 38);
            textBoxUnit.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(3, 153);
            label4.Name = "label4";
            label4.Size = new Size(134, 38);
            label4.TabIndex = 4;
            label4.Text = "Кількість:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 105);
            label3.Name = "label3";
            label3.Size = new Size(81, 38);
            label3.TabIndex = 3;
            label3.Text = "Ціна:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(161, 38);
            label2.TabIndex = 2;
            label2.Text = "Од. виміру:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(167, 9);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(584, 38);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 38);
            label1.TabIndex = 0;
            label1.Text = "Назва:";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 481);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редагування";
            Load += EditForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxQuantity;
        private TextBox textBoxPrice;
        private TextBox textBoxUnit;
        private TextBox textBoxMonth;
        private TextBox textBoxDay;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button buttonRefresh;
        private TextBox textBoxYear;
        private Button buttonCancel;
        private Button buttonDelete;
        private Label label8;
    }
}