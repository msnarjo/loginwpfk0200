using Login_k020.Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_k020.Datos
{
    internal class LoginDao
    {

        private const string NOMBRE_ARCHIVO="C:\\Users\\DanielMay\\Desktop\\DGUI\\USERAD.txt";
        //internal string Password;


        // public string Username { get; internal set; }
        public Usuario readfile()
        {
            
            Usuario user = null;
            try
            {

                StreamReader sr = new StreamReader(NOMBRE_ARCHIVO);
                string line = sr.ReadLine();
                int contador = 1;
                user = new Usuario();
                while (line != null)
                {
                    if (contador == 1)
                    {

                        user.Username = line;

                    }if (contador == 2)
                    {

                        user.Password = line;

                    }
                    line = sr.ReadLine();
                    contador++;
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            
            }

            return user;
        }

        // internal Usuario readfile() => throw new NotImplementedException();
    }
}
