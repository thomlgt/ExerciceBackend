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
    [Route("api/voiture")]
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
        public IEnumerable<VoitureDTO> FindAll()
        {
            return service.TrouverTout();
        }

        [HttpGet]
        [Route("{id}")]
        public VoitureDTO FindById(int id)
        {
            return service.TrouverParId(id);
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<VoitureDTO> FindByNom(string nom)
        {
            return service.TrouverParNom(nom);
        }

        [HttpGet]
        [Route("marque/{marque}")]
        public IEnumerable<VoitureDTO> FindByMarque(string marque)
        {
            return service.TrouverParMarque(marque);
        }

        [HttpGet]
        [Route("immatriculation/{immatriculation}")]
        public IEnumerable<VoitureDTO> FindByImmatriculation(string immatriculation)
        {
            return service.TrouverParImmatriculation(immatriculation);
        }

        [HttpGet]
        [Route("proprietaire/{id}")]
        public IEnumerable<VoitureDTO> FindByProprietaireId(int id)
        {
            return service.TrouverParProprietaireId(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            service.SupprimerVoiture(id);
        }

        [HttpPut]
        [Route("{id}")]
        public VoitureDTO Update(int id, [FromBody] VoitureDTO voiture)
        {
            return service.ModifierVoiture(id, voiture);
        }

        [HttpPost]
        [Route("")]
        public VoitureDTO Save([FromBody] VoitureDTO voiture)
        {
            return service.AjouterUneVoiture(voiture);
        }
    }
}