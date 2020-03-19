using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.DTO;
using App.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/personnes")]
    [ApiController]
    public class PersonneController : ControllerBase
    {
        private IPersonneService service;

        public PersonneController(IPersonneService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<PersonneDTO> FindAll()
        {
            return service.TrouverTout();
        }

        [HttpGet]
        [Route("{id}")]
        public PersonneDTO FindById(int id)
        {
            return service.TrouverParId(id);
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<PersonneDTO> FindByNom(string nom)
        {
            return service.TrouverParNom(nom);
        }

        [HttpGet]
        [Route("prenom/{prenom}")]
        public IEnumerable<PersonneDTO> FindByPrenom(string prenom)
        {
            return service.TrouverParPrenom(prenom);
        }

        [HttpGet]
        [Route("age/{age}")]
        public IEnumerable<PersonneDTO> FindByAge(int age)
        {
            return service.TrouverParAge(age);
        }

        [HttpGet]
        [Route("age")]
        public IEnumerable<PersonneDTO> FindByAge(int min, int max)
        {
            return service.TrouverParAge(min, max);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            service.SupprimerPersonne(id);
        }

        [HttpPut]
        [Route("{id}")]
        public PersonneDTO Update(int id, [FromBody] PersonneDTO personne)
        {
            return service.ModifierPersonne(id, personne);
        }

        [HttpPost]
        [Route("")]
        public PersonneDTO Save([FromBody] PersonneDTO personne)
        {
            return service.AjouterUnePersonne(personne);
        }
    }
}