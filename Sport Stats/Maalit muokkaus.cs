using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitustyö
{
    public partial class frmMaalit : Form
    {
       
        public frmMaalit()
        {
            InitializeComponent();
        }

        //Ladataan tiedot tiedostosta datagridiin
        public void HaeTiedot(int määrä)
        {
            string[] tiedot = new string[4];
            
            StreamReader sr = new StreamReader("c:\\temp\\Maalit.txt");

            for (int i = 0; i < määrä; i++)
            {
                sr.ReadLine();
                tiedot[0] = sr.ReadLine();
                tiedot[1] = sr.ReadLine();
                tiedot[2] = sr.ReadLine();
                tiedot[3] = sr.ReadLine();

                LisääTiedot(tiedot[0], tiedot[1], tiedot[2], tiedot[3]);
            }
            sr.Close();
        }

        //Lisätään rivi datagridiin funktioon syötetyillä muuttujilla
        public void LisääTiedot(string i, string j, string k, string l)
        {
            dgvMaalit.Rows.Add(i, j, k, l);
        }

        public int LaskeMaalienMäärä()
        {
            int määrä = 0; bool ehto = true;
            
            StreamReader sr = new StreamReader("c:\\temp\\Maalit.txt");

            while (ehto)
            {
                if (sr.EndOfStream)
                {
                    ehto = false;
                }

                else
                {
                    määrä++;
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                }
            }
            sr.Close();
            return
                määrä;
        }

        //Luodaan datagridin otsikot ja suoritetaan funktiot
        private void Maalit_Load(object sender, EventArgs e)
        {
            dgvMaalit.Columns.Add("Aika", "aika");
            dgvMaalit.Columns.Add("Joukkue", "joukkue");
            dgvMaalit.Columns.Add("Tekijä", "tekijä");
            dgvMaalit.Columns.Add("Syöttäjä", "syöttäjä");
            int määrä;

            if (File.Exists("c:\\temp\\Maalit.txt"))
            {
                määrä = LaskeMaalienMäärä();
                HaeTiedot(määrä);
            }
        }

        //Lisätään uusi rivi datagridiin 
        private void btnlisää_Click(object sender, EventArgs e)
        {           
            StreamReader sr = new StreamReader("c:\\temp\\joukkuevalinta.txt");              //Lukee tiedosto sulkematta sitä
            string aikaalku, aikamuokattu, joukkue = "", tekijä, syöttäjä;

            aikaalku = tbAika.Text;
            aikamuokattu = aikaalku.Insert(2,":");
            if (rbtnKoti.Checked)
                joukkue = sr.ReadLine();
            if (rbtnVieras.Checked)
            {
                sr.ReadLine();
                joukkue = sr.ReadLine();
            }

            tekijä = cbTekijä.Text;
            syöttäjä = cbSyöttäjä.Text;

            dgvMaalit.Rows.Add(aikamuokattu, joukkue, tekijä, syöttäjä);
        }

        //Kirjoitetaan tiedosto uudelleen
        public void KirjoitaTiedosto()
        {
            File.WriteAllText("c:\\temp\\Maalit.txt", string.Empty);
            FileStream fs = new FileStream("c:\\temp\\Maalit.txt",
            FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < dgvMaalit.Rows.Count; i++)
            {
                sw.WriteLine();
                sw.WriteLine(dgvMaalit.Rows[i].Cells[0].Value.ToString());
                sw.WriteLine(dgvMaalit.Rows[i].Cells[1].Value.ToString());
                sw.WriteLine(dgvMaalit.Rows[i].Cells[2].Value.ToString());
                sw.WriteLine(dgvMaalit.Rows[i].Cells[3].Value.ToString());
            }

            sw.Close();
        }

        //Kirjoitetaan tiedosto ja suljetaan ikkuna
        private void btnTallenna_Click(object sender, EventArgs e)
        {
            if (File.Exists("c:\\temp\\Maalit.txt"))
                KirjoitaTiedosto();
            else
            {
                File.Create("c:\\temp\\Maalit.txt");
                KirjoitaTiedosto();
            }
            this.Close();
        }

        //Hyväksytään vain numerot
        private void tbAika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }                  
        }

        //Syötetään kotijoukkueen pelaajat comboboxiin jos nappula on valittuna
        private void rbtnKoti_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVieras.Checked == true)
            {
                rbtnKoti.Checked = false;
            }
            cbTekijä.Items.Clear();
            cbTekijä.Text = "";
            cbSyöttäjä.Items.Clear();
            cbSyöttäjä.Text = "";
            cbSyöttäjä.Items.Add("Ei syöttäjää");

            StreamReader sr = new StreamReader("c:\\temp\\joukkuevalinta.txt");
            string koti = sr.ReadLine();

            if (koti == "FC Honka")
            {
                StreamReader sr1 = new StreamReader("c:\\temp\\FC Honka.txt");
                StreamReader sr2 = new StreamReader("c:\\temp\\FC Honka.txt");
                for (int i = 0; i < 4; i++)
                {
                    sr1.ReadLine();
                    cbTekijä.Items.Add(sr1.ReadLine());
                }

                for (int i = 0; i < 4; i++)
                {
                    sr2.ReadLine();
                    cbSyöttäjä.Items.Add(sr2.ReadLine());
                }
            }

            if (koti == "FC Inter")
            {
                StreamReader sr1 = new StreamReader("c:\\temp\\FC Inter.txt");
                StreamReader sr2 = new StreamReader("c:\\temp\\FC Inter.txt");
                for (int i = 0; i < 4; i++)
                {
                    sr1.ReadLine();
                    cbTekijä.Items.Add(sr1.ReadLine());
                }

                for (int i = 0; i < 4; i++)
                {
                    sr2.ReadLine();
                    cbSyöttäjä.Items.Add(sr2.ReadLine());
                }
            }

            if (koti == "FC Lahti")
            {
                StreamReader sr1 = new StreamReader("c:\\temp\\FC Lahti.txt");
                StreamReader sr2 = new StreamReader("c:\\temp\\FC Lahti.txt");
                for (int i = 0; i < 4; i++)
                {
                    sr1.ReadLine();
                    cbTekijä.Items.Add(sr1.ReadLine());
                }

                for (int i = 0; i < 4; i++)
                {
                    sr2.ReadLine();
                    cbSyöttäjä.Items.Add(sr2.ReadLine());
                }
            }

            if (koti == "HIFC")
            {
                StreamReader sr1 = new StreamReader("c:\\temp\\HIFC.txt");
                StreamReader sr2 = new StreamReader("c:\\temp\\HIFC.txt");
                for (int i = 0; i < 4; i++)
                {
                    sr1.ReadLine();
                    cbTekijä.Items.Add(sr1.ReadLine());
                }

                for (int i = 0; i < 4; i++)
                {
                    sr2.ReadLine();
                    cbSyöttäjä.Items.Add(sr2.ReadLine());
                }
            }
        }

        //Syötetään vierasjoukkueen pelaajat comboboxiin jos nappula on valittuna
        private void rbtnVieras_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKoti.Checked == true)
            {
                rbtnVieras.Checked = false;
            }
            cbTekijä.Items.Clear();
            cbTekijä.Text = "";
            cbSyöttäjä.Items.Clear();
            cbSyöttäjä.Text = "";
            cbSyöttäjä.Items.Add("Ei syöttäjää");

            StreamReader sr = new StreamReader("c:\\temp\\joukkuevalinta.txt");
            sr.ReadLine();
            string vieras = sr.ReadLine();

            if (vieras == "FC Honka")
            {                
                StreamReader srhonka1 = new StreamReader("c:\\temp\\FC Honka.txt");
                StreamReader srhonka2 = new StreamReader("c:\\temp\\FC Honka.txt");
                for (int i = 0; i < 4; i++)
                {
                    srhonka1.ReadLine();
                    cbTekijä.Items.Add(srhonka1.ReadLine());
                }

                for (int i = 0; i < 4; i++)
                {
                    srhonka2.ReadLine();
                    cbSyöttäjä.Items.Add(srhonka2.ReadLine());
                }
            }

            if (vieras == "FC Inter")
            {
                StreamReader sr1 = new StreamReader("c:\\temp\\FC Inter.txt");
                StreamReader sr2 = new StreamReader("c:\\temp\\FC Inter.txt");
                for (int i = 0; i < 4; i++)
                {
                    sr1.ReadLine();
                    cbTekijä.Items.Add(sr1.ReadLine());
                }

                for (int i = 0; i < 4; i++)
                {
                    sr2.ReadLine();
                    cbSyöttäjä.Items.Add(sr2.ReadLine());
                }
            }

            if (vieras == "FC Lahti")
            {
                StreamReader sr1 = new StreamReader("c:\\temp\\FC Lahti.txt");
                StreamReader sr2 = new StreamReader("c:\\temp\\FC Lahti.txt");
                for (int i = 0; i < 4; i++)
                {
                    sr1.ReadLine();
                    cbTekijä.Items.Add(sr1.ReadLine());
                }

                for (int i = 0; i < 4; i++)
                {
                    sr2.ReadLine();
                    cbSyöttäjä.Items.Add(sr2.ReadLine());
                }
            }

            if (vieras == "HIFC")
            {
                StreamReader sr1 = new StreamReader("c:\\temp\\HIFC.txt");
                StreamReader sr2 = new StreamReader("c:\\temp\\HIFC.txt");
                for (int i = 0; i < 4; i++)
                {
                    sr1.ReadLine();
                    cbTekijä.Items.Add(sr1.ReadLine());
                }

                for (int i = 0; i < 4; i++)
                {
                    sr2.ReadLine();
                    cbSyöttäjä.Items.Add(sr2.ReadLine());
                }
            }
        }
    }
}
