using StorageApp1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageApp1.Forms
{
    public partial class ShipmentForm : Form
    {
        private StorageList _storage;
        private double totalShipmentPrice;
        public ShipmentForm()
        {
            InitializeComponent();
        }

        public ShipmentForm(StorageList storage)
        {
            InitializeComponent();

            this.MinimumSize = new Size(646, 414);
            this.MaximumSize = new Size(int.MaxValue, 414);

            textBoxQuantity.Enabled = false;

            _storage = storage;

            foreach (var product in _storage.Products)
            {
                comboBoxProducts.Items.Add(product.Name);
            }


            comboBoxProducts.SelectedIndexChanged += comboBoxProducts_SelectedIndexChanged;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShipmentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxProducts.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть товар.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedProductName = comboBoxProducts.SelectedItem.ToString();
            var selectedProduct = _storage.Products.FirstOrDefault(p => p.Name == selectedProductName);

            if (selectedProduct != null)
            {
                int quantityToShip;
                if (int.TryParse(textBoxQuantity.Text, out quantityToShip))
                {
                    if (quantityToShip > 0 && quantityToShip <= selectedProduct.Quantity)
                    {
                        selectedProduct.Quantity -= quantityToShip;

                        _storage.SaveProducts("data.txt");

                        labelProductInfo.Text = $"Наявна кількість: {selectedProduct.Quantity} {selectedProduct.Unit}.";

                        textBoxQuantity.Clear();

                        MessageBox.Show("Товар успішно відвантажено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Недостатня кількість товару.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введіть коректну кількість.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateShipmentPrice();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = comboBoxProducts.SelectedItem.ToString();
            var selectedProduct = _storage.Products.FirstOrDefault(p => p.Name == selectedProductName);

            if (selectedProduct != null)
            {
                textBoxQuantity.Enabled = true;
                labelProductInfo.Text = $"Наявна кількість: {selectedProduct.Quantity} {selectedProduct.Unit}. \nЦіна товару: {selectedProduct.Price.ToString("F2")}.";
                CalculateShipmentPrice();
            }
        }

        private void ShipmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelProductInfo_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CalculateShipmentPrice()
        {
            if (comboBoxProducts.SelectedItem != null)
            {
                string selectedProductName = comboBoxProducts.SelectedItem.ToString();
                var selectedProduct = _storage.Products.FirstOrDefault(p => p.Name == selectedProductName);

                if (selectedProduct != null && int.TryParse(textBoxQuantity.Text, out int quantity))
                {
                    totalShipmentPrice = selectedProduct.Price * quantity;
                    labelTotalShipmentPrice.Text = $"{totalShipmentPrice:F2} грн";
                }
                else
                {
                    labelTotalShipmentPrice.Text = "0,00 грн";
                }
            }
            else
            {
                labelTotalShipmentPrice.Text = "0,00 грн";
            }
        }

        private void labelTotalShipmentPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
