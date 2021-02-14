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

            public int acceso(Login log)
            {

            int estado = 0;
            if (log.Usuario.Equals("Carlos") && log.Password.Equals("1234")) 
                estado = 1;
            {


            }

            return estado;
        
        }
    }
}
