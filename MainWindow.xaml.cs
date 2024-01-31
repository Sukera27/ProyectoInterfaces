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
using CRUDInterfaces.database;
using MaterialDesignThemes.Wpf;

namespace CRUDInterfaces
{
  
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool isDarkTheme {  get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(Object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();

            if(isDarkTheme= theme.GetBaseTheme() == BaseTheme.Dark)
            {
                isDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);

            }
            else
            {
                isDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);


        }
        private void salirApp(Object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (DataBase.login(username, password))
            {
                Home homePage = new();
                homePage.Show();  // Mostrar la ventana Home
                Window.GetWindow(this).Close();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
        }
        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Intentar registrar el usuario
            bool registrado = DataBase.registrarUsuario(username, password);

            if (registrado)
            {
                MessageBox.Show("Usuario registrado exitosamente");
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario. Es posible que el nombre de usuario ya exista.");
            }
        }



    }


}
