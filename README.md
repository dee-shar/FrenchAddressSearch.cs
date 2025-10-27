# FrenchAddressSearch.cs
Web-API for [geo.api.gouv.fr](https://geo.api.gouv.fr) an open data platform that provides various data sets related to addresses in France

## Example
```cs
using FrenchAddressSearchApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new FrenchAddressSearch();
            string regions = await api.GetRegions();
            Console.WriteLine(regions);
        }
    }
}
```
