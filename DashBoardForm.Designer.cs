
namespace _35481013_EXAM
{
    partial class DashBoardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.upcomingEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInformationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upcomingEventsToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.eventHostToolStripMenuItem,
            this.regularUsersToolStripMenuItem,
            this.eventsHistoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // upcomingEventsToolStripMenuItem
            // 
            this.upcomingEventsToolStripMenuItem.Name = "upcomingEventsToolStripMenuItem";
            this.upcomingEventsToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.upcomingEventsToolStripMenuItem.Text = "Upcoming Events";
            this.upcomingEventsToolStripMenuItem.Click += new System.EventHandler(this.upcomingEventsToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInformationDetailsToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // updateInformationDetailsToolStripMenuItem
            // 
            this.updateInformationDetailsToolStripMenuItem.Name = "updateInformationDetailsToolStripMenuItem";
            this.updateInformationDetailsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.updateInformationDetailsToolStripMenuItem.Text = "Update Information Details";
            this.updateInformationDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateInformationDetailsToolStripMenuItem_Click);
            // 
            // eventHostToolStripMenuItem
            // 
            this.eventHostToolStripMenuItem.Name = "eventHostToolStripMenuItem";
            this.eventHostToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.eventHostToolStripMenuItem.Text = "Event Host";
            this.eventHostToolStripMenuItem.Click += new System.EventHandler(this.eventHostToolStripMenuItem_Click);
            // 
            // regularUsersToolStripMenuItem
            // 
            this.regularUsersToolStripMenuItem.Name = "regularUsersToolStripMenuItem";
            this.regularUsersToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.regularUsersToolStripMenuItem.Text = "Regular Users";
            this.regularUsersToolStripMenuItem.Click += new System.EventHandler(this.regularUsersToolStripMenuItem_Click);
            // 
            // eventsHistoryToolStripMenuItem
            // 
            this.eventsHistoryToolStripMenuItem.Name = "eventsHistoryToolStripMenuItem";
            this.eventsHistoryToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.eventsHistoryToolStripMenuItem.Text = "Events History";
            this.eventsHistoryToolStripMenuItem.Click += new System.EventHandler(this.eventsHistoryToolStripMenuItem_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::_35481013_EXAM.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoardForm";
            this.Text = "DashBoardForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem upcomingEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInformationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsHistoryToolStripMenuItem;
    }
}