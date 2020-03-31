using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.DTO;
using App.Exceptions;
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
            try
            {
                return Ok(this.service.TrouverTout());
            }
            catch (RessourceException e)
            {
                if (e.Statut == 404)
                    return NotFound(e.Message);
                else
                {
                    return BadRequest(e.Message);
                }
            }

        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult FindById(int id)
        {
            try
            {
                return Ok(this.service.TrouverParId(id));
            }
            catch (RessourceException e)
            {
                if (e.Statut == 404)
                    return NotFound(e.Message);
                else
                {
                    return BadRequest(e.Message);
                }
            }

        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IActionResult FindByNom(string nom)
        {
            try
            {
                return Ok(this.service.TrouverParNom(nom));
            }
            catch (RessourceException e)
            {
                if (e.Statut == 404)
                    return NotFound(e.Message);
                else
                {
                    return BadRequest(e.Message);
                }
            }

        }

        [HttpGet]
        [Route("marque/{marque}")]
        public IActionResult FindByMarque(string marque)
        {
            try
            {
                return Ok(this.service.TrouverParMarque(marque));
            }
            catch (RessourceException e)
            {
                if (e.Statut == 404)
                    return NotFound(e.Message);
                else
                {
                    return BadRequest(e.Message);
                }
            }

        }

        [HttpGet]
        [Route("immatriculation/{immatriculation}")]
        public IActionResult FindByImmatriculation(string immatriculation)
        {
            try
            {
                return Ok(this.service.TrouverParImmatriculation(immatriculation));
            }
            catch (RessourceException e)
            {
                if (e.Statut == 404)
                    return NotFound(e.Message);
                else
                {
                    return BadRequest(e.Message);
                }
            }

        }

        [HttpGet]
        [Route("proprietaire/{id}")]
        public IActionResult FindByProprietaireId(int id)
        {
            try
            {
                return Ok(this.service.TrouverParProprietaireId(id));
            }
            catch (RessourceException e)
            {
                if (e.Statut == 404)
                    return NotFound(e.Message);
                else
                {
                    return BadRequest(e.Message);
                }
            }

        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                this.service.SupprimerVoiture(id);
                return Ok();
            }
            catch (RessourceException e)
            {
                if (e.Statut == 404)
                    return NotFound(e.Message);
                else
                {
                    return BadRequest(e.Message);
                }
            }

        }

        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody] VoitureDTO voiture)
        {
            try
            {
                this.service.ModifierVoiture(voiture);
                return Ok();
            }
            catch (RessourceException e)
            {
                if (e.Statut == 404)
                    return NotFound(e.Message);
                else
                {
                    return BadRequest(e.Message);
                }
            }

        }

        [HttpPost]
        [Route("")]
        public IActionResult Save([FromBody] VoitureDTO voiture)
        {
            try
            {
                this.service.AjouterUneVoiture(voiture);
                return Ok();
            }
            catch (RessourceException e)
            {
                if (e.Statut == 404)
                    return NotFound(e.Message);
                else
                {
                    return BadRequest(e.Message);
                }
            }

        }
    }
}