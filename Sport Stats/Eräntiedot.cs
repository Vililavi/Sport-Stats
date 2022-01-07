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
    public partial class frmEräntiedot : Form
    {
        public frmEräntiedot()
        {
            InitializeComponent();
        }

        private void Eräntiedot_Load(object sender, EventArgs e)
        {
            dgvEräntiedot.Columns.Add("Pelaaja", "Pelaaja");
            dgvEräntiedot.Columns.Add("Joukkue", "Joukkue");
            dgvEräntiedot.Columns.Add("Maalit", "Maalit");
            dgvEräntiedot.Columns.Add("Syötöt", "Syötöt");

            NäytäJoukkueet();
            NäytäMaalitjaSyötöt();
            NäytäPistetilastot();
            LisääSyötöt();
        }

        public void NäytäJoukkueet()
        {
            StreamReader sr = new StreamReader("c:\\temp\\joukkuevalinta.txt");
            lblJoukkue1.Text = sr.ReadLine();
            lblJoukkue2.Text = sr.ReadLine();
            sr.Close();
        }

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
                        dgvEräntiedot.Rows.Add(maalintekijät[i], maalintekijäjoukkue[i], maalit[i], "0");
                    }

                    sr.Close();

                    string kohde, verrattava, maali;
                    int maalii;
                    for (int i = 0; i < maalimäärä; i++)
                    {
                        verrattava = dgvEräntiedot.Rows[i].Cells[0].Value.ToString();

                        for (int j = 0; j < maalimäärä; j++)
                        {
                            kohde = dgvEräntiedot.Rows[j].Cells[0].Value.ToString();

                            if (verrattava == kohde)
                            {
                                maalii = int.Parse(dgvEräntiedot.Rows[i].Cells[2].Value.ToString());
                                maalii++;
                                maali = maalii.ToString();
                                dgvEräntiedot.Rows[i].Cells[2].Value = maali;

                            }
                            this.Refresh();
                        }
                    }

                    for (int k = 0; k < maalimäärä; k++)
                    {
                        int maalimäärävähennys;
                        maalimäärävähennys = int.Parse(dgvEräntiedot.Rows[k].Cells[2].Value.ToString());
                        maalimäärävähennys--;
                        dgvEräntiedot.Rows[k].Cells[2].Value = maalimäärävähennys.ToString();
                    }

                    int rivi = int.Parse(dgvEräntiedot.Rows.Count.ToString());

                    string tekijä, tekijä2;
                    for (int l = 0; l < rivi; l++)
                    {
                        tekijä = dgvEräntiedot.Rows[l].Cells[0].Value.ToString();

                        for (int x = l + 1; x < rivi; x++)
                        {
                            tekijä2 = dgvEräntiedot.Rows[x].Cells[0].Value.ToString();
                            if (tekijä == tekijä2)
                            {
                                dgvEräntiedot.Rows.Remove(dgvEräntiedot.Rows[x]);
                                x--;
                            }
                            rivi = int.Parse(dgvEräntiedot.Rows.Count.ToString());
                        }
                    }
                }
            }
        }

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
                                if (pelaaja == dgvEräntiedot.Rows.Count)
                                {
                                    dgvEräntiedot.Rows.Add(käsiteltäväpelaaja, käsiteltävänpelaajanjoukkue, "0", "1");
                                    ehto = false;
                                }

                                else if (dgvEräntiedot.Rows[pelaaja].Cells[0].Value.ToString() == käsiteltäväpelaaja)
                                {
                                    syöttömäärä = int.Parse(dgvEräntiedot.Rows[pelaaja].Cells[3].Value.ToString());
                                    dgvEräntiedot.Rows[pelaaja].Cells[3].Value = syöttömäärä++.ToString();
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
}
