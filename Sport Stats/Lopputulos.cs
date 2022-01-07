using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitustyö
{
    public partial class frmLopputulos : Form
    {
        public frmLopputulos()
        {
            InitializeComponent();
        }      

        //Luodaan otsikot datagridiin ja suoritetaan funktiot
        private void Lopputulos_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Pelaaja", "Pelaaja");
            dataGridView1.Columns.Add("Joukkue", "Joukkue");
            dataGridView1.Columns.Add("Maalit", "Maalit");
            dataGridView1.Columns.Add("Syötöt", "Syötöt");

            NäytäJoukkueet();
            NäytäMaalitjaSyötöt();
            NäytäPistetilastot();
            LisääSyötöt();
            Luotilastotiedostot();
            TallennaPelinTiedot();
            LisääJoukkueidentilastot();
            LisääPelaajienTilastot();
        }

        //Lataa oikat joukkueet otsikkoon
        public void NäytäJoukkueet()
        {
            StreamReader sr = new StreamReader("c:\\temp\\joukkuevalinta.txt");
            lblJoukkue1.Text = sr.ReadLine();
            lblJoukkue2.Text = sr.ReadLine();
            sr.Close();         
        }

        //Ladataan kaikki maalit ja syötöt datagridiin
        int koti = 0, vieras = 0;
        bool ehto = true;
        public void NäytäMaalitjaSyötöt()
        {
            if (File.Exists("c:\\temp\\Maalit.txt"))
            {
                FileStream fs = new FileStream("c:\\temp\\Maalit.txt",
                FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fs);
                if (sr.ReadLine() == "")
                {
                    while (ehto)
                    {
                        if (sr.EndOfStream)
                        {
                            ehto = false;
                            lblJoukkue2Tulos.Text = vieras.ToString();
                            lblJoukkue1Tulos.Text = koti.ToString();
                            sr.Close();
                        }

                        else
                        {
                            sr.ReadLine();
                            if (sr.ReadLine() == lblJoukkue1.Text)
                                koti++;
                            else
                                vieras++;
                            sr.ReadLine();
                            sr.ReadLine();
                            sr.ReadLine();
                        }
                    }
                    sr.Close();
                }

                else
                {
                    sr.ReadLine();
                    sr.Close();
                }
            }           
        }

        //Lisätään oikea maalimäärä pelaajalle ja poistetaan muut pelaajan nimet taulukosta
        public void NäytäPistetilastot()
        {
            if (File.Exists("c:\\temp\\Maalit.txt"))
            {
                int maalimäärä = (int.Parse(lblJoukkue1Tulos.Text)) + (int.Parse(lblJoukkue2Tulos.Text));

                if (maalimäärä != 0)
                {
                    StreamReader sr = new StreamReader("c:\\temp\\Maalit.txt");
                    string[] maalintekijät = new string[maalimäärä];
                    int[] maalit = new int[maalimäärä];
                    string[] maalintekijäjoukkue = new string[maalimäärä];

                    for (int i = 0; i < maalimäärä; i++)
                    {
                        sr.ReadLine();
                        sr.ReadLine();
                        maalintekijäjoukkue[i] = sr.ReadLine();
                        maalintekijät[i] = sr.ReadLine();
                        maalit[i] = 1;
                        sr.ReadLine();                      
                    }

                    for (int i = 0; i < maalimäärä; i++)
                    {
                        dataGridView1.Rows.Add(maalintekijät[i],maalintekijäjoukkue[i], maalit[i], "0");
                    }
           
                    sr.Close();

                    string kohde, verrattava, maali;
                    int maalii;
                    for (int i = 0; i < maalimäärä; i++)
                    {
                        verrattava = dataGridView1.Rows[i].Cells[0].Value.ToString();

                        for (int j = 0; j < maalimäärä; j++)
                        {
                            kohde = dataGridView1.Rows[j].Cells[0].Value.ToString();

                            if (verrattava == kohde)
                            {
                                maalii = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                                maalii++;
                                maali = maalii.ToString();
                                dataGridView1.Rows[i].Cells[2].Value = maali;

                            }
                            this.Refresh();
                        }
                    }

                    for (int k = 0; k < maalimäärä; k++)
                    {
                        int maalimäärävähennys;
                        maalimäärävähennys = int.Parse(dataGridView1.Rows[k].Cells[2].Value.ToString());
                        maalimäärävähennys--;
                        dataGridView1.Rows[k].Cells[2].Value = maalimäärävähennys.ToString();
                    }

                    int rivi = int.Parse(dataGridView1.Rows.Count.ToString());

                    string tekijä, tekijä2;
                    for (int l = 0; l < rivi; l++)
                    {
                        tekijä = dataGridView1.Rows[l].Cells[0].Value.ToString();

                        for (int x = l + 1; x < rivi; x++)
                        {
                            tekijä2 = dataGridView1.Rows[x].Cells[0].Value.ToString();
                            if (tekijä == tekijä2)
                            {
                                dataGridView1.Rows.Remove(dataGridView1.Rows[x]);
                                x--;
                            }
                            rivi = int.Parse(dataGridView1.Rows.Count.ToString());
                        }
                    }
                }                
            }
        }

        //Lisätään oikea syöttömäärä ja poistetaan turhat nimet, ja jos pelaajalla vain syöttöjä niin luodaan uusi rivi taulukkoon
        public void LisääSyötöt()
        {
            if (File.Exists("c:\\temp\\Maalit.txt"))
            {
                int maalimäärä = (int.Parse(lblJoukkue1Tulos.Text)) + (int.Parse(lblJoukkue2Tulos.Text)),
                    pelaaja, syöttömäärä;
                string käsiteltäväpelaaja, käsiteltävänpelaajanjoukkue;
                bool ehto;

                if (maalimäärä != 0)
                {
                    StreamReader sr = new StreamReader("c:\\temp\\Maalit.txt");

                    for (int i = 0; i < maalimäärä; i++)
                    {
                        sr.ReadLine();
                        sr.ReadLine();
                        käsiteltävänpelaajanjoukkue = sr.ReadLine();
                        sr.ReadLine();                                      
                        käsiteltäväpelaaja = sr.ReadLine();

                        if (käsiteltäväpelaaja == "Ei syöttäjää")
                        {
                            
                        }                           

                        else
                        {
                            pelaaja = 0;
                            ehto = true;
                            while (ehto)
                            {
                                if (pelaaja == dataGridView1.Rows.Count)
                                {
                                    dataGridView1.Rows.Add(käsiteltäväpelaaja, käsiteltävänpelaajanjoukkue, "0", "1");
                                    ehto = false;
                                }

                                else if (dataGridView1.Rows[pelaaja].Cells[0].Value.ToString() == käsiteltäväpelaaja)
                                {
                                    syöttömäärä = int.Parse(dataGridView1.Rows[pelaaja].Cells[3].Value.ToString());
                                    dataGridView1.Rows[pelaaja].Cells[3].Value = syöttömäärä++.ToString();
                                    ehto = false;
                                }

                                else
                                    pelaaja++;
                            }
                        }
                    }
                    sr.Close();
                }
            }
        }

        //Lisää Jalkapallopelit tiedostoon maalit ja poistaa turhat tiedostot
        public void TallennaPelinTiedot()
        {
            int rivimäärä;
            string maalinaika, maalintekijä, loppumisaika;

            if (File.Exists("c:\\temp\\Maalit.txt"))
            {
                rivimäärä = File.ReadLines("c:\\temp\\Maalit.txt").Count();

                StreamWriter sw = new StreamWriter("c:\\temp\\Pelit.txt", true);
                StreamReader sr = new StreamReader("c:\\temp\\Maalit.txt");
                StreamReader srl = new StreamReader("c:\\temp\\Loppumisaika.txt");

                for (int i = 0; i < rivimäärä / 5; i++)
                {
                    sr.ReadLine();
                    maalinaika = sr.ReadLine();
                    maalintekijä = sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sw.WriteLine(maalintekijä + "  " + maalinaika);
                }

                loppumisaika = srl.ReadLine();
                sw.WriteLine(loppumisaika);

                sw.Close();
                sr.Close();
                srl.Close();
            }
            File.Delete("c:\\temp\\Loppumisaika.txt");
            File.Delete("c:\\temp\\FC Honka.txt");
            File.Delete("c:\\temp\\FC Inter.txt");
            File.Delete("c:\\temp\\FC Lahti.txt");
            File.Delete("c:\\temp\\HIFK.txt");
            File.Delete("c:\\temp\\joukkuevalinta.txt");     
        }

        //Luodaan joukkueiden pelaajien tilastot, jos niitä ei ole jo valmiina
        public void Luotilastotiedostot()
        {
            if (File.Exists("c:\\temp\\FC_Honka_Tilastot.txt") == false)
            {
                int rivimäärä = File.ReadLines("c:\\temp\\FC Honka.txt").Count();
                StreamReader sr = new StreamReader("c:\\temp\\FC Honka.txt");
                StreamWriter sw = new StreamWriter("c:\\temp\\FC_Honka_Tilastot.txt");
                string luettava, kirjoitettava;
                sw.WriteLine("Pelaajien tilastot ilmoitetaan muodossa:");
                sw.WriteLine("Pelaaja");
                sw.WriteLine("Maalit");
                sw.WriteLine("Syötö");
                sw.WriteLine(".");
                sw.WriteLine(".");
                sw.WriteLine(".");
                for (int i = 0; i < rivimäärä; i++)
                {
                    if (sr.ReadLine() != null)
                    {
                        luettava = sr.ReadLine();
                        kirjoitettava = luettava;
                        sw.WriteLine(kirjoitettava);
                        sw.WriteLine("0");
                        sw.WriteLine("0");
                    }

                    else
                        break;
                }
                sr.Close();
                sw.Close();
            }

            if (File.Exists("c:\\temp\\FC_Inter_Tilastot.txt") == false)
            {
                int rivimäärä = File.ReadLines("c:\\temp\\FC Inter.txt").Count();
                StreamReader sr = new StreamReader("c:\\temp\\FC Inter.txt");
                StreamWriter sw = new StreamWriter("c:\\temp\\FC_Inter_Tilastot.txt");
                string luettava, kirjoitettava;
                sw.WriteLine("Pelaajien tilastot ilmoitetaan muodossa:");
                sw.WriteLine("Pelaaja");
                sw.WriteLine("Maalit");
                sw.WriteLine("Syötö");
                sw.WriteLine(".");
                sw.WriteLine(".");
                sw.WriteLine(".");
                for (int i = 0; i < rivimäärä; i++)
                {
                    if (sr.ReadLine() != null)
                    {
                        luettava = sr.ReadLine();
                        kirjoitettava = luettava;
                        sw.WriteLine(kirjoitettava);
                        sw.WriteLine("0");
                        sw.WriteLine("0");
                    }

                    else
                        break;
                }
                sr.Close();
                sw.Close();
            }

            if (File.Exists("c:\\temp\\FC_Lahti_Tilastot.txt") == false)
            {
                int rivimäärä = File.ReadLines("c:\\temp\\FC Lahti.txt").Count();
                StreamReader sr = new StreamReader("c:\\temp\\FC Lahti.txt");
                StreamWriter sw = new StreamWriter("c:\\temp\\FC_Lahti_Tilastot.txt");
                string luettava, kirjoitettava;
                sw.WriteLine("Pelaajien tilastot ilmoitetaan muodossa:");
                sw.WriteLine("Pelaaja");
                sw.WriteLine("Maalit");
                sw.WriteLine("Syötö");
                sw.WriteLine(".");
                sw.WriteLine(".");
                sw.WriteLine(".");
                for (int i = 0; i < rivimäärä; i++)
                {
                    if (sr.ReadLine() != null)
                    {
                        luettava = sr.ReadLine();
                        kirjoitettava = luettava;
                        sw.WriteLine(kirjoitettava);
                        sw.WriteLine("0");
                        sw.WriteLine("0");
                    }
                    else
                        break;
                }
                sr.Close();
                sw.Close();
            }

            if (File.Exists("c:\\temp\\HIFK_Tilastot.txt") == false)
            {
                int rivimäärä = File.ReadLines("c:\\temp\\HIFK.txt").Count();
                StreamReader sr = new StreamReader("c:\\temp\\HIFK.txt");
                StreamWriter sw = new StreamWriter("c:\\temp\\HIFK_Tilastot.txt");
                string luettava, kirjoitettava;
                sw.WriteLine("Pelaajien tilastot ilmoitetaan muodossa:");
                sw.WriteLine("Pelaaja");
                sw.WriteLine("Maalit");
                sw.WriteLine("Syötö");
                sw.WriteLine(".");
                sw.WriteLine(".");
                sw.WriteLine(".");
                for (int i = 0; i < rivimäärä; i++)
                {
                    if (sr.ReadLine() != null)
                    {
                        luettava = sr.ReadLine();
                        kirjoitettava = luettava;
                        sw.WriteLine(kirjoitettava);
                        sw.WriteLine("0");
                        sw.WriteLine("0");
                    }

                    else
                        break;
                }
                sr.Close();
                sw.Close();
            }

            if (File.Exists("c:\\temp\\Joukkueiden_Tilastot.txt") == false)
            {               
                StreamWriter sw = new StreamWriter("c:\\temp\\Joukkueiden_Tilastot.txt");
                sw.WriteLine("Joukkueiden tilastot ilmoitetaan muodossa:");
                sw.WriteLine("Joukkue");
                sw.WriteLine("Voitot");
                sw.WriteLine("Tasapelit");
                sw.WriteLine("Häviöt");
                sw.WriteLine(".");
                sw.WriteLine(".");
                sw.WriteLine(".");
                sw.WriteLine("FC Honka");
                sw.WriteLine("0");
                sw.WriteLine("0");
                sw.WriteLine("0");
                sw.WriteLine("FC Inter");
                sw.WriteLine("0");
                sw.WriteLine("0");
                sw.WriteLine("0");
                sw.WriteLine("FC Lahti");
                sw.WriteLine("0");
                sw.WriteLine("0");
                sw.WriteLine("0");
                sw.WriteLine("HIFK");
                sw.WriteLine("0");
                sw.WriteLine("0");
                sw.WriteLine("0");
                sw.Close();
            }            
        }

        //Lisätään tilastot Joukkueiden_Tilastot-tiedostoon
        public void LisääJoukkueidentilastot()
        {
            if (int.Parse(lblJoukkue1Tulos.Text) > int.Parse(lblJoukkue2Tulos.Text))
            {
                int rivit = File.ReadAllLines("c:\\temp\\Joukkueiden_Tilastot.txt").Count();
                string[] tiedosto = new string[rivit + 1];
                StreamReader sr = new StreamReader("c:\\temp\\Joukkueiden_Tilastot.txt");

                for (int i = 0; i < rivit; i++)
                {
                    tiedosto[i] = sr.ReadLine();
                }
                sr.Close();

                for (int i = 0; i < rivit; i++)
                {
                    if (tiedosto[i] == lblJoukkue1.Text)
                    {
                        int luku = int.Parse(tiedosto[i + 1]);
                        luku++;
                        tiedosto[i + 1] = luku.ToString();
                    }
                }

                StreamWriter sw = new StreamWriter("c:\\temp\\Joukkueiden_Tilastot.txt");
                for (int i = 0; i < rivit; i++)
                {
                    sw.WriteLine(tiedosto[i]);
                }
                sw.Close();

                ToinenJoukkue1();
            }

            if (int.Parse(lblJoukkue1Tulos.Text) < int.Parse(lblJoukkue2Tulos.Text))
            {
                int rivit = File.ReadAllLines("c:\\temp\\Joukkueiden_Tilastot.txt").Count();
                string[] tiedosto = new string[rivit + 1];
                StreamReader sr = new StreamReader("c:\\temp\\Joukkueiden_Tilastot.txt");

                for (int i = 0; i < rivit; i++)
                {
                    tiedosto[i] = sr.ReadLine();
                }
                sr.Close();

                for (int i = 0; i < rivit; i++)
                {
                    if (tiedosto[i] == lblJoukkue2.Text)
                    {
                        int luku = int.Parse(tiedosto[i + 1]);
                        luku++;
                        tiedosto[i + 1] = luku.ToString();
                    }
                }

                StreamWriter sw = new StreamWriter("c:\\temp\\Joukkueiden_Tilastot.txt");
                for (int i = 0; i < rivit; i++)
                {
                    sw.WriteLine(tiedosto[i]);
                }
                sw.Close();

                ToinenJoukkue2();
            }

            else
            {
                LisääTasapeli1();
                LisääTasapeli2();
            }
        }

        //Lisätään kotijoukkueen tilastot
        public void ToinenJoukkue1()
        {
            int rivit = File.ReadAllLines("c:\\temp\\Joukkueiden_Tilastot.txt").Count();
            string[] tiedosto = new string[rivit + 3];
            StreamReader sr = new StreamReader("c:\\temp\\Joukkueiden_Tilastot.txt");

            for (int i = 0; i < rivit; i++)
            {
                tiedosto[i] = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == lblJoukkue2.Text)
                {
                    int luku = int.Parse(tiedosto[i + 3]);
                    luku++;
                    tiedosto[i + 3] = luku.ToString();
                }
            }

            StreamWriter sw = new StreamWriter("c:\\temp\\Joukkueiden_Tilastot.txt");
            for (int i = 0; i < rivit; i++)
            {
                sw.WriteLine(tiedosto[i]);
            }
            sw.Close();
        }

        //Lisätään vierasjoukkueen tilastot
        public void ToinenJoukkue2()
        {
            int rivit = File.ReadAllLines("c:\\temp\\Joukkueiden_Tilastot.txt").Count();
            string[] tiedosto = new string[rivit + 3];
            StreamReader sr = new StreamReader("c:\\temp\\Joukkueiden_Tilastot.txt");

            for (int i = 0; i < rivit; i++)
            {
                tiedosto[i] = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == lblJoukkue1.Text)
                {
                    int luku = int.Parse(tiedosto[i + 3]);
                    luku++;
                    tiedosto[i + 3] = luku.ToString();
                }
            }

            StreamWriter sw = new StreamWriter("c:\\temp\\Joukkueiden_Tilastot.txt");
            for (int i = 0; i < rivit; i++)
            {
                sw.WriteLine(tiedosto[i]);
            }
            sw.Close();
        }

        //Lisätään kotijoukkueen tasapeli, jos sellainen tulee
        public void LisääTasapeli1()
        {
            int rivit = File.ReadAllLines("c:\\temp\\Joukkueiden_Tilastot.txt").Count();
            string[] tiedosto = new string[rivit + 2];
            StreamReader sr = new StreamReader("c:\\temp\\Joukkueiden_Tilastot.txt");

            for (int i = 0; i < rivit; i++)
            {
                tiedosto[i] = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == lblJoukkue1.Text)
                {
                    int luku = int.Parse(tiedosto[i + 2]);
                    luku++;
                    tiedosto[i + 2] = luku.ToString();
                }
            }

            StreamWriter sw = new StreamWriter("c:\\temp\\Joukkueiden_Tilastot.txt");
            for (int i = 0; i < rivit; i++)
            {
                sw.WriteLine(tiedosto[i]);
            }
            sw.Close();
        }

        //Lisätään vierasjoukkueen tasapeli, jos sellainen tulee
        public void LisääTasapeli2()
        {
            int rivit = File.ReadAllLines("c:\\temp\\Joukkueiden_Tilastot.txt").Count();
            string[] tiedosto = new string[rivit + 2];
            StreamReader sr = new StreamReader("c:\\temp\\Joukkueiden_Tilastot.txt");

            for (int i = 0; i < rivit; i++)
            {
                tiedosto[i] = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == lblJoukkue2.Text)
                {
                    int luku = int.Parse(tiedosto[i + 2]);
                    luku++;
                    tiedosto[i + 2] = luku.ToString();
                }
            }

            StreamWriter sw = new StreamWriter("c:\\temp\\Joukkueiden_Tilastot.txt");
            for (int i = 0; i < rivit; i++)
            {
                sw.WriteLine(tiedosto[i]);
            }
            sw.Close();
        }

        //LIsätään pelaajien tilastot tiedostoon
        public void LisääPelaajienTilastot()
        {
            if (File.Exists("c:\\temp\\Maalit.txt"))
            {
                int rivit = File.ReadAllLines("c:\\temp\\Maalit.txt").Count();
                string joukkue, tekijä, syöttäjä;
                StreamReader sr = new StreamReader("c:\\temp\\Maalit.txt");

                for (int i = 0; i < rivit; i++)
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    joukkue = sr.ReadLine();
                    tekijä = sr.ReadLine();
                    syöttäjä = sr.ReadLine();

                    if (joukkue == "FC Honka")
                        HonkaPelaajat(tekijä, syöttäjä);

                    if (joukkue == "FC Inter")
                        InterPelaajat(tekijä, syöttäjä);

                    if (joukkue == "FC Lahti")
                        LahtiPelaajat(tekijä, syöttäjä);

                    if (joukkue == "HIFK")
                        HIFKPelaajat(tekijä, syöttäjä);
                }
                sr.Close();
                File.Delete("c:\\temp\\Maalit.txt");
            }
        }

        //Luetaan tiedosta ja päivitetään tilastot ja kirjoitetaan tiedosto uudelleen
        public void HonkaPelaajat(string tekijä, string syöttäjä)
        {
            int rivit = File.ReadAllLines("c:\\temp\\FC_Honka_Tilastot.txt").Count();
            string[] tiedosto = new string[rivit + 2];
            StreamReader sr = new StreamReader("c:\\temp\\FC_Honka_Tilastot.txt");

            for (int i = 0; i < rivit; i++)
            {
                tiedosto[i] = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == tekijä)
                {
                    int luku = int.Parse(tiedosto[i + 1]);
                    luku++;
                    tiedosto[i + 1] = luku.ToString();
                }
            }

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == syöttäjä)
                {
                    int luku = int.Parse(tiedosto[i + 2]);
                    luku++;
                    tiedosto[i + 2] = luku.ToString();
                }
            }

            StreamWriter sw = new StreamWriter("c:\\temp\\FC_Honka_Tilastot.txt");
            for (int i = 0; i < rivit; i++)
            {
                sw.WriteLine(tiedosto[i]);
            }
            sw.Close();
        }

        //Luetaan tiedosta ja päivitetään tilastot ja kirjoitetaan tiedosto uudelleen
        public void InterPelaajat(string tekijä, string syöttäjä)
        {
            int rivit = File.ReadAllLines("c:\\temp\\FC_Inter_Tilastot.txt").Count();
            string[] tiedosto = new string[rivit + 2];
            StreamReader sr = new StreamReader("c:\\temp\\FC_Inter_Tilastot.txt");

            for (int i = 0; i < rivit; i++)
            {
                tiedosto[i] = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == tekijä)
                {
                    int luku = int.Parse(tiedosto[i + 1]);
                    luku++;
                    tiedosto[i + 1] = luku.ToString();
                }
            }

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == syöttäjä)
                {
                    int luku = int.Parse(tiedosto[i + 2]);
                    luku++;
                    tiedosto[i + 2] = luku.ToString();
                }
            }

            StreamWriter sw = new StreamWriter("c:\\temp\\FC_Inter_Tilastot.txt");
            for (int i = 0; i < rivit; i++)
            {
                sw.WriteLine(tiedosto[i]);
            }
            sw.Close();
        }

        //Luetaan tiedosta ja päivitetään tilastot ja kirjoitetaan tiedosto uudelleen
        public void LahtiPelaajat(string tekijä, string syöttäjä)
        {
            int rivit = File.ReadAllLines("c:\\temp\\FC_Lahti_Tilastot.txt").Count();
            string[] tiedosto = new string[rivit + 2];
            StreamReader sr = new StreamReader("c:\\temp\\FC_Lahti_Tilastot.txt");

            for (int i = 0; i < rivit; i++)
            {
                tiedosto[i] = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == tekijä)
                {
                    int luku = int.Parse(tiedosto[i + 1]);
                    luku++;
                    tiedosto[i + 1] = luku.ToString();
                }
            }

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == syöttäjä)
                {
                    int luku = int.Parse(tiedosto[i + 2]);
                    luku++;
                    tiedosto[i + 2] = luku.ToString();
                }
            }

            StreamWriter sw = new StreamWriter("c:\\temp\\FC_Lahti_Tilastot.txt");
            for (int i = 0; i < rivit; i++)
            {
                sw.WriteLine(tiedosto[i]);
            }
            sw.Close();
        }

        //Luetaan tiedosta ja päivitetään tilastot ja kirjoitetaan tiedosto uudelleen
        public void HIFKPelaajat(string tekijä, string syöttäjä)
        {
            int rivit = File.ReadAllLines("c:\\temp\\HIFK_Tilastot.txt").Count();
            string[] tiedosto = new string[rivit + 2];
            StreamReader sr = new StreamReader("c:\\temp\\HIFK_Tilastot.txt");

            for (int i = 0; i < rivit; i++)
            {
                tiedosto[i] = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == tekijä)
                {
                    int luku = int.Parse(tiedosto[i + 1]);
                    luku++;
                    tiedosto[i + 1] = luku.ToString();
                }
            }

            for (int i = 0; i < rivit; i++)
            {
                if (tiedosto[i] == syöttäjä)
                {
                    int luku = int.Parse(tiedosto[i + 2]);
                    luku++;
                    tiedosto[i + 2] = luku.ToString();
                }
            }

            StreamWriter sw = new StreamWriter("c:\\temp\\HIFK_Tilastot.txt");
            for (int i = 0; i < rivit; i++)
            {
                sw.WriteLine(tiedosto[i]);
            }
            sw.Close();
        }
    }
}
