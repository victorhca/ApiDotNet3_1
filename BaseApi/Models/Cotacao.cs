using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.Models
{
    public class Cotacao
    {
        public int Id { get; set; }
        public string DeMoedaCode { get; set; }
        public int DeMoedaId { get; set; }
        public string ParaMoedaCode { get; set; }
        public int ParaMoedaId { get; set; }
        public double Valor { get; set; }
        public string Email { get; set; }
        public string ProcessSrv { get; set; } = "N";

    }
}
