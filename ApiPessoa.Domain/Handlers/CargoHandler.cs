using ApiPessoa.Domain.Commands.Cargocommands.Outputs;
using ApiPessoa.Domain.Commands.CargoCommands.Inputs;
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
        public CargoCommandResult Handle(CargoCommandCreate command)
        {
            Cargo cargo = new Cargo(command.CodigoCargo, command.IdOrgao, command.NomeCargo, command.AtribuicoesCargo, command.CargaHoraria,
                command.CargaHorariaVariavel, command.IdLegislacao, command.IdCarreira, command.LocalId, command.Ativo);

            _repositorio.Save(cargo);

            return new CargoCommandResult(true, "Cargo cadastrado com sucesso", null);

        }
    }
}
