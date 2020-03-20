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
        public IActionResult FindAll()
        {
            return Ok(this.service.TrouverTout());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult FindById(int id)
        {
            return Ok(this.service.TrouverParId(id));
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IActionResult FindByNom(string nom)
        {
            return Ok(this.service.TrouverParNom(nom));
        }

        [HttpGet]
        [Route("prenom/{prenom}")]
        public IActionResult FindByPrenom(string prenom)
        {
            return Ok(this.service.TrouverParPrenom(prenom));
        }

        [HttpGet]
        [Route("age/{age}")]
        public IActionResult FindByAge(int age)
        {
            return Ok(this.service.TrouverParAge(age));
        }

        [HttpGet]
        [Route("age")]
        public IActionResult FindByAge(int min, int max)
        {
            return Ok(this.service.TrouverParAge(min, max));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            this.service.SupprimerPersonne(id);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody] PersonneDTO personne)
        {
            return Ok(this.service.ModifierPersonne(personne));
        }

        [HttpPost]
        [Route("")]
        public IActionResult Save([FromBody] PersonneDTO personne)
        {
            return Ok(this.service.AjouterUnePersonne(personne));
        }
    }
}