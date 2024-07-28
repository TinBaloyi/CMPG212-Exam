
namespace _35481013_EXAM
{
    partial class Register
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
            this.lstBxEvents = new System.Windows.Forms.ListBox();
            this.bttnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxEvents
            // 
            this.lstBxEvents.FormattingEnabled = true;
            this.lstBxEvents.Location = new System.Drawing.Point(26, 28);
            this.lstBxEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBxEvents.Name = "lstBxEvents";
            this.lstBxEvents.Size = new System.Drawing.Size(563, 212);
            this.lstBxEvents.TabIndex = 0;
            // 
            // bttnRegister
            // 
            this.bttnRegister.Location = new System.Drawing.Point(181, 272);
            this.bttnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnRegister.Name = "bttnRegister";
            this.bttnRegister.Size = new System.Drawing.Size(87, 32);
            this.bttnRegister.TabIndex = 1;
            this.bttnRegister.Text = "Register";
            this.bttnRegister.UseVisualStyleBackColor = true;
            this.bttnRegister.Click += new System.EventHandler(this.bttnRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bttnRegister);
            this.Controls.Add(this.lstBxEvents);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxEvents;
        private System.Windows.Forms.Button bttnRegister;
    }
}