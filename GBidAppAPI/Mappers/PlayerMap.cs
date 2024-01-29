using CsvHelper.Configuration;
using GBidAppAPI.Models;

namespace GBidAppAPI.Mappers
{
    public class PlayerMap : ClassMap<Player>
    {
        public PlayerMap() 
        {
            Map(p => p.PlayerName).Index(2);
        }
    }
}
