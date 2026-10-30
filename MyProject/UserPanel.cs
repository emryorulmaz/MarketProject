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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            authorityComboBox.Items.Add("admin");
            authorityComboBox.Items.Add("cashier");
            BringOnlySecurityQuestions();
            GetLoginTable();
        }

        public void GetLoginTable()
        {
            Controller controller = new Controller();
            List<LoginTable> userList = controller.GetLoginTable();
            
            dataGridView1.DataSource = userList;


            
        }

        public void BringOnlySecurityQuestions()
        {
            Controller controller = new Controller();
            
            foreach (var securityQuestion in controller.BringOnlySecurityQuestions())
            {
                securityQuestionComboBox.Items.Add(securityQuestion.securityQuestion);
            }

        }


        
        private void addUserButton_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User user = new User();
            user.userName = userNameTextBox.Text;
            user.password = passwordTextBox.Text;
            user.authority = authorityComboBox.SelectedItem.ToString();
            user.securityQuestion = securityQuestionComboBox.SelectedItem.ToString();
            user.securityAnswer = securityAnswerTextBox.Text;
            user.emailAdress = emailAdressTextBox.Text;

            LoginStatus result = controller.AddUser(user);

            if(result == LoginStatus.Successful)
            {
                MessageBox.Show("User has been added!");
                dataGridView1.DataSource = controller.GetLoginTable();

                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
                authorityComboBox.Text = "";
                emailAdressTextBox.Text = "";
                securityQuestionComboBox.Text = "";
                securityAnswerTextBox.Text = "";
                IDTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("Error Occured!");
            }
        }

        
       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        


        private void updateButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = userNameTextBox.Text;
            user.password = passwordTextBox.Text;
            user.authority = authorityComboBox.SelectedItem.ToString();
            user.securityQuestion = securityQuestionComboBox.SelectedItem.ToString();
            user.securityAnswer = securityAnswerTextBox.Text;
            user.emailAdress = emailAdressTextBox.Text;
            user.id = int.Parse(IDTextBox.Text);

            Controller controller = new Controller();
            LoginStatus result = controller.UpdateUser(user);

            if(result == LoginStatus.Successful)
            {
                MessageBox.Show("User has been updated!");
                dataGridView1.DataSource = controller.GetLoginTable();

                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
                authorityComboBox.Text = "";
                emailAdressTextBox.Text = "";
                securityQuestionComboBox.Text = "";
                securityAnswerTextBox.Text = "";
                IDTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("User has not been updated!");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTextBox.Text);
            Controller controller = new Controller();
            LoginStatus result = controller.DeleteUser(id);

            if(result == LoginStatus.Successful)
            {
                MessageBox.Show("User has been deleted!");
                dataGridView1.DataSource = controller.GetLoginTable();

                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
                authorityComboBox.Text = "";
                emailAdressTextBox.Text = "";
                securityQuestionComboBox.Text = "";
                securityAnswerTextBox.Text = "";
                IDTextBox.Text = ""; 

            }
            else
            {
                MessageBox.Show("User has not been deleted!");
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
            userNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            passwordTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            authorityComboBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            emailAdressTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            securityQuestionComboBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            securityAnswerTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            IDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
