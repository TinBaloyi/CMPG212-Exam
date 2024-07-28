
namespace _35481013_EXAM
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.Label();
            this.bttnRegistration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.NameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMembershipLevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(286, 135);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(286, 166);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.Location = new System.Drawing.Point(224, 63);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(224, 16);
            this.Registration.TabIndex = 4;
            this.Registration.Text = "Please Enter Details to register";
            // 
            // bttnRegistration
            // 
            this.bttnRegistration.Location = new System.Drawing.Point(258, 237);
            this.bttnRegistration.Name = "bttnRegistration";
            this.bttnRegistration.Size = new System.Drawing.Size(117, 23);
            this.bttnRegistration.TabIndex = 5;
            this.bttnRegistration.Text = "Register";
            this.bttnRegistration.UseVisualStyleBackColor = true;
            this.bttnRegistration.Click += new System.EventHandler(this.bttnRegistration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(286, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // NameError
            // 
            this.NameError.ContainerControl = this;
            // 
            // EmailError
            // 
            this.EmailError.ContainerControl = this;
            // 
            // PasswordError
            // 
            this.PasswordError.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Already a user?";
            // 
            // bttnLogin
            // 
            this.bttnLogin.Location = new System.Drawing.Point(275, 315);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(75, 23);
            this.bttnLogin.TabIndex = 9;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "MemberShip?";
            // 
            // cmbMembershipLevel
            // 
            this.cmbMembershipLevel.FormattingEnabled = true;
            this.cmbMembershipLevel.Items.AddRange(new object[] {
            "Premium",
            "Regular"});
            this.cmbMembershipLevel.Location = new System.Drawing.Point(286, 198);
            this.cmbMembershipLevel.Name = "cmbMembershipLevel";
            this.cmbMembershipLevel.Size = new System.Drawing.Size(100, 21);
            this.cmbMembershipLevel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(184, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "WELCOME TO  CodeCraft Solutions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_35481013_EXAM.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(633, 367);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMembershipLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnRegistration);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "User Registration";
            ((System.ComponentModel.ISupportInitialize)(this.NameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Button bttnRegistration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider NameError;
        private System.Windows.Forms.ErrorProvider EmailError;
        private System.Windows.Forms.ErrorProvider PasswordError;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMembershipLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

