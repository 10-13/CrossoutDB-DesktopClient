using System;
using System.Collections.Generic;
using Crossout.Model.Items;
using Newtonsoft.Json;

namespace Crossout.Model.Recipes
{
    public class RecipeItem
    {
        private RecipeCounter counter;

        public RecipeItem(RecipeCounter counter)
        {
            UniqueId = counter.NextId();
        }

        public RecipeItem()
        {

        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("uniqueId")]
        public int UniqueId { get; set; }

        [JsonProperty("rootNumber")]
        public int RootNumber
        {
            get
            {
                var number = Number;
                RecipeItem p = Parent;
                while (p != null)
                {
                    number = number * Math.Max(p.Number, 1);
                    p = p.Parent;
                }
                return number;
            }
        }

        [JsonProperty("factionNumber")]
        public int FactionNumber { get; set; }

        [JsonProperty("depth")]
        public int Depth { get; set; } = 0;

        [JsonProperty("maxDepth")]
        public int MaxDepth { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("sumBuy")]
        public decimal SumBuy { get; set; }

        [JsonProperty("sumSell")]
        public decimal SumSell { get; set; }

        [JsonProperty("sumBuyFormat")]
        public string SumBuyFormat { get; set; }

        [JsonProperty("sumSellFormat")]
        public string SumSellFormat { get; set; }

        [JsonProperty("buyPriceTimesNumber")]
        public decimal BuyPriceTimesNumber { get; set; }

        [JsonProperty("sellPriceTimesNumber")]
        public decimal SellPriceTimesNumber { get; set; }

        [JsonProperty("isSumRow")]
        public bool IsSumRow { get; set; } = false;

        [JsonProperty("formatBuyPriceTimesNumber")]
        public string FormatBuyPriceTimesNumber { get; set; }

        [JsonProperty("formatSellPriceTimesNumber")]
        public string FormatSellPriceTimesNumber { get; set; }

        static readonly HashSet<int> ResourceNumbers = new HashSet<int>()
        {
            43, //Copper x100
            53 , //Scrap x100
            85, //Wires x100
            119, //Coupons x100
            168, //Electronics x100
            330, //Taler x100
            337,  //Uran x100
            522, // Sweets x100
            784, //Batteries x100
            785 //Plastic x100
        };

        private static decimal CalculatePriceByNumber(decimal price, int number, int id)
        {
            if (ResourceNumbers.Contains(id))
            {
                return price * number / 100m;
            }
            return price * number;
        }

        [JsonIgnore]
        public RecipeItem Parent { get; set; }

        [JsonProperty("parentId")]
        public int ParentId
        { get; set; }

        [JsonProperty("parentUniqueId")]
        public int ParentUniqueId
        { get; set; }

        [JsonProperty("parentRecipe")]
        public int ParentRecipe
        { get; set; }

        [JsonProperty("superParentRecipe")]
        public int SuperParentRecipe
        { get; set; }

        [JsonProperty("ingredientSum")]
        public RecipeItem IngredientSum { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; } = new Item();

        [JsonProperty("ingredients")]
        public List<RecipeItem> Ingredients { get; set; } = new List<RecipeItem>();

        public override string ToString()
        {
            return $"{nameof(Depth)}: {Depth}, {nameof(Item)}: {Item}, {nameof(Number)}: {Number}";
        }
    }
}