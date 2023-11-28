using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc_csharp.model.entities
{
    public class PerfilRiot
    {
        public string id { get; set; }
        public string accountId { get; set; }
        public string puuid { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public string revisionDate { get; set; }
        public int summonerLevel { get; set; }

        public PerfilRiot()
        {

        }
    }
}
