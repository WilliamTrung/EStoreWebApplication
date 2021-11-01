
namespace SalesWinApp
{
    partial class frmMain
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberManagementToolStripMenuItem,
            this.productManagementToolStripMenuItem,
            this.orderManagementToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // memberManagementToolStripMenuItem
            // 
            this.memberManagementToolStripMenuItem.Name = "memberManagementToolStripMenuItem";
            this.memberManagementToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.memberManagementToolStripMenuItem.Text = "Member Management";
            this.memberManagementToolStripMenuItem.Click += new System.EventHandler(this.memberManagementToolStripMenuItem_Click);
            // 
            // productManagementToolStripMenuItem
            // 
            this.productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            this.productManagementToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.productManagementToolStripMenuItem.Text = "Product Management";
            // 
            // orderManagementToolStripMenuItem
            // 
            this.orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            this.orderManagementToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.orderManagementToolStripMenuItem.Text = "Order Management";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 532);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Application";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderManagementToolStripMenuItem;
    }
}