using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalisRating.Interfaces
{
    public interface IPolicySource
    {
        string GetPolicyFromSource();
    }
}