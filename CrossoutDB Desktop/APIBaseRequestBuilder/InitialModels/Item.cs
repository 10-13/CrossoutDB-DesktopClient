using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Crossout.Data;
using Crossout.Data.Stats;
using Crossout.Data.Stats.Main;
using Newtonsoft.Json;

namespace Crossout.Model.Items
{
    // Matches with DB Ids

    public enum Rarity
    {
        Common_1 = 1,
        Rare_2 = 2,
        Epic_3 = 3,
        Legendary_4 = 4,
        Relic_5 = 5,
        Skins_6 = 6
    }

    // Matches with DB Ids

    public enum WorkbenchItemId
    {
        //445	Common Minimum Bench Cost
        //446	Rare Minimum Bench Cost
        //447	Epic Minimum Bench Cost
        //448	Legendary Minimum Bench Cost
        //449	Relic Minimum Bench Cost

        Common_445 = 445,
        Rare_446 = 446,
        Epic_447 = 447,
        Legendary_448 = 448,
        Relic_449 = 449,
        Skins_466 = 466,
    }

    [JsonObject("item")]
    public class Item
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string DescriptionText
        { get; set; }

        [JsonProperty("sellOffers")]
        public int SellOffers { get; set; }

        [JsonProperty("sellPrice")]
        public decimal SellPrice { get; set; }

        [JsonProperty("buyOrders")]
        public int BuyOrders { get; set; }

        [JsonProperty("buyPrice")]
        public decimal BuyPrice { get; set; }

        [JsonProperty("removed")]
        public int Removed { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("workbenchRarity")]
        public int WorkbenchRarity { get; set; }

        [JsonProperty("craftingSellSum")]
        public decimal CraftingSellSum { get; set; }

        [JsonProperty("craftingBuySum")]
        public decimal CraftingBuySum { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("margin")]
        public decimal Margin
        { get; set; }

        [JsonProperty("craftingMargin")]
        public decimal CraftingMargin
        { get; set; }

        [JsonProperty("formatMargin")]
        public string FormatMargin
        { get; set; }

        [JsonProperty("formatCraftingMargin")]
        public string FormatCraftingMargin
        { get; set; }

        [JsonProperty("craftVsBuy")]
        public string CraftVsBuy
        { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("lastUpdateTime")]
        public string LastUpdateTime { get; set; }

        [JsonProperty("rarityId")]
        public int RarityId { get; set; }

        [JsonProperty("rarityName")]
        public string RarityName { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("typeId")]
        public int TypeId { get; set; }

        [JsonProperty("recipeId")]
        public int RecipeId { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("factionNumber")]
        public int FactionNumber { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }

        [JsonProperty("formatBuyPrice")]
        public string FormatBuyPrice
        { get; set; }

        [JsonProperty("formatSellPrice")]
        public string FormatSellPrice
        { get; set; }

        [JsonProperty("formatCraftingSellSum")]
        public string FormatCraftingSellSum { get; set; }
        [JsonProperty("formatCraftingBuySum")]
        public string FormatCraftingBuySum
        { get; set; }

        [JsonProperty("image")]
        public string Image
        { get; set; }

        [JsonIgnore]
        public PartStatsBase Stats { get; set; }

        [JsonProperty("sortedStats")]
        public List<SingleStat> SortedStats
        { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(SellOffers)}: {SellOffers}, {nameof(SellPrice)}: {SellPrice}, {nameof(BuyOrders)}: {BuyOrders}, {nameof(BuyPrice)}: {BuyPrice}";
        }
    }
}