using CRUDInterfaces.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
    /// Lógica de interacción para SinStock.xaml
    /// </summary>
    public partial class SinStock : Page
    {
        public SinStock()
        {
            InitializeComponent();
            CargarDatosSinStock();
        }
        private void CargarDatosSinStock()
        {
            try
            {
                // Obtener el DataTable con los datos de productos sin stock
                DataTable sinStockDataTable = DataBase.ObtenerProductosSinStock();

                // Verificar si hay datos antes de asignar al DataGrid
                if (sinStockDataTable.Rows.Count > 0)
                {
                    // Asignar el DataTable como origen de datos para el DataGrid
                    dataGridSinStock.ItemsSource = sinStockDataTable.DefaultView;
                }
                else
                {
                    Debug.WriteLine("No se encontraron datos de productos sin stock.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al cargar los datos de productos sin stock: {ex.Message}");
                // Puedes mostrar un mensaje al usuario o realizar otras acciones según sea necesario.
            }
        }
    }
}
