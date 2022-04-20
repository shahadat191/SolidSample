using ArdalisRating.Interfaces;
using ArdalisRating.Models;
using ArdalisRating.Models.Rater;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public ILogger Logger { get; set; }
        public IPolicySource PolicySource { get; set; }
        public IPolicySerializer PolicySerializer { get; set; }
        public decimal Rating { get; set; }

        public RatingEngine() {
            Logger = new ConsoleLogger();
            PolicySource = new FilePolicySource();
            PolicySerializer = new PolicySerializer();
        }
        public void Rate()
        {
            Logger.Log("Starting rate.");
            Logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyJson = PolicySource.GetPolicyFromSource();
            var policy = PolicySerializer.GetPolicyFromJson(policyJson);

            Rater rater = RaterFactory.Create(policy, this);
            rater?.Rate(policy);
            Logger.Log("Rating completed.");
        }
    }
}
