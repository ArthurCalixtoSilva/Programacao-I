using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aula08
{
    internal class bdcomum
    {
        public static MySqlConnection fazconexao()
        {
            return new MySqlConnection("server=127.0.0.1;port=3306;database=aula08_Sergio;uid=root;pwd=A12345678+;");
        }


    }
}
