﻿using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;
using Npgsql;
using Microsoft.AspNetCore.Hosting.Server;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;
using System.Collections.Generic;
using System.Data;

namespace ModuloServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //DATABASE ACCESS VARIABLES
        private const string datasource = "192.168.11.66";
        private const string port = "7777";
        private const string database = "mydatabase";
        private const string username = "postgres";
        private const string passwd = "samuele01";


        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hello World");
        }

        [HttpPost("studenti")]
        public ActionResult<string> PostStudente(List<string> studente)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO STUDENTI (nome,cognome,id_matricola,id_classe) VALUES ('{studente[0]}', '{studente[1]}','{studente[2]}','{studente[3]}')";
                cmd.ExecuteNonQuery();
            }
            return Ok("Studente inserito!");
        }

        [HttpPost("voto")]
        public ActionResult<string> PostVoti(List<string> voto)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO VOTI (id_matricola,id_voto,id_materie) VALUES ('{voto[0]}',{voto[1]},'{voto[2]}')";
                cmd.ExecuteNonQuery();
            }
            return Ok("Voto inserito!");
        }

        [HttpPost("classi")]
        public ActionResult<string> PostClasse(List<string> classe)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO CLASSI (id_classe) VALUES ('{classe[0]}')";
                cmd.ExecuteNonQuery();
            }
            return Ok("Classe aggiunta!");
        }

        [HttpPost("insieme_materie")]
        public ActionResult<string> PostMateriaInInsieme(List<string> materia)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO INSIEME_MATERIE (id_materie) VALUES ('{materia[0]}')";
                cmd.ExecuteNonQuery();
            }
            return Ok("Materia inserita!");
        }

        [HttpPost("materie")]
        public ActionResult<string> PostMaterie(List<string> values)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO MATERIE (id_materie, id_classe) VALUES ('{values[0]}', '{values[1]}')";
                cmd.ExecuteNonQuery();
            }
            return Ok();
        }

        [HttpPost("materia_classe")]
        public ActionResult<string> PostMateriaClasse(List<string> values)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO MATERIE (id_materie, id_classe) VALUES ('{values[0]}', '{values[1]}')";
                cmd.ExecuteNonQuery();
            }
            return Ok();
        }

        [HttpGet("materie")]
        public ActionResult<List<string>> GetMaterie()
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            List<string> materie = new List<string>();
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM INSIEME_MATERIE";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    materie.Add(rdr.GetString(0));
                }
            }
            return Ok(materie);
        }

        [HttpGet("materieByClasse")]
        public ActionResult<List<string>> GetMaterieByClasse(string id_classe)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            List<string> materie = new List<string>();
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT ID_MATERIE FROM MATERIE WHERE ID_CLASSE = '{id_classe}'";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    materie.Add(rdr.GetString(0));
                }
            }
            return Ok(materie);
        }

        [HttpGet("classi")]
        public ActionResult<List<string>> GetClassi()
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            List<string> classi = new List<string>();
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM CLASSI ORDER BY ID_CLASSE";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    classi.Add(rdr.GetString(0));
                }
            }
            return Ok(classi);
        }

        [HttpGet("studenti")]
        public ActionResult<List<Studente>> GetStudenti(string id_classe)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            List<Studente> studenti = new List<Studente>();
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM STUDENTI WHERE ID_CLASSE = '{id_classe}'";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    studenti.Add(new Studente(rdr.GetString(2), rdr.GetString(3), rdr.GetString(0), rdr.GetString(1)));
                }
            }
            return Ok(studenti);
        }

        [HttpGet ("AllMatricole")]
        public ActionResult<List<string>> GetAllMatricole()
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            List<string> matricole = new List<string>();
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM STUDENTI";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    matricole.Add(rdr.GetString(0));
                }
            }
            return Ok(matricole);
        }

        [HttpGet("studente")]
        public ActionResult<Studente> GetStudente(string id_studente)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            Studente studente = new Studente();
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM STUDENTI WHERE ID_MATRICOLA = '{id_studente}'";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    studente = new Studente(rdr.GetString(2), rdr.GetString(3), rdr.GetString(0), rdr.GetString(1));
                }
            }
            return Ok(studente);
        }

        [HttpGet("voti")]
        public ActionResult<Studente> GetVoti(string id_studente)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            Studente studente = new Studente("from", "api", id_studente, "AAA");
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT ID_VOTO, ID_MATERIE FROM VOTI WHERE ID_MATRICOLA = '{id_studente}' ORDER BY ID_MATERIE";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    studente.addVotiMateria(rdr.GetDouble(0), rdr.GetString(1));
                }
                return Ok(studente);
            }
        }

        [HttpGet("matricola")]
        public ActionResult<string> GetMatricola(string id_classe, string nome, string cognome)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            string matricola = "";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT ID_MATRICOLA FROM STUDENTI WHERE ID_CLASSE = '{id_classe}' AND NOME = '{nome}' AND COGNOME = '{cognome}'";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    matricola = rdr.GetValue(0).ToString();
                }
                if (matricola == "")
                    matricola = "Non trovato!";
            }
            return Ok(matricola);
        }

        [HttpGet("materieByMatricola")]
        public ActionResult<List<string>> GetMaterieByMatricola(string matricola) 
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            List<string> materie = new List<string>();
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select id_materie from studenti s join materie m on s.id_classe = m.id_classe where s.id_matricola = '{matricola}'";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                     materie.Add(rdr.GetValue(0).ToString());
                }
            }
            return Ok(materie);
        }

        [HttpDelete("classe")]
        public ActionResult<string> DeleteClasse(string id_classe)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"DELETE FROM MATERIE WHERE ID_CLASSE = '{id_classe}'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"DELETE FROM VOTI WHERE ID_MATRICOLA IN (SELECT ID_MATRICOLA FROM STUDENTI WHERE ID_CLASSE = '{id_classe}')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"DELETE FROM STUDENTI WHERE ID_CLASSE = '{id_classe}'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"DELETE FROM CLASSI WHERE ID_CLASSE = '{id_classe}'";
                cmd.ExecuteNonQuery();
            }
            return Ok("Classe eliminata!");
        }

        [HttpDelete("materia_classe")]
        public ActionResult<string> DeleteMateriaClasse(string id_classe, string id_materia)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"DELETE FROM MATERIE WHERE ID_CLASSE = '{id_classe}' AND ID_MATERIE = '{id_materia}'";
                cmd.ExecuteNonQuery();
            }
            return Ok();
        }

        [HttpDelete("voto")]
        public ActionResult<string> DeleteVoto(string id_voto, string id_materia, string id_studente)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            int before = 0, after = 0;
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT COUNT(KEY_VOTO) FROM VOTI WHERE ID_MATRICOLA = '{id_studente}'";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    before = rdr.GetInt32(0);
                }
                rdr.Close();
                cmd.CommandText = $"DELETE FROM VOTI WHERE KEY_VOTO IN (SELECT KEY_VOTO FROM VOTI WHERE ID_VOTO = {id_voto} AND ID_MATERIE = '{id_materia}' AND ID_MATRICOLA = '{id_studente}' LIMIT 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"SELECT COUNT(KEY_VOTO) FROM VOTI WHERE ID_MATRICOLA = '{id_studente}'";
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    after = rdr.GetInt32(0);
                }
            }
            if (before == after)
                return Ok("Voto non trovato!");
            else
                return Ok("Voto eliminato!");
        }

        [HttpDelete("allvoti")]
        public ActionResult<string> DeleteVoti(string id_studente)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"DELETE FROM VOTI WHERE ID_MATRICOLA = '{id_studente}'";
                cmd.ExecuteNonQuery();
            }
            return Ok("Voti eliminati!");
        }

        [HttpDelete("votimateriastudente")]
        public ActionResult<string> DeleteVotiByMateriaStudente(string id_studente, string id_materia)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"DELETE FROM VOTI WHERE ID_MATRICOLA = '{id_studente}' AND ID_MATERIE = '{id_materia}'";
                cmd.ExecuteNonQuery();
            }
            return Ok("Voti eliminati!");
        }

        [HttpDelete("materia")]
        public ActionResult<string> DeleteMateria (string id_materia)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"DELETE FROM MATERIE WHERE ID_MATERIE = '{id_materia}'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"DELETE FROM VOTI WHERE ID_MATERIE = '{id_materia}'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"DELETE FROM INSIEME_MATERIE WHERE ID_MATERIE = '{id_materia}'";
                cmd.ExecuteNonQuery();
            }
            return Ok("Materia eliminata!");
        }

        [HttpDelete("studente")]
        public ActionResult<string> DeleteStudente(string id_studente)
        {
            var cs = $"Host={datasource};Port={port};Username={username};Password={passwd};Database={database}";
            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"DELETE FROM VOTI WHERE ID_MATRICOLA = '{id_studente}'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"DELETE FROM STUDENTI WHERE ID_MATRICOLA = '{id_studente}'";
                cmd.ExecuteNonQuery();
            }
            return Ok("Studente eliminato!");
        }
    }
}