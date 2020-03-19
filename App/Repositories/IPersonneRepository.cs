using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repositories
{
    public interface IPersonneRepository
    {
        //------TROUVER------
        public IEnumerable<Personne> FindAll();
        public Personne FindById(int id);
        public IEnumerable<Personne> FindByNom(string nom);
        public IEnumerable<Personne> FindByPrenom(string prenom);
        public IEnumerable<Personne> FindByAge(int age);
        public IEnumerable<Personne> FindByAge(int min, int max);
        //------AJOUTER------
        public Personne Save(Personne personne);
        //------SUPPRIMER------
        public void Delete(int id);
        //------MODIFIER------
        public Personne Update(int id, Personne personne);
    }
}
