using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IPersonneService
    {
        //------TROUVER------
        public IEnumerable<PersonneDTO> TrouverTout();
        public PersonneDTO TrouverParId(int id);
        public IEnumerable<PersonneDTO> TrouverParNom(string nom);
        public IEnumerable<PersonneDTO> TrouverParPrenom(string prenom);
        public IEnumerable<PersonneDTO> TrouverParAge(int age);
        public IEnumerable<PersonneDTO> TrouverParAge(int min, int max);
        //------AJOUTER------
        public PersonneDTO AjouterUnePersonne(PersonneDTO personne);
        //------SUPPRIMER------
        public void SupprimerPersonne(int id);
        //------MODIFIER------
        public PersonneDTO ModifierPersonne(int id, PersonneDTO personne);
    }
}
