using BaseApi.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.Controllers
{
    [ApiController]
    [Route("Api/Empresa")]
    public class EmpresaController : ControllerBase
    {
        private readonly DbTesteContext contexto;

        public EmpresaController(DbTesteContext context) {
            contexto = context;
        }

        [HttpGet("GetDocuments/{numdoc?}")]
        public void GetDocuments() {

        }
    }
}
