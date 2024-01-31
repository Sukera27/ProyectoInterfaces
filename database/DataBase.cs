using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDInterfaces.database
{

    class DataBase
    {
        // Define la cadena de conexión
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=northwind";

        // Propiedad pública para la cadena de conexión
        public static string ConnectionString
        {
            get { return connectionString; }
        }

        // Método para obtener la conexión
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
       

        public static Boolean login(String usuario, String contrasena)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string consultaUser = "SELECT * FROM usuario WHERE nombre_usuario = @usuario and contrasena = @contrasena";

                    using (MySqlCommand cmd = new MySqlCommand(consultaUser, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        using (MySqlDataReader lector = cmd.ExecuteReader())
                        {
                            return lector.Read();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public static Boolean registrarUsuario(String usuario, String contrasena)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Verificar si el usuario ya existe
                    string consultaExistencia = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @usuario";
                    using (MySqlCommand cmdExistencia = new MySqlCommand(consultaExistencia, connection))
                    {
                        cmdExistencia.Parameters.AddWithValue("@usuario", usuario);

                        int cantidadUsuarios = Convert.ToInt32(cmdExistencia.ExecuteScalar());

                        if (cantidadUsuarios == 0)
                        {
                            // El usuario no existe, se puede registrar
                            string consultaRegistro = "INSERT INTO usuario (nombre_usuario, contrasena) VALUES (@usuario, @contrasena)";
                            using (MySqlCommand cmdRegistro = new MySqlCommand(consultaRegistro, connection))
                            {
                                cmdRegistro.Parameters.AddWithValue("@usuario", usuario);
                                cmdRegistro.Parameters.AddWithValue("@contrasena", contrasena);

                                int filasAfectadas = cmdRegistro.ExecuteNonQuery();

                                return filasAfectadas > 0;
                            }
                        }
                        else
                        {
                            // El usuario ya existe, aquí debes decidir qué hacer, por ejemplo, podrías lanzar una excepción.
                            // También puedes devolver false si no quieres hacer nada en este caso.
                            // return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }

            // Agrega una declaración de retorno fuera del bloque try-catch para manejar el caso donde no se cumple la condición if.
            return false;
        }


        public static DataTable ObtenerProductos()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string consultaProductos = "SELECT * FROM northwind.products;";
                    using (MySqlCommand cmdProductos = new MySqlCommand(consultaProductos, connection))
                    {
                        using (MySqlDataReader lector = cmdProductos.ExecuteReader())
                        {
                            dataTable.Load(lector);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return dataTable;
        }


        public static void InsertarProducto(string productName, string quantityPerUnit)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Construir la consulta de inserción
                    string consultaInsercion = "INSERT INTO northwind.products (ProductName, QuantityPerUnit) " +
                                               "VALUES (@ProductName, @QuantityPerUnit);";

                    using (MySqlCommand cmdInsercion = new MySqlCommand(consultaInsercion, connection))
                    {
                        cmdInsercion.Parameters.AddWithValue("@ProductName", productName);
                        cmdInsercion.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit);

                        // Puedes agregar parámetros adicionales según sea necesario

                        // Ejecutar la consulta de inserción
                        cmdInsercion.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al insertar el producto: {ex.Message}");
                // Puedes manejar el error según tus necesidades
            }
        }

        public static void EliminarProducto(string productName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Construir la consulta de eliminación
                    string consultaEliminacion = "DELETE FROM northwind.products WHERE ProductName = @ProductName;";

                    using (MySqlCommand cmdEliminacion = new MySqlCommand(consultaEliminacion, connection))
                    {
                        cmdEliminacion.Parameters.AddWithValue("@ProductName", productName);

                        // Ejecutar la consulta de eliminación
                        cmdEliminacion.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al eliminar el producto: {ex.Message}");
                // Puedes manejar el error según tus necesidades
            }
        }

        public static void ActualizarProducto(string productName, string newProductName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Construir la consulta de actualización
                    string consultaActualizacion = "UPDATE northwind.products SET ProductName = @NewProductName WHERE ProductName = @ProductName;";

                    using (MySqlCommand cmdActualizacion = new MySqlCommand(consultaActualizacion, connection))
                    {
                        cmdActualizacion.Parameters.AddWithValue("@ProductName", productName);
                        cmdActualizacion.Parameters.AddWithValue("@NewProductName", newProductName);

                        // Ejecutar la consulta de actualización
                        cmdActualizacion.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al actualizar el producto: {ex.Message}");
                // Puedes manejar el error según tus necesidades
            }
        }

        public static DataTable ObtenerTopProductosVendidos()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string consultaTopVendidos = @"
        SELECT 
            p.ProductName,
            SUM(od.Quantity) as TotalSold
        FROM 
            Products p
        JOIN 
            OrderDetails od ON p.ProductID = od.ProductID
        GROUP BY 
            p.ProductID, p.ProductName
        ORDER BY 
            TotalSold DESC
        LIMIT 5;";

                    using (MySqlCommand cmdTopVendidos = new MySqlCommand(consultaTopVendidos, connection))
                    {
                        using (MySqlDataReader lector = cmdTopVendidos.ExecuteReader())
                        {
                            dataTable.Load(lector);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return dataTable;
        }

        public static DataTable ObtenerTopProductosCaros()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string consultaTopCaros = @"
        SELECT 
            ProductName,
            UnitPrice
        FROM 
            Products
        ORDER BY 
            UnitPrice DESC
        LIMIT 5;";

                    using (MySqlCommand cmdTopCaros = new MySqlCommand(consultaTopCaros, connection))
                    {
                        using (MySqlDataReader lector = cmdTopCaros.ExecuteReader())
                        {
                            dataTable.Load(lector);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return dataTable;
        }

        public static DataTable ObtenerProductosSinStock()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string consultaSinStock = @"
        SELECT 
            *
        FROM 
            Products
        WHERE 
            UnitsInStock = 0;";

                    using (MySqlCommand cmdSinStock = new MySqlCommand(consultaSinStock, connection))
                    {
                        using (MySqlDataReader lector = cmdSinStock.ExecuteReader())
                        {
                            dataTable.Load(lector);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return dataTable;
        }



    }

}
