namespace Soru2
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
            this.btn_stokListele = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label_sepettutari = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2_stokyazi = new System.Windows.Forms.Label();
            this.button_sepetibosalt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_stokListele
            // 
            this.btn_stokListele.Location = new System.Drawing.Point(13, 48);
            this.btn_stokListele.Name = "btn_stokListele";
            this.btn_stokListele.Size = new System.Drawing.Size(75, 23);
            this.btn_stokListele.TabIndex = 0;
            this.btn_stokListele.Text = "Stok Listele";
            this.btn_stokListele.UseVisualStyleBackColor = true;
            this.btn_stokListele.Click += new System.EventHandler(this.btn_stokListele_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUrunAdi,
            this.columnHeaderAdet,
            this.columnHeaderFiyat});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(266, 278);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderUrunAdi
            // 
            this.columnHeaderUrunAdi.Text = "Ürün Adı";
            this.columnHeaderUrunAdi.Width = 76;
            // 
            // columnHeaderAdet
            // 
            this.columnHeaderAdet.Text = "Adet";
            this.columnHeaderAdet.Width = 95;
            // 
            // columnHeaderFiyat
            // 
            this.columnHeaderFiyat.Text = "Fiyat";
            this.columnHeaderFiyat.Width = 84;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(541, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sepete Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(344, 79);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(323, 278);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            this.columnHeader3.Width = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(339, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toplam Fiyat :";
            // 
            // label_sepettutari
            // 
            this.label_sepettutari.AutoSize = true;
            this.label_sepettutari.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sepettutari.Location = new System.Drawing.Point(558, 360);
            this.label_sepettutari.Name = "label_sepettutari";
            this.label_sepettutari.Size = new System.Drawing.Size(95, 29);
            this.label_sepettutari.TabIndex = 8;
            this.label_sepettutari.Text = "label2";
            this.label_sepettutari.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(344, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(480, 48);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2_stokyazi
            // 
            this.label2_stokyazi.AutoSize = true;
            this.label2_stokyazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_stokyazi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2_stokyazi.Location = new System.Drawing.Point(141, 54);
            this.label2_stokyazi.Name = "label2_stokyazi";
            this.label2_stokyazi.Size = new System.Drawing.Size(138, 16);
            this.label2_stokyazi.TabIndex = 11;
            this.label2_stokyazi.Text = "Stoktan Urun Seciniz...";
            this.label2_stokyazi.Visible = false;
            // 
            // button_sepetibosalt
            // 
            this.button_sepetibosalt.Enabled = false;
            this.button_sepetibosalt.Location = new System.Drawing.Point(541, 12);
            this.button_sepetibosalt.Name = "button_sepetibosalt";
            this.button_sepetibosalt.Size = new System.Drawing.Size(126, 23);
            this.button_sepetibosalt.TabIndex = 12;
            this.button_sepetibosalt.Text = "Sepeti Boşalt";
            this.button_sepetibosalt.UseVisualStyleBackColor = true;
            this.button_sepetibosalt.Click += new System.EventHandler(this.button_sepetibosalt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "21911099 Gokhan Gencer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_sepetibosalt);
            this.Controls.Add(this.label2_stokyazi);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_sepettutari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_stokListele);
            this.Name = "Form1";
            this.Text = "Kırtasiye Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_stokListele;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderUrunAdi;
        private System.Windows.Forms.ColumnHeader columnHeaderAdet;
        private System.Windows.Forms.ColumnHeader columnHeaderFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_sepettutari;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2_stokyazi;
        private System.Windows.Forms.Button button_sepetibosalt;
        private System.Windows.Forms.Label label2;
    }
}

