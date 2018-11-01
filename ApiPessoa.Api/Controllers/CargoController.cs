using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPessoa.Domain.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ApiPessoa.Api.Controllers
{
    public class CargoController : Controller
    {
        [HttpGet]
        [Route("cargos")]
        public IEnumerable<Cargo> Get()
        {
            return null;
        }
    }
}