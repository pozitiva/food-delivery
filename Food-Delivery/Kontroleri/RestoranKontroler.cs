﻿using AutoMapper;
using DostavaHrane.Dto;
using DostavaHrane.Entiteti;
using DostavaHrane.Servisi;
using DostavaHrane.Servisi.Interfejsi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Diagnostics.Metrics;

namespace DostavaHrane.Kontroleri
{
    [Route("api/restoran")]
    [ApiController]
    public class RestoranKontroler: ControllerBase
    {
        private readonly IRestoranServis _restoranServis;
        private readonly IMapper _mapper;

        public RestoranKontroler(IRestoranServis restoranServis, IMapper mapper)
        {
            _restoranServis = restoranServis;
            _mapper = mapper;
        }

     
        [HttpGet]
        public async Task<IActionResult> VratiSveRestorane()
        {
            var restorani = await _restoranServis.VratiSveRestoraneAsync();
            var restoraniDto = _mapper.Map<List<RestoranDto>>(restorani);

            return Ok(restoraniDto);
        }

        [HttpGet("{restoranId}")]
        public async Task<IActionResult> VratiRestoranPoId(int restoranId)
        {
            var restoran = await _restoranServis.VratiRestoranPoIdAsync(restoranId);
            var restoranDto = _mapper.Map<RestoranDto>(restoran);

            // TODO vratiti sva jela odmayh sa re4storanom
            //var jela = await _restoranServis.VratiSvaJelaPoRestoranuAsync(restoranId);
            //var jelaDto = _mapper.Map<List<JeloDto>>(jela);

            //restoranDto.Jela = jelaDto; 

            return Ok(restoranDto);
        }


        [HttpGet("{restoranId}/jela")]
        public async Task<IActionResult> VratiSvaJelaZaRestoran(int restoranId)
        {
            var jela = await _restoranServis.VratiSvaJelaPoRestoranuAsync(restoranId);
            var jelaDto = _mapper.Map<List<JeloDto>>(jela);

            return Ok(jelaDto);
        }

        //[HttpGet("{restoranId}/jela/{jeloId}")]
        //public async Task<IActionResult> VratiJeloZaRestoran(int restoranId, int jeloId)
        //{
        //    var restoran = await _restoranServis.VratiRestoranPoIdAsync(restoranId);
        //    if (restoran == null)
        //    {
        //        return NotFound("Restoran nije pronađen");
        //    }

        //    //var jelo = await _restoranServis.VratiJeloPoIdIZaRestoranAsync(restoranId, jeloId);
        //    if (jelo == null)
        //    {
        //        return NotFound("Jelo nije pronađeno u ovom restoranu");
        //    }

        //    var jeloDto = _mapper.Map<JeloDto>(jelo);
        //    return Ok(jeloDto);
        //}





    }
}
