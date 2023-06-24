using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConexionDB
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        static ConexionDB()
        {

            connectionString = @"Data Source=.;Initial Catalog=CARNICERIA_DB;Integrated Security=True";
            command =new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static List<Cliente> LeerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                connection.Open();

                command.CommandText = "SELECT ID_CLIENTE, CORREO, PASSWORD, MONTO, GASTO FROM CLIENTE ";
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientes.Add(new Cliente(Convert.ToInt32(reader["ID_CLIENTE"]), reader["CORREO"].ToString(), reader["PASSWORD"].ToString(), Convert.ToDecimal(reader["MONTO"]), Convert.ToDecimal(reader["GASTO"])));
                    }
                }
                return clientes;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void AgregarCliente(Cliente cliente)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "INSERT INTO CLIENTE (CORREO, PASSWORD, MONTO, GASTO) VALUES (@correo, @password, @monto, @gasto)";
                command.Parameters.AddWithValue("@correo", cliente.Correo);
                command.Parameters.AddWithValue("@password", cliente.Password);
                command.Parameters.AddWithValue("@monto", cliente.Monto);
                command.Parameters.AddWithValue("@gasto", cliente.Gasto);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void BorrarCliente(Cliente cliente)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "DELETE FROM CLIENTE WHERE ID_CLIENTE = @id_cliente";
                command.Parameters.AddWithValue("@id_cliente", cliente.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ModificarCorreoCliente(Cliente cliente, string correo)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "UPDATE CLIENTE SET CORREO = @correo WHERE ID_CLIENTE = @id_cliente";
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@id_cliente", cliente.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static void ModificarPasswordCliente(Cliente cliente, string password)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "UPDATE CLIENTE SET PASSWORD = @password WHERE ID_CLIENTE = @id_cliente";
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@id_cliente", cliente.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ModificarMontoCliente(Cliente cliente, decimal monto)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "UPDATE CLIENTE SET MONTO = @monto WHERE ID_CLIENTE = @id_cliente";
                command.Parameters.AddWithValue("@monto", monto);
                command.Parameters.AddWithValue("@id_cliente", cliente.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ModificarGastoCliente(Cliente cliente, decimal gasto)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "UPDATE CLIENTE SET GASTO = @gasto WHERE ID_CLIENTE = @id_cliente";
                command.Parameters.AddWithValue("@gasto", gasto);
                command.Parameters.AddWithValue("@id_cliente", cliente.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Vendedor> LeerVendedores()
        {
            List<Vendedor> vendedores = new List<Vendedor>();

            try
            {
                connection.Open();

                command.CommandText = "SELECT ID_VENDEDOR, CORREO, PASSWORD FROM VENDEDOR ";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vendedores.Add(new Vendedor(Convert.ToInt32(reader["ID_VENDEDOR"]), reader["CORREO"].ToString(), reader["PASSWORD"].ToString()));
                    }
                }
                return vendedores;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void AgregarVendedor(Vendedor vendedor)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "INSERT INTO VENDEDOR (CORREO, PASSWORD) VALUES (@correo, @password)";
                command.Parameters.AddWithValue("@correo", vendedor.Correo);
                command.Parameters.AddWithValue("@password", vendedor.Password);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void BorrarVendedor(Vendedor vendedor)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "DELETE FROM VENDEDOR WHERE ID_VENDEDOR = @id_vendedor";
                command.Parameters.AddWithValue("@id_vendedor", vendedor.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ModificarCorreoVendedor(Vendedor vendedor, string correo)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "UPDATE VENDEDOR SET CORREO = @correo WHERE ID_VENDEDOR = @id_vendedor";
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@id_vendedor", vendedor.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static void ModificarPasswordVendedor(Vendedor vendedor, string password)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "UPDATE VENDEDOR SET PASSWORD = @password WHERE ID_VENDEDOR = @id_vendedor";
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@id_vendedor", vendedor.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
