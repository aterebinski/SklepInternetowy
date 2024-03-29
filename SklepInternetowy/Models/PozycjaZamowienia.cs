﻿using System.Web.UI.WebControls;

namespace SklepInternetowy.Models
{
    public class PozycjaZamowienia
    {
        public int PozycjaZamowieniaId { get; set; }
        public int ZamowienieId { get; set; }
        public int KursId { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaZakupu { get; set; }
        public virtual Kurs Kurs { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}