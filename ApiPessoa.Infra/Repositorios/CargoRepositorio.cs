using ApiPessoa.Domain.Entidades;
using ApiPessoa.Domain.Queries.Cargo;
using ApiPessoa.Domain.Repositorios;
using ApiPessoa.Infra.DataContexto;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ApiPessoa.Infra.Repositorios
{
    public class CargoRepositorio : ICargoRepositorio
    {
        private readonly Contexto _contexto;
        private readonly ContextoSQL _contextoSQL;

        public CargoRepositorio(Contexto contexto, ContextoSQL contextoSQL)
        {
            _contexto = contexto;
            _contextoSQL = contextoSQL;
        }
        public IEnumerable<ListaCargosQueryResult> Get()
        {
            return _contextoSQL.Connection.Query<ListaCargosQueryResult>("SELECT * FROM [SiaiDp_Cargo]", new { });
        }

        public GetCargoByIdQueryResult GetById(int id) 
        {
            return _contextoSQL.Connection.Query<GetCargoByIdQueryResult>("SELECT * FROM [SiaiDp_Cargo] WHERE [IdCargo]=@IdCargo", new { IdCargo = id }).FirstOrDefault();
        }

        public void Save(Cargo cargo)
        {
            using (var transaction = _contexto.Database.BeginTransaction())
            {
                try
                {
                    _contexto.Add(cargo);
                    _contexto.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }

            }
        }
    }
}
