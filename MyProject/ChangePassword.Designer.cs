namespace MyProject
{
    partial class ChangePassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.securityQuestionOKBox = new System.Windows.Forms.Button();
            this.securityQuestionAnswerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.securityQuestionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changePasswordGrpBox = new System.Windows.Forms.GroupBox();
            this.passwordOKButton = new System.Windows.Forms.Button();
            this.newPasswordAgainTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.byMailGroupBox = new System.Windows.Forms.GroupBox();
            this.mailOKButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.verificationCodeTextBox = new System.Windows.Forms.TextBox();
            this.sendVerificationCodeButton = new System.Windows.Forms.Button();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.changePasswordGrpBox.SuspendLayout();
            this.byMailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.securityQuestionOKBox);
            this.groupBox1.Controls.Add(this.securityQuestionAnswerTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.securityQuestionComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "By Security Question";
            // 
            // securityQuestionOKBox
            // 
            this.securityQuestionOKBox.Location = new System.Drawing.Point(81, 205);
            this.securityQuestionOKBox.Name = "securityQuestionOKBox";
            this.securityQuestionOKBox.Size = new System.Drawing.Size(171, 30);
            this.securityQuestionOKBox.TabIndex = 1;
            this.securityQuestionOKBox.Text = "OK";
            this.securityQuestionOKBox.UseVisualStyleBackColor = true;
            this.securityQuestionOKBox.Click += new System.EventHandler(this.securityQuestionOKBox_Click);
            // 
            // securityQuestionAnswerTextBox
            // 
            this.securityQuestionAnswerTextBox.Location = new System.Drawing.Point(120, 136);
            this.securityQuestionAnswerTextBox.Name = "securityQuestionAnswerTextBox";
            this.securityQuestionAnswerTextBox.Size = new System.Drawing.Size(152, 22);
            this.securityQuestionAnswerTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 62);
            this.label3.TabIndex = 3;
            this.label3.Text = "Security Question Answer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // securityQuestionComboBox
            // 
            this.securityQuestionComboBox.FormattingEnabled = true;
            this.securityQuestionComboBox.Location = new System.Drawing.Point(120, 72);
            this.securityQuestionComboBox.Name = "securityQuestionComboBox";
            this.securityQuestionComboBox.Size = new System.Drawing.Size(152, 24);
            this.securityQuestionComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Security Question";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(120, 21);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(152, 22);
            this.usernameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changePasswordGrpBox
            // 
            this.changePasswordGrpBox.Controls.Add(this.passwordOKButton);
            this.changePasswordGrpBox.Controls.Add(this.newPasswordAgainTextBox);
            this.changePasswordGrpBox.Controls.Add(this.label5);
            this.changePasswordGrpBox.Controls.Add(this.newPasswordTextBox);
            this.changePasswordGrpBox.Controls.Add(this.label4);
            this.changePasswordGrpBox.Location = new System.Drawing.Point(193, 307);
            this.changePasswordGrpBox.Name = "changePasswordGrpBox";
            this.changePasswordGrpBox.Size = new System.Drawing.Size(323, 166);
            this.changePasswordGrpBox.TabIndex = 1;
            this.changePasswordGrpBox.TabStop = false;
            // 
            // passwordOKButton
            // 
            this.passwordOKButton.Location = new System.Drawing.Point(242, 132);
            this.passwordOKButton.Name = "passwordOKButton";
            this.passwordOKButton.Size = new System.Drawing.Size(75, 23);
            this.passwordOKButton.TabIndex = 1;
            this.passwordOKButton.Text = "OK";
            this.passwordOKButton.UseVisualStyleBackColor = true;
            this.passwordOKButton.Click += new System.EventHandler(this.passwordOKButton_Click);
            // 
            // newPasswordAgainTextBox
            // 
            this.newPasswordAgainTextBox.Location = new System.Drawing.Point(104, 101);
            this.newPasswordAgainTextBox.Name = "newPasswordAgainTextBox";
            this.newPasswordAgainTextBox.Size = new System.Drawing.Size(172, 22);
            this.newPasswordAgainTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 69);
            this.label5.TabIndex = 8;
            this.label5.Text = "New Pasword Again";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(104, 30);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(172, 22);
            this.newPasswordTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Pasword";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // byMailGroupBox
            // 
            this.byMailGroupBox.Controls.Add(this.mailOKButton);
            this.byMailGroupBox.Controls.Add(this.label7);
            this.byMailGroupBox.Controls.Add(this.verificationCodeTextBox);
            this.byMailGroupBox.Controls.Add(this.sendVerificationCodeButton);
            this.byMailGroupBox.Controls.Add(this.eMailTextBox);
            this.byMailGroupBox.Controls.Add(this.label6);
            this.byMailGroupBox.Location = new System.Drawing.Point(375, 12);
            this.byMailGroupBox.Name = "byMailGroupBox";
            this.byMailGroupBox.Size = new System.Drawing.Size(339, 289);
            this.byMailGroupBox.TabIndex = 5;
            this.byMailGroupBox.TabStop = false;
            this.byMailGroupBox.Text = "By Mail";
            // 
            // mailOKButton
            // 
            this.mailOKButton.Location = new System.Drawing.Point(167, 180);
            this.mailOKButton.Name = "mailOKButton";
            this.mailOKButton.Size = new System.Drawing.Size(96, 28);
            this.mailOKButton.TabIndex = 10;
            this.mailOKButton.Text = "OK";
            this.mailOKButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Verification Code";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // verificationCodeTextBox
            // 
            this.verificationCodeTextBox.Location = new System.Drawing.Point(138, 143);
            this.verificationCodeTextBox.Name = "verificationCodeTextBox";
            this.verificationCodeTextBox.ReadOnly = true;
            this.verificationCodeTextBox.Size = new System.Drawing.Size(152, 22);
            this.verificationCodeTextBox.TabIndex = 8;
            // 
            // sendVerificationCodeButton
            // 
            this.sendVerificationCodeButton.Location = new System.Drawing.Point(138, 79);
            this.sendVerificationCodeButton.Name = "sendVerificationCodeButton";
            this.sendVerificationCodeButton.Size = new System.Drawing.Size(152, 27);
            this.sendVerificationCodeButton.TabIndex = 7;
            this.sendVerificationCodeButton.Text = "Send Verification Code";
            this.sendVerificationCodeButton.UseVisualStyleBackColor = true;
            this.sendVerificationCodeButton.Click += new System.EventHandler(this.sendVerificationCodeButton_Click);
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(138, 43);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.ReadOnly = true;
            this.eMailTextBox.Size = new System.Drawing.Size(152, 22);
            this.eMailTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(49, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(598, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 49;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.byMailGroupBox);
            this.Controls.Add(this.changePasswordGrpBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.changePasswordGrpBox.ResumeLayout(false);
            this.changePasswordGrpBox.PerformLayout();
            this.byMailGroupBox.ResumeLayout(false);
            this.byMailGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox securityQuestionAnswerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox securityQuestionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.GroupBox changePasswordGrpBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button securityQuestionOKBox;
        private System.Windows.Forms.Button passwordOKButton;
        private System.Windows.Forms.TextBox newPasswordAgainTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox byMailGroupBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sendVerificationCodeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox verificationCodeTextBox;
        private System.Windows.Forms.Button mailOKButton;
        private System.Windows.Forms.Button button1;
    }
}