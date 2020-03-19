using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/personne")]
    [ApiController]
    public class PersonneController : ControllerBase
    {
        public static List<PersonneDTO> personnes = new List<PersonneDTO>();

        [HttpGet]
        [Route("")]
        public IEnumerable<PersonneDTO> FindAll()
        {
            List<PersonneDTO> result = new List<PersonneDTO>();
            foreach(var personne in personnes)
            {
                if(personne != null)
                {
                    result.Add(personne);
                }
            }
            return result;
        }

        [HttpGet]
        [Route("{id}")]
        public PersonneDTO FindById(int id)
        {
            return personnes[id];
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<PersonneDTO> FindByNom(string nom)
        {
            return personnes.Where(p => p.Nom == nom);
        }

        [HttpGet]
        [Route("prenom/{prenom}")]
        public IEnumerable<PersonneDTO> FindByPrenom(string prenom)
        {
            return personnes.Where(p => p.Prenom == prenom);
        }

        [HttpGet]
        [Route("age/{age}")]
        public IEnumerable<PersonneDTO> FindByAge(int age)
        {
            return personnes.Where(p => p.Age == age);
        }

        [HttpGet]
        [Route("age")]
        public IEnumerable<PersonneDTO> FindByAge(int min, int max)
        {
            return personnes.Where(p => (p.Age >= min && p.Age <= max) );
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            personnes[id] = null;
        }

        [HttpPut]
        [Route("{id}")]
        public PersonneDTO Update(int id, [FromBody] PersonneDTO personne)
        {
            personne.Id = id;
            personnes[id] = personne;
            return personne;
        }
    }
}