using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repositories.Impl
{
    public class PersonneRepository : IPersonneRepository
    {
        private static List<Personne> personnes = new List<Personne>();

        public void Delete(int id)
        {
            personnes[id] = null;
        }

        public IEnumerable<Personne> FindAll()
        {
            List<Personne> result = new List<Personne>();
            foreach (var personne in personnes)
            {
                if (personne != null)
                {
                    result.Add(personne);
                }
            }
            return result;
        }

        public IEnumerable<Personne> FindByAge(int age)
        {
            return personnes.Where(p => p.Age == age);
        }

        public IEnumerable<Personne> FindByAge(int min, int max)
        {
            return personnes.Where(p => p.Age >= min && p.Age <= max);
        }

        public Personne FindById(int id)
        {
            return personnes[id];
        }

        public IEnumerable<Personne> FindByNom(string nom)
        {
            return personnes.Where(p => p.Nom == nom);
        }

        public IEnumerable<Personne> FindByPrenom(string prenom)
        {
            return personnes.Where(p => p.Prenom == prenom);
        }

        public Personne Save(Personne personne)
        {
            personne.Id = personnes.Count();
            personnes.Add(personne);
            return personne;
        }

        public Personne Update(int id, Personne personne)
        {
            personne.Id = id;
            personnes[id] = personne;
            return personne;
        }
    }
}
