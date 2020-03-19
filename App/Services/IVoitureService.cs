using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IVoitureService
    {
        /// <summary>
        /// Méthode qui retourne la liste de toutes les Voiture(DTO)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VoitureDTO> TrouverTout();

        /// <summary>
        /// Méthode qui retourne une Voiture(DTO) ayant pour id : {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VoitureDTO TrouverParId(int id);

        /// <summary>
        /// Méthode qui retourne la liste des Voitures(DTO) ayant pour nom : {nom}
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public IEnumerable<VoitureDTO> TrouverParNom(string nom);

        /// <summary>
        /// Méthode qui retourne la liste des Voitures(DTO) ayant pour marque : {marque}
        /// </summary>
        /// <param name="marque"></param>
        /// <returns></returns>
        public IEnumerable<VoitureDTO> TrouverParMarque(string marque);

        /// <summary>
        /// Méthode qui retourne la liste des Voitures(DTO) ayant pour immatriculation : {immatriculation}
        /// </summary>
        /// <param name="immatriculation"></param>
        /// <returns></returns>
        public IEnumerable<VoitureDTO> TrouverParImmatriculation(string immatriculation);

        /// <summary>
        /// Méthode qui retourne la liste des Voitures(DTO) ayant pour proprietaireId : {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<VoitureDTO> TrouverParProprietaireId(int id);
        
        /// <summary>
        /// Méthode qui retourne une Voiture(DTO) après l'avoir enregistré
        /// </summary>
        /// <param name="voiture"></param>
        /// <returns></returns>
        public VoitureDTO AjouterUneVoiture(VoitureDTO voiture);
        
        /// <summary>
        /// Méthode qui supprime une Voiture(DTO) ayant pour id : {id}
        /// </summary>
        /// <param name="id"></param>
        public void SupprimerVoiture(int id);
        
        /// <summary>
        /// Méthode qui retourne une Voiture(DTO) après l'avoir modifié
        /// </summary>
        /// <param name="id"></param>
        /// <param name="voiture"></param>
        /// <returns></returns>
        public VoitureDTO ModifierVoiture(int id, VoitureDTO voiture);
    }
}
