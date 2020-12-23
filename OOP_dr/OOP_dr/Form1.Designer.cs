
namespace OOP_dr
{
    partial class Form1
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lvwKitaplar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwOyunKonsol = new System.Windows.Forms.ListView();
            this.lvwElektronik = new System.Windows.Forms.ListView();
            this.lvwMuzik = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(433, 508);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lvwKitaplar
            // 
            this.lvwKitaplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwKitaplar.FullRowSelect = true;
            this.lvwKitaplar.GridLines = true;
            this.lvwKitaplar.HideSelection = false;
            this.lvwKitaplar.Location = new System.Drawing.Point(12, 12);
            this.lvwKitaplar.Name = "lvwKitaplar";
            this.lvwKitaplar.Size = new System.Drawing.Size(920, 118);
            this.lvwKitaplar.TabIndex = 4;
            this.lvwKitaplar.UseCompatibleStateImageBehavior = false;
            this.lvwKitaplar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kitap Adı";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yazarı";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Basım Yılı";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yayınevi";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kapak Türü";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fiyatı";
            // 
            // lvwOyunKonsol
            // 
            this.lvwOyunKonsol.FullRowSelect = true;
            this.lvwOyunKonsol.GridLines = true;
            this.lvwOyunKonsol.HideSelection = false;
            this.lvwOyunKonsol.Location = new System.Drawing.Point(12, 136);
            this.lvwOyunKonsol.Name = "lvwOyunKonsol";
            this.lvwOyunKonsol.Size = new System.Drawing.Size(920, 118);
            this.lvwOyunKonsol.TabIndex = 4;
            this.lvwOyunKonsol.UseCompatibleStateImageBehavior = false;
            this.lvwOyunKonsol.View = System.Windows.Forms.View.Details;
            // 
            // lvwElektronik
            // 
            this.lvwElektronik.FullRowSelect = true;
            this.lvwElektronik.GridLines = true;
            this.lvwElektronik.HideSelection = false;
            this.lvwElektronik.Location = new System.Drawing.Point(12, 261);
            this.lvwElektronik.Name = "lvwElektronik";
            this.lvwElektronik.Size = new System.Drawing.Size(920, 118);
            this.lvwElektronik.TabIndex = 4;
            this.lvwElektronik.UseCompatibleStateImageBehavior = false;
            this.lvwElektronik.View = System.Windows.Forms.View.Details;
            // 
            // lvwMuzik
            // 
            this.lvwMuzik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvwMuzik.FullRowSelect = true;
            this.lvwMuzik.GridLines = true;
            this.lvwMuzik.HideSelection = false;
            this.lvwMuzik.Location = new System.Drawing.Point(12, 385);
            this.lvwMuzik.Name = "lvwMuzik";
            this.lvwMuzik.Size = new System.Drawing.Size(920, 118);
            this.lvwMuzik.TabIndex = 4;
            this.lvwMuzik.UseCompatibleStateImageBehavior = false;
            this.lvwMuzik.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sanatçı Adı";
            this.columnHeader7.Width = 104;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Albüm Adı";
            this.columnHeader8.Width = 117;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Çıkış Yılı";
            this.columnHeader9.Width = 110;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Dil";
            this.columnHeader10.Width = 164;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Türü";
            this.columnHeader11.Width = 124;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Fiyat";
            this.columnHeader12.Width = 184;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 541);
            this.Controls.Add(this.lvwMuzik);
            this.Controls.Add(this.lvwElektronik);
            this.Controls.Add(this.lvwOyunKonsol);
            this.Controls.Add(this.lvwKitaplar);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView lvwKitaplar;
        private System.Windows.Forms.ListView lvwOyunKonsol;
        private System.Windows.Forms.ListView lvwElektronik;
        private System.Windows.Forms.ListView lvwMuzik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

