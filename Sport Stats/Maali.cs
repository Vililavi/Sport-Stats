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
    public partial class frmMaali : Form
    {
        public frmMaali()
        {
            InitializeComponent();
        }
        
        //Jos nappula on valittu niin ladataan oikean joukkueen pelaajat comboboxiin
        private void rbtnKotijoukkue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVierasjoukkue.Checked == true)
            {
                rbtnKotijoukkue.Checked = false;
            }
            cbTekijä.Items.Clear();
            cbTekijä.Text = "";
            cbSyöttäjä.Items.Clear();
            cbSyöttäjä.Text = "";
            cbSyöttäjä.Items.Add("Ei syöttäjää");

            if (File.Exists("c:\\temp\\joukkuevalinta.txt"))
            {
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

                if (koti == "HIFK")
                {
                    StreamReader sr1 = new StreamReader("c:\\temp\\HIFK.txt");
                    StreamReader sr2 = new StreamReader("c:\\temp\\HIFK.txt");
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

        //Jos nappula on valittu niin ladataan oikean joukkueen pelaajat comboboxiin
        private void rbtnVierasjoukkue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKotijoukkue.Checked == true)
            {
                rbtnVierasjoukkue.Checked = false;
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
                StreamReader sr1 = new StreamReader("c:\\temp\\HIFK.txt");
                StreamReader sr2 = new StreamReader("c:\\temp\\HIFK.txt");
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

        //Lisätään maalintekijä, syöttäjä ja maalintekijäjoukkue Maalit.txt tiedostoon
        private void button1_Click(object sender, EventArgs e)
        {         
            if (cbTekijä.Text != "" && cbSyöttäjä.Text != "")
            {
                StreamReader sr = new StreamReader("c:\\temp\\joukkuevalinta.txt");
                StreamWriter sw = new StreamWriter("c:\\temp\\Maalit.txt", true);

                if (rbtnKotijoukkue.Checked == true)
                {
                    sw.WriteLine(sr.ReadLine());
                }

                else
                {
                    sr.ReadLine();
                    sw.WriteLine(sr.ReadLine());
                }
                sw.WriteLine(cbTekijä.Text);
                sw.WriteLine(cbSyöttäjä.Text);
                sw.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sinun pitää valita maalin tekijä ja syöttäjä");
            }
        }
    }
}
