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
                connection.Open();

                command.CommandText = $"INSERT INTO CLIENTE (CORREO, PASSWORD, MONTO, GASTO) VALUES ('{cliente.Correo}', '{cliente.Password}', {cliente.Monto}, {cliente.Gasto})";
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
                connection.Open();

                command.CommandText = $"DELETE FROM CLIENTE WHERE ID_CLIENTE = {cliente.Id}";
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

        public static void ModificarCliente(Cliente cliente)
        {
            try
            {
                connection.Open();

                command.CommandText = $"UPDATE CLIENTE SET ";
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
                connection.Open();

                command.CommandText = $"INSERT INTO VENDEDOR (CORREO, PASSWORD) VALUES ('{vendedor.Correo}', '{vendedor.Password}')";
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
                connection.Open();

                command.CommandText = $"DELETE FROM VENDEDOR WHERE ID_VENDEDOR = {vendedor.Id}";
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
