using StorageApp1.Classes;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StorageApp1.Forms
{
    public partial class RevenueInvoice : Form
    {
        private StorageList storage;
        private double totalPrice;

        public RevenueInvoice()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.RevenueInvoice_Load);

            this.MinimumSize = new Size(811, 537);
            this.MaximumSize = new Size(int.MaxValue, 537);

            /*var currentDate = DateTime.Now;*/
            storage = new StorageList();
            storage.LoadProducts("data.txt");

            foreach (var product in storage.Products)
            {
                comboBoxName.Items.Add(product.Name);
            }
            /*textBoxName.TextChanged += textBoxName_TextChanged;*/
            comboBoxName.SelectedIndexChanged += comboBoxName_SelectedIndexChanged;


            // Встановлюємо поточну дату
            /*textBoxDay.Text = currentDate.Day.ToString();
            textBoxMonth.Text = currentDate.Month.ToString();
            textBoxYear.Text = currentDate.Year.ToString();*/
            RefreshDateTextBoxes();

            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            textBoxCount.TextChanged += textBoxCount_TextChanged;
        }

        private void RevenueInvoice_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => comboBoxName.Focus()));
        }


        private void textBoxDay_TextChanged(object sender, EventArgs e)
        {
        }

        private void RevenueInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = comboBoxName.Text;
            string unit = textBoxUnit.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введіть назву товару.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(unit))
            {
                MessageBox.Show("Введіть одиницю виміру товару.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(textBoxPrice.Text, out double price) || price <= 0)
            {
                MessageBox.Show("Введіть коректну ціну.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string formattedPrice = price.ToString("F2");

            if (!int.TryParse(textBoxCount.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введіть коректну кількість.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxDay.Text, out int day) || !int.TryParse(textBoxMonth.Text, out int month) || !int.TryParse(textBoxYear.Text, out int year))
            {
                MessageBox.Show("Введіть коректну дату.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime currentDate = DateTime.Now;
            if (!DateTime.TryParse($"{year}-{month}-{day}", out DateTime deliveryDate) || deliveryDate > currentDate)
            {
                MessageBox.Show("Введіть коректну дату.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*проводимо перевірку, чи існує товар з такою ж назвою, одиницею виміру та ціною*/
            var existingProduct = storage.Products
                .FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                                     p.Unit.Equals(unit, StringComparison.OrdinalIgnoreCase) &&
                                     p.Price == price);

            if (existingProduct != null)
            {
                existingProduct.Quantity += quantity;
                existingProduct.LastDeliveryDate = deliveryDate;

                MessageBox.Show("Товар успішно оновлений.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshTextBoxes();
            }
            else
            {
                Product product = new Product(name, unit, price, quantity, deliveryDate);
                storage.Products.Add(product);

                MessageBox.Show("Товар успішно доданий.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshTextBoxes();
            }

            storage.SaveProducts("data.txt");

            comboBoxName.Items.Clear();

            foreach (var product in storage.Products)
            {
                comboBoxName.Items.Add(product.Name);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxName.Text) || !string.IsNullOrWhiteSpace(textBoxUnit.Text) ||
                !string.IsNullOrWhiteSpace(textBoxPrice.Text) || !string.IsNullOrWhiteSpace(textBoxCount.Text))
            {
                var result = MessageBox.Show("Чи дійсно ви хочете перейти на головну форму?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            MainForm main = new MainForm();
            this.Hide();
            main.Show();
        }

        /*private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            string enteredName = textBoxName.Text;

            var existingProduct = storage.Products.FirstOrDefault(p => p.Name.Equals(enteredName, StringComparison.OrdinalIgnoreCase));

            if (existingProduct != null)
            {
                textBoxUnit.Text = existingProduct.Unit;
                textBoxPrice.Text = existingProduct.Price.ToString();
            }
        }*/

        private void RevenueInvoice_Load_1(object sender, EventArgs e)
        {

        }

        private void RefreshTextBoxes()
        {
            comboBoxName.Text = null;
            textBoxUnit.Text = null;
            textBoxPrice.Text = null;
            textBoxCount.Text = null;

            RefreshDateTextBoxes();
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void RefreshDateTextBoxes()
        {
            var currentDate = DateTime.Now;

            textBoxDay.Text = currentDate.Day.ToString();
            textBoxMonth.Text = currentDate.Month.ToString();
            textBoxYear.Text = currentDate.Year.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxSaveToXml_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void CalculateTotalPrice()
        {
            if (double.TryParse(textBoxPrice.Text, out double price) && int.TryParse(textBoxCount.Text, out int quantity))
            {
                totalPrice = price * quantity;
                labelTotalShipmentPrice.Text = $"{totalPrice:F2} грн";
            }
            else
            {
                labelTotalShipmentPrice.Text = "0,00 грн";
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = comboBoxName.SelectedItem.ToString();
            var existingProduct = storage.Products.FirstOrDefault(p => p.Name.Equals(selectedName, StringComparison.OrdinalIgnoreCase));

            if (existingProduct != null)
            {
                textBoxUnit.Text = existingProduct.Unit;
                textBoxPrice.Text = existingProduct.Price.ToString();
            }
        }

        private void comboBoxName_TextChanged(object sender, EventArgs e)
        {
            string enteredName = comboBoxName.Text;
            var existingProduct = storage.Products.FirstOrDefault(p => p.Name.Equals(enteredName, StringComparison.OrdinalIgnoreCase));

            if (existingProduct != null)
            {
                textBoxUnit.Text = existingProduct.Unit;
                textBoxPrice.Text = existingProduct.Price.ToString();
            }
            else
            {
                textBoxUnit.Text = null;
                textBoxPrice.Text = null;
            }
        }
    }
}
