
namespace ParaCafe
{
    partial class MainForm
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
            this.tsmiMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPastOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.lstTables = new System.Windows.Forms.ListView();
            this.tsmiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmiMenu
            // 
            this.tsmiMenu.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsmiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProducts,
            this.tsmiPastOrders});
            this.tsmiMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmiMenu.Name = "tsmiMenu";
            this.tsmiMenu.Size = new System.Drawing.Size(800, 24);
            this.tsmiMenu.TabIndex = 0;
            this.tsmiMenu.Text = "menuStrip1";
            // 
            // tsmiProducts
            // 
            this.tsmiProducts.Name = "tsmiProducts";
            this.tsmiProducts.Size = new System.Drawing.Size(82, 20);
            this.tsmiProducts.Text = "Ürünler";
            // 
            // tsmiPastOrders
            // 
            this.tsmiPastOrders.Name = "tsmiPastOrders";
            this.tsmiPastOrders.Size = new System.Drawing.Size(172, 20);
            this.tsmiPastOrders.Text = "Geçmiş Siparişler";
            // 
            // lstTables
            // 
            this.lstTables.Location = new System.Drawing.Point(5, 27);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(788, 411);
            this.lstTables.TabIndex = 1;
            this.lstTables.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstTables);
            this.Controls.Add(this.tsmiMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.tsmiMenu;
            this.Name = "MainForm";
            this.Text = "Para Cafe";
            this.tsmiMenu.ResumeLayout(false);
            this.tsmiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tsmiMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiProducts;
        private System.Windows.Forms.ToolStripMenuItem tsmiPastOrders;
        private System.Windows.Forms.ListView lstTables;
    }
}