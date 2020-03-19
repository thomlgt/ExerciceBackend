using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Voiture
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Marque { get; set; }
        public string Immatriculation { get; set; }
        public Personne Proprietaire { get; set; }

        public Voiture() { }

        public Voiture(int id, string nom, string marque, string immatriculation, Personne proprietaire)
        {
            Id = id;
            Nom = nom;
            Marque = marque;
            Immatriculation = immatriculation;
            Proprietaire = proprietaire;
        }

        public static implicit operator VoitureDTO(Voiture v)
        {
            return new VoitureDTO(
                v.Id,
                v.Nom,
                v.Marque,
                v.Immatriculation,
                v.Proprietaire
                );
        }
    }
}
