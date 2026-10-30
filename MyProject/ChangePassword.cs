using MyProject.controller;
using MyProject.enumaration;
using MyProject.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

            BringOnlySecurityQuestions();

            //Controller controller = new Controller();
            //List<LoginTable> loginTableList = controller.GetLoginTable();

            //foreach (LoginTable loginTable in loginTableList)
            //{
            //    securityQuestionComboBox.Items.Add(loginTable.securityQuestion.ToString());
            //}


            
        } 


        void BringOnlySecurityQuestions()
        {
            Controller controller = new Controller();
            List<LoginTable> securityQuestionList = controller.BringOnlySecurityQuestions();

            foreach (LoginTable sQ in securityQuestionList)
            {
                securityQuestionComboBox.Items.Add(sQ.securityQuestion.ToString());
            }




            changePasswordGrpBox.Enabled = false;
        }

        private void securityQuestionOKBox_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            LoginStatus result = controller.Authorize(usernameTextBox.Text, securityQuestionAnswerTextBox.Text.ToLower().Trim(),securityQuestionComboBox.SelectedItem.ToString());
            if(result == LoginStatus.Successful)
            {          
                changePasswordGrpBox.Enabled = true;
                byMailGroupBox.Enabled = false;
            }
            else if (result == LoginStatus.UnSuccessful)
            {
                MessageBox.Show("wrongg");
            }
        }

        private void sendVerificationCodeButton_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int code = random.Next(111111, 999999);
            //MailAddress recipent = new MailAddress(eMailTextBox.Text,"Hey You!");
            //MailAddress mailSender = new MailAddress("deneme_test198@outlook.com","Emre Yorulmaz");
            //MailMessage message = new MailMessage();
            //message.To.Add(recipent);
            //message.From = mailSender;
            //message.Subject = "Password Change";
            //message.Body = "The code to change your password: " + code;

            //SmtpClient smtpClient = new SmtpClient("smtp.live.com",587);
            //smtpClient.Credentials = new System.Net.NetworkCredential("deneme_test198@outlook.com", "Denemeamaclioldugundan1");
            //smtpClient.EnableSsl = true;
            //smtpClient.Send(message);
            //MessageBox.Show("sent");

        }

        private void passwordOKButton_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

             if(newPasswordTextBox.Text == newPasswordAgainTextBox.Text)
            {
                LoginStatus result = controller.ChangePassword(usernameTextBox.Text,newPasswordTextBox.Text);

                if(result == LoginStatus.Successful)
                {
                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("Unsuccessful");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
