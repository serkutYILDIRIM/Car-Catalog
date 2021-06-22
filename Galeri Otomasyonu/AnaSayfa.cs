using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeri_Otomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void seferlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jeep jp = new Jeep();
            jp.ShowDialog();
        }

        private void otobüslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hatchback hb = new Hatchback();
            hb.ShowDialog();
        }

        private void şoförlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sedan sd = new Sedan();
            sd.ShowDialog();
        }

        private void ekleSilDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanıcı kl = new Kullanıcı();
            kl.ShowDialog();
        }

        private void GaleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satıs st = new Satıs();
            st.ShowDialog();
        }
    }
}
