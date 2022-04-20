using System.IO;
using ArdalisRating.Interfaces;

namespace ArdalisRating.Models
{
    public class FilePolicySource : IPolicySource
    {
        public string GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}