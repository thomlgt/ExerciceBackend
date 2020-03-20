using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repositories.Impl
{
    public class PersonneRepository : IPersonneRepository
    {
        private appContext context;

        public PersonneRepository(appContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            Personne personne = context.Personne.Find(id);
            context.Personne.Remove(personne);
            Save();
        }

        public IEnumerable<Personne> FindAll()
        {
            return context.Personne;
        }

        public IEnumerable<Personne> FindByAge(int age)
        {
            return context.Personne.Where(p => p.Age == age);
        }

        public IEnumerable<Personne> FindByAge(int min, int max)
        {
            return context.Personne.Where(p => p.Age >= min && p.Age <= max);
        }

        public Personne FindById(int id)
        {
            return context.Personne.Find(id);
        }

        public IEnumerable<Personne> FindByNom(string nom)
        {
            return context.Personne.Where(p => p.Nom == nom);
        }

        public IEnumerable<Personne> FindByPrenom(string prenom)
        {
            return context.Personne.Where(p => p.Prenom == prenom);
        }

        public Personne Save(Personne personne)
        {
            context.Personne.Add(personne);
            Save();
            return personne;
        }

        public Personne Update(Personne personne)
        {
            context.Entry(personne).State = EntityState.Modified;
            Save();
            return personne;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
