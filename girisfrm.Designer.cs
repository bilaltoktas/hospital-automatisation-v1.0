
namespace WindowsFormsApp3
{
    partial class girisfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisfrm));
            this.btnHasta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnSekreter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.BackColor = System.Drawing.Color.MistyRose;
            this.btnHasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHasta.BackgroundImage")));
            this.btnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHasta.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnHasta.FlatAppearance.BorderSize = 0;
            this.btnHasta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHasta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHasta.Location = new System.Drawing.Point(12, 136);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(164, 183);
            this.btnHasta.TabIndex = 0;
            this.btnHasta.Text = " ";
            this.btnHasta.UseVisualStyleBackColor = false;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTA GİRİŞ EKRANI";
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.Color.MistyRose;
            this.btnDoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktor.BackgroundImage")));
            this.btnDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktor.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnDoktor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDoktor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDoktor.Location = new System.Drawing.Point(196, 136);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(164, 183);
            this.btnDoktor.TabIndex = 2;
            this.btnDoktor.Text = " ";
            this.btnDoktor.UseVisualStyleBackColor = false;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // btnSekreter
            // 
            this.btnSekreter.BackColor = System.Drawing.Color.MistyRose;
            this.btnSekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreter.BackgroundImage")));
            this.btnSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSekreter.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnSekreter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSekreter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSekreter.Location = new System.Drawing.Point(381, 136);
            this.btnSekreter.Name = "btnSekreter";
            this.btnSekreter.Size = new System.Drawing.Size(164, 183);
            this.btnSekreter.TabIndex = 3;
            this.btnSekreter.Text = " ";
            this.btnSekreter.UseVisualStyleBackColor = false;
            this.btnSekreter.Click += new System.EventHandler(this.btnSekreter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(205, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR GİRİŞ EKRANI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(386, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEKRETER GİRİŞ EKRANI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 68);
            this.label4.TabIndex = 7;
            this.label4.Text = "... HASTANESİ\r\nHASTANE KAYIT YÖNETİM SİSTEMİ";
            // 
            // girisfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(560, 369);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSekreter);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "girisfrm";
            this.Text = "... HASTANESİ HASTANE KAYIT YÖNETİM SİSTEMİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.girisfrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnSekreter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

