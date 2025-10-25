# french_address_search.sh
Web-API for [geo.api.gouv.fr](https://geo.api.gouv.fr) an open data platform that provides various data sets related to addresses in France

## Example
```cs
using System;
using FrenchAddressSearchApi;
using System.Threading.Tasks;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new FrenchAddressSearch();
            string regions = await api.getRegions();
            Console.WriteLine(regions);
        }
    }
}
```
