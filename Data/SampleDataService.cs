using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class SampleDataService : ISampleDataService
    {
        public List<string> GetMilfShakeType()
        {
            return new List<string>
            {
                "Chocolate",
                "Vanilla",
                "Peanut Butter",
                "Strawberry"
            };
        }

        public List<string> GetMilkShakeSizes()
        {
            return new List<string>
            {
                "Small",
                "Medium",
                "Large",
                "Extra Large"
            };
        }
    }
}
