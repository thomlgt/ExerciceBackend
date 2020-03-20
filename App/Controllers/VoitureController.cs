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
    [Route("api/voitures")]
    [ApiController]
    public class VoitureController : ControllerBase
    {
        private IVoitureService service;

        public VoitureController(IVoitureService service)
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
        [Route("marque/{marque}")]
        public IActionResult FindByMarque(string marque)
        {
            return Ok(this.service.TrouverParMarque(marque));
        }

        [HttpGet]
        [Route("immatriculation/{immatriculation}")]
        public IActionResult FindByImmatriculation(string immatriculation)
        {
            return Ok(this.service.TrouverParImmatriculation(immatriculation));
        }

        [HttpGet]
        [Route("proprietaire/{id}")]
        public IActionResult FindByProprietaireId(int id)
        {
            return Ok(this.service.TrouverParProprietaireId(id));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            this.service.SupprimerVoiture(id);
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromBody] VoitureDTO voiture)
        {
            return Ok(this.service.ModifierVoiture(voiture));
        }

        [HttpPost]
        [Route("")]
        public IActionResult Save([FromBody] VoitureDTO voiture)
        {
            return Ok(this.service.AjouterUneVoiture(voiture));
        }
    }
}