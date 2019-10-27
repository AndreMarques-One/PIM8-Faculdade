using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Asp.NETMVCCRUD.dao.conexao
{
    public class Conexao
    { 
        public static OleDbConnection getConexao()
        {
            OleDbConnection conn = null;
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BRENDA\Desktop\Raiz\GitHub\PIM8-Faculdade\Asp.NETMVCCRUD\AtividadeDBO.mdb";
            conn = new OleDbConnection(connectionString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;

        }

        public static void fecharConexao(OleDbConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }

    
}
    