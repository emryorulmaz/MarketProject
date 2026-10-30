namespace MyProject
{
    partial class ProductPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.kiloTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(757, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(431, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Price";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(449, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 49);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kilo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTextBox.Location = new System.Drawing.Point(404, 201);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 23);
            this.emailTextBox.TabIndex = 29;
            this.emailTextBox.Text = "Product Name";
            this.emailTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 50);
            this.label3.TabIndex = 28;
            this.label3.Text = "Barcode Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(562, 299);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(207, 22);
            this.priceTextBox.TabIndex = 36;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(562, 202);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.productNameTextBox.TabIndex = 35;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(130, 202);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(207, 22);
            this.idTextBox.TabIndex = 33;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(403, 454);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(314, 44);
            this.deleteUserButton.TabIndex = 42;
            this.deleteUserButton.Text = "Delete ";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(60, 454);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(314, 44);
            this.updateButton.TabIndex = 41;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(226, 404);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(314, 44);
            this.addUserButton.TabIndex = 40;
            this.addUserButton.Text = "Add New Product";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(131, 249);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(206, 22);
            this.barcodeTextBox.TabIndex = 43;
            // 
            // kiloTextBox
            // 
            this.kiloTextBox.Location = new System.Drawing.Point(562, 250);
            this.kiloTextBox.Name = "kiloTextBox";
            this.kiloTextBox.Size = new System.Drawing.Size(207, 22);
            this.kiloTextBox.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(627, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 48;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kiloTextBox);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductPanel";
            this.Load += new System.EventHandler(this.ProductPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox kiloTextBox;
        private System.Windows.Forms.Button button1;
    }
}