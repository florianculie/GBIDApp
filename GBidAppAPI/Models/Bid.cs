namespace GBidAppAPI.Models
{
    public class Bid
    {
        public int IdBid { get; set; }
        public int IdItem { get; set; }
        public int IdPlayer { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
    }
}
