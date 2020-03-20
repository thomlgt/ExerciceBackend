using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repositories.Impl
{
    public class VoitureRepository : IVoitureRepository
    {
        private static List<Voiture> voitures = new List<Voiture>();

        public void Delete(int id)
        {
            voitures[id] = null;
        }

        public IEnumerable<Voiture> FindAll()
        {
            List<Voiture> result = new List<Voiture>();
            foreach(Voiture voiture in voitures)
            {
                if(voiture != null)
                {
                    result.Add(voiture);
                }
            }
            return result;
        }

        public Voiture FindById(int id)
        {
            return voitures[id];
        }

        public IEnumerable<Voiture> FindByImmatriculation(string immatriculation)
        {
            return voitures.Where(v => v.Immatriculation == immatriculation);
        }

        public IEnumerable<Voiture> FindByMarque(string marque)
        {
            return voitures.Where(v => v.Marque == marque);
        }

        public IEnumerable<Voiture> FindByNom(string nom)
        {
            return voitures.Where(v => v.Nom == nom);
        }

        public IEnumerable<Voiture> FindByProprietaireId(int id)
        {
            return voitures.Where(v => v.PersonneId == id);
        }

        public Voiture Save(Voiture voiture)
        {
            voiture.Id = voitures.Count();
            voitures.Add(voiture);
            return voiture;
        }

        public Voiture Update(int id, Voiture voiture)
        {
            voiture.Id = id;
            voitures[id] = voiture;
            return voiture;
        }
    }
}
