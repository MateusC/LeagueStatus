using System;

namespace LeagueStatus.Application.Services.Summoner
{
    public class SummonerDTO
    {
        public String Id { get; set; }

        public String AccountId { get; set; }

        public String Name { get; set; }

        public Int64 SummonerLevel { get; set; }

        public Int32 ProfileIconId { get; set; }

        public String Puuid { get; set; }

        public Int64 RevisionDate { get; set; }
    }
}
