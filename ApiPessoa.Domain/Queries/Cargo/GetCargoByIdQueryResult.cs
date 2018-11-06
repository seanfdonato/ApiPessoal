using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPessoa.Domain.Queries.Cargo
{
   public class GetCargoByIdQueryResult
    {
        public int IdCargo { get; set; }
        public string CodigoCargo { get; set; }
        public int IdOrgao { get; set; }
        public string NomeCargo { get; set; }
        public string AtribuicoesCargo { get; set; }
        public int CargaHoraria { get; set; }
        public int CargaHorariaVariavel { get; set; }
        public int? IdLegislacao { get; set; }
        public int? IdCarreira { get; set; }
    }
}
