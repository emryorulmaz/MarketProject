namespace MyProject
{
    partial class CashierPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierPanel));
            this.meatButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.drinksButton = new System.Windows.Forms.Button();
            this.vegetableButton = new System.Windows.Forms.Button();
            this.fruitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // meatButton
            // 
            this.meatButton.ImageIndex = 2;
            this.meatButton.ImageList = this.imageList1;
            this.meatButton.Location = new System.Drawing.Point(31, 55);
            this.meatButton.Name = "meatButton";
            this.meatButton.Size = new System.Drawing.Size(152, 146);
            this.meatButton.TabIndex = 0;
            this.meatButton.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fruits.png");
            this.imageList1.Images.SetKeyName(1, "vegetable.png");
            this.imageList1.Images.SetKeyName(2, "beef.png");
            this.imageList1.Images.SetKeyName(3, "water-glass.png");
            // 
            // drinksButton
            // 
            this.drinksButton.ImageIndex = 3;
            this.drinksButton.ImageList = this.imageList1;
            this.drinksButton.Location = new System.Drawing.Point(232, 55);
            this.drinksButton.Name = "drinksButton";
            this.drinksButton.Size = new System.Drawing.Size(152, 146);
            this.drinksButton.TabIndex = 1;
            this.drinksButton.UseVisualStyleBackColor = true;
            // 
            // vegetableButton
            // 
            this.vegetableButton.ImageIndex = 1;
            this.vegetableButton.ImageList = this.imageList1;
            this.vegetableButton.Location = new System.Drawing.Point(31, 241);
            this.vegetableButton.Name = "vegetableButton";
            this.vegetableButton.Size = new System.Drawing.Size(152, 146);
            this.vegetableButton.TabIndex = 2;
            this.vegetableButton.UseVisualStyleBackColor = true;
            this.vegetableButton.Click += new System.EventHandler(this.vegetableButton_Click);
            // 
            // fruitButton
            // 
            this.fruitButton.ImageIndex = 0;
            this.fruitButton.ImageList = this.imageList1;
            this.fruitButton.Location = new System.Drawing.Point(232, 241);
            this.fruitButton.Name = "fruitButton";
            this.fruitButton.Size = new System.Drawing.Size(152, 146);
            this.fruitButton.TabIndex = 3;
            this.fruitButton.UseVisualStyleBackColor = true;
            this.fruitButton.Click += new System.EventHandler(this.fruitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(343, 8);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(21, 16);
            this.labelHour.TabIndex = 5;
            this.labelHour.Text = "12";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(370, 8);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(21, 16);
            this.labelMinute.TabIndex = 6;
            this.labelMinute.Text = "12";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(398, 8);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(21, 16);
            this.labelSecond.TabIndex = 7;
            this.labelSecond.Text = "12";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CashierPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 455);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fruitButton);
            this.Controls.Add(this.vegetableButton);
            this.Controls.Add(this.drinksButton);
            this.Controls.Add(this.meatButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashierPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierPanel";
            this.Load += new System.EventHandler(this.CashierPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button meatButton;
        private System.Windows.Forms.Button drinksButton;
        private System.Windows.Forms.Button vegetableButton;
        private System.Windows.Forms.Button fruitButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Timer timer1;
    }
}