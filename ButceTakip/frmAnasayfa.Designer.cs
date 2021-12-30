
namespace ButceTakip
{
    partial class frmAnasayfa
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
            this.dataListe = new System.Windows.Forms.DataGridView();
            this.btnIslemEkle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataListe)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListe
            // 
            this.dataListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListe.ContextMenuStrip = this.contextMenuStrip1;
            this.dataListe.Location = new System.Drawing.Point(12, 60);
            this.dataListe.Name = "dataListe";
            this.dataListe.RowHeadersWidth = 51;
            this.dataListe.RowTemplate.Height = 24;
            this.dataListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListe.Size = new System.Drawing.Size(1218, 542);
            this.dataListe.TabIndex = 0;
            // 
            // btnIslemEkle
            // 
            this.btnIslemEkle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnIslemEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIslemEkle.Location = new System.Drawing.Point(1105, 12);
            this.btnIslemEkle.Name = "btnIslemEkle";
            this.btnIslemEkle.Size = new System.Drawing.Size(125, 33);
            this.btnIslemEkle.TabIndex = 6;
            this.btnIslemEkle.Text = "İşlem Ekle";
            this.btnIslemEkle.UseVisualStyleBackColor = false;
            this.btnIslemEkle.Click += new System.EventHandler(this.btnIslemEkle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKullanici.Location = new System.Drawing.Point(12, 12);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(235, 33);
            this.lblKullanici.TabIndex = 8;
            this.lblKullanici.Text = "Baba : Erdi YALÇIN";
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 614);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnIslemEkle);
            this.Controls.Add(this.dataListe);
            this.Name = "frmAnasayfa";
            this.Text = "Bütçe";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListe)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListe;
        private System.Windows.Forms.Button btnIslemEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
    }
}