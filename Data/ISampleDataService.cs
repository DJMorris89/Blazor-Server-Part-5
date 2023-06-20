using System.Collections.Generic;

namespace BlazorApp.Data
{
    public interface ISampleDataService
    {
        List<string> GetMilfShakeType();
        List<string> GetMilkShakeSizes();
    }
}