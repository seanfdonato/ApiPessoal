namespace ApiPessoa.Domain.Commands.CargoCommands.Inputs
{
    public class CargoCommandCreate
    {
        public string CodigoCargo { get; set; }
        public int IdOrgao { get; set; }
        public string NomeCargo { get; set; }
        public string AtribuicoesCargo { get; set; }
        public int CargaHoraria { get; set; }
        public int CargaHorariaVariavel { get; set; }
        public int? IdLegislacao { get; set; }
        public int? IdCarreira { get; set; }
        public string LocalId { get; set; }
        public bool Ativo { get; set; }
    }
}
