using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    interface IPersonneService
    {
        //Trouver
        public IEnumerable<PersonneDTO> TrouverTousPersonnes();
        public PersonneDTO TrouverParId(int id);
        public IEnumerable<PersonneDTO> TrouverParNom(string nom);
        public IEnumerable<PersonneDTO> TrouverParPrenom(string prenom);
        public IEnumerable<PersonneDTO> TrouverParAge(int age);
        public IEnumerable<PersonneDTO> TrouverParAge(int min, int max);
        //Ajouter
        public PersonneDTO AjouterUnePersonne(PersonneDTO personne);
        //Supprimer
        public void SupprimerPersonne(int id);
        //Modifier
        public PersonneDTO ModifierPersonne(int id, PersonneDTO personne);
    }
}
