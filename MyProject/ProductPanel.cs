using MyProject.controller;
using MyProject.enumaration;
using MyProject.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class ProductPanel : Form
    {
        public ProductPanel()
        {
            InitializeComponent();
        }

        private void ProductPanel_Load(object sender, EventArgs e)
        {
            BringAllProducts();
        }

        public void BringAllProducts()
        {
            Controller controller = new Controller();
            dataGridView1.DataSource = controller.BringAllProducts();

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            Product product = new Product();


            product.barcodeNumber = barcodeTextBox.Text;
            product.price = int.Parse(priceTextBox.Text);
            product.kilo = int.Parse(kiloTextBox.Text);
            product.productName = product.id.ToString();


            LoginStatus result = controller.AddProduct(product);

            if (result == LoginStatus.Successful)
            {
                MessageBox.Show("The Product has been added!");
                dataGridView1.DataSource = controller.BringAllProducts();
                idTextBox.Text = "";
                barcodeTextBox.Text = "";
                productNameTextBox.Text = "";
                kiloTextBox.Text = "";
                priceTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Something wrong!");
            }




        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            int id = int.Parse(idTextBox.Text);

            LoginStatus result = controller.DeleteProduct(id);

            if(result == LoginStatus.Successful)
            {
                MessageBox.Show("The Product has been deleted!");
                dataGridView1.DataSource = controller.BringAllProducts();
                idTextBox.Text = "";
                barcodeTextBox.Text = "";
                productNameTextBox.Text = "";
                kiloTextBox.Text = "";
                priceTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Something wrong!");
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            int id;

            if (!int.TryParse(idTextBox.Text, out id))
            {
                MessageBox.Show("Please select a product first.");
                return;
            }



            Product product = new Product();
            product.id = id;

           



            product.productName = productNameTextBox.Text;
            product.price = int.Parse(priceTextBox.Text);
            product.barcodeNumber = barcodeTextBox.Text;
            product.kilo = int.Parse(kiloTextBox.Text);

            LoginStatus result = controller.UpdateProduct(product);

            if(result == LoginStatus.Successful)
            {
                MessageBox.Show("The Product has been updated!");
                dataGridView1.DataSource = controller.BringAllProducts();

                idTextBox.Text = "";
                barcodeTextBox.Text = "";
                productNameTextBox.Text = "";
                kiloTextBox.Text = "";
                priceTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("Something wrong!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            idTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            barcodeTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            productNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kiloTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            priceTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


        }
    }
}
