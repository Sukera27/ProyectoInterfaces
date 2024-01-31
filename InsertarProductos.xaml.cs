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
    /// <summary>
    /// Lógica de interacción para InsertarProductos.xaml
    /// </summary>
    public partial class InsertarProductos : Page
    {
        public InsertarProductos()
        {
            InitializeComponent();
        }
        private void GuardarProducto(object sender, RoutedEventArgs e)
        {
            // Obtener los valores de los campos
            string productName = txtProductName.Text;
            string quantityPerUnit = txtQuantityPerUnit.Text;

            // Puedes obtener los demás valores de los campos de manera similar

            // Llamar al método para insertar el producto en la base de datos
            DataBase.InsertarProducto(productName, quantityPerUnit /*, otros valores*/);

            // Puedes agregar lógica adicional, como mostrar un mensaje de éxito, navegar a otra página, etc.
        }
    }
}
