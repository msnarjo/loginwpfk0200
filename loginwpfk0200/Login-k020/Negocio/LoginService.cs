using Login_k020.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_k020.Negocio
{
    internal class LoginService//POCO
    {
        string usernameValido = "admin";
        string passwordValido = "nimda";


        public bool Check(string username, string password)
        {
            if (usernameValido == username
            && passwordValido == password)
            {
                return true;

            }
            else 
            {
                return false;
            }

        }

        public bool CheckArchivoTexto(string username, string password)
        {

            LoginDao loginDao = new LoginDao();
            Usuario usuario = loginDao.readfile();
            if (usuario != null)
            {
                if (usuario.Username == username &&
                    usuario.Password == password)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        
        }

        public bool checkContraBaseDatos(string username, string password) 
        
        {
            UsuariosDao usuariosDao = new UsuariosDao();
            Usuario user = usuariosDao.buscarUsuarioPorUsername(username,password);
            if (user != null)
            {

                Console.WriteLine("usuario" + user.Username
                    + "existe en la base de datos");
                return true;
            
            }
            Console.WriteLine("Usuario no existe en la base datos");
            return false;
        
        }
      

    }

}
