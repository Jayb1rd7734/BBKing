using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BBKing.Website.Models
{
    public class Player
    {
        public string Name { get; set; }
        public double PER { get; set; }
        public double PPG { get; set; }
        public double AST { get; set; }
        public double TRB { get; set; }
        public double BLK { get; set; }
        public double STL { get; set; }
        public double TOV { get; set; }
        [JsonPropertyName("FG%")]
        public double FGP { get; set; }
        [JsonPropertyName("FT%")]
        public double FTP { get; set; }
        public double WS { get; set; }
        public double CW { get; set; }
        public double GP { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Player>(this);
    }
}
