using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string email = "";
            int id;
            Console.Write("Exclusão por ID\nQual ID a ser excluído: ");
            id = int.Parse(Console.ReadLine());
            Cliente.ExcluirCliente(id);
            Cliente incluir = new Cliente();
            Console.Write("Incluir registro\nDigite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o email: ");
            email = Console.ReadLine();
            incluir.name = nome;
            incluir.email = email;
            Cliente.InserirCliente(incluir);
            Cliente.ListarClientes();
            Cliente.ListarClientes();
            Console.Write("Qual nome a buscar? ");
            nome=Console.ReadLine();
            Cliente.BuscarClientes(nome);







            /*
            //Teste de conexão
            MySqlConnection conexao = bdcomum.fazconexao();

            try
            {
                conexao.Open();
                Console.WriteLine("Conectado!");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "Select * from clientes limit 1";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Cliente pessoa = new Cliente();
                    pessoa.PreencherCliente(dr);
                    pessoa.mostrar();
                }
                else
                {
                    dr.Close();
                }
                    conexao.Close();
            }
            catch (MySqlException erro)
            {
                Console.WriteLine(erro.Message);
                return;
            }
            */
        }
    }
}
