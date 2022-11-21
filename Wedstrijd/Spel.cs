using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wedstrijd
{
    public partial class Spel : Form
    {
        Random r = new Random();
        List<double> scores = new List<double>();
        bool start = true;
        bool tijdLoopt = true;
        double vraag = -0.5;
        double goed = -1;
        double fout = -1;
        double gemScore = 0;
        double besteScore = 0;
        double vorigeScore = 0;
        int juisteAnt;
        int _ticks = 60;

        private void NieuweSom()
        {
            Antwoord_Een.Checked = false;
            Antwoord_Twee.Checked = false;
            Antwoord_Drie.Checked = false;
            Antwoord_Vier.Checked = false;
            juisteAnt = 0;
            vraag += 0.5;
            label_Vraag.Text = "Vraag " + vraag;

            int soortSom = r.Next(4);
            string[] somData = new string[7];

            switch (soortSom)
            {
                case 0:
                    somData = Optelsom();
                    break;
                case 1:
                    somData = Aftreksom();
                    break;
                case 2:
                    somData = Keersom();
                    break;
                case 3:
                    somData = Deelsom();
                    break;
            }

            Som.Text = somData[0] + " " + somData[1] + " " + somData[2];
            Antwoord_Een.Text = somData[3];
            Antwoord_Twee.Text = somData[4];
            Antwoord_Drie.Text = somData[5];
            Antwoord_Vier.Text = somData[6];
        }
        
        private void Resultaat(System.Windows.Forms.RadioButton myRadioButton)
        {
            if (myRadioButton.Text.Equals(juisteAnt.ToString()))
            {
                goed += 0.5;
                if (start) { fout++; start = false; }
                label_Goed.Text = goed.ToString();
            }

            else
            {
                fout += 0.5;
                if (start) { goed++; start = false; }
                label_Fout.Text = fout.ToString();
            }
        }
        

        private int[] AMGA(int goedeAnt, int[] array) // AMGA = Array Met Goede Antwoord
        {
            int plaats = r.Next(4);
            array[plaats] = goedeAnt;
            
            return array;
        }

        private string[] Optelsom()
        {
            int num1 = r.Next(100, 1000);
            int num2 = r.Next(100, 1000);
            juisteAnt = num1 + num2;

            int[] antwoorden = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int n1 = r.Next(100, 1000);
                int n2 = r.Next(100, 1000);
                antwoorden[i] = n1 + n2;

                while ((antwoorden[i] < (juisteAnt * 0.67) || antwoorden[i] > (juisteAnt * 1.33)) && antwoorden[i] == juisteAnt)
                {
                    n1 = r.Next(100, 1000);
                    n2 = r.Next(100, 1000);
                    antwoorden[i] = n1 + n2;
                }
            }

            antwoorden = AMGA(juisteAnt, antwoorden);

            string[] somData = new string[7];
            somData[0] = num1.ToString();
            somData[1] = "+";
            somData[2] = num2.ToString();

            for (int i = 0; i < 4; i++)
            {
                somData[i + 3] = antwoorden[i].ToString();
            }

            return somData;
        }

        private string[] Aftreksom()
        {
            int num1 = 0;
            int num2 = 0;

            while (juisteAnt < 100)
            {
                num1 = r.Next(100, 1000);
                num2 = r.Next(100, 1000);
                juisteAnt = num1 - num2;
            }

            int[] antwoorden = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int n1;
                int n2;

                while (antwoorden[i] < 100)
                {
                    n1 = r.Next(100, 1000);
                    n2 = r.Next(100, 1000);
                    antwoorden[i] = n1 - n2;
                }

                while ((antwoorden[i] < (juisteAnt * 0.67) || antwoorden[i] > (juisteAnt * 1.33)) && antwoorden[i] == juisteAnt)
                {
                    while (antwoorden[i] < 100)
                    {
                        n1 = r.Next(100, 1000);
                        n2 = r.Next(100, 1000);
                        antwoorden[i] = n1 - n2;
                    }
                }
            }

            antwoorden = AMGA(juisteAnt, antwoorden);

            string[] somData = new string[7];
            somData[0] = num1.ToString();
            somData[1] = "-";
            somData[2] = num2.ToString();

            for (int i = 0; i < 4; i++)
            {
                somData[i + 3] = antwoorden[i].ToString();
            }

            return somData;
        }

        private string[] Keersom()
        {
            int num1 = r.Next(5, 16);
            int num2 = r.Next(5, 16);
            juisteAnt = num1 * num2;

            int[] antwoorden = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int n1 = r.Next(5, 16);
                int n2 = r.Next(5, 16);
                antwoorden[i] = n1 * n2;

                while (antwoorden[i] == juisteAnt)
                {
                    n1 = r.Next(5, 16);
                    n2 = r.Next(5, 16);
                    antwoorden[i] = n1 * n2;
                }
            }

            antwoorden = AMGA(juisteAnt, antwoorden);

            string[] somData = new string[7];
            somData[0] = num1.ToString();
            somData[1] = "*";
            somData[2] = num2.ToString();

            for (int i = 0; i < 4; i++)
            {
                somData[i + 3] = antwoorden[i].ToString();
            }

            return somData;
        }

        private string[] Deelsom()
        {
            int num2 = 0;
            int num3 = r.Next(5, 16);
            int num4 = r.Next(5, 16);
            int num1 = num3 * num4;

            if (num3 <= num4)
            {
                juisteAnt = num3;
                num2 = num4;
            }

            else
            {
                juisteAnt = num4;
                num2 = num3;
            }

            int[] antwoorden = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int n2;
                int n3 = r.Next(5, 16);
                int n4 = r.Next(5, 16);
                int n1 = n3 * n4;

                if (n3 <= n4)
                {
                    antwoorden[i] = n3;
                    n2 = n4;
                }

                else
                {
                    antwoorden[i] = n4;
                    n2 = n3;
                }

                while (antwoorden[i] == juisteAnt)
                {
                    n3 = r.Next(5, 16);
                    n4 = r.Next(5, 16);
                    n1 = n3 * n4;

                    if (n3 <= n4)
                    {
                        antwoorden[i] = n3;
                        n2 = n4;
                    }

                    else
                    {
                        antwoorden[i] = n4;
                        n2 = n3;
                    }
                }
            }

            antwoorden = AMGA(juisteAnt, antwoorden);

            string[] somData = new string[7];
            somData[0] = num1.ToString();
            somData[1] = "/";
            somData[2] = num2.ToString();

            for (int i = 0; i < 4; i++)
            {
                somData[i + 3] = antwoorden[i].ToString();
            }

            return somData;
        }

        private void SpelAfgelopen()
        {
            if (fout > 2 || tijdLoopt == false)
            {
                if (goed > besteScore) { besteScore = goed; }
                label_BesteScore.Text = "Beste score: " + besteScore.ToString();

                vorigeScore = goed;
                label_VorigeScore.Text = "Vorige score: " + vorigeScore.ToString();

                scores.Add(goed);
                scores.Sort();
                scores.Reverse();

                double totaalgoed = 0;

                listBox_BesteScores.Items.Clear();

                foreach (var score in scores)
                {
                    listBox_BesteScores.Items.Add(score);
                    totaalgoed += score;
                }

                gemScore = totaalgoed / scores.Count;
                label_GemiddeldeScore.Text = "Gemiddelde score: " + Math.Round(gemScore, 2).ToString();

                if (tijdLoopt) { vraag = -1; }
                else { vraag = -0.5; }
                start = true;
                tijdLoopt = true;
                goed = -1;
                fout = -1;
                juisteAnt = 0;
                _ticks = 60;
                tijdLoopt = true;

                timer1.Start();
                NieuweSom();
                Antwoord_Een.Checked = true;
                label_Goed.Text = "0";
                label_Fout.Text = "0";
            }
        }

        //Home _homeForm;
        public Spel()
        {
            InitializeComponent();
            NieuweSom();
            label_BesteScore.Text = "Beste score: " + besteScore.ToString();
            label_VorigeScore.Text = "Vorige score: " + vorigeScore.ToString();
            label_GemiddeldeScore.Text = "Gemiddelde score: " + gemScore.ToString();
        }

        private void Spel_Load(object sender, EventArgs e)
        {

        }

        private void Antwoord_Een_CheckedChanged(object sender, EventArgs e)
        {
            Resultaat(Antwoord_Een);
            NieuweSom();
            SpelAfgelopen();
        }

        private void Antwoord_Twee_CheckedChanged(object sender, EventArgs e)
        {
            Resultaat(Antwoord_Twee);
            NieuweSom();
            SpelAfgelopen();
        }

        private void Antwoord_Drie_CheckedChanged(object sender, EventArgs e)
        {
            Resultaat(Antwoord_Drie);
            NieuweSom();
            SpelAfgelopen();
        }

        private void Antwoord_Vier_CheckedChanged(object sender, EventArgs e)
        {
            Resultaat(Antwoord_Vier);
            NieuweSom();
            SpelAfgelopen();
        }

        private void Som_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks--;
            Tijd.Text = "Tijd over: " + _ticks.ToString() + "s";

            if (_ticks <= 0)
            {
                Tijd.Text = "Tijd voorbij.";
                timer1.Stop();
                tijdLoopt = false;
                SpelAfgelopen();
            }
        }
    }
}
