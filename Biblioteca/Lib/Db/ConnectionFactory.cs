using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteca.Lib.Db
{
    /// <summary>
    /// Classe responsével por controlar as conexões do sistemas
    /// com o banco de dados.
    /// </summary>
    public class ConnectionFactory
    {
        /// <summary>
        /// Define strig de conexão com o banco
        /// </summary>
        private static string strConnection = "server=localhost; uid=biblioteca; pwd=biblioteca; database=biblioteca;";
        /// <summary>
        /// Estabelece ema conexão com o banco de dados
        /// </summary>
        /// <returns> intancia de uma conexão com o banco</returns>
        public static IDbConnection GetConnection()
        {
            IDbConnection conn = null;
            conn = new MySqlConnection(strConnection);
            return conn;
        }
    }
}
