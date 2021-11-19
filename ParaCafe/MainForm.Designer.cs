
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tsmiMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPastOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.lstTables = new System.Windows.Forms.ListView();
            this.imlTables = new System.Windows.Forms.ImageList(this.components);
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
            this.tsmiProducts.Click += new System.EventHandler(this.tsmiProducts_Click);
            // 
            // tsmiPastOrders
            // 
            this.tsmiPastOrders.Name = "tsmiPastOrders";
            this.tsmiPastOrders.Size = new System.Drawing.Size(172, 20);
            this.tsmiPastOrders.Text = "Geçmiş Siparişler";
            this.tsmiPastOrders.Click += new System.EventHandler(this.tsmiPastOrders_Click);
            // 
            // lstTables
            // 
            this.lstTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTables.ForeColor = System.Drawing.Color.Gray;
            this.lstTables.HideSelection = false;
            this.lstTables.LargeImageList = this.imlTables;
            this.lstTables.Location = new System.Drawing.Point(0, 24);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(800, 399);
            this.lstTables.TabIndex = 1;
            this.lstTables.UseCompatibleStateImageBehavior = false;
            this.lstTables.DoubleClick += new System.EventHandler(this.lstTables_DoubleClick);
            // 
            // imlTables
            // 
            this.imlTables.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTables.ImageStream")));
            this.imlTables.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTables.Images.SetKeyName(0, "bos");
            this.imlTables.Images.SetKeyName(1, "dolu");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.lstTables);
            this.Controls.Add(this.tsmiMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.tsmiMenu;
            this.Name = "MainForm";
            this.Text = "Para Cafe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.ImageList imlTables;
    }
}