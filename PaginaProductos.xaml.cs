using CRUDInterfaces.database;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace CRUDInterfaces
{
    /// <summary>
    /// Lógica de interacción para PaginaProductos.xaml
    /// </summary>
    public partial class PaginaProductos : Page
    {
        public PaginaProductos()
        {
            InitializeComponent();
            CargarDatosProductos();
            Loaded += ReadPage_Loaded;
            CategoriesCombo.SelectionChanged += categoriesComboBox_SelectionChanged;
        }

        private void categoriesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CategoriesCombo.SelectedItem != null)
            {
                string selectedCategories = CategoriesCombo.SelectedItem.ToString();
                FillCategoriesDetails(selectedCategories);
            }
        }

        private void FillCategoriesDetails(string selectedCategories)
        {
            using (MySqlConnection connection = DataBase.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM products AS pro JOIN categories as cat on (pro.categoryID=cat.categoryID) WHERE categoryName = @selectedCategories";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Usar parámetro para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@selectedCategories", selectedCategories);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Limpiar los datos actuales del DataGrid
                            dataGridProductos.ItemsSource = null;

                            // Asignar los nuevos datos al DataGrid
                            dataGridProductos.ItemsSource = dataTable.DefaultView;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los detalles del producto: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void CargarDatosProductos()
        {
            try
            {
                // Obtener el DataTable con los datos de productos desde la base de datos
                DataTable productosDataTable = DataBase.ObtenerProductos();

                // Verificar si hay datos antes de asignar al DataGrid
                if (productosDataTable.Rows.Count > 0)
                {
                    // Asignar el DataTable como origen de datos para el DataGrid
                    dataGridProductos.ItemsSource = productosDataTable.DefaultView;
                }
                else
                {
                    Debug.WriteLine("No se encontraron datos de productos en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al cargar los datos de productos: {ex.Message}");
                // Puedes mostrar un mensaje al usuario o realizar otras acciones según sea necesario.
            }
        }

        private void ReadPage_Loaded(object sender, RoutedEventArgs e)
        {
            // Llena el ComboBox con nombres de productos
            fillcategory();
        }

        private void fillcategory()
        {
            using (MySqlConnection connection = DataBase.GetConnection())
            {
                try
                {
                    connection.Open();
                    String query = "Select categoryName from categories";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string categoryName = reader["categoryName"].ToString();
                                CategoriesCombo.Items.Add(categoryName);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
