using System;
using System.Collections.Generic;
using System.Text;
using ApiPessoa.Domain.Entidades;
using ApiPessoa.Domain.Repositorios;
using FluentValidator;

namespace ApiPessoa.Domain.Handlers
{
    public class CargoHandler : Notifiable 
    {
        private readonly ICargoRepositorio _repositorio;
        public CargoHandler(ICargoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public void Handle(Cargo cargo)
        {

        }
    }
}
