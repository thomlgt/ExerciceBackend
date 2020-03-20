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
        public string Marque { get; set; }
        public string Nom { get; set; }
        public string Immatriculation { get; set; }
        public int PersonneId { get; set; }
        public virtual PersonneDTO Personne { get; set; }

        public VoitureDTO() { }

        public VoitureDTO(int id, string marque, string nom, string immatriculation, int personneId, PersonneDTO personne)
        {
            Id = id;
            Marque = marque;
            Nom = nom;
            Immatriculation = immatriculation;
            PersonneId = personneId;
            Personne = personne;
        }

        /// <summary>
        /// Méthode permettant de transformer une Voiture(DTO) en Voiture(Models) de manière implicite
        /// </summary>
        /// <param name="v"></param>
        public static implicit operator Voiture(VoitureDTO v)
        {
            return new Voiture(
                v.Id,
                v.Nom,
                v.Marque,
                v.Immatriculation,
                v.PersonneId,
                v.Personne
                );
        }
    }
}
