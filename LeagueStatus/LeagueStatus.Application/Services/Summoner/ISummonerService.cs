using System;
using System.Threading.Tasks;

namespace LeagueStatus.Application.Services.Summoner
{
    public interface ISummonerService
    {
        Task<SummonerDTO> GetByName(String name);
    }
}