using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FrenchAddressSearchApi
{
    public class FrenchAddressSearch
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://geo.api.gouv.fr";
        public FrenchAddressSearch()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> SearchAddress(string parameters)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/search/{parameters}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetRegions()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/regions");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCommunes()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/communes_associees_deleguees");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetDepartaments()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/departements");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
