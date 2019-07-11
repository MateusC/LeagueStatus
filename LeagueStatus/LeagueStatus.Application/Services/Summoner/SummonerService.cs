using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LeagueStatus.Application.Services.Summoner
{
    public class SummonerService : ISummonerService
    {
        private readonly ApiSettings _settings;

        public SummonerService(ApiSettings settings)
        {
            _settings = settings;
        }

        public async Task<SummonerDTO> GetByName(String name)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Riot-Token", _settings.Key);

                var response = await client.GetStringAsync($"{_settings.Url}lol/summoner/v4/summoners/by-name/{name}");

                return JsonConvert.DeserializeObject<SummonerDTO>(response);
            }
        }
    }
}
