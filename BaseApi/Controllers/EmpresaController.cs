using BaseApi.Data;
using BaseApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        public readonly DbTesteContext contexto;

        public EmpresaController(DbTesteContext context) {
            contexto = context;
        }

        [HttpGet("GetDocuments/{autor?}")]
        public ActionResult<List<Documento>> GetDocuments(string autor = "") {

            if (!string.IsNullOrEmpty(autor)) {
                var doc = contexto.Documents.Where(x => x.Autor.Contains(autor)).ToList();
                return Ok(doc);
            } else {
                var doc = contexto.Documents.ToList();
                return Ok(doc);
            }

        }
        [HttpPost("InsertDocument")]
        public ActionResult InsertDocument([FromBody] Documento document) {

            try {
                contexto.Documents.Add(document);
                contexto.SaveChanges();
                
                return Ok();

            } catch (Exception) {
                return BadRequest();
            }
        }
    }
}
