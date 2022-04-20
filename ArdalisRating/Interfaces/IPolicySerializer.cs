using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalisRating.Interfaces
{
    public interface IPolicySerializer
    {
        Policy GetPolicyFromJson(string text);
    }
}