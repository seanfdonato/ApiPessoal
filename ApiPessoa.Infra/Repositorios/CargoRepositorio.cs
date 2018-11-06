using ApiPessoa.Domain.Entidades;
using ApiPessoa.Domain.Repositorios;
using ApiPessoa.Domain.Queries.Cargo;
using System;
using System.Collections.Generic;
using System.Text;
using ApiPessoa.Infra.DataContexto;
using Dapper;
using System.Linq;
namespace ApiPessoa.Infra.Repositorios
{
    public class CargoRepositorio : ICargoRepositorio
    {
        private readonly Contexto _contexto;

        public CargoRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<ListaCargosQueryResult> Get()
        {
            return _contexto.Connection.Query<ListaCargosQueryResult>("SELECT * FROM [SiaiDp_Cargo]", new { });
        }

        public GetCargoByIdQueryResult GetById(int id)
        {
            return _contexto.Connection.Query<GetCargoByIdQueryResult>("SELECT * FROM [SiaiDp_Cargo] WHERE [IdCargo]=@IdCargo", new { IdCargo = id }).FirstOrDefault();
        }

        public void Save(Cargo cargo)
        {
            using (var transaction = _contexto.Database.BeginTransaction())
            {
                try
                {
                    //string sql = "INSERT INTO CARGO VALUES  ";
                    //_contexto.Connection
                    _contexto.Cargos.Add(cargo);
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
