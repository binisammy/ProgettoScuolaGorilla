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

        public async Task<List<string>> getMaterieByClasse(string id_classe)
        {
            string getstudentiUrl = BaseUrl + $"/materieByMatricola?id_classe={id_classe}";
            var responseStudente = await client.GetFromJsonAsync<List<string>>(getstudentiUrl);
            return responseStudente;
        }

        public async Task<Studente> getVoti(string id_matricola)
        {
            string getvotiUrl = BaseUrl + $"/voti?id_studente={id_matricola}";
            var responseStudente = await client.GetFromJsonAsync<Studente>(getvotiUrl);
            return responseStudente;
        }

        public async Task<string> postVoto(string id_materia, string id_studente, string voto)
        {
            List<string> parametri = new List<string>
            {
                id_studente,
                voto,
                id_materia
            };
            string postvotoUrl = BaseUrl + $"/voto";
            var response = await client.PostAsJsonAsync(postvotoUrl, parametri);
            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<Studente> getStudente(string id_studente)
        {
            string getstudenteUrl = BaseUrl + $"/studente?id_studente={id_studente}";
            var responseStudente = await client.GetFromJsonAsync<Studente>(getstudenteUrl);
            return responseStudente;
        }

        public async Task<string> deleteVoto(string id_voto, string id_materia, string id_studente)
        {
            string deletevotoUrl = BaseUrl + $"/voto?id_voto={id_voto}&id_materia={id_materia}&id_studente={id_studente}";
            var response = await client.DeleteAsync(deletevotoUrl);
            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<string> deleteVoti(string id_studente)
        {
            string deletevotiUrl = BaseUrl + $"/allvoti?id_studente={id_studente}";
            var response = await client.DeleteAsync(deletevotiUrl);
            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<string> deleteVotiByMateria(string id_studente, string id_materia)
        {
            string deletevotiUrl = BaseUrl + $"/votimateria?id_studente={id_studente}&id_materia={id_materia}";
            var response = await client.DeleteAsync(deletevotiUrl);
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
