﻿using System.ComponentModel.DataAnnotations;

namespace SuperHerosDatas.Api.Models
{
    public class Superhero
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please specify a name for the superhero")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Height { get; set; }

        [UseSorting]
        public ICollection<Superpower> Superpowers { get; set; }

        [UseSorting]
        public ICollection<Movie> Movies { get; set; }
    }
}
