using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayi_Bulma_Oyunu
{
    public partial class Form1 : Form
    {
        string gizlisayi;
        string tahmin;
        int süre;
        int kalansüre;
        int haksayisi;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.gizlisayi = textBoxGizliSayi.Text.Trim(); //Trim(), string bir ifadenin başındaki ve sonundaki boşlukları siler.

            if (SayiKontrol())
            {
                MessageBox.Show("Tahmin Edilen Sayıda Tekrarlı Rakamlar Var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            this.haksayisi = (int)numericUpDownHakSayisi.Value;
            this.kalansüre = this.süre = (int)numericUpDownSüre.Value; // kalan süreyi eksilteceğimiz için tek değişken kullanmıyoruz.

            toolStripStatusLabel1.Text = "Kalan Hak Sayısı =" + haksayisi.ToString();

            labelBasamakSayisi.Text = "Basamak Sayısı =" + gizlisayi.Length;

            for (int i = 0; i < gizlisayi.Length; i++)
            {
                TextBox txt = new TextBox();
                txt.Name = "txt" + (i + 1);
                txt.Enabled = false;
                txt.Size = new Size(60, 20);
                txt.Location = new Point(30 + i * 66, 20);
                txt.TextAlign = HorizontalAlignment.Center;
                txt.BackColor = Color.AliceBlue;
                panel1.Controls.Add(txt);

                Label lbl = new Label();
                lbl.Name = "lbl" + (i + 1);
                lbl.Size = new Size(60, 10);
                lbl.Location = new Point(30 + i * 66, 40);
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.BackColor = Color.White;
                panel1.Controls.Add(lbl);
            }
            timer1.Start();


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            kalansüre--;
            toolStripStatusLabel2.Text = ("Kalan Süre =" + kalansüre);
            if (kalansüre == 0)
            {
                if (--haksayisi == 0)
                {
                    buttonTahmin.Enabled = false;
                    timer1.Stop();
                }
                toolStripStatusLabel1.Text = "Kalan Hak Sayısı=" + haksayisi.ToString();
                kalansüre = süre;
            }
            OyunBitti();
        }

        private void OyunBitti()
        {
            if (kalansüre == 0)
            {
                if (--haksayisi == 0)
                {
                    buttonTahmin.Enabled = false;
                    timer1.Stop();
                }
                toolStripStatusLabel1.Text = "Kalan Hak Sayısı =" + haksayisi.ToString();
                kalansüre = süre;

            }
        }

        public void buttonTahmin_Click(object sender, EventArgs e)
        {
            this.tahmin = textBoxTahmin.Text;

            if (tahmin.Length != gizlisayi.Length)
            {
                MessageBox.Show("Tahmin Edilen Sayı Geçerli Uzunlukta Değil !!! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
   
            (int arti,int eksi)= KontrolStrings();

            listBoxTahminler.Items.Add(tahmin);
            listBoxSonuçlar.Items.Add(arti + "(+) ve " + eksi + "(-)");

            if (arti == gizlisayi.Length)
            {
                MessageBox.Show("Tebrikler");
                timer1.Stop();
                buttonTahmin.Enabled = false;
                return;
            }
            OyunBitti();
            kalansüre = süre;
        }

        private (int arti, int eksi) KontrolStrings()
        {

            for (int i = 0; i < gizlisayi.Length; i++)
            {
                TextBox txt = (TextBox)panel1.Controls["txt" + (i + 1)];
                txt.Text = tahmin[i].ToString();


                Label lbl = (Label)panel1.Controls["lbl" + (i + 1)];
                lbl.BackColor = Color.White;

            }

            int arti = 0, eksi = 0, ind = -1;
            for (int i = 0; i < gizlisayi.Length; i++)
            {
                if (gizlisayi[i] == tahmin[i])
                {
                    arti++;

                    Label lbl = (Label)panel1.Controls["lbl" + (i + 1)];
                    lbl.BackColor = Color.Blue;
                }
                else if((ind = gizlisayi.IndexOf(tahmin[i])) != -1)
                {
                    eksi++;

                    Label lbl = (Label)panel1.Controls["lbl" + (ind + 1)];
                    lbl.BackColor = Color.Red;
                }
            }
            return (arti, eksi);
        }

        private bool SayiKontrol()
        {
            for (int i = 0; i < gizlisayi.Length - 1; i++)
            {
                for (int j = i + 1; j < gizlisayi.Length; j++)
                {
                    if (gizlisayi[i] == gizlisayi[j]) return true;

                }
            }
            return false;
        }


    }
}
