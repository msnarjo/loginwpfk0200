using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Login_k020.Datos
{
    class UsuariosDao
    {
        private const string ConnString = 
            "server=(localdb)\\MSSQLLocalDB;database=proyectoK20;Trusted_Connection=True";
        private const string sqlLogin = 
            "select * from usuario where username = @nombreUsuario;";


        public Usuario buscarUsuarioPorUsername(string username, string password)
            {
            Usuario user = null;
               using (SqlConnection connection = new SqlConnection())
                {

                connection.ConnectionString = ConnString;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sqlLogin;
                SqlParameter usernaeParameter = new SqlParameter("@nombreUsuario",username);
                command.Parameters.Add(usernaeParameter);
                SqlDataReader dr = command.ExecuteReader();
                Console.WriteLine("Se encontraron" + dr.HasRows);
                if(dr.HasRows) 
                {

                    while (dr.Read())
                    {
                        if (password == dr.GetString("password"))
                        { 
                        
                        user = new Usuario();
                        user.id = dr.GetInt32("id");
                        user.Username = username;
                        user.Password = dr.GetString("password");
                        user.NombreCompleto = dr.GetString("Nombre_Completo");
                            break;

                        
                        }

                    }

                }


                }

            return user;
                
            }

    }
}
