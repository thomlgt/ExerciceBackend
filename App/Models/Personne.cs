using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public Personne() { }

        public Personne(int id, string nom, string prenom, int age)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        /// <summary>
        /// Méthode permettant de transformer une Personne(Models) en une Personne(DTO) de manière implicite
        /// </summary>
        /// <param name="p"></param>
        public static implicit operator PersonneDTO(Personne p)
        {
            return new PersonneDTO(
                p.Id,
                p.Nom,
                p.Prenom,
                p.Age
                );
        }
    }
}
