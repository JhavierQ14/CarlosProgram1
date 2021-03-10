using Carlos01.DAO;
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
    public partial class FrmListaVisualDeusuarios : Form
    {
        public FrmListaVisualDeusuarios()
        {
            InitializeComponent();
        }

        private void FrmListaVisualDeusuarios_Load(object sender, EventArgs e)
        {
            ClsListaUsuarios cls = new ClsListaUsuarios();

            foreach (var interacion in cls.user) {


                dataGridView1.Rows.Add(interacion.ToString());
            }
        }
    }
}
