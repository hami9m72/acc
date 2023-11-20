using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp.Model
{
    public class Streaming
    {
        [JsonProperty("128")]
        public string _128 { get; set; }

        [JsonProperty("320")]
        public string _320 { get; set; }
    }
}
