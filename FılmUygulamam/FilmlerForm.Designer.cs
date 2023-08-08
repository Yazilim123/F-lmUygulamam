namespace FılmUygulamam
{
    partial class FilmlerForm
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
            dgvFilmler = new DataGridView();
            IFilmSayisi = new Label();
            menuStrip1 = new MenuStrip();
            filmİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            listeleToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            ekleToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvFilmler).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFilmler
            // 
            dgvFilmler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFilmler.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvFilmler.Location = new Point(12, 64);
            dgvFilmler.MultiSelect = false;
            dgvFilmler.Name = "dgvFilmler";
            dgvFilmler.RowTemplate.Height = 25;
            dgvFilmler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFilmler.Size = new Size(753, 358);
            dgvFilmler.TabIndex = 0;
            // 
            // IFilmSayisi
            // 
            IFilmSayisi.AutoSize = true;
            IFilmSayisi.ForeColor = Color.DodgerBlue;
            IFilmSayisi.Location = new Point(12, 36);
            IFilmSayisi.Name = "IFilmSayisi";
            IFilmSayisi.Size = new Size(62, 15);
            IFilmSayisi.TabIndex = 1;
            IFilmSayisi.Text = "IFilmSayisi";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { filmİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1045, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // filmİşlemleriToolStripMenuItem
            // 
            filmİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeleToolStripMenuItem, toolStripMenuItem1, ekleToolStripMenuItem });
            filmİşlemleriToolStripMenuItem.Name = "filmİşlemleriToolStripMenuItem";
            filmİşlemleriToolStripMenuItem.Size = new Size(89, 20);
            filmİşlemleriToolStripMenuItem.Text = "Film İşlemleri";
            // 
            // listeleToolStripMenuItem
            // 
            listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            listeleToolStripMenuItem.Size = new Size(180, 22);
            listeleToolStripMenuItem.Text = "Listele";
            listeleToolStripMenuItem.Click += listeleToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // ekleToolStripMenuItem
            // 
            ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            ekleToolStripMenuItem.Size = new Size(180, 22);
            ekleToolStripMenuItem.Text = "Ekle";
            // 
            // FilmlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 421);
            Controls.Add(IFilmSayisi);
            Controls.Add(dgvFilmler);
            Controls.Add(menuStrip1);
            Name = "FilmlerForm";
            Text = "Form1";
            Load += FilmlerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmler).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFilmler;
        private Label IFilmSayisi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filmİşlemleriToolStripMenuItem;
        private ToolStripMenuItem listeleToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ekleToolStripMenuItem;
    }
}