using CRUDInterfaces.database;
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

namespace CRUDInterfaces
{
    
    public partial class BorrarProductos : Page
    {
        public BorrarProductos()
        {
            InitializeComponent();
        }

        private void EliminarProducto(object sender, RoutedEventArgs e)
        {
            // Obtener el nombre del producto a eliminar
            string productName = txtProductName.Text;

            // Llamar al método para eliminar el producto de la base de datos
            DataBase.EliminarProducto(productName);

            MessageBox.Show("Producto eliminado correctamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
