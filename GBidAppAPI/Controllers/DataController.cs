using CsvHelper;
using CsvHelper.Configuration;
using GBidAppAPI.Mappers;
using GBidAppAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace GBidAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : Controller
    {
        private readonly ILogger<DataController> _logger;
        
        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        [HttpPost("csv")]
        public ActionResult ImportFromCSV(IFormFile files)
        {
            var test2 = 1;
            test2 = test2 + 1;
            CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                MissingFieldFound = null
            };
            using (StreamReader streamReader = new StreamReader(files.OpenReadStream()))
            {
                using(CsvReader csv = new CsvReader(streamReader, configuration))
                {
                    csv.Context.RegisterClassMap<BidMap>();
                    csv.Context.RegisterClassMap<PlayerMap>();
                    csv.Context.RegisterClassMap<ItemMap>();

                    IList<Bid> bids = new List<Bid>();
                    IList<Player> players = new List<Player>();
                    IList<Item> items = new List<Item>();

                    while (csv.Read())
                    {
                        Bid bid = csv.GetRecord<Bid>();
                        Player player = csv.GetRecord<Player>();
                        Item item = csv.GetRecord<Item>();
                        
                        //bid.Date = csv.GetField<DateTime>(0);
                        //item.Name = csv.GetField<string>(1);
                        //player.PlayerName = csv.GetField<string>(2);
                        //bid.Price = csv.GetField<int>(3);

                        bids.Add(bid);
                        players.Add(player);
                        items.Add(item);
                    }
                    var test = 1;
                    test = test + 1;
                }
            }


            return Ok();
        }
    }
}
