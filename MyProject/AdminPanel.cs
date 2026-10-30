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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            UserPanel userPanel = new UserPanel();
            userPanel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductPanel productPanel = new ProductPanel();
            productPanel.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
