using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ApiMethods
    {
        private HttpClient client;
        private string BaseUrl;
        
        public ApiMethods()
        {
            this.client = new HttpClient();
            this.BaseUrl = "http://localhost:10212/values";
        }

        public async Task<List<string>> getClassi()
        {
            string getclassiUrl = BaseUrl + "/classi";
            var responseClasse = await client.GetFromJsonAsync<List<string>>(getclassiUrl);
            return responseClasse;
        }

        public async Task<List<string>> getMaterie(string id_classe)
        {
            string getmaterieUrl = BaseUrl + $"/materie?id_classe={id_classe}";
            var responseStudente = await client.GetFromJsonAsync<List<string>>(getmaterieUrl);
            return responseStudente;
        }

        public async Task<Studente> getVoti(string id_matricola)
        {
            string getvotiUrl = BaseUrl + $"/voti?id_studente={id_matricola}";
            var responseStudente = await client.GetFromJsonAsync<Studente>(getvotiUrl);
            return responseStudente;
        }


    }
}
