using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.Models
{
    public class Cotacao
    {
        public int Id { get; set; }
        public string DeMoeda { get; set; }
        public string ParaMoeda { get; set; }
        public double Valor { get; set; }
        public string Email { get; set; }
        public string ProcessSrv { get; set; } = "N";

    }
}
