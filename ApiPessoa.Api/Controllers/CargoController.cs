using ApiPessoa.Domain.Commands.Cargocommands.Outputs;
using ApiPessoa.Domain.Commands.CargoCommands.Inputs;
using ApiPessoa.Domain.Handlers;
using ApiPessoa.Domain.Queries.Cargo;
using ApiPessoa.Domain.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace ApiPessoa.Api.Controllers
{
    public class CargoController : Controller
    {
        private readonly ICargoRepositorio _repositorio;
        private readonly CargoHandler _cargoHandler;

        public CargoController(ICargoRepositorio repositorio, CargoHandler cargoHandler)
        {
            _repositorio = repositorio;
            _cargoHandler = cargoHandler;
        }
        [HttpGet]
        [Route("cargos")]
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
        public CargoCommandResult Post([FromBody]CargoCommandCreate command)
        {
            CargoCommandResult result = _cargoHandler.Handle(command);
            return result;
        }

    }
}