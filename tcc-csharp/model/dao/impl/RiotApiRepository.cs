using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc_csharp.model.entities;
using Newtonsoft.Json;

namespace tcc_csharp.model.dao.impl
{
    public class RiotApiRepository : IRiotApi
    {
        public async Task<PerfilRiot> findByUsername(string username)
        {
            var apiKey = "your-api-key";
            var url = $"https://br1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{username}?api_key={apiKey}";
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string conteudo = await response.Content.ReadAsStringAsync();
                    PerfilRiot perfilRiot = JsonConvert.DeserializeObject<PerfilRiot>(conteudo);
                    return perfilRiot;
                }
                else
                {
                    return null;
                }
           }
        }
    }
}
