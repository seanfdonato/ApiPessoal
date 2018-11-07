using ApiPessoa.Domain.Entidades;
using ApiPessoa.Domain.Repositorios;
using FluentValidator;
using ApiPessoa.Domain.Commands.Outputs;

namespace ApiPessoa.Domain.Handlers
{
    public class CargoHandler : Notifiable
    {
        private readonly ICargoRepositorio _repositorio;
        public CargoHandler(ICargoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public CommandResult Handle(Cargo cargo)
        {

            _repositorio.Save(cargo);
            return new CommandResult(true, "Cadastrado com sucesso", null);

        }
    }
}
