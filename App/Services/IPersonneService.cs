using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IPersonneService
    {
        /// <summary>
        /// Méthode qui renvoie la liste de toutes les Personnes(DTO)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PersonneDTO> TrouverTout();

        /// <summary>
        /// Méthode qui renvoie la Personne(DTO) ayant pour id: {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PersonneDTO TrouverParId(int id);

        /// <summary>
        /// Méthode qui retourne la liste des Personnes(DTO) ayant pour nom : {nom}
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public IEnumerable<PersonneDTO> TrouverParNom(string nom);

        /// <summary>
        /// Méthode qui retourne la liste des Personne(DTO) ayant pour prenom : {prenom}
        /// </summary>
        /// <param name="prenom"></param>
        /// <returns></returns>
        public IEnumerable<PersonneDTO> TrouverParPrenom(string prenom);

        /// <summary>
        /// Méthode qui retourne la liste des Personnes(DTO) ayant pour age : {age}
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public IEnumerable<PersonneDTO> TrouverParAge(int age);

        /// <summary>
        /// Méthode qui retourne la liste des Personnes(DTO) ayant pour age : {min} <= age =< {max}
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public IEnumerable<PersonneDTO> TrouverParAge(int min, int max);
        
        /// <summary>
        /// Méthode qui retourne une Personne(DTO) après l'avoir enregistré
        /// </summary>
        /// <param name="personne"></param>
        /// <returns></returns>
        public PersonneDTO AjouterUnePersonne(PersonneDTO personne);
        
        /// <summary>
        /// Méthode qui supprime une Personne(DTO) ayant pour id:{id}
        /// </summary>
        /// <param name="id"></param>
        public void SupprimerPersonne(int id);
        
        /// <summary>
        /// Méthode qui retourne une Personne(DTO) après l'avoir modifié
        /// </summary>
        /// <param name="id"></param>
        /// <param name="personne"></param>
        /// <returns></returns>
        public PersonneDTO ModifierPersonne(PersonneDTO personne);
    }
}
