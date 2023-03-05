using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Response
{
    public class Response
    {

        [JsonPropertyName("code")]
        public string code { get; set; }
        [JsonPropertyName("message")]
        public string? message { get; set; }
    }
}
