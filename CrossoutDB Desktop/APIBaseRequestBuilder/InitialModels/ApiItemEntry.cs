using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crossout.Data.Stats.Main;
using Newtonsoft.Json;

namespace Crossout.Web.Models.API.v1
{
    public class ApiItemEntry : ApiEntryBase
    {

        [JsonProperty("selloffers")]
        public int SellOffers { get; set; }

        [JsonProperty("sellprice")]
        public decimal SellPrice { get; set; }

        [JsonProperty("buyorders")]
        public int BuyOrders { get; set; }

        [JsonProperty("buyprice")]
        public decimal BuyPrice { get; set; }

        [JsonProperty("removed")]
        public int Removed { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("workbenchrarity")]
        public int WorkbenchRarity { get; set; }

        [JsonProperty("margin")]
        public decimal Margin
        { get; set; }

        [JsonProperty("formatmargin")]
        public string FormatMargin
        { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("lastupdatetime")]
        public string LastUpdateTime { get; set; }

        [JsonProperty("rarityname")]
        public int RarityId { get; set; }

        [JsonProperty("rarityname")]
        public string RarityName { get; set; }

        [JsonProperty("categoryid")]
        public int CategoryId { get; set; }

        [JsonProperty("categoryname")]
        public string CategoryName { get; set; }

        [JsonProperty("typeid")]
        public int TypeId { get; set; }

        [JsonProperty("recipeid")]
        public int RecipeId { get; set; }

        [JsonProperty("typename")]
        public string TypeName { get; set; }

        [JsonProperty("factionnumber")]
        public int FactionNumber { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }

        public bool OlderThan(int minutes)
        {
            return DateTime.UtcNow - Timestamp > new TimeSpan(0, minutes, 0);
        }

        [JsonProperty("formatbuyprice")]
        public string FormatBuyPrice
        { get; set; }

        [JsonProperty("formatsellprice")]
        public string FormatSellPrice
        { get; set; }

        [JsonProperty("image")]
        public string Image
        { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(SellOffers)}: {SellOffers}, {nameof(SellPrice)}: {SellPrice}, {nameof(BuyOrders)}: {BuyOrders}, {nameof(BuyPrice)}: {BuyPrice}";
        }
    }
}