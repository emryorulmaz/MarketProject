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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User result = controller.Login(userNameTextBox.Text, passwordTextBox.Text);

            if (result != null && result.status == LoginStatus.Successful && result.authority == "admin")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else if (result != null && result.status == LoginStatus.Successful && result.authority == "cashier")
            {
                CashierPanel cashierPanel = new CashierPanel();
                cashierPanel.Show();
                this.Hide();
            }
            else if (result != null && result.status == LoginStatus.UnSuccessful)
            {
                MessageBox.Show("There is no such a record");
            }
            else
            {
                MessageBox.Show("Error Occured");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
            this.Hide();
        }

        
    }
}
