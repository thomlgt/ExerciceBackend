using App.DTO;
using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Voiture
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Nom { get; set; }
        public string Immatriculation { get; set; }
        public int PersonneId { get; set; }

        public Voiture() { }

        public Voiture(int id, string marque, string nom, string immatriculation, int personneId, Personne personne)
        {
            Id = id;
            Marque = marque;
            Nom = nom;
            Immatriculation = immatriculation;
            PersonneId = personneId;
            Personne = personne;
        }

        public virtual Personne Personne { get; set; }

        public static implicit operator VoitureDTO(Voiture v)
        {
            return new VoitureDTO(
                v.Id,
                v.Marque,
                v.Nom,
                v.Immatriculation,
                v.PersonneId,
                v.Personne
                );
        }
    }
}
