using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Db
{
    /*
        Crie um banco de dados no seu servidor SQL Server.

        Execute no banco de dados:
            CREATE TABLE Cliente (
                Id INT PRIMARY KEY IDENTITY,
                Nome varchar(255),
                Email varchar(255),
                Telefone varchar(255)
            );

        Crie um arquivo com a classe Db, copie e cole o método Conexao nela,
        adicionando a URL do seu banco de dados no return.
    */

    public class DbExemplo
    {
        public static string Conexao
        {
            get
            {
                return ""; // URL do seu banco SQL Server.
            }
        }
    }
}
