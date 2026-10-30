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
    public partial class CashierPanel : Form
    {
        public CashierPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void CashierPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.Hour.ToString() + ":";
            labelMinute.Text = DateTime.Now.Minute.ToString() + ":";
            labelSecond.Text = DateTime.Now.Second.ToString();
        }

        private void fruitButton_Click(object sender, EventArgs e)
        {
            FruitPanel fruitPanel = new FruitPanel();
            fruitPanel.Show();
            this.Hide();
        }

        private void vegetableButton_Click(object sender, EventArgs e)
        {

        }
    }
}
