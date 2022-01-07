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
    public partial class Joukkueet : Form
    {
        public Joukkueet()
        {
            InitializeComponent();
        }
           
        private void Jalkapallojoukkueet_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Joukkueet",typeof(string));

            table.Rows.Add("FC Honka");
            table.Rows.Add("FC Inter");
            table.Rows.Add("FC Lahti");
            table.Rows.Add("HIFK");

            dgvVierasjoukkue.DataSource = table;
            dgvKotijoukkue.DataSource = table;      
            
            StreamWriter swhonka = new StreamWriter("c:\\temp\\FC Honka.txt");
            swhonka.WriteLine("5");
            swhonka.WriteLine("Aalto.Henri");
            swhonka.WriteLine("77");
            swhonka.WriteLine("Arifi.Doni");
            swhonka.WriteLine("45");
            swhonka.WriteLine("Azodo.Robbie");
            swhonka.WriteLine("3");
            swhonka.WriteLine("Baah.Gibeon");
            swhonka.Close();

            StreamWriter swinter = new StreamWriter("c:\\temp\\FC Inter.txt");
            swinter.WriteLine("11");
            swinter.WriteLine("Ademi.Albion");
            swinter.WriteLine("30");
            swinter.WriteLine("Al Bermanei.Mohammed");
            swinter.WriteLine("2");
            swinter.WriteLine("Annan.Anthony");
            swinter.WriteLine("27");
            swinter.WriteLine("Balbi.Luciano");
            swinter.Close();

            StreamWriter swlahti = new StreamWriter("c:\\temp\\FC Lahti.txt");
            swlahti.WriteLine("19");
            swlahti.WriteLine("Amione.Jerenimo");
            swlahti.WriteLine("3");
            swlahti.WriteLine("Hauhia.Mikko");
            swlahti.WriteLine("18");
            swlahti.WriteLine("Jäntti.Teemu");
            swlahti.WriteLine("23");
            swlahti.WriteLine("Marttinen.Tim");
            swlahti.Close();

            StreamWriter swhifc = new StreamWriter("c:\\temp\\HIFK.txt");
            swhifc.WriteLine("17");
            swhifc.WriteLine("Bäckman.Jani");  
            swhifc.WriteLine("9");
            swhifc.WriteLine("Henrique.Luis");
            swhifc.WriteLine("18");
            swhifc.WriteLine("Hänninen.Matias");
            swhifc.WriteLine("19");
            swhifc.WriteLine("Larsson.Kevin");
            swhifc.Close();
        }
         
        //Luetaan DataGridin tieto ja syötetään textboxiin
        private void dgvJoukkueet_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string kotijoukkue;
            DataGridViewRow row = this.dgvKotijoukkue.Rows[e.RowIndex];
            kotijoukkue = row.Cells["Joukkueet"].Value.ToString();
            txtbKoti.Text = kotijoukkue;
        }

        //Luetaan DataGridin tieto ja syötetään textboxiin
        private void dtvVierasjoukkue_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string vierasjoukkue;
            DataGridViewRow row = this.dgvKotijoukkue.Rows[e.RowIndex];
            vierasjoukkue = row.Cells["Joukkueet"].Value.ToString();
            txtbVieras.Text = vierasjoukkue;
        }

        //Luetaan Textboxien sisältö ja kirjoitetaan tiedostoon ja suljetaan ikkuna
        private void btnValmis_Click(object sender, EventArgs e)
        {
            string koti = txtbKoti.Text, vieras = txtbVieras.Text;
            StreamWriter sw = new StreamWriter("c:\\temp\\joukkuevalinta.txt");
            sw.WriteLine(koti);
            sw.WriteLine(vieras);
            sw.Close();
            
            this.Close();
        }    
    }   
}
