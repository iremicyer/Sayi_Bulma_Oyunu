namespace Sayi_Bulma_Oyunu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTahmin = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.numericUpDownSüre = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHakSayisi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBasamakSayisi = new System.Windows.Forms.Label();
            this.textBoxTahmin = new System.Windows.Forms.TextBox();
            this.textBoxGizliSayi = new System.Windows.Forms.TextBox();
            this.labelTahmin = new System.Windows.Forms.Label();
            this.labelSüre = new System.Windows.Forms.Label();
            this.labelHakSayisi = new System.Windows.Forms.Label();
            this.labelGizliSayi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTahminler = new System.Windows.Forms.Label();
            this.listBoxTahminler = new System.Windows.Forms.ListBox();
            this.labelSonuçlar = new System.Windows.Forms.Label();
            this.listBoxSonuçlar = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSüre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHakSayisi)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTahmin);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Controls.Add(this.numericUpDownSüre);
            this.groupBox1.Controls.Add(this.numericUpDownHakSayisi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelBasamakSayisi);
            this.groupBox1.Controls.Add(this.textBoxTahmin);
            this.groupBox1.Controls.Add(this.textBoxGizliSayi);
            this.groupBox1.Controls.Add(this.labelTahmin);
            this.groupBox1.Controls.Add(this.labelSüre);
            this.groupBox1.Controls.Add(this.labelHakSayisi);
            this.groupBox1.Controls.Add(this.labelGizliSayi);
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonTahmin
            // 
            this.buttonTahmin.BackColor = System.Drawing.Color.Khaki;
            this.buttonTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTahmin.Location = new System.Drawing.Point(191, 160);
            this.buttonTahmin.Name = "buttonTahmin";
            this.buttonTahmin.Size = new System.Drawing.Size(82, 34);
            this.buttonTahmin.TabIndex = 3;
            this.buttonTahmin.Text = "Tahmin Et";
            this.buttonTahmin.UseVisualStyleBackColor = false;
            this.buttonTahmin.Click += new System.EventHandler(this.buttonTahmin_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOK.Location = new System.Drawing.Point(279, 19);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 76);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "BAŞLA";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // numericUpDownSüre
            // 
            this.numericUpDownSüre.Location = new System.Drawing.Point(87, 81);
            this.numericUpDownSüre.Name = "numericUpDownSüre";
            this.numericUpDownSüre.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSüre.TabIndex = 2;
            this.numericUpDownSüre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSüre.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownHakSayisi
            // 
            this.numericUpDownHakSayisi.Location = new System.Drawing.Point(87, 55);
            this.numericUpDownHakSayisi.Name = "numericUpDownHakSayisi";
            this.numericUpDownHakSayisi.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHakSayisi.TabIndex = 2;
            this.numericUpDownHakSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHakSayisi.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "(Sn)";
            // 
            // labelBasamakSayisi
            // 
            this.labelBasamakSayisi.BackColor = System.Drawing.Color.Yellow;
            this.labelBasamakSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBasamakSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBasamakSayisi.Location = new System.Drawing.Point(33, 128);
            this.labelBasamakSayisi.Name = "labelBasamakSayisi";
            this.labelBasamakSayisi.Size = new System.Drawing.Size(262, 24);
            this.labelBasamakSayisi.TabIndex = 0;
            this.labelBasamakSayisi.Text = "Basamak Sayısı =";
            this.labelBasamakSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTahmin
            // 
            this.textBoxTahmin.Location = new System.Drawing.Point(87, 168);
            this.textBoxTahmin.Name = "textBoxTahmin";
            this.textBoxTahmin.Size = new System.Drawing.Size(82, 20);
            this.textBoxTahmin.TabIndex = 1;
            // 
            // textBoxGizliSayi
            // 
            this.textBoxGizliSayi.Location = new System.Drawing.Point(87, 23);
            this.textBoxGizliSayi.Name = "textBoxGizliSayi";
            this.textBoxGizliSayi.PasswordChar = '*';
            this.textBoxGizliSayi.Size = new System.Drawing.Size(82, 20);
            this.textBoxGizliSayi.TabIndex = 1;
            // 
            // labelTahmin
            // 
            this.labelTahmin.AutoSize = true;
            this.labelTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTahmin.Location = new System.Drawing.Point(22, 168);
            this.labelTahmin.Name = "labelTahmin";
            this.labelTahmin.Size = new System.Drawing.Size(59, 13);
            this.labelTahmin.TabIndex = 0;
            this.labelTahmin.Text = "Tahmin =";
            // 
            // labelSüre
            // 
            this.labelSüre.AutoSize = true;
            this.labelSüre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSüre.Location = new System.Drawing.Point(37, 83);
            this.labelSüre.Name = "labelSüre";
            this.labelSüre.Size = new System.Drawing.Size(44, 13);
            this.labelSüre.TabIndex = 0;
            this.labelSüre.Text = "Süre =";
            // 
            // labelHakSayisi
            // 
            this.labelHakSayisi.AutoSize = true;
            this.labelHakSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHakSayisi.Location = new System.Drawing.Point(7, 57);
            this.labelHakSayisi.Name = "labelHakSayisi";
            this.labelHakSayisi.Size = new System.Drawing.Size(78, 13);
            this.labelHakSayisi.TabIndex = 0;
            this.labelHakSayisi.Text = "Hak Sayısı =";
            // 
            // labelGizliSayi
            // 
            this.labelGizliSayi.AutoSize = true;
            this.labelGizliSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGizliSayi.Location = new System.Drawing.Point(15, 23);
            this.labelGizliSayi.Name = "labelGizliSayi";
            this.labelGizliSayi.Size = new System.Drawing.Size(70, 13);
            this.labelGizliSayi.TabIndex = 0;
            this.labelGizliSayi.Text = "Gizli Sayı =";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTahminler
            // 
            this.labelTahminler.BackColor = System.Drawing.Color.Yellow;
            this.labelTahminler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTahminler.Location = new System.Drawing.Point(423, 39);
            this.labelTahminler.Name = "labelTahminler";
            this.labelTahminler.Size = new System.Drawing.Size(107, 27);
            this.labelTahminler.TabIndex = 0;
            this.labelTahminler.Text = "Tahminler ";
            this.labelTahminler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxTahminler
            // 
            this.listBoxTahminler.BackColor = System.Drawing.Color.Bisque;
            this.listBoxTahminler.FormattingEnabled = true;
            this.listBoxTahminler.Location = new System.Drawing.Point(423, 69);
            this.listBoxTahminler.Name = "listBoxTahminler";
            this.listBoxTahminler.Size = new System.Drawing.Size(107, 186);
            this.listBoxTahminler.TabIndex = 1;
            // 
            // labelSonuçlar
            // 
            this.labelSonuçlar.BackColor = System.Drawing.Color.Yellow;
            this.labelSonuçlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSonuçlar.Location = new System.Drawing.Point(546, 40);
            this.labelSonuçlar.Name = "labelSonuçlar";
            this.labelSonuçlar.Size = new System.Drawing.Size(107, 27);
            this.labelSonuçlar.TabIndex = 0;
            this.labelSonuçlar.Text = "Sonuçlar";
            this.labelSonuçlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxSonuçlar
            // 
            this.listBoxSonuçlar.BackColor = System.Drawing.Color.Bisque;
            this.listBoxSonuçlar.FormattingEnabled = true;
            this.listBoxSonuçlar.Location = new System.Drawing.Point(546, 70);
            this.listBoxSonuçlar.Name = "listBoxSonuçlar";
            this.listBoxSonuçlar.Size = new System.Drawing.Size(107, 186);
            this.listBoxSonuçlar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(28, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 135);
            this.panel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "Kalan  Hak Sayısı = ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "Kalan Hak Sayısı = ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel2.Text = "Kalan Süre = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxSonuçlar);
            this.Controls.Add(this.listBoxTahminler);
            this.Controls.Add(this.labelSonuçlar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTahminler);
            this.Name = "Form1";
            this.Text = "Sayı Tahmin Oyunu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSüre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHakSayisi)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelGizliSayi;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown numericUpDownSüre;
        private System.Windows.Forms.NumericUpDown numericUpDownHakSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBasamakSayisi;
        private System.Windows.Forms.TextBox textBoxGizliSayi;
        private System.Windows.Forms.Label labelHakSayisi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxTahmin;
        private System.Windows.Forms.Label labelTahmin;
        private System.Windows.Forms.Button buttonTahmin;
        private System.Windows.Forms.Label labelTahminler;
        private System.Windows.Forms.ListBox listBoxTahminler;
        private System.Windows.Forms.Label labelSonuçlar;
        private System.Windows.Forms.ListBox listBoxSonuçlar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSüre;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

