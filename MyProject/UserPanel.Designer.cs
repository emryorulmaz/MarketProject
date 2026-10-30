namespace MyProject
{
    partial class UserPanel
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailAdressTextBox = new System.Windows.Forms.TextBox();
            this.securityAnswerTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.authorityComboBox = new System.Windows.Forms.ComboBox();
            this.securityQuestionComboBox = new System.Windows.Forms.ComboBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(240, 355);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(314, 44);
            this.addUserButton.TabIndex = 4;
            this.addUserButton.Text = "Add New User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Authority";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(126, 184);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.userNameTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(126, 230);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(207, 22);
            this.passwordTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTextBox.Location = new System.Drawing.Point(390, 180);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 23);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.Text = "Email Address";
            this.emailTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(386, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 49);
            this.label6.TabIndex = 14;
            this.label6.Text = "Security Question";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(390, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Security Answer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailAdressTextBox
            // 
            this.emailAdressTextBox.Location = new System.Drawing.Point(562, 182);
            this.emailAdressTextBox.Name = "emailAdressTextBox";
            this.emailAdressTextBox.Size = new System.Drawing.Size(207, 22);
            this.emailAdressTextBox.TabIndex = 17;
            // 
            // securityAnswerTextBox
            // 
            this.securityAnswerTextBox.Location = new System.Drawing.Point(562, 279);
            this.securityAnswerTextBox.Name = "securityAnswerTextBox";
            this.securityAnswerTextBox.Size = new System.Drawing.Size(207, 22);
            this.securityAnswerTextBox.TabIndex = 19;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(74, 405);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(314, 44);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(417, 405);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(314, 44);
            this.deleteUserButton.TabIndex = 21;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // authorityComboBox
            // 
            this.authorityComboBox.FormattingEnabled = true;
            this.authorityComboBox.Location = new System.Drawing.Point(127, 276);
            this.authorityComboBox.Name = "authorityComboBox";
            this.authorityComboBox.Size = new System.Drawing.Size(206, 24);
            this.authorityComboBox.TabIndex = 22;
            // 
            // securityQuestionComboBox
            // 
            this.securityQuestionComboBox.FormattingEnabled = true;
            this.securityQuestionComboBox.Location = new System.Drawing.Point(563, 227);
            this.securityQuestionComboBox.Name = "securityQuestionComboBox";
            this.securityQuestionComboBox.Size = new System.Drawing.Size(206, 24);
            this.securityQuestionComboBox.TabIndex = 23;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(127, 327);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(206, 22);
            this.IDTextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(635, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 41);
            this.button1.TabIndex = 26;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.securityQuestionComboBox);
            this.Controls.Add(this.authorityComboBox);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.securityAnswerTextBox);
            this.Controls.Add(this.emailAdressTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Panel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label emailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailAdressTextBox;
        private System.Windows.Forms.TextBox securityAnswerTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.ComboBox authorityComboBox;
        private System.Windows.Forms.ComboBox securityQuestionComboBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}