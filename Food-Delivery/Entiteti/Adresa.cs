﻿namespace Food_Delivery.Entiteti
{
    public class Adresa
    {
        public int Id { get; set; }
        public string Naziv {  get; set; }
        public string Ulica { get; set; }
        public string Grad {  get; set; }

        public ICollection<AdresaMusterije> AdreseMusterija { get; set; }
        //public ICollection<Narudzbina> Narudzbine {  get; set; }
    }
}