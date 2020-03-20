using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repositories
{
    public interface IVoitureRepository
    {
        /// <summary>
        /// Méthode qui retourne la liste de toutes les Voitures(Models)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Voiture> FindAll();

        /// <summary>
        /// Méthode qui retourne une Voiture(Models) ayant pour id : {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Voiture FindById(int id);

        /// <summary>
        /// Méthode qui retourne la liste des Voiture(Models) ayant pour nom : {nom}
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public IEnumerable<Voiture> FindByNom(string nom);

        /// <summary>
        /// Méthode qui retourne la liste des Voiture(Models) ayant pour marque : {marque}
        /// </summary>
        /// <param name="marque"></param>
        /// <returns></returns>
        public IEnumerable<Voiture> FindByMarque(string marque);

        /// <summary>
        /// Méthode qui retourne la liste des Voiture(Models) ayant pour immatriculation : {immatriculation}
        /// </summary>
        /// <param name="immatriculation"></param>
        /// <returns></returns>
        public IEnumerable<Voiture> FindByImmatriculation(string immatriculation);

        /// <summary>
        /// Méthode qui retourne la liste des Voiture(Models) ayant pour proprietaireId : {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Voiture> FindByProprietaireId(int id);

        /// <summary>
        /// Méthode qui retourne une Voiture(Models) après l'avoir enregistré
        /// </summary>
        /// <param name="voiture"></param>
        /// <returns></returns>
        public Voiture Save(Voiture voiture);

        /// <summary>
        /// Méthode qui supprime une Voiture(Models) ayant pour id : {id}
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id);
        
        /// <summary>
        /// Méthode qui retourne une Voiture(Models) après l'avoir modifié
        /// </summary>
        /// <param name="id"></param>
        /// <param name="voiture"></param>
        /// <returns></returns>
        public Voiture Update(Voiture voiture);
    }
}
