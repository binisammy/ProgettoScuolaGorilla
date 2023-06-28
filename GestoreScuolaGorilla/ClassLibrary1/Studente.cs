﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Studente
    {
        private Dictionary<string, Voti> votiMaterie;
        private string nome;
        private string cognome;
        private string matricola;
        private string idClasse;

        public Studente()
        {
            votiMaterie = new Dictionary<string, Voti>();
            nome = "";
            cognome = "";
            matricola = "";
            idClasse = "";
        }

        public Studente(string nome, string cognome, string matricola, string idClasse)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.matricola = matricola;
            votiMaterie = new Dictionary<string, Voti>();
            this.idClasse = idClasse;
        }

        public string Nome
        {
            get
            { 
                return nome;
            }
            set 
            {
                nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return cognome;
            }
            set
            {
                cognome = value;
            }
        }

        public string Matricola
        {
            get
            {
                return matricola;
            }
            set
            {
                matricola = value;
            }
        }

        public string IdClasse
        {
            get
            {
                return idClasse;
            }
            set
            {
                idClasse = value;
            }
        }

        public Dictionary<string, Voti> VotiMaterie
        {
            get
            {
                return votiMaterie;
            }
            set
            {
                votiMaterie = value;
            }
        }
        public void addVotiMateria(double voto, string materia) 
        {
            materia = materia.ToLower();
            if(votiMaterie.ContainsKey(materia))
            {
                votiMaterie[materia].add(voto);
            }
            else
            {
                votiMaterie.Add(materia, new Voti(materia, voto));
            }
        }
    }
}
