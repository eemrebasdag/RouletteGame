using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roulette
{
    public partial class Form1 : Form
    {
        public enum renk
        {
            siyah,
            kirmizi,
            yesil


        }

        public class Sayi
        {
            public int Number { get; set; }

            public renk Color { get; set; }



        }

        public int Bakiye;
        public List<Sayi> Numbers;
        public Random rnd;
        int rndNumber;
        Sayi number;
        int oynananPara;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            if (bakiyeKontrol())
            {
                rnd = new Random();
                rndNumber = rnd.Next(0, 41);

                if (rndNumber == 0)
                {
                    lblResult.ForeColor = Color.Green;

                }
                else if (rndNumber % 2 == 0) lblResult.ForeColor = Color.Red;
                else lblResult.ForeColor = Color.Black;

                lblResult.Text = rndNumber.ToString();

                number = Numbers.FirstOrDefault(a => a.Number == rndNumber);

                oynananPara = Convert.ToInt32(nudPara.Value);
                Bakiye -= oynananPara;
                lblBakiye.Text = Bakiye.ToString();

                if (cbNumberCnt.Checked)
                {
                    if (nudNumber.Value == number.Number && nudNumber.Value == 0)
                    {
                        MessageBox.Show(" x14 Kazandın");

                        oynananPara *= 14;
                        Bakiye += oynananPara;
                        lblBakiye.Text = Bakiye.ToString();
                    }
                    else if (nudNumber.Value == number.Number)
                    {
                        MessageBox.Show(" x4 Kazandın");

                        oynananPara *= 4;
                        Bakiye += oynananPara;
                        lblBakiye.Text = Bakiye.ToString();

                    }

                }
                else if (cbRed.Checked)
                {
                    if(number.Color == renk.kirmizi)
                    {
                        oynananPara *= 2;
                        Bakiye += oynananPara;
                        lblBakiye.Text = Bakiye.ToString();

                    }

                }
                else if (cbBlack.Checked)
                {
                    if (number.Color == renk.siyah)
                    {
                        oynananPara *= 2;
                        Bakiye += oynananPara;
                        lblBakiye.Text = Bakiye.ToString();

                    }

                }
                else if (cbGreen.Checked)
                {
                    if (number.Color == renk.yesil)
                    {
                        oynananPara *= 14;
                        Bakiye += oynananPara;
                        lblBakiye.Text = Bakiye.ToString();

                    }

                }


            }
            else
            {
                MessageBox.Show("Düşük Bakiye !!!");
                MessageBox.Show("Hesabınıza Ekleme Yapıyorum...");
                Bakiye += 100;
                lblBakiye.Text = Bakiye.ToString();
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bakiye = 100;
            Numbers = new List<Sayi>();

            for (int i = 0; i < 41; i++)
            {

                if (i == 0)
                {
                    Numbers.Add(new Sayi
                    {
                        Number = i,
                        Color = renk.yesil

                    });


                }
                else if (i % 2 == 0)
                {
                    Numbers.Add(new Sayi
                    {
                        Number = i,
                        Color = renk.kirmizi
                    });

                }
                else
                {
                    Numbers.Add(new Sayi
                    {
                        Number = i,
                        Color = renk.siyah
                    });
                }

                lblBakiye.Text = Bakiye.ToString();
            }
        }

        public bool bakiyeKontrol()
        {
            if (Bakiye < nudPara.Value)
            {
                return false;
            }
            else return true;
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbNumberCnt_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
