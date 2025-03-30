using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ScryfallCardGenerator.Tools
{
    public class CardInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }
        
        [JsonProperty("color_identity")]
        public string ColorIdentity { get; set; }

    }
}
