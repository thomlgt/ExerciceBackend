using App.DTO;
using App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services.Impl
{
    public class VoitureService : IVoitureService
    {
        private IVoitureRepository repository;

        public VoitureService(IVoitureRepository repository)
        {
            this.repository = repository;
        }

        public VoitureDTO AjouterUneVoiture(VoitureDTO voiture)
        {
            return this.repository.Save(voiture);
        }

        public VoitureDTO ModifierVoiture(int id, VoitureDTO voiture)
        {
            return this.repository.Update(id, voiture);
        }

        public void SupprimerVoiture(int id)
        {
            this.repository.Delete(id);
        }

        public VoitureDTO TrouverParId(int id)
        {
            return this.repository.FindById(id);
        }

        public IEnumerable<VoitureDTO> TrouverParImmatriculation(string immatriculation)
        {
            List<VoitureDTO> result = new List<VoitureDTO>();
            foreach (VoitureDTO voiture in this.repository.FindByImmatriculation(immatriculation))
            {
                result.Add(voiture);
            }
            return result;
        }

        public IEnumerable<VoitureDTO> TrouverParMarque(string marque)
        {
            List<VoitureDTO> result = new List<VoitureDTO>();
            foreach (VoitureDTO voiture in this.repository.FindByMarque(marque))
            {
                result.Add(voiture);
            }
            return result;
        }

        public IEnumerable<VoitureDTO> TrouverParNom(string nom)
        {
            List<VoitureDTO> result = new List<VoitureDTO>();
            foreach (VoitureDTO voiture in this.repository.FindByNom(nom))
            {
                result.Add(voiture);
            }
            return result;
        }

        public IEnumerable<VoitureDTO> TrouverParProprietaireId(int id)
        {
            List<VoitureDTO> result = new List<VoitureDTO>();
            foreach (VoitureDTO voiture in this.repository.FindByProprietaireId(id))
            {
                result.Add(voiture);
            }
            return result;
        }

        public IEnumerable<VoitureDTO> TrouverTout()
        {
            List<VoitureDTO> result = new List<VoitureDTO>();
            foreach (VoitureDTO voiture in this.repository.FindAll())
            {
                if(voiture != null)
                {
                    result.Add(voiture);
                }
            }
            return result;
        }
    }
}
