
namespace _35481013_EXAM
{
    partial class EventHost
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
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnInsert = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnUpdate.Location = new System.Drawing.Point(50, 269);
            this.bttnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(131, 33);
            this.bttnUpdate.TabIndex = 1;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = false;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnInsert
            // 
            this.bttnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnInsert.Location = new System.Drawing.Point(250, 269);
            this.bttnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnInsert.Name = "bttnInsert";
            this.bttnInsert.Size = new System.Drawing.Size(142, 33);
            this.bttnInsert.TabIndex = 2;
            this.bttnInsert.Text = "Insert";
            this.bttnInsert.UseVisualStyleBackColor = false;
            this.bttnInsert.Click += new System.EventHandler(this.bttnInsert_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnDelete.Location = new System.Drawing.Point(469, 269);
            this.bttnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(166, 33);
            this.bttnDelete.TabIndex = 3;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // EventHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 340);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnInsert);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventHost";
            this.Text = "EventHost";
            this.Load += new System.EventHandler(this.EventHost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnInsert;
        private System.Windows.Forms.Button bttnDelete;
    }
}