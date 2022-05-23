using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru2
{
    public partial class Form1 : Form
    {
        //Ürünler sınıfından yeni nesneler üretiliyor...
        Urunler defter = new Urunler();
        Urunler kalem = new Urunler();
        Urunler silgi = new Urunler();
        Urunler karton = new Urunler();
        Urunler okulCantasi = new Urunler();
        Urunler boya = new Urunler();
        Urunler yapistirici = new Urunler();
        Urunler kitap = new Urunler();
        ListViewItem satir1 = new ListViewItem();
        ListViewItem satir2 = new ListViewItem();
        ListViewItem satir3 = new ListViewItem();
        ListViewItem satir4 = new ListViewItem();
        ListViewItem satir5 = new ListViewItem();
        ListViewItem satir6 = new ListViewItem();
        ListViewItem satir7 = new ListViewItem();
        ListViewItem satir8 = new ListViewItem();
        double toplamFiyat = 0;




        public Form1()
        {
            InitializeComponent();

        }

        private void btn_stokListele_Click(object sender, EventArgs e)
        {
            btn_stokListele.Enabled = false;
            label2_stokyazi.Visible = true;
            button_sepetibosalt.Enabled = true;
            button1.Enabled = true;
           

            kalem.urunAdi = "Kalem";
            kalem.urunAdet = 20;
            kalem.urunFiyat = 10.90;

            defter.urunAdi = "Defter";
            defter.urunAdet = 20;
            defter.urunFiyat = 39.90;

            silgi.urunAdi = "Silgi";
            silgi.urunAdet = 20;
            silgi.urunFiyat = 3.90;

            karton.urunAdi = "Karton";
            karton.urunAdet = 20;
            karton.urunFiyat = 8;

            okulCantasi.urunAdi = "Okul Çantası";
            okulCantasi.urunAdet = 20;
            okulCantasi.urunFiyat = 59.90;

            boya.urunAdi = "Boya";
            boya.urunAdet = 20;
            boya.urunFiyat = 15;

            yapistirici.urunAdi = "Yapıştırıcı";
            yapistirici.urunAdet = 20;
            yapistirici.urunFiyat = 3.90;

            kitap.urunAdi = "Kitap";
            kitap.urunAdet = 20;
            kitap.urunFiyat = 20;

            satir1.Text = kalem.urunAdi;
            satir1.SubItems.Add(kalem.urunAdet.ToString());
            satir1.SubItems.Add(kalem.urunFiyat.ToString() + " TL");
            listView1.Items.Add(satir1);

            satir2.Text = defter.urunAdi;
            satir2.SubItems.Add(defter.urunAdet.ToString());
            satir2.SubItems.Add(defter.urunFiyat.ToString() + " TL");
            listView1.Items.Add(satir2);

            satir3.Text = silgi.urunAdi;
            satir3.SubItems.Add(silgi.urunAdet.ToString());
            satir3.SubItems.Add(silgi.urunFiyat.ToString() + " TL");
            listView1.Items.Add(satir3);

            satir4.Text = karton.urunAdi;
            satir4.SubItems.Add(karton.urunAdet.ToString());
            satir4.SubItems.Add(karton.urunFiyat.ToString() + " TL");
            listView1.Items.Add(satir4);

            satir5.Text = okulCantasi.urunAdi;
            satir5.SubItems.Add(okulCantasi.urunAdet.ToString());
            satir5.SubItems.Add(okulCantasi.urunFiyat.ToString() + " TL");
            listView1.Items.Add(satir5);

            satir6.Text = boya.urunAdi;
            satir6.SubItems.Add(boya.urunAdet.ToString());
            satir6.SubItems.Add(boya.urunFiyat.ToString() + " TL");
            listView1.Items.Add(satir6);

            satir7.Text = yapistirici.urunAdi;
            satir7.SubItems.Add(yapistirici.urunAdet.ToString());
            satir7.SubItems.Add(yapistirici.urunFiyat.ToString() + " TL");
            listView1.Items.Add(satir7);

            satir8.Text = kitap.urunAdi;
            satir8.SubItems.Add(kitap.urunAdet.ToString());
            satir8.SubItems.Add(kitap.urunFiyat.ToString() + " TL");
            listView1.Items.Add(satir8);
            listView1.MultiSelect = false; //Birden fazla satır seçilmesin.

            listView1.Focus();
            listView1.Items[0].Selected = true;            
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Stoktaki ürünler seçilince combobox1 de aynı ürün gösteriliyor..
            comboBox1.Text = listView1.FocusedItem.Text.ToString();
            if (comboBox1.Enabled == false)
                comboBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool urunVarmi = false;
            label_sepettutari.Visible = true;
            //0 adet seçilen ürün sepete eklenmiyor
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Ürün adet seçmediniz....");
            }
           
            else if (listView2.Items.Count > 0)
            {

                for (int i = 0; i < listView2.Items.Count; i++)

                {
                    if (listView2.Items[i].SubItems[0].Text == comboBox1.Text)
                    {

                        listView2.Items[i].SubItems[1].Text = Convert.ToString(Convert.ToInt32(listView2.Items[i].SubItems[1].Text) + numericUpDown1.Value);
                        hesapla(comboBox1.Text, Convert.ToDouble(numericUpDown1.Value));
                        double urunBirimFiyati = birimfiyati(comboBox1.Text, Convert.ToDouble(listView2.Items[i].SubItems[1].Text));
                        listView2.Items[i].SubItems[2].Text = urunBirimFiyati.ToString() + " TL";
                        label_sepettutari.Text = toplamFiyat.ToString() + " TL";
                        numericUpDown1.Value = 0;
                        urunVarmi = true;
                    }

                }

            }
            if (urunVarmi == false && numericUpDown1.Value != 0)
            {
                double urunToplam;
                ListViewItem sepet = new ListViewItem();
                sepet.Text = comboBox1.Text;
                sepet.SubItems.Add(numericUpDown1.Text);
                urunToplam = hesapla(comboBox1.Text, Convert.ToDouble(numericUpDown1.Value));
                sepet.SubItems.Add(urunToplam.ToString() + " TL");
                listView2.Items.Add(sepet);
                label_sepettutari.Text = toplamFiyat.ToString() + " TL";
                numericUpDown1.Value = 0;
            }

        }      
               

        //Seçili ürünün adet olarak toplam fiyatını hesaplayan metot
        private double hesapla(string urunAdi, double UrunAdet)
        {
            switch (urunAdi)
            {
                case "Kalem":
                    {
                        kalem.urunAdet = kalem.urunAdet - Convert.ToInt32(UrunAdet);

                        listView1.SelectedIndices.Add(0);
                        listView1.SelectedItems[0].SubItems[1].Text = kalem.urunAdet.ToString();
                        toplamFiyat += kalem.urunFiyat * UrunAdet;
                        return kalem.urunFiyat * UrunAdet;
                    }
                case "Defter":
                    {
                        defter.urunAdet = defter.urunAdet - Convert.ToInt32(UrunAdet);
                        listView1.SelectedItems[0].SubItems[1].Text = defter.urunAdet.ToString();
                        toplamFiyat += defter.urunFiyat * UrunAdet;
                        return defter.urunFiyat * UrunAdet;
                    }
                case "Silgi":
                    {
                        silgi.urunAdet = silgi.urunAdet - Convert.ToInt32(UrunAdet);
                        listView1.SelectedItems[0].SubItems[1].Text = silgi.urunAdet.ToString();
                        toplamFiyat += silgi.urunFiyat * UrunAdet;
                        return silgi.urunFiyat * UrunAdet;
                    }
                case "Karton":
                    {
                        karton.urunAdet = karton.urunAdet - Convert.ToInt32(UrunAdet);
                        listView1.SelectedItems[0].SubItems[1].Text = karton.urunAdet.ToString();
                        toplamFiyat += karton.urunFiyat * UrunAdet;
                        return karton.urunFiyat * UrunAdet;
                    }
                case "Okul Çantası":
                    {
                        okulCantasi.urunAdet = okulCantasi.urunAdet - Convert.ToInt32(UrunAdet);
                        listView1.SelectedItems[0].SubItems[1].Text = okulCantasi.urunAdet.ToString();
                        toplamFiyat += okulCantasi.urunFiyat * UrunAdet;
                        return okulCantasi.urunFiyat * UrunAdet;
                    }
                case "Boya":
                    {
                        boya.urunAdet = boya.urunAdet - Convert.ToInt32(UrunAdet);
                        listView1.SelectedItems[0].SubItems[1].Text = boya.urunAdet.ToString();
                        toplamFiyat += boya.urunFiyat * UrunAdet;
                        return boya.urunFiyat * UrunAdet;
                    }
                case "Yapıştırıcı":
                    {
                        yapistirici.urunAdet = yapistirici.urunAdet - Convert.ToInt32(UrunAdet);
                        listView1.SelectedItems[0].SubItems[1].Text = yapistirici.urunAdet.ToString();
                        toplamFiyat += yapistirici.urunFiyat * UrunAdet;
                        return yapistirici.urunFiyat * UrunAdet;
                    }
                case "Kitap":
                    {
                        kitap.urunAdet = kitap.urunAdet - Convert.ToInt32(UrunAdet);
                        listView1.SelectedItems[0].SubItems[1].Text = kitap.urunAdet.ToString();
                        toplamFiyat += kitap.urunFiyat * UrunAdet;
                        return kitap.urunFiyat * UrunAdet;
                    }
                default:
                    break;
            }

            throw new NotImplementedException();
        }

        private double birimfiyati(string urunAdi, double UrunAdet)
        {
            switch (urunAdi)
            {
                case "Kalem":
                    {                                                                     
                        return kalem.urunFiyat * UrunAdet;
                    }
                case "Defter":
                    {
                     
                        return defter.urunFiyat * UrunAdet;
                    }
                case "Silgi":
                    {
                        return silgi.urunFiyat * UrunAdet;
                    }
                case "Karton":
                    {
                        return karton.urunFiyat * UrunAdet;
                    }
                case "Okul Çantası":
                    {
                        return okulCantasi.urunFiyat * UrunAdet;
                    }
                case "Boya":
                    {
                        return boya.urunFiyat * UrunAdet;
                    }
                case "Yapıştırıcı":
                    {
                        return yapistirici.urunFiyat * UrunAdet;
                    }
                case "Kitap":
                    {
                        return kitap.urunFiyat * UrunAdet;
                    }
                default:
                    break;
            }

            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kalem");
            comboBox1.Items.Add("Defter");
            comboBox1.Items.Add("Silgi");
            comboBox1.Items.Add("Karton");
            comboBox1.Items.Add("Okul Çantası");
            comboBox1.Items.Add("Boya");
            comboBox1.Items.Add("Yapıştırıcı");
            comboBox1.Items.Add("Kitap");
        }
        //numericupdown tuşunun stokta bulunan ürün adedi kadar artmasını sağlayan kontrol...
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)


        {

            switch (comboBox1.Text)
            {
                case "Kalem":
                    {

                        numericUpDown1.Maximum = Convert.ToInt32(kalem.urunAdet);
                        break;
                    }
                case "Defter":
                    {
                        numericUpDown1.Maximum = Convert.ToInt32(defter.urunAdet);
                        break;
                    }
                case "Silgi":
                    {
                        numericUpDown1.Maximum = Convert.ToInt32(silgi.urunAdet);
                        break;
                    }
                case "Karton":
                    {
                        numericUpDown1.Maximum = Convert.ToInt32(karton.urunAdet);
                        break;
                    }
                case "Okul Çantası":
                    {
                        numericUpDown1.Maximum = Convert.ToInt32(okulCantasi.urunAdet);
                        break;
                    }
                case "Boya":
                    {
                        numericUpDown1.Maximum = Convert.ToInt32(boya.urunAdet);
                        break;
                    }
                case "Yapıştırıcı":
                    {
                        numericUpDown1.Maximum = Convert.ToInt32(yapistirici.urunAdet);
                        break;
                    }
                case "Kitap":
                    {
                        numericUpDown1.Maximum = Convert.ToInt32(kitap.urunAdet);
                        break;
                    }
                default:
                    break;
            }
        }

        private void button_sepetibosalt_Click(object sender, EventArgs e)
        {

            //Uygulama yeniden başlatılıyor...
            Application.Restart();







        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox1.Text = listView1.FocusedItem.Text.ToString();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listView1.FocusedItem.Selected = false;
            for (int i = 0; i < listView1.Items.Count; i++)

            {
                if (listView1.Items[i].SubItems[0].Text == comboBox1.Text)
                {

                    listView1.Focus(); // !!! Satırı seçebilmek için nesne üzerine odaklandık. 
                    listView1.Items[i].Selected = true; //Üzerinde oldugumuz satırı seçtik.
                    break; // döngüden çıktım. 
                }

            }

        }
    }

}
