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
        public enum RequestType
        {
            rarities = 1,
            factions = 2,
            types = 3,
            categories = 4,
            items = 5,
            item = 6,
            recipe = 7,
            market = 9
        }
        public enum MarketColumn
        {
            sellprice = 1,
            buyprice = 2,
            selloffers = 3,
            buyorders = 4
        }
        public static string RequesString(RequestType type,params int[] ids)
        {
            string res = "https://crossoutdb.com/api/v2/" + type.ToString();
            if(type == RequestType.market)
            {
                res += '/';
                if (ids[0] == 1)
                    res += MarketColumn.sellprice.ToString();
                if (ids[0] == 2)
                    res += MarketColumn.buyprice.ToString();
                if (ids[0] == 3)
                    res += MarketColumn.selloffers.ToString();
                if (ids[0] == 4)
                    res += MarketColumn.buyorders.ToString();
                res += '/' + ids[1];
            }
            else if((int)type > 5)
            {
                res += '/' + ids[0].ToString();
            }
            return res;
        }

        public static List<ApiRarityEntry> GetRarity()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            //List<ApiRarityEntry> apiRarityEntries = JsonConvert.DeserializeObject<List<ApiRarityEntry>>(new WebClient().DownloadString(""))
            return null;
        }
    } 
}