using ApiPessoa.Domain.Entidades;
using ApiPessoa.Domain.Queries.Cargo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPessoa.Domain.Repositorios
{
    public interface ICargoRepositorio
    {
        IEnumerable<ListaCargosQueryResult> Get();
        GetCargoByIdQueryResult GetById(int id);
        void Save(Cargo cargo);
    }
}
