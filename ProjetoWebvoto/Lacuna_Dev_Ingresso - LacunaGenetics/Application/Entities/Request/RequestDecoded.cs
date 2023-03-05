using Lacuna.Dev.Ingresso.LacunaGenetics.Abstraction;
using Lacuna.Dev.Ingresso.LacunaGenetics.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request
{
    public class RequestDecoded : IRequest
    {
        [JsonPropertyName("strand")]
        public string strand { get; set; }

        public string GetAddress()
        {
            return "/api/dna/jobs/{id}/decode";
        }

        public TypeEnum GetTypeHttpRequest()
        {
            return TypeEnum.HttpPost;
        }
    }
}
