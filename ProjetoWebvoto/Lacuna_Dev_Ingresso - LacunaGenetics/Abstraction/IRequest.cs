using Lacuna.Dev.Ingresso.LacunaGenetics.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.Abstraction
{
    public interface IRequest
    {
        public string GetAddress();

        public TypeEnum GetTypeHttpRequest();

    }
}
