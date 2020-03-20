using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repositories.Impl
{
    public class VoitureRepository : IVoitureRepository
    {
        private appContext context;

        public VoitureRepository(appContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            Voiture voiture = context.Voiture.Find(id);
            context.Voiture.Remove(voiture);
        }

        public IEnumerable<Voiture> FindAll()
        {
            return context.Voiture;
        }

        public Voiture FindById(int id)
        {
            return context.Voiture.Find(id);
        }

        public IEnumerable<Voiture> FindByImmatriculation(string immatriculation)
        {
            return context.Voiture.Where(v => v.Immatriculation == immatriculation);
        }

        public IEnumerable<Voiture> FindByMarque(string marque)
        {
            return context.Voiture.Where(v => v.Marque == marque);
        }

        public IEnumerable<Voiture> FindByNom(string nom)
        {
            return context.Voiture.Where(v => v.Nom == nom);
        }

        public IEnumerable<Voiture> FindByProprietaireId(int id)
        {
            return context.Voiture.Where(v => v.PersonneId == id);
        }

        public Voiture Save(Voiture voiture)
        {
            context.Voiture.Add(voiture);
            return voiture;
        }

        public Voiture Update(int id, Voiture voiture)
        {
            voiture.Id = id;
            context.Entry(voiture).State = EntityState.Modified;
            return voiture;
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
