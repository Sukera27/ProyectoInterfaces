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
    /// Lógica de interacción para MasVendidos.xaml
    /// </summary>
    public partial class MasVendidos : Page
    {
        public MasVendidos()
        {
            InitializeComponent();
            CargarDatosTopVendidos();
        }
        private void CargarDatosTopVendidos()
        {
            try
            {
                // Obtener el DataTable con los datos de los productos más vendidos
                DataTable topVendidosDataTable = DataBase.ObtenerTopProductosVendidos();

                // Verificar si hay datos antes de asignar al DataGrid
                if (topVendidosDataTable.Rows.Count > 0)
                {
                    // Asignar el DataTable como origen de datos para el DataGrid
                    dataGridTopVendidos.ItemsSource = topVendidosDataTable.DefaultView;
                }
                else
                {
                    Debug.WriteLine("No se encontraron datos de productos más vendidos.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al cargar los datos de productos más vendidos: {ex.Message}");
                // Puedes mostrar un mensaje al usuario o realizar otras acciones según sea necesario.
            }
        }
    }
}
