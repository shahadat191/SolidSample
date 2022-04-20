using System;

namespace ArdalisRating.Models.Rater
{
    public class RaterFactory
    {
        public static Rater Create(Policy policy, RatingEngine engine)
        {
            try {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.Models.Rater.{policy.Type}PolicyRater"), new object[] {engine, engine.Logger}
                );
            }
            catch{
                return null;
            }
            // switch (policy.Type)
            // {
            //     case PolicyType.Auto:
            //         return new AutoPolicyRater(engine, engine.Logger);
            //     case PolicyType.Land:
            //         return new LandPolicyRater(engine, engine.Logger);
            //     case PolicyType.Life:
            //         return new LifePolicyRater(engine, engine.Logger);
            //     default:
            //         throw new Exception("Error Type");
            // }
        }
    }
}
