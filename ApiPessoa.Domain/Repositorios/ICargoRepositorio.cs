using ApiPessoa.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPessoa.Domain.Repositorios
{
    public interface ICargoRepositorio
    {
        IEnumerable<Cargo> Get();
    }
}
