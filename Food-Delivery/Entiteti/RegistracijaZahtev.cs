﻿using System.ComponentModel.DataAnnotations;

namespace DostavaHrane.Entiteti
{
    public class RegistracijaZahtev
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MinLength(6)]
        public string Sifra { get; set; } = string.Empty;

        [Required, Compare("Sifra", ErrorMessage = "Sifra i ponovljena sifra se ne poklapaju.")]
        public string PotvrdjenaSifra { get; set; } = string.Empty;


    }
}
