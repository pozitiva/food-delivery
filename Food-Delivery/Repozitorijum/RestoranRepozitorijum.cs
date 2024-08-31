﻿using DostavaHrane.Data;
using DostavaHrane.Dto;
using DostavaHrane.Entiteti;
using DostavaHrane.Repozitorijum.Interfejsi;
using Microsoft.EntityFrameworkCore;

namespace DostavaHrane.Repozitorijum
{
    public class RestoranRepozitorijum : IRestoranRepozitorijum
    {
        private readonly DataContext _context;
        public RestoranRepozitorijum(DataContext context)
        {
            _context= context;
        }
        public async Task DodajAsync(Restoran restoran)
        {
            _context.Add(restoran);
            await _context.SaveChangesAsync();
        }

        public Task IzmeniAsync(Restoran restoran)
        {
            throw new NotImplementedException();
        }

        public Task ObrisiAsync(Restoran restoran)
        {
            throw new NotImplementedException();
        }

        public async Task<Restoran> VratiPoIdAsync(int id)
        {
            
            return await _context.Restorani
                         .Include(r => r.Jela)  
                         .Where(r => r.Id.Equals( id))
                         .FirstOrDefaultAsync();
        }

        public async Task<Restoran> VratiRestotranSaEmailom(KorisnikLoginDto restoran)
        {
            return await _context.Restorani
                         .Where(r => r.Email == restoran.Email)
                         .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Jelo>> VratiSvaJelaPoRestoranuAsync(int restoranId)
        {
            return await _context.Jela.Where(e=> e.Restoran.Id.Equals(restoranId)).ToListAsync();
        }

        public async Task<IEnumerable<Restoran>> VratiSveAsync()
        {
            return await _context.Restorani.Include(r => r.Jela).ToListAsync();
        }
    }
}
