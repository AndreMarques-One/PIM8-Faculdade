using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using Asp.NETMVCCRUD.dao.conexao;
using Asp.NETMVCCRUD.Models;

namespace Asp.NETMVCCRUD.dao
{
    public class AtividadeDAO:Conexao
    {
        

        public List<Atividade> findALL()
        {

            return id;
        }

        public Atividade find(int id) 
        {
            string query = "SELECT * FROM atividade =" + atividade.Id + "";
            OleDbDataReader reader = null;
            OleDbConnection conn = null;
            Atividade Id = null;
            try
            {

                conn = getConexao();

                OleDbCommand cmd = new OleDbCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Id = new Atividade();
                        Id.Nome = reader.GetString(50);
                        Id.Tipo = reader.GetString(50);
                        Id.DataLimite = reader.GetData(int ordinal);
                        return Id;
                    }
                    reader.Close();
                    fecharConexao(conn);
                    return Id;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                if (conn != null)
                {
                    conn.Close();
                }
            }


        }

        public bool save(int id) {

            string query = "insert into ativadade  (nome, tipo, dataLimite) values ('" + atividade.Nome + "', '" + atividade.Tipo + "', '" + atividade.DataLimite + "'");
            OleDbDataReader reader = null;
            OleDbConnection conn = null;
            try
            {
                conn = getConexao();


                OleDbCommand cmd = new OleDbCommand(query, conn);
                reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    
                }
                fecharConexao(conn);
            }
            catch(Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return true;
        }
        

        public bool update(int Id, string Nome, string Tipo, DateTime DataLimite) {

            string query = "UPDATE atividade SET Id=""+Id+""WHERE Nome =""+Nome+""Tipo=""+Tipo+""DataLimite=""+Datalimite"";

                OleDbDataReader reader = null;
            OleDbConnection conn = null;
            try
            {

                conn = getConexao();

                OleDbCommand cmd = new OleDbCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return true;
                }
                fecharConexao(conn);
            }

            catch(Exception ex)
            {

                throw ex;
            }

            finally
            {
                if (conn != null)
                {

                    conn.Close();
                }
            }
            return true;

        }

        public bool delete(int id)
        {
            string query = "DELETE * FROM atividade WHERE id ='"+id+"'";

            OleDbDataReader reader = null;
            OleDbConnection conn = null;
            try
            {

                conn = getConexao();

                OleDbCommand cmd = new OleDbCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return true;
                }
                fecharConexao(conn);
            }

            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                if (conn != null)
                {

                    conn.Close();
                }
            }
            return true;

        }



    }
}
}