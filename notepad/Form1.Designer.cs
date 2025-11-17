namespace notepad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMetinAlani = new RichTextBox();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            açToolStripMenuItem = new ToolStripMenuItem();
            kaydetToolStripMenuItem = new ToolStripMenuItem();
            farklıKaydetToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            geriAlToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMetinAlani
            // 
            txtMetinAlani.Dock = DockStyle.Fill;
            txtMetinAlani.Location = new Point(0, 28);
            txtMetinAlani.Name = "txtMetinAlani";
            txtMetinAlani.Size = new Size(800, 422);
            txtMetinAlani.TabIndex = 0;
            txtMetinAlani.Text = "";
            txtMetinAlani.TextChanged += txtMetinAlani_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniToolStripMenuItem, açToolStripMenuItem, kaydetToolStripMenuItem, farklıKaydetToolStripMenuItem, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(64, 24);
            dosyaToolStripMenuItem.Text = "Dosya";
            dosyaToolStripMenuItem.Click += dosyaToolStripMenuItem_Click;
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(176, 26);
            yeniToolStripMenuItem.Text = "Yeni";
            yeniToolStripMenuItem.Click += yeniToolStripMenuItem_Click;
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.Size = new Size(176, 26);
            açToolStripMenuItem.Text = "Aç";
            açToolStripMenuItem.Click += açToolStripMenuItem_Click;
            // 
            // kaydetToolStripMenuItem
            // 
            kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            kaydetToolStripMenuItem.Size = new Size(176, 26);
            kaydetToolStripMenuItem.Text = "Kaydet";
            kaydetToolStripMenuItem.Click += kaydetToolStripMenuItem_Click;
            // 
            // farklıKaydetToolStripMenuItem
            // 
            farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            farklıKaydetToolStripMenuItem.Size = new Size(176, 26);
            farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            farklıKaydetToolStripMenuItem.Click += farklıKaydetToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(176, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { geriAlToolStripMenuItem, kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem });
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(77, 24);
            düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // geriAlToolStripMenuItem
            // 
            geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            geriAlToolStripMenuItem.Size = new Size(146, 26);
            geriAlToolStripMenuItem.Text = "Geri Al";
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(146, 26);
            kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(146, 26);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(146, 26);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMetinAlani);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Notepad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtMetinAlani;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem geriAlToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
