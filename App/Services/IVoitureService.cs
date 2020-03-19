using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IVoitureService
    {
        //------TROUVER------
        public IEnumerable<VoitureDTO> TrouverTout();
        public VoitureDTO TrouverParId(int id);
        public IEnumerable<VoitureDTO> TrouverParNom(string nom);
        public IEnumerable<VoitureDTO> TrouverParMarque(string marque);
        public IEnumerable<VoitureDTO> TrouverParImmatriculation(string immatriculation);
        public IEnumerable<VoitureDTO> TrouverParProprietaireId(int id);
        //------AJOUTER------
        public VoitureDTO AjouterUneVoiture(VoitureDTO voiture);
        //------SUPPRIMER------
        public void SupprimerVoiture(int id);
        //------MODIFIER------
        public VoitureDTO ModifierVoiture(int id, VoitureDTO voiture);
    }
}
