using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

using Crossout.Data;
using Crossout.Data.Stats;
using Crossout.Model.Items;
using Crossout.Model.Recipes;
using Crossout.Model;
using Crossout;
using Crossout.Web.Models.API.v1;
using Crossout.Web.Models.API;
using Crossout.Web.Models.Recipes;
using Crossout.Web.Models;
using Crossout.Web;

using Newtonsoft.Json;


namespace API.Request
{
    public static class BsicRequests
    {
        public enum MarketColumn
        {
            sellprice = 1,
            buyprice = 2,
            selloffers = 3,
            buyorders = 4
        }

        public static List<ApiRarityEntry> GetRarity()
        {
            List<ApiRarityEntry> apiRarityEntries = JsonConvert.DeserializeObject<List<ApiRarityEntry>>(new WebClient().DownloadString("https://crossoutdb.com/api/v2/rarities"));
            return apiRarityEntries;
        }

        public static List<ApiFactionEntry> GetFactions()
        {
            List<ApiFactionEntry> apiRarityEntries = JsonConvert.DeserializeObject<List<ApiFactionEntry>>(new WebClient().DownloadString("https://crossoutdb.com/api/v2/factions"));
            return apiRarityEntries;
        }

        public static List<ApiItemTypeEntry> GetItemTypes()
        {
            List<ApiItemTypeEntry> apiRarityEntries = JsonConvert.DeserializeObject<List<ApiItemTypeEntry>>(new WebClient().DownloadString("https://crossoutdb.com/api/v2/types"));
            return apiRarityEntries;
        }
        public static List<ApiCategoryEntry> GetCategories()
        {
            List<ApiCategoryEntry> apiRarityEntries = JsonConvert.DeserializeObject<List<ApiCategoryEntry>>(new WebClient().DownloadString("https://crossoutdb.com/api/v2/categories"));
            return apiRarityEntries;
        }

        public static Item GetItem(string id)
        {
            Item Item = JsonConvert.DeserializeObject<Item>(new WebClient().DownloadString("https://crossoutdb.com/api/v2/item/" + id));
            return Item;
        }

        public static Item[] GetItems(string query = "",string rarity = "",string faction = "",string category = "")
        {
            Item[] Items = JsonConvert.DeserializeObject<Item[]>(new WebClient().DownloadString("https://crossoutdb.com/api/v2/items?query=" + query + "&rarity=" + rarity + "&faction="  + faction + "&category=" + category));
            return Items;
        }

        public static RecipeItem GetRecipe(string id)
        {
            RecipeItem recipe = JsonConvert.DeserializeObject<RecipeItem>(new WebClient().DownloadString("https://crossoutdb.com/api/v2/recipe/" + id));
            return recipe;
        }
    } 
}