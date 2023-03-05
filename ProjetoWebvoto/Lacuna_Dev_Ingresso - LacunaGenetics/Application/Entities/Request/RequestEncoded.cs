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
    public class RequestEncoded : IRequest
    {
        [JsonPropertyName("strandEncoded")]
        public string strandEncoded { get; set; }

        public string GetAddress()
        {
            return "/api/dna/jobs/{id}/encode";
        }

        public TypeEnum GetTypeHttpRequest()
        {
            return TypeEnum.HttpPost;
        }
    }
}
