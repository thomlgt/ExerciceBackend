using App.DTO;
using App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services.Impl
{
    public class PersonneService : IPersonneService
    {
        private IPersonneRepository repository;

        public PersonneService(IPersonneRepository repository)
        {
            this.repository = repository;
        }

        public PersonneDTO AjouterUnePersonne(PersonneDTO personne)
        {
            return this.repository.Save(personne);
        }

        public PersonneDTO ModifierPersonne(int id, PersonneDTO personne)
        {
            return this.repository.Update(id, personne);
        }

        public void SupprimerPersonne(int id)
        {
            this.repository.Delete(id);
        }

        public IEnumerable<PersonneDTO> TrouverParAge(int age)
        {
            List<PersonneDTO> result = new List<PersonneDTO>();
            foreach (PersonneDTO personne in this.repository.FindByAge(age))
            {
                result.Add(personne);
            }
            return result;
        }

        public IEnumerable<PersonneDTO> TrouverParAge(int min, int max)
        {
            List<PersonneDTO> result = new List<PersonneDTO>();
            foreach (PersonneDTO personne in this.repository.FindByAge(min, max))
            {
                result.Add(personne);
            }
            return result;
        }

        public PersonneDTO TrouverParId(int id)
        {
            return this.repository.FindById(id);
        }

        public IEnumerable<PersonneDTO> TrouverParNom(string nom)
        {
            List<PersonneDTO> result = new List<PersonneDTO>();
            foreach (PersonneDTO personne in this.repository.FindByNom(nom))
            {
                result.Add(personne);
            }
            return result;
        }

        public IEnumerable<PersonneDTO> TrouverParPrenom(string prenom)
        {
            List<PersonneDTO> result = new List<PersonneDTO>();
            foreach(PersonneDTO personne in this.repository.FindByPrenom(prenom))
            {
                result.Add(personne);
            }
            return result;
        }

        public IEnumerable<PersonneDTO> TrouverTout()
        {
            List<PersonneDTO> result = new List<PersonneDTO>();
            foreach (PersonneDTO personne in this.repository.FindAll())
            {
                if (personne != null)
                {
                    result.Add(personne);
                }
            }
            return result;
        }
    }
}
