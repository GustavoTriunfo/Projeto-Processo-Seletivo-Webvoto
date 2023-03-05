using Lacuna.Dev.Ingresso.LacunaGenetics.Abstraction;
using Lacuna.Dev.Ingresso.LacunaGenetics.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request
{
    public class RequestOperation : IRequest
    {
       public string GetAddress()
        {
            return "/api/dna/jobs";
        }

        public TypeEnum GetTypeHttpRequest()
        {
            return TypeEnum.HttpGet;
        }
    }
}
