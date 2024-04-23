using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraBrasil.Model.Responses
{
    public class BancoResponse
    {
        public string? Ispb { get; set; }
        public string? ShortName { get; set; }
        public int BankCode { get; set; }
        public string? FullName { get; set; }
    }
}
