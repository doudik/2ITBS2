using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Auto
    {
        protected string model;
        protected int rychlost;
        protected float spotreba, cenaZaLitr, celkovaCena, celkovaDoba;
        protected string vypocet;
        
        public Auto(string model, int rychlost, float spotreba) { 
            this.model = model;
            this.rychlost = rychlost;
            this.spotreba = spotreba;
            cenaZaLitr = 47.3f;
        }
        public string VypocetCesty(float vzdalenost) {
            celkovaCena = cenaZaLitr * ((vzdalenost / 100) * spotreba); 
            celkovaDoba = vzdalenost / rychlost; //v hodinách
            celkovaDoba = celkovaDoba * 60; //v minutách


            vypocet = "Tvoje útrata:" + celkovaCena + "Kč | Trasa: " + vzdalenost + "km si ujel za: " + celkovaDoba + "m | Spotřeba paliva: " + spotreba * (vzdalenost / 100) + "L";
            return vypocet;
        }
    }
}
