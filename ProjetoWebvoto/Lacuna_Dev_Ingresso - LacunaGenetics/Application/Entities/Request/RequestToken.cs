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
    public class RequestToken : IRequest
    {
        [JsonPropertyName("username")]
        public string username { get; set; }
       
        [JsonPropertyName("password")]
        public string password { get; set; }

        public string GetAddress()
        {
            return "/api/users/login";
        }

        public TypeEnum GetTypeHttpRequest()
        {
            return TypeEnum.HttpPost;
        }
    }
}
