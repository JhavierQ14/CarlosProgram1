using Carlos01.DAO;
using Carlos01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlos01.Negocio
{
    class ClsLogin
    {
        Login log = new Login();

        ClsListaUsuarios cls = new ClsListaUsuarios();

            public int acceso(Login log)
            {
            int estado = 0;
            for ( int i=0; i<cls.user.Length;i++) {   

            if (log.Usuario.Equals(cls.user[i]) && log.Password.Equals(cls.pass[i])) 
                estado = 1;
            {


            }
        }

            return estado;
        
        }
    }
}
