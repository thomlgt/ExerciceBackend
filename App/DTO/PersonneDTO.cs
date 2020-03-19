﻿using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.DTO
{
    public class PersonneDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public PersonneDTO() { }

        public PersonneDTO(int id, string nom, string prenom, int age)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public static implicit operator Personne(PersonneDTO p)
        {
            return new Personne(
                p.Id,
                p.Nom,
                p.Prenom,
                p.Age
                );
        }
    }
}
