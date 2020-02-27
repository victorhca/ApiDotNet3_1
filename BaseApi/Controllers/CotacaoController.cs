using BaseApi.Data;
using BaseApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseApi.Controllers
{
    [ApiController]
    [Route("Api/Cotacao")]
    public class CotacaoController : ControllerBase
    {
        public readonly DbTesteContext contexto;

        public CotacaoController(DbTesteContext context) {
            contexto = context;
        }

        [HttpPost("InsertQuotation")]        
        public ActionResult InsertQuotation([FromBody] Cotacao quotation) {

            contexto.Quotations.Add(quotation);
            contexto.SaveChanges();

            return Ok();
        }
    }
}
