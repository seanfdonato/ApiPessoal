using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPessoa.Domain.Entidades;
using ApiPessoa.Domain.Queries.Cargo;
using ApiPessoa.Domain.Repositorios;
using Microsoft.AspNetCore.Mvc;


namespace ApiPessoa.Api.Controllers
{
    public class CargoController : Controller
    {
        private readonly ICargoRepositorio _repositorio;
        public CargoController(ICargoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        [HttpGet]
        [Route("cargo")]
        public IEnumerable<ListaCargosQueryResult> Get()
        {
            return _repositorio.Get();
        }
        [HttpGet]
        [Route("cargo/{id}")]
        public GetCargoByIdQueryResult GetById(int id)
        {
            return _repositorio.GetById(id);
        }
        
        [HttpPost]
        [Route("cargo")]
        public void Post([FromBody]Cargo cargo)
        {
            _repositorio.Save(cargo);
        }

    }
}