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
    public partial class frmSalibandytilastot : Form
    {               
        public frmSalibandytilastot()
        {
            InitializeComponent();           
        }

        bool handled; // muuttuja estämään nappien painamisen uudelleen Space-näppäimellä

        //Pysäyttää kellon ja asettaa kellon värin punaiseksi
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (handled)
            {
                handled = false;
                return;
            }

            lblkello.ForeColor = Color.Red;                    
            timerKello.Stop();                 
        }

        int tiedostonlisäys = 0;
        //Käynnistää kellon, asettaa kellon värin vihreäksi ja lukee maalien määrän ja päivittää joukkueiden maalit näytölle
        public void btnStart_Click(object sender, EventArgs e)
        {
            if (handled)
            {
                handled = false;
                return;
            }

            timerKello.Interval = 1000;
            timerKello.Start();
            lblkello.ForeColor = Color.LimeGreen;

            int laskin = 0, koti = 0, vieras = 0;
            bool ehto = true;

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
                            lblMaaliVieras.Text = vieras.ToString();
                            lblMaaliKoti.Text = koti.ToString();
                            sr.Close();
                        }

                        else
                        {
                            laskin++;
                            sr.ReadLine();
                            if (sr.ReadLine() == lblJoukkueKoti.Text)
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

            //Luodaan jalkapallopelien tiedosto/kirjoitetaan tiedostoon uusi peli
            if (tiedostonlisäys == 0)
            {
                if (File.Exists("c:\\temp\\Pelit.txt"))
                {
                    DateTime aika = DateTime.Now;
                    StreamWriter sw = new StreamWriter("c:\\temp\\Pelit.txt", true);
                    sw.WriteLine();
                    sw.WriteLine("Alkamisaika: " + aika);
                    sw.WriteLine(lblJoukkueKoti.Text + " / " + lblJoukkueVieras.Text);
                    sw.WriteLine("Maalit:");
                    sw.Close();
                    tiedostonlisäys++;
                }

                else
                {
                    DateTime aika = DateTime.Now;
                    StreamWriter sw = new StreamWriter("c:\\temp\\Pelit.txt");
                    sw.WriteLine();
                    sw.WriteLine("Alkamisaika: " + aika);
                    sw.WriteLine(lblJoukkueKoti.Text + " / " + lblJoukkueVieras.Text);
                    sw.WriteLine("Maalit:");
                    sw.Close();
                    tiedostonlisäys++;
                }
            }
        }

        //Funktio joka asettaa nappulat tiettyyn tilaan ehdon mukaan
        public void Nappuloidentila(bool ehto)
        {
            if (ehto == true)
            {
                btnAloitaera.Enabled = true;
                btnStart.Enabled = false;
                btnAikamuokkaus.Enabled = false;
                btnAikamuokkausMiinus.Enabled = false;
                btnAikamuokkausPlus.Enabled = false;
                btnStop.Enabled = false;
                btnMaali.Enabled = false;             
                btnAloitaera.Click += btnAloitaera_Click;              
            }
            if (ehto == false)
            {
                btnAloitaera.Enabled = false;
                btnStart.Enabled = true;
                btnAikamuokkaus.Enabled = true;
                btnAikamuokkausMiinus.Enabled = true;
                btnAikamuokkausPlus.Enabled = true;
                btnStop.Enabled = true;
                btnMaali.Enabled = true;
                btnAloitaera.Click -= btnAloitaera_Click;
            }
        }

        int erä = 0;
        //Aloitetaan erä sekä päivitetään eän numero
        private void btnAloitaera_Click(object sender, EventArgs e)
        {
            erä++;
            btnAloitaera.BackColor = Color.Silver;
            btnAloitaera.Text = "Erä aloitettu";
            Nappuloidentila(false);

            if (erä == 2)
                lblEra.Text = "Erä 1";

            else if (erä == 4)
                lblEra.Text = "Erä 2";

            else
                lblEra.Text = "Erä 3";
        }

        int sekunti = 0, uusi_sekunti = 0, minuutti = 0, uusi_minuutti = 0;
        /*Kello ajanmuokkausta varten. Ajanmuokkauksessa luodaan toinen label oikean kellon päälle.
        sitten kun oikea kello käynnistetään se tulee näkyviin. */
        private void timerPäivitys_Tick(object sender, EventArgs e)
        {            
            string aika = "";

            if (uusi_sekunti > sekunti)
            {            
                if (min < 10)
                    aika += "0" + min;

                else
                    aika += min;

                aika += ":";

                if (sec > 59)
                {
                    sec = 0;    
                }

                if (sec < 10)
                    aika += "0" + (sec).ToString(); 

                else aika += (sec).ToString();

                if (sec == 00)
                {
                    min--;
                    sec = 59;
                }

                lblkello.Text = aika;
                sekunti = uusi_sekunti;
            }

            if (uusi_sekunti < sekunti)
            {
                if (min < 10)
                    aika += "0" + min;

                else
                {
                    aika += min;
                }

                aika += ":";

                if (sec < 0)
                {
                    sec = 59;
                }

                if (sec < 10)
                    aika += "0" + (sec).ToString();

                else aika += (sec).ToString();

                if (sec == 00)
                {
                    min--;
                    sec = 59;
                }

                lblkello.Text = aika;
                sekunti = uusi_sekunti;
            }

            if (uusi_minuutti > minuutti)
            {
                if (min < 10)
                    aika += "0" + (min).ToString();

                else
                    aika += (min).ToString();

                aika += ":";

                if (sec < 10)
                    aika += "0" + sec;

                else aika += sec;

                if (sec == 00)
                {
                    min--;
                    sec = 59;
                }

                lblkello.Text = aika;
                sekunti = uusi_sekunti;
            }

            if (uusi_minuutti < minuutti)
            {
                if (min < 10)
                    aika += "0" + (min).ToString();

                else
                    aika += (min).ToString();

                aika += ":";

                if (min < 0)
                    min = 0;

                if (sec < 10)
                    aika += "0" + sec;

                else aika += sec;

                if (sec == 00)
                {
                    min--;
                    sec = 59;
                }

                lblkello.Text = aika;
                sekunti = uusi_sekunti;
            }
            
        }

        //Asettaa kellon toiminnan ja jos erän kesto tulee täyteen kello pysäytetään, ja nappulat poistetaan käytöstä
        bool ehto = true, ehto2 = true;
        int sec = 60, min = 44;       
        private void timerKello_Tick(object sender, EventArgs e)
        {
            sec--;
            lblkello.Text = sec.ToString();

            string time = "";

            if (min < 10)
                time += "0" + min;

            else
                time += min;
            
            time += ":";

            if (sec < 10)
                time += "0" + sec;

            else time += sec;

            if (sec <= 0)
            {
                min--;
                sec = 59;
            }
                
            lblkello.Text = time;

            if (min <=30 && sec <= 1)
            {
                if (ehto)
                {
                    min = 30;
                    sec = 0;
                    lblkello.Text = "30:00";
                    timerKello.Stop();
                    Nappuloidentila(true);
                    btnAloitaera.Text = "Aloita erä";
                    var form8 = new frmEräntiedot();
                    form8.Show();
                }
                                                                                    
                erä++;
                ehto = false;

                if (min <= 15 && sec <= 1)
                {
                    if (ehto2)
                    {
                        min = 15;
                        sec = 0;
                        lblkello.Text = "15:00";
                        timerKello.Stop();
                        Nappuloidentila(true);
                        btnAloitaera.Text = "Aloita erä";
                        var form8 = new frmEräntiedot();
                        form8.Show();
                    }

                    erä++;
                    ehto2 = false;

                    if (min <= 0 && sec <= 1)
                    {
                        min = 0;
                        sec = 0;
                        StreamWriter sw = new StreamWriter("c:\\temp\\Loppumisaika.txt");
                        timerKello.Stop();
                        lblkello.Text = "00:00";
                        lblkello.ForeColor = Color.Red;
                        lblEra.Text = "";
                        Nappuloidentila(true);
                        btnAloitaera.Enabled = false;
                        btnAloitaera.Text = "Peli loppui";
                        btnPelinTiedot.Visible = true;
                        btnPelinTiedot.Enabled = true;
                        DateTime aika = DateTime.Now;
                        sw.WriteLine("Loppumisaika: " + aika);
                        sw.Close();
                    }
                }
            }                               
        }
      
        //Kellon ajan muokkauksen määrittäminen-----------------------
        private void btnAikamuokkaus_Click(object sender, EventArgs e)
        {
            if (handled)
            {
                handled = false;
                return;
            }

            if (btnAikamuokkaus.Text == "Minuutti")
            {
                btnAikamuokkaus.Text = "Sekunti";
            }
            else
            {
                btnAikamuokkaus.Text = "Minuutti";
            }
           
        }

        private void btnAikamuokkausPlus_Click(object sender, EventArgs e)
        {
            if (handled)
            {
                handled = false;
                return;
            }

            if (btnAikamuokkaus.Text == "Minuutti")
            {
                min = min + 1;
                uusi_minuutti = uusi_minuutti + 1;
            }
            else
            {
                sec = sec + 1;
                uusi_sekunti = uusi_sekunti + 1;
            }
        }

        private void btnAikamuokkausMiinus_Click(object sender, EventArgs e)
        {
            if (handled)
            {
                handled = false;
                return;
            }

            if (btnAikamuokkaus.Text == "Minuutti")
            {
                min = min - 1;
                uusi_minuutti = uusi_minuutti - 1;
            }
            else
            {
                sec = sec - 1;
                uusi_sekunti = uusi_sekunti - 1;
            }
        }
        //-------------------------------------------------------------
        private void btnValitseJoukkueet_Click(object sender, EventArgs e)
        {
            var form5 = new Joukkueet();          
            form5.Show();
        }

        //Alustetaan nappulat ja poistetaan mahdollinen kansio
        private void frmUrheilutiedotJalkapallo_Load(object sender, EventArgs e)
        {
            timerPäivitys.Start();
            Nappuloidentila(true);
            btnAloitaera.Enabled = false;
            btnPelinTiedot.Visible = false;
            btnPelinTiedot.Enabled = false;         

            if (File.Exists("c:\\temp\\joukkuevalinta.txt"))
            {
                File.Delete("c:\\temp\\joukkuevalinta.txt");
            }

            if (File.Exists("c:\\temp\\Maalit.txt"))
            {
                File.Delete("c:\\temp\\Maalit.txt");
            }      
        }

        //Asettaa oikean joukkueen pelaajat DataGridiin
        private void frmUrheilutiedotJalkapallo_MouseHover(object sender, EventArgs e)
        {
            
            string joukkue1 = "Joukkue1", joukkue2 = "Joukkue2";

            //Syötetään joukkueiden pelaajien tiedot

            Pelaajat[] honka = new Pelaajat[4];

            Pelaajat h1;
            h1.pelinro = "5";
            h1.etunimi = "Henri";
            h1.sukunimi = "Aalto";

            Pelaajat h2;
            h2.pelinro = "77";
            h2.etunimi = "Doni";
            h2.sukunimi = "Arifi";

            Pelaajat h3;
            h3.pelinro = "45";
            h3.etunimi = "Robbie";
            h3.sukunimi = "Azodo";

            Pelaajat h4;
            h4.pelinro = "3";
            h4.etunimi = "Gibeon";
            h4.sukunimi = "Baah";
            honka[0] = h1;
            honka[1] = h2;
            honka[2] = h3;
            honka[3] = h4;


            Pelaajat[] inter = new Pelaajat[4];

            Pelaajat i1;
            i1.pelinro = "11";
            i1.etunimi = "Albion";
            i1.sukunimi = "Ademi";

            Pelaajat i2;
            i2.pelinro = "30";
            i2.etunimi = "Mohammed";
            i2.sukunimi = "Al Bermanei";

            Pelaajat i3;
            i3.pelinro = "2";
            i3.etunimi = "Anthony";
            i3.sukunimi = "Annan";

            Pelaajat i4;
            i4.pelinro = "27";
            i4.etunimi = "Luciano";
            i4.sukunimi = "Balbi";
            inter[0] = i1;
            inter[1] = i2;
            inter[2] = i3;
            inter[3] = i4;


            Pelaajat[] lahti = new Pelaajat[4];

            Pelaajat l1;
            l1.pelinro = "19";
            l1.etunimi = "Jerenimo";
            l1.sukunimi = "Amione";

            Pelaajat l2;
            l2.pelinro = "3";
            l2.etunimi = "Mikko";
            l2.sukunimi = "Hauhia";

            Pelaajat l3;
            l3.pelinro = "18";
            l3.etunimi = "Teemu";
            l3.sukunimi = "Jäntti";

            Pelaajat l4;
            l4.pelinro = "23";
            l4.etunimi = "Tim";
            l4.sukunimi = "Marttinen";
            lahti[0] = l1;
            lahti[1] = l2;
            lahti[2] = l3;
            lahti[3] = l4;


            Pelaajat[] hifk = new Pelaajat[4];

            Pelaajat hi1;
            hi1.pelinro = "17";
            hi1.etunimi = "Jani";
            hi1.sukunimi = "Bäckman";

            Pelaajat hi2;
            hi2.pelinro = "9";
            hi2.etunimi = "Luis";
            hi2.sukunimi = "Henrique";

            Pelaajat hi3;
            hi3.pelinro = "18";
            hi3.etunimi = "Matias";
            hi3.sukunimi = "Hänninen";

            Pelaajat hi4;
            hi4.pelinro = "19";
            hi4.etunimi = "Kevin";
            hi4.sukunimi = "Larsson";
            hifk[0] = hi1;
            hifk[1] = hi2;
            hifk[2] = hi3;
            hifk[3] = hi4;

            //Luetaan tiedostosta ketkä pelaavat, ja sitten ladataan oikeiden pelaajien tiedot.

            if (File.Exists("c:\\temp\\joukkuevalinta.txt"))
            {
                StreamReader srj = new StreamReader("c:\\temp\\joukkuevalinta.txt");
                joukkue1 = srj.ReadLine();
                joukkue2 = srj.ReadLine();
                srj.Close();
                this.Refresh();
                lblJoukkueKoti.Text = joukkue1;
                lblJoukkueVieras.Text = joukkue2;
                btnAloitaera.Enabled = true;

                if (joukkue1 == "FC Honka" && joukkue2 == "FC Inter")
                {
                    dgKoti.DataSource = honka;
                    dgVieras.DataSource = inter;
                }

                if (joukkue2 == "FC Honka" && joukkue1 == "FC Inter")
                {
                    dgVieras.DataSource = honka;
                    dgKoti.DataSource = inter;
                }

                if (joukkue1 == "FC Honka" && joukkue2 == "FC Lahti")
                {
                    dgKoti.DataSource = honka;
                    dgVieras.DataSource = lahti;
                }

                if (joukkue1 == "FC Lahti" && joukkue2 == "FC Honka")
                {
                    dgKoti.DataSource = lahti;
                    dgVieras.DataSource = honka;
                }

                if (joukkue1 == "FC Honka" && joukkue2 == "HIFK")
                {
                    dgKoti.DataSource = honka;
                    dgVieras.DataSource = hifk;
                }

                if (joukkue1 == "HIFK" && joukkue2 == "FC Honka")
                {
                    dgVieras.DataSource = honka;
                    dgKoti.DataSource = hifk;
                }

                if (joukkue1 == "FC Inter" && joukkue2 == "FC Lahti")
                {
                    dgKoti.DataSource = inter;
                    dgVieras.DataSource = lahti;
                }

                if (joukkue2 == "FC Inter" && joukkue1 == "FC Lahti")
                {
                    dgVieras.DataSource = inter;
                    dgKoti.DataSource = lahti;
                }

                if (joukkue1 == "FC Inter" && joukkue2 == "HIFK")
                {
                    dgKoti.DataSource = inter;
                    dgVieras.DataSource = hifk;
                }

                if (joukkue2 == "FC Inter" && joukkue1 == "HIFK")
                {
                    dgVieras.DataSource = inter;
                    dgKoti.DataSource = hifk;
                }

                if (joukkue1 == "FC Lahti" && joukkue2 == "HIFK")
                {
                    dgKoti.DataSource = lahti;
                    dgVieras.DataSource = hifk;
                }

                if (joukkue2 == "FC Lahti" && joukkue1 == "HIFK")
                {
                    dgVieras.DataSource = lahti;
                    dgKoti.DataSource = hifk;
                }

                if (joukkue1 == joukkue2)
                {
                    MessageBox.Show("Et voi valita joukkuetta pelaamaa itseään vastaan\r                 Valitse uusi peli\r             File -> New -> Game");
                }
                btnValitseJoukkueet.Enabled = false;                                     
            }
        }

        //Lataa formin uudelleen
        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmSalibandytilastot();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void maalitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form8 = new frmMaalit();
            form8.Show();
        }

        //Asettaa dataGridin tekstien värin
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.dgVieras.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void dataGridView2_DataSourceChanged(object sender, EventArgs e)
        {
            this.dgKoti.DefaultCellStyle.ForeColor = Color.Black;
        }

        //Avaa pelin lopputulosnäkymän
        private void btnPelinTiedot_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmLopputulos();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        //Kun painaa space kello käy, ja kun painaa uudelleen kello pysähtyy.
        int muuttuja = 0;
        private void frmUrheilutiedotJalkapallo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (muuttuja % 2 == 0)
                {
                    btnStart.PerformClick();
                    muuttuja++;
                }

                else
                {
                    btnStop.PerformClick();
                    muuttuja++;
                }
            }
        }

        //-------------Estää nappuloiden painamisen uudestaan painamalla space---------
        private void btnStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                handled = true;
        }

        private void btnStop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                handled = true;
        }

        private void btnMaali_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                handled = true;
        }

        private void btnAikamuokkausPlus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                handled = true;
        }

        private void btnAikamuokkausMiinus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                handled = true;
        }

        private void btnPikakelaus_Click(object sender, EventArgs e)
        {
            if (handled)
            {
                handled = false;
                return;
            }

            if (btnPikakelaus.Text == "Normaali nopeus")
            {
                timerKello.Interval = 1;
                btnPikakelaus.Text = "  Pika-   kelaus";
            }
            else
            {
                btnPikakelaus.Text = "Normaali nopeus";
                timerKello.Interval = 1000;
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Tilastointiohjelman Käyttöohje.pdf");
        }

        private void btnAikamuokkaus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                handled = true;
        }
        //----------------------------------------------------------------------------

        //View nappuloiden toiminnallisuus
        private void jalkapallotilastotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmUrheilutiedotJalkapallo();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void jääkiekkotilastotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmJääkiekkotilastot();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void salibandytilastotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmSalibandytilastot();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        //Kirjoitetaan Maalit.txt tiedostoon maalintekoaika ja avataan maalin luonti ikkuna
        private void btnMaali_Click(object sender, EventArgs e)
        {
            if (handled)
            {
                handled = false;
                return;
            }

            StreamWriter sw = new StreamWriter("c:\\temp\\Maalit.txt", true);
            sw.WriteLine();
            sw.WriteLine(lblkello.Text);
            sw.Close();
            var form6 = new frmMaali();
            form6.Show();
        }
    }
}
