using Carlos01.MODEL;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();

            Carga();
        }
        void Carga()
        {
            dataGridView1.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();

                foreach (var iteracion in Lista)
                {
                    dataGridView1.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities())
            {
                try
                {

                    UserList userList = new UserList();


                userList.NombreUsuario = txtNombre.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.Pass = txtPass.Text;

                db.UserList.Add(userList);
                db.SaveChanges();
                MessageBox.Show("Save");


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());

                }

                Carga();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities())
                try
            {
          

                    int Eliminar = Convert.ToInt32(txtId.Text);

                UserList userList = db.UserList.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();

                ////  userList = db.UserList.Find(Eliminar);
                db.UserList.Remove(userList);
                db.SaveChanges();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());

            }

            Carga();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(txtId.Text);
                    UserList userList = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();

                    //userList user List = new userList();
                    //UserList = db.UserList.Find(16);

                    userList.NombreUsuario = txtNombre.Text;
                    userList.Apellido = txtApellido.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtPass.Text;

                    db.SaveChanges();
                }
                Carga();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
