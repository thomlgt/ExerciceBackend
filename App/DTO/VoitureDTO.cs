using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.DTO
{
    public class VoitureDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Marque { get; set; }
        public string Immatriculation { get; set; }
        public PersonneDTO Proprietaire { get; set; }

        public VoitureDTO() { }

        public VoitureDTO(int id, string nom, string marque, string immatriculation, PersonneDTO proprietaire)
        {
            Id = id;
            Nom = nom;
            Marque = marque;
            Immatriculation = immatriculation;
            Proprietaire = proprietaire;
        }

        public static implicit operator Voiture(VoitureDTO v)
        {
            return new Voiture(
                v.Id,
                v.Nom,
                v.Marque,
                v.Immatriculation,
                v.Proprietaire
                );
        }
    }
}
