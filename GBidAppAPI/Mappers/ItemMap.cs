using CsvHelper.Configuration;
using GBidAppAPI.Models;

namespace GBidAppAPI.Mappers
{
    public class ItemMap : ClassMap<Item>
    {

        public ItemMap() 
        {
            Map(i => i.Name).Index(1);
        }
    }
}
