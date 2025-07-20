using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;

namespace Aula08
{
    public class Cliente
    {
            public int id {  get; set; }
            public string name { get; set; }
            public string email { get; set; }

            public void mostrar()
            {
                Console.WriteLine($"\n{this.id}\t | \t{this.name}\t | \t{this.email}");
            }

            public void PreencherCliente(MySqlDataReader dados)
            {
                this.id = int.Parse( dados[0].ToString() );
                this.name = dados[1].ToString();
                this.email = dados[2].ToString();
            
        }

        public static void ListarClientes()
        {
            MySqlConnection cn = bdcomum.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select * from clientes";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Console.WriteLine("Listar todos os clientes");
                    Console.WriteLine("ID\t | \t NOME \t\t | \t EMAIL");
                    while (dr.Read())
                    {
                        Cliente pessoa = new Cliente();
                        pessoa.PreencherCliente(dr);
                        pessoa.mostrar();
                    }
                    cn.Close();
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("Impossível conectar");
                Environment.Exit(0);
            }
        }
              public static void  BuscarClientes(string nome)
        {
            MySqlConnection cn = bdcomum.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select * from clientes where nome like '%" + nome + "%'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Console.WriteLine("Clientes selecionados");
                    Console.WriteLine("ID\t | \t NOME \t\t | \t EMAIL");
                    while (dr.Read())
                    {
                        Cliente pessoa = new Cliente();
                        pessoa.PreencherCliente(dr);
                        pessoa.mostrar();
                    }
                    cn.Close();
                }
                else
                {
                    Console.WriteLine("Cliente não encontrado");
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("Impossível conectar");
                Environment.Exit(0);
            }

        }

        public static void InserirCliente(Cliente novo)
        {
            MySqlConnection cn = bdcomum.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO clientes(nome,email) VALUES ('"+novo.name+"', '"+novo.email+"')";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Impossível conectar");
            }
        }

        public static void ExcluirCliente(int id)
        {
            MySqlConnection cn = bdcomum.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM clientes WHERE id = " + id;
                cmd.ExecuteNonQuery();
                Console.WriteLine($"Excluído o ID -> {id}");
                cn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Impossível conectar");
            }
        }
        public static void AlterarCliente(int id)
        {
            MySqlConnection cn = bdcomum.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT"
                cn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Impossível conectar");
            }
        }
    }
}
