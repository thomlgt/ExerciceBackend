using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repositories
{
    public interface IVoitureRepository
    {
        //------TROUVER------
        public IEnumerable<Voiture> FindAll();
        public Voiture FindById(int id);
        public IEnumerable<Voiture> FindByNom(string nom);
        public IEnumerable<Voiture> FindByMarque(string marque);
        public IEnumerable<Voiture> FindByImmatriculation(string immatriculation);
        public IEnumerable<Voiture> FindByProprietaireId(int id);
        //------AJOUTER------
        public Voiture Save(Voiture voiture);
        //------SUPPRIMER------
        public void Delete(int id);
        //------MODIFIER------
        public Voiture Update(int id, Voiture voiture);
    }
}
