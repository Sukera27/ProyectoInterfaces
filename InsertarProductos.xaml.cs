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
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantityPerUnit.Text) ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                string.IsNullOrWhiteSpace(txtUnitsOnOrder.Text))
            {
                MessageBox.Show("Todos los campos deben ser completados", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return; // Salir del método sin continuar
            }

            // Obtener los valores de los campos
            string productName = txtProductName.Text;
            string quantityPerUnit = txtQuantityPerUnit.Text;
            double unitPrice = Convert.ToDouble(txtUnitPrice.Text);
            short unitsOnOrder = Convert.ToInt16(txtUnitsOnOrder.Text);

            // Llamar al método para insertar el producto en la base de datos
            DataBase.InsertarProducto(productName, quantityPerUnit, unitPrice, unitsOnOrder);

            MessageBox.Show("Producto añadido correctamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }
}
