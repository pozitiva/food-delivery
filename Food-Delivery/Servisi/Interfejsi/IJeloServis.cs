﻿using DostavaHrane.Entiteti;

namespace DostavaHrane.Servisi.Interfejsi
{
    public interface IJeloServis
    {
        Task<IEnumerable<Jelo>> VratiSvaJelaAsync();
        Task DodajJeloAsync(Jelo jelo);

        Task IzmeniJeloAsync(Jelo jelo);
        Task ObrisiJeloAsync(Jelo jelo);
        Task<Jelo> VratiJeloPoIdAsync(int jeloId);
        Task<IEnumerable<Jelo>> VratiSvaJelaPoRestoranu(int restoranId);
        Task DodajJeloAsync(Jelo jelo, IFormFile? slika);
    }
}
