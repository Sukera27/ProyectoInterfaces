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
    /// Lógica de interacción para ActualizarProductos.xaml
    /// </summary>
    public partial class ActualizarProductos : Page
    {
        public ActualizarProductos()
        {
            InitializeComponent();
        }
        private void ActualizarProducto_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si algún campo está vacío
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtNewProductName.Text) ||
                string.IsNullOrWhiteSpace(txtNewQuantityPerUnit.Text) ||
                string.IsNullOrWhiteSpace(txtNewUnitPrice.Text) ||
                string.IsNullOrWhiteSpace(txtNewUnitsOnOrder.Text))
            {
                MessageBox.Show("Todos los campos deben ser completados", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return; // Salir del método sin continuar
            }

            // Obtener la información del producto
            string productName = txtProductName.Text; // Nombre actual
            string newProductName = txtNewProductName.Text; // Nuevo nombre
            string newQuantityPerUnit = txtNewQuantityPerUnit.Text; // Nueva cantidad por unidad
            double newUnitPrice = Convert.ToDouble(txtNewUnitPrice.Text); // Nuevo precio unitario
            short newUnitsOnOrder = Convert.ToInt16(txtNewUnitsOnOrder.Text); // Nuevas unidades en pedido

            // Llamar al método para actualizar el producto en la base de datos
            DataBase.ActualizarProducto(productName, newProductName, newQuantityPerUnit, newUnitPrice, newUnitsOnOrder);

            MessageBox.Show("Producto actualizado correctamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }
}
