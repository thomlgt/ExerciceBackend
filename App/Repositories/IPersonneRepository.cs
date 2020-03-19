using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repositories
{
    public interface IPersonneRepository
    {
        /// <summary>
        /// Méthode qui retourne la liste de toutes les Personnes(Models)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Personne> FindAll();

        /// <summary>
        /// Méthode qui retourne la Personne(Models) qui a pour id : {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Personne FindById(int id);

        /// <summary>
        /// Méthode qui retourne la liste des Personnes(Models) ayant pour nom : {nom}
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public IEnumerable<Personne> FindByNom(string nom);

        /// <summary>
        /// Méthode qui retourne la liste des Personnes(Models) ayant pour prenom : {prenom}
        /// </summary>
        /// <param name="prenom"></param>
        /// <returns></returns>
        public IEnumerable<Personne> FindByPrenom(string prenom);

        /// <summary>
        /// Méthode qui retourne la liste des Personnes(Models) ayant pour Age : {age}
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public IEnumerable<Personne> FindByAge(int age);

        /// <summary>
        /// Méthode qui retourne la liste des Personnes(Models) ayant pour age : {min} <= age =< {max}
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public IEnumerable<Personne> FindByAge(int min, int max);
        
        /// <summary>
        /// Méthode qui retourne une Personne(Models) après l'avoir enregistré
        /// </summary>
        /// <param name="personne"></param>
        /// <returns></returns>
        public Personne Save(Personne personne);
        
        /// <summary>
        /// Méthode qui supprime une Personne(Models) ayant pour id : {id}
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id);
        
        /// <summary>
        /// Méthode qui retourne une Personne(Models) après l'avoir modifié
        /// </summary>
        /// <param name="id"></param>
        /// <param name="personne"></param>
        /// <returns></returns>
        public Personne Update(int id, Personne personne);
    }
}
