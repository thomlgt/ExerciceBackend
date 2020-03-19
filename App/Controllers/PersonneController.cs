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
        public static List<Personne> personnes = new List<Personne>();

        [HttpGet]
        [Route("")]
        public IEnumerable<Personne> FindAll()
        {
            List<Personne> result = new List<Personne>();
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
        public Personne FindById(int id)
        {
            return personnes[id];
        }
    }
}