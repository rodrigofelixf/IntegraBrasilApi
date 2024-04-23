using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntegraBrasil.Model.Responses
{
    public class EnderecoResponse
    {
       
        public string? Cep { get; set; }
        
        public string? State { get; set; }
       
        public string? City { get; set; }

        public string? Neighborhood { get; set; }

        public string? Street { get; set; }

        [JsonIgnore]
        public string? Service { get; set; }
    }
}
