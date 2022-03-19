using Login_k020.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login_k020
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginService login = new LoginService();


        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
  

            
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Password;
            
            if (login.CheckArchivoTexto(username,password))
            {
                MessageBox.Show("Usuarlio logueado :3");
                //salidaLabel.Content = "Usuario logueado";
                //MessageBox.Show("Exito", "Usuario logueado");
                //Console.WriteLine("UserN: " + username + "PassW:" + password);
                
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
                ventanaPrincipal.Show();
                this.Close();

                //this.Hide();


            }
            else
            {

                MessageBox.Show("Error de login","Usuario o password incorrectos");
                //salidaLabel.Content = "Usuario o password incorrectos";

            }

        }
    }
}
