using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPessoa.Domain.Entidades
{
    public class Cargo
    {
        public Cargo(string codigoCargo, int idOrgao,
            string nomeCargo, string atribuicoesCargo, int cargaHoraria,
            int cargaHorariaVariavel, int? idLegislacao, int? idCarreira,
            string localId, bool ativo)
        {
            CodigoCargo = codigoCargo;
            IdOrgao = idOrgao;
            NomeCargo = nomeCargo;
            AtribuicoesCargo = atribuicoesCargo;
            CargaHoraria = cargaHoraria;
            CargaHorariaVariavel = cargaHorariaVariavel;
            IdLegislacao = idLegislacao;
            IdCarreira = idCarreira;
            LocalId = localId;
            Ativo = ativo;
        }

        public int IdCargo { get; private set; }
        public string CodigoCargo { get; private set; }
        public int IdOrgao { get; private set; }
        public string NomeCargo { get; private set; }
        public string AtribuicoesCargo { get; private set; }
        public int CargaHoraria { get; private set; }
        public int CargaHorariaVariavel { get; private set; }
        public int? IdLegislacao { get; private set; }
        public int? IdCarreira { get; private set; }
        public string LocalId { get; private set; }
        public bool Ativo { get; private set; }
    }
}
