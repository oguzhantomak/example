using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                label1.Text = "En büyük sayı : " + sayi1.ToString();
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                label1.Text = "En büyük sayı : " + sayi2.ToString();
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2)
            {
                label1.Text = "En büyük sayı : " + sayi3.ToString();
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int sayi4 = 0;

            for (int i = 0; i <= 100; i++)
            {
                sayi4 += i;
            }
            label2.Text = sayi4.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                double not1 = Convert.ToInt32(textBox4.Text);
                double not2 = Convert.ToInt32(textBox5.Text);
                double not3 = Convert.ToInt32(textBox6.Text);

                if (not1 > 100 || not2 > 100 || not3 > 100)
                {
                    MessageBox.Show("Not veya notlar 100 den büyük olamaz");
                }

                //if (not1>100)
                //{
                //    MessageBox.Show("1. yazılı notu 100 den büyük olamaz");
                //}
                //else if (not2>100)
                //{
                //    MessageBox.Show("2.yazılı notu 100 den büyük olamaz");
                //}
                //else if (not3>100)
                //{
                //    MessageBox.Show("Sözlü notunuz 100 den büyük olamaz");
                //}
                else
                {
                    double ortalama = (not1 + not2 + not3) / 3;
                    if (ortalama > 0 && ortalama <= 24)
                    {
                        label3.Text = "Ortalama = " + ortalama + " Karne değeri : 0";
                    }
                    else if (ortalama > 24 && ortalama < 45)
                    {
                        label3.Text = "Ortalama = " + ortalama + " Karne değeri : 1";
                    }
                    else if (ortalama > 44 && ortalama < 55)
                    {
                        label3.Text = "Ortalama = " + ortalama + " Karne değeri : 2";
                    }
                    else if (ortalama > 54 && ortalama < 70)
                    {
                        label3.Text = "Ortalama = " + ortalama + " Karne değeri : 3";
                    }
                    else if (ortalama > 69 && ortalama < 85)
                    {
                        label3.Text = "Ortalama = " + ortalama + " Karne değeri : 4";
                    }
                    else if (ortalama > 84 && ortalama < 101)
                    {
                        label3.Text = "Ortalama = " + ortalama + " Karne değeri : 5";
                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }


        }
    }
}
