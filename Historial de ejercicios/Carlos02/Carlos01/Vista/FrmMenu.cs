using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carlos01.Vista
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cLICKPARAMASINFORMACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cLICKPARAMASINFORMACIONToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmListaVisualDeusuarios frm = new FrmListaVisualDeusuarios();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
