using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.Models
{
    public class Documento
    {
        public int Id { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }
        public string Autor { get; set; }
        public string Email { get; set; }
    }
}
