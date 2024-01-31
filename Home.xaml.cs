using MaterialDesignThemes.Wpf;
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
using System.Windows.Shapes;

namespace CRUDInterfaces
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            contentFrame.Navigate(new Presentación());
        }
       
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            

            // Crear una nueva instancia de la ventana de inicio de sesión (MainWindow)
            MainWindow mainWindow = new MainWindow();

            // Cerrar la ventana actual (Home)
            Close();

            // Mostrar la ventana de inicio de sesión
            mainWindow.Show();
        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new Presentación());
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
        private void ProductosButton_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new PaginaProductos());
        }
        private void InsertProductsButton_Click(Object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new InsertarProductos()); 
        }
        private void deleteProductsButton_Click(Object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new BorrarProductos());
        }
        private void updateProductsButton_Click(Object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new ActualizarProductos());
        }
        private void topSoldProductsButton_Click(Object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new MasVendidos());
        }
        private void topExpensiveProductsButton_Click(Object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new MasCaros());
        }
        private void outStockProductsButton_Click(Object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(new SinStock());
        }
    }
}
