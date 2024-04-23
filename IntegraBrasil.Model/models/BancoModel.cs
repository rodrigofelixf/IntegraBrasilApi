using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntegraBrasil.Model.models
{
    public class BancoModel
    {
        [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }

        [JsonPropertyName("name")]
        public string? ShortName { get; set; }

        [JsonPropertyName("code")]
        public int? BankCode { get; set; }

        [JsonPropertyName("fullName")]
        public string? FullName { get; set; }
    }


}
