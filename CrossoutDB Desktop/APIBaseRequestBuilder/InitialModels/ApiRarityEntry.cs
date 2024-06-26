﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Crossout.Web.Models.API.v1
{
    public class ApiRarityEntry : ApiEntryBase
    {
        [JsonProperty("primarycolor")]
        public string PrimaryColor { get; set; }
        
        [JsonProperty("secondarycolor")]
        public string SecondaryColor { get; set; }
        
        [JsonProperty("order")]
        public int Order { get; set; }
    }
}