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
    public partial class EditForm : Form
    {
        private Product _product;
        private StorageList _storage;

        public EditForm()
        {
            InitializeComponent();

        }
        public EditForm(Product product, StorageList storage)
        {
            InitializeComponent();

            this.MinimumSize = new Size(779, 537);
            this.MaximumSize = new Size(int.MaxValue, 537);

            /*this.FormBorderStyle = FormBorderStyle.FixedSingle;*/

            _product = product;
            _storage = storage;

            textBoxName.Text = _product.Name;
            textBoxUnit.Text = _product.Unit;
            textBoxPrice.Text = _product.Price.ToString();
            textBoxQuantity.Text = _product.Quantity.ToString();
            textBoxDay.Text = _product.LastDeliveryDate.Day.ToString();
            textBoxMonth.Text = _product.LastDeliveryDate.Month.ToString();
            textBoxYear.Text = _product.LastDeliveryDate.Year.ToString();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    MessageBox.Show("Введіть назву товару.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxUnit.Text))
                {
                    MessageBox.Show("Введіть одиницю виміру товару.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(textBoxPrice.Text, out double price) || price <= 0)
                {
                    MessageBox.Show("Введіть коректну ціну.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textBoxQuantity.Text, out int quantity) || quantity <= 0)
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
                    MessageBox.Show("Введіть коректну дату постачання.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _product.Name = textBoxName.Text;
                _product.Unit = textBoxUnit.Text;
                _product.Price = double.Parse(textBoxPrice.Text);
                _product.Quantity = int.Parse(textBoxQuantity.Text);
                _product.LastDeliveryDate = new DateTime(
                    int.Parse(textBoxYear.Text),
                    int.Parse(textBoxMonth.Text),
                    int.Parse(textBoxDay.Text));

                _storage.SaveProducts("data.txt");
                MessageBox.Show("Дані товару оновлено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви дійсно хочете видалити товар?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _storage.Products.Remove(_product);
                _storage.SaveProducts("data.txt");
                MessageBox.Show("Товар видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            if (textBoxName.Text == _product.Name && textBoxUnit.Text == _product.Unit &&
            textBoxPrice.Text == _product.Price.ToString() && textBoxQuantity.Text == _product.Quantity.ToString() &&
            textBoxDay.Text == _product.LastDeliveryDate.Day.ToString() &&
            textBoxMonth.Text == _product.LastDeliveryDate.Month.ToString() &&
            textBoxYear.Text == _product.LastDeliveryDate.Year.ToString())
                this.Close();
            else
            {
                var case2 = MessageBox.Show("Ви впевнені, що хочете скасувати зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (case2 == DialogResult.Yes)
                    this.Close();
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}