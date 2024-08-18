using StorageApp1.Classes;
using StorageApp1.Forms;

namespace StorageApp1
{
    public partial class MainForm : Form
    {

        private StorageList storage;
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1181, 784);


            storage = new StorageList();
            storage.LoadProducts("data.txt");

            DisplayProducts();

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var revInvoice = new RevenueInvoice();
            this.Hide();
            revInvoice.Show();
        }
        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShipmentForm shipmentForm = new ShipmentForm(storage);
            shipmentForm.Show();
            this.Hide();

        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Після закриття форми редагування оновлюємо відображення товарів у списку
            /*storage.ReindexProducts();
            DisplayProducts();*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                buttonEdit.Enabled = true;
            }
            else
            {
                buttonEdit.Enabled = false;
            }
        }


        private void DisplayProducts()
        {
            listBox1.Items.Clear();
            foreach (var product in storage.Products)
            {
                listBox1.Items.Add(product.ToString());
            }
            buttonEdit.Enabled = false;
        }

        private void DisplayProducts(List<Product> products)
        {
            listBox1.Items.Clear();

            foreach (var product in products)
            {
                listBox1.Items.Add(product);
            }
            buttonEdit.Enabled = false;
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedProduct = storage.Products
                    .FirstOrDefault(p => p.ToString() == listBox1.SelectedItem.ToString());

                if (selectedProduct != null)
                {
                    EditForm editForm = new EditForm(selectedProduct, storage);
                    editForm.ShowDialog();

                    storage.ReindexProducts();

                    DisplayProducts();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(search))
            {
                var filteredProducts = storage.Products
                    .Where(p => p.Name.ToLower().Contains(search))
                    .ToList();

                DisplayProducts(filteredProducts);

                switch (filteredProducts.Count)
                {
                    case 0:
                        MessageBox.Show("Нічого не знайдено.", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxSearch.Text = null;
                        DisplayProducts();
                        break;

                    default:
                        MessageBox.Show($"Знайдено кількість товарів: {filteredProducts.Count}. ", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            else
            {
                DisplayProducts();
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = null;
            DisplayProducts();
        }
    }
}
