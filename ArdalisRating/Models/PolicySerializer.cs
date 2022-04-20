using ArdalisRating.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating.Models
{
    public class PolicySerializer : IPolicySerializer
    {
        public Policy GetPolicyFromJson(string policyJson)
        {
            return JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());
        }
    }
}