namespace StorageApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            buttonReset = new Button();
            label2 = new Label();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            button2 = new Button();
            buttonEdit = new Button();
            button4 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonReset);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 115);
            panel1.TabIndex = 0;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Right;
            buttonReset.Font = new Font("Segoe UI", 14F);
            buttonReset.Location = new Point(986, 55);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(161, 51);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "Скинути";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(192, 38);
            label2.TabIndex = 2;
            label2.Text = "Назва товару:";
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Right;
            buttonSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearch.Location = new Point(820, 55);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(160, 51);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 12F);
            textBoxSearch.Location = new Point(213, 11);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(934, 38);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(3, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1149, 452);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(457, 5);
            label1.Name = "label1";
            label1.Size = new Size(245, 45);
            label1.TabIndex = 1;
            label1.Text = "Список товарів";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(265, 526);
            button2.Name = "button2";
            button2.Size = new Size(204, 84);
            button2.TabIndex = 2;
            button2.Text = "Надходження товару";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Bottom;
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(475, 526);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(204, 84);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(685, 526);
            button4.Name = "button4";
            button4.Size = new Size(204, 84);
            button4.TabIndex = 4;
            button4.Text = "Відгрузка товару";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(buttonEdit);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(0, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 615);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 728);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головне меню";
            FormClosing += MainForm_FormClosing_1;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Label label2;
        private Button buttonReset;
        private ListBox listBox1;
        private Label label1;
        private Button button2;
        private Button buttonEdit;
        private Button button4;
        private Panel panel2;
    }
}
