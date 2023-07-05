using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Cryptography;
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

        public async Task<List<string>> getMaterie()
        {
            string getmaterieUrl = BaseUrl + $"/materie";
            var responseStudente = await client.GetFromJsonAsync<List<string>>(getmaterieUrl);
            return responseStudente;
        }

        public async Task<List<string>> getMaterieByClasse(string id_classe)
        {
            string getstudentiUrl = BaseUrl + $"/materieByClasse?id_classe={id_classe}";
            var responseStudente = await client.GetFromJsonAsync<List<string>>(getstudentiUrl);
            return responseStudente;
        }

        public async Task<Studente> getVoti(string id_matricola)
        {
            string getvotiUrl = BaseUrl + $"/voti?id_studente={id_matricola}";
            var responseStudente = await client.GetFromJsonAsync<Studente>(getvotiUrl);
            return responseStudente;
        }

        public async Task<string> getMatricola(string id_classe, string nome, string cognome)
        {
            string getmatricolaUrl = BaseUrl + $"/matricola?id_classe={id_classe}&nome={nome}&cognome={cognome}";
            var response = await client.GetStringAsync(getmatricolaUrl);
            return response;
        }

        public async Task<List<string>> getAllMatricole()
        {
            string getAllmatricoleUrl = BaseUrl + $"/AllMatricole";
            var response = await client.GetFromJsonAsync<List<string>>(getAllmatricoleUrl);
            return response;
        }

        public async Task<List<Studente>> getStudenti(string id_classe)
        {
            string getstudentiUrl = BaseUrl + $"/studenti?id_classe={id_classe}";
            var responseStudente = await client.GetFromJsonAsync<List<Studente>>(getstudentiUrl);
            return responseStudente;
        }

        public async Task<List<string>> getMaterieByMatricola(string matricola)
        {
            string getMaterieUrl = BaseUrl + $"/materieByMatricola?matricola={matricola}";
            var response = await client.GetFromJsonAsync<List<string>>(getMaterieUrl);
            return response;
        }

        public async Task<string> postStudente(List<string> studente)
        {
            string poststudenteUrl = BaseUrl + "/studenti";
            var response = await client.PostAsJsonAsync(poststudenteUrl, studente);
            return response.Content.ReadAsStringAsync().Result;
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

        public async Task<string> postMateriaInInsieme(string id_materia)
        {
            string postMateriaUrl = BaseUrl + "/insieme_materie";
            List<string> materia = new List<string> { id_materia };
            var response = await client.PostAsJsonAsync(postMateriaUrl, materia);
            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<string> postMateriaInClasse(string id_materia, string id_classe)
        {
            string postMateriaUrl = BaseUrl + "/materia_classe";
            List<string> materia = new List<string> { id_materia, id_classe };
            var response = await client.PostAsJsonAsync(postMateriaUrl, materia);
            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<string> postClasse(string id_classe)
        {
            string postClasseUrl = BaseUrl + "/classi";
            List<string> classe = new List<string> { id_classe };
            var response = await client.PostAsJsonAsync(postClasseUrl, classe);
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

        public async Task<string> deleteVotiByMateriaStudente(string id_studente, string id_materia)
        {
            string deletevotiUrl = BaseUrl + $"/votimateriastudente?id_studente={id_studente}&id_materia={id_materia}";
            var response = await client.DeleteAsync(deletevotiUrl);
            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<string> deleteMateriaFromClasse(string id_classe, string id_materia)
        {
            string deletevotiUrl = BaseUrl + $"/materia_classe?id_materia={id_materia}&id_classe={id_classe}";
            var response = await client.DeleteAsync(deletevotiUrl);
            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<string> deleteMateriaFromInsieme(string id_materia)
        {
            string deletemateriaUrl = BaseUrl + $"/materia?id_materia={id_materia}";
            var response = await client.DeleteAsync(deletemateriaUrl);
            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<string> deleteClasse(string id_classe)
        {
            string deleteclasseUrl = BaseUrl + $"/classe?id_classe={id_classe}";
            var response = await client.DeleteAsync(deleteclasseUrl);
            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<string> deleteStudente(string id_studente)
        {
            string deletestudenteUrl = BaseUrl + $"/studente?id_studente={id_studente}";
            var response = await client.DeleteAsync(deletestudenteUrl);
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
