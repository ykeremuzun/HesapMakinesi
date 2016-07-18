using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;
        double sayi;
        double sayi2;
        string deneme;
        double sonuc;
        char[] deneme1= new char[999999];
        private void btn_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text=="0")
            {
                txtEkran.Clear();
            }
            Button atama = (Button)sender;
            txtEkran.Text = txtEkran.Text + atama.Text;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            txt2.Clear();
            txtEkran.Clear();
            txtEkran.Text = "0";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Button atama2 = (Button)sender;
            txtEkran.Text = txtEkran.Text + atama2.Text;
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
        deneme = txtEkran.Text; 
          deneme1= deneme.ToCharArray(0,deneme.Length);
            sayac = 0;
            foreach (char de in deneme1)
            {
                sayac++;
                switch (de)
                {
                    case '+':
                       
                            sayi = double.Parse(deneme.Substring(0,sayac-1));
                            sayi2 = double.Parse(deneme.Substring(sayac, deneme.Length-sayac));
                            sonuc=sayi + sayi2;
                        txt2.Text = sonuc.ToString();break;
                    case '-':

                        sayi = double.Parse(deneme.Substring(0, sayac - 1));
                        sayi2 = double.Parse(deneme.Substring(sayac, deneme.Length - sayac));
                        sonuc = sayi - sayi2;
                        txt2.Text = sonuc.ToString();
                        break;
                    case 'X':

                        sayi = double.Parse(deneme.Substring(0, sayac - 1));
                        sayi2 = double.Parse(deneme.Substring(sayac, deneme.Length - sayac));
                        sonuc = sayi * sayi2;
                        txt2.Text = sonuc.ToString();
                        break;
                    case '/':

                        sayi = double.Parse(deneme.Substring(0, sayac - 1));
                        sayi2 = double.Parse(deneme.Substring(sayac, deneme.Length - sayac));
                        sonuc = sayi / sayi2;
                        txt2.Text = sonuc.ToString();
                        break;
                    default:
                        break;
                }
            }


        }

        private void btn_Click_1(object sender, EventArgs e)
        {
            if (txtEkran.Text.Length == 0)
            {
                MessageBox.Show("Bu İşlemi Yapamazsınız!");
            }
            else
            {
                txtEkran.Text = txtEkran.Text.Substring(0, txtEkran.Text.Length - 1);
            }
            
         

        }

        private void btnArtiEksi_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtEkran.Text)>=0)
            {
                txtEkran.Text = '-'+ txtEkran.Text;
            }
            else
            {
                txtEkran.Text = '+' + txtEkran.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
