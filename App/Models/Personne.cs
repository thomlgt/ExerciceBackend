using App.DTO;
using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int? Age { get; set; }
        public virtual ICollection<Voiture> Voiture { get; set; }

        public Personne()
        {
            Voiture = new HashSet<Voiture>();
        }

        public Personne(int id, string nom, string prenom, int? age, ICollection<Voiture> voiture)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Voiture = voiture;
        }

        public static implicit operator PersonneDTO(Personne p)
        {
            if (p == null) return null;

            ICollection<VoitureDTO> voitures= new List<VoitureDTO>();

            if (p.Voiture != null)
            {
                foreach (VoitureDTO v in p.Voiture)
                {
                    voitures.Add(v);
                }
            }

            return new PersonneDTO(
                p.Id,
                p.Nom,
                p.Prenom,
                p.Age,
                voitures
                );
        }
    }
}
