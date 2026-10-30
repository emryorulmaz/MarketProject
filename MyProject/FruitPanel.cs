using AForge.Video.DirectShow;
using MyProject.controller;
using MyProject.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MyProject
{
    public partial class FruitPanel : Form
    {
        FilterInfoCollection filterInfo;
        VideoCaptureDevice videoCaptureDevice;
        int number1;
        int number2;
        int processType;


        public FruitPanel()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (calculatorTextBox.Text == "0")
            {
                calculatorTextBox.Text = "";
            }
            calculatorTextBox.Text += ((Button)sender).Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            calculatorTextBox.Text = "0";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (processType == 1)
            {
                number2 = int.Parse(calculatorTextBox.Text.ToString());
                int result = number1 + number2;
                calculatorTextBox.Text = result.ToString();
            }
            if (processType == 2)
            {
                number2 = int.Parse(calculatorTextBox.Text.ToString());
                int result = number1 - number2;
                calculatorTextBox.Text = result.ToString();
            }
            if (processType == 3)
            {
                number2 = int.Parse(calculatorTextBox.Text.ToString());
                int result = number1 * number2;
                calculatorTextBox.Text = result.ToString();
            }
            if (processType == 4)
            {
                number2 = int.Parse(calculatorTextBox.Text.ToString());
                int result = number1 / number2;
                calculatorTextBox.Text = result.ToString();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(calculatorTextBox.Text.ToString());
            processType = 1;
            calculatorTextBox.Text = "0";


        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(calculatorTextBox.Text.ToString());
            processType = 2;
            calculatorTextBox.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(calculatorTextBox.Text.ToString());
            processType = 4;
            calculatorTextBox.Text = "0";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(calculatorTextBox.Text.ToString());
            processType = 3;
            calculatorTextBox.Text = "0";
        }

        private void FruitPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
           

            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo cameras in filterInfo)
            {
                chooseCameraComboBox.Items.Add(cameras.Name);
            }

            if (chooseCameraComboBox.Items.Count > 0)
            {
                chooseCameraComboBox.SelectedIndex = 0;
            }

        }


        private void turnOnCameraButton_Click(object sender, EventArgs e)
        {

            


            videoCaptureDevice = new VideoCaptureDevice(filterInfo[chooseCameraComboBox.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();


            if (chooseCameraComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("No camera found.");
                return;
            }

        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.Hour.ToString() + "/";
            labelMinute.Text = DateTime.Now.Minute.ToString() + "/";
            labelSecond.Text = DateTime.Now.Second.ToString();

            if (pictureBoxCamera.Image != null && pictureBoxCamera.Image != Properties.Resources.blackk)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBoxCamera.Image);

                if (result != null)
                {
                    textBox1.Text = result.ToString();

                }
            }
        }

        private void turnOffCameraButton_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
            pictureBoxCamera.Image = Properties.Resources.blackk;

        }

        private void pictureBoxCamera_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            Product product = controller.GetProduct(textBox1.Text);
            calculatorTextBox.Text = product.price.ToString();
            productNameLabel.Text = product.productName.ToString();
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "barcode.wav";
            soundPlayer.Play();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
