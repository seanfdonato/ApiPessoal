using System;
using System.Data;
using System.Data.SqlClient;
using ApiPessoa.Domain.Entidades;
using ApiPessoa.Shared;
using Microsoft.EntityFrameworkCore;

namespace ApiPessoa.Infra.DataContexto
{
    public class Contexto : DbContext
    {
        public DbSet<Cargo> Cargos { get; set; }
        public SqlConnection Connection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Setting.ConnectionString);
        }

        public Contexto()
        {
            Connection = new SqlConnection(Setting.ConnectionString);
            Connection.Open();
        }


        //public void Dispose()
        //{
        //    if (Connection.State != ConnectionState.Closed)
        //    {
        //        Connection.Close();
        //    }

        //}
    }
}
