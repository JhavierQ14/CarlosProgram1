using Carlos01.Dominio;
using Carlos01.Negocio;
using Carlos01.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carlos01
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            Login log = new Login();
            log.Usuario = txtUser.Text;
            log.Password = txtPass.Text;

            ClsLogin clsL = new ClsLogin();

            int variableevalucion = clsL.acceso(log);

            if (variableevalucion == 1)
            {

                MessageBox.Show("WELCOME");
                Vista.FrmMenu frm = new Vista.FrmMenu();
                frm.UsuarioEstado = txtUser.Text;

            }
            else {
                MessageBox.Show("FALSE");
            }

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
