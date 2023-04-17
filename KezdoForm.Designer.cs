namespace Konyvbolt_FT
{
    partial class KezdoForm
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
            this.konyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vásárlóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vásárlásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VasarloBox = new System.Windows.Forms.ListBox();
            this.KonyvBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konyvToolStripMenuItem,
            this.vásárlóToolStripMenuItem,
            this.vásárlásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // konyvToolStripMenuItem
            // 
            this.konyvToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.módosításToolStripMenuItem});
            this.konyvToolStripMenuItem.Name = "konyvToolStripMenuItem";
            this.konyvToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.konyvToolStripMenuItem.Text = "Könyv";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "Új";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            // 
            // vásárlóToolStripMenuItem
            // 
            this.vásárlóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem1,
            this.törlésToolStripMenuItem1,
            this.módosításToolStripMenuItem1});
            this.vásárlóToolStripMenuItem.Name = "vásárlóToolStripMenuItem";
            this.vásárlóToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vásárlóToolStripMenuItem.Text = "Vásárló";
            // 
            // újToolStripMenuItem1
            // 
            this.újToolStripMenuItem1.Name = "újToolStripMenuItem1";
            this.újToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem1.Text = "Új";
            // 
            // törlésToolStripMenuItem1
            // 
            this.törlésToolStripMenuItem1.Name = "törlésToolStripMenuItem1";
            this.törlésToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem1.Text = "Törlés";
            // 
            // módosításToolStripMenuItem1
            // 
            this.módosításToolStripMenuItem1.Name = "módosításToolStripMenuItem1";
            this.módosításToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem1.Text = "Módosítás";
            // 
            // vásárlásToolStripMenuItem
            // 
            this.vásárlásToolStripMenuItem.Name = "vásárlásToolStripMenuItem";
            this.vásárlásToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.vásárlásToolStripMenuItem.Text = "Vásárlás";
            // 
            // VasarloBox
            // 
            this.VasarloBox.FormattingEnabled = true;
            this.VasarloBox.Location = new System.Drawing.Point(532, 24);
            this.VasarloBox.Name = "VasarloBox";
            this.VasarloBox.Size = new System.Drawing.Size(268, 426);
            this.VasarloBox.TabIndex = 1;
            // 
            // KonyvBox
            // 
            this.KonyvBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.KonyvBox.FormattingEnabled = true;
            this.KonyvBox.Location = new System.Drawing.Point(0, 24);
            this.KonyvBox.Name = "KonyvBox";
            this.KonyvBox.Size = new System.Drawing.Size(248, 426);
            this.KonyvBox.TabIndex = 2;
            // 
            // KezdoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KonyvBox);
            this.Controls.Add(this.VasarloBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KezdoForm";
            this.Text = "Konyvbolt";
            this.Load += new System.EventHandler(this.KezdoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konyvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vásárlóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vásárlásToolStripMenuItem;
        private System.Windows.Forms.ListBox VasarloBox;
        private System.Windows.Forms.ListBox KonyvBox;
    }
}

