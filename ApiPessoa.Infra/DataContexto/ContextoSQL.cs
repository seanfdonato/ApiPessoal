using ApiPessoa.Shared;
using System;
using System.Data;
using System.Data.SqlClient;


namespace ApiPessoa.Infra.DataContexto
{
    public class ContextoSQL : IDisposable
    {
        public SqlConnection Connection { get; set; }

        public ContextoSQL()
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
