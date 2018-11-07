using ApiPessoa.Domain.Entidades;
using ApiPessoa.Domain.Queries.Cargo;
using System.Collections.Generic;

namespace ApiPessoa.Domain.Repositorios
{
    public interface ICargoRepositorio
    {
        IEnumerable<ListaCargosQueryResult> Get();
        GetCargoByIdQueryResult GetById(int id);
        void Save(Cargo cargo);
    }
}
