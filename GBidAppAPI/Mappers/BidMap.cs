using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using GBidAppAPI.Models;

namespace GBidAppAPI.Mappers
{
    public class BidMap : ClassMap<Bid>
    {

        public BidMap() 
        {
            Map(b => b.Date)
                .TypeConverter<DateTimeConverter>()
                .TypeConverterOption.Format("dd/MM/yyyy").Index(0);
            Map(p => p.Price).Index(3);
            
        }
    }
}
