using System;
using System.Data;
using System.Data.SqlClient;
using ApiPessoa.Shared;

namespace ApiPessoa.Infra.Contexto
{
    public class Contexto : IDisposable
    {
        public SqlConnection Connection { get; set; }
        public Contexto()
        {
            Connection = new SqlConnection(Setting.ConnectionString);
            Connection.Open();
        }
        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }

        }
    }
}
