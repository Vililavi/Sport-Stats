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
    public partial class frmUrheilutiedotvalinta : Form
    {    
        public frmUrheilutiedotvalinta()
        {
            InitializeComponent();          
        }

        private void btnJalkapallo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmUrheilutiedotJalkapallo();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnJääkiekko_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new frmJääkiekkotilastot();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void btnSalibandy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new frmSalibandytilastot();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void frmUrheilutiedotvalinta_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("c:\\temp") != true)
                Directory.CreateDirectory("c:\\temp");
        }
    }
}
