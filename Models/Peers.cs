﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    [JsonArray]
    public class Peers
    {
        public List<string> PeerList { get; set; }
    }
}
