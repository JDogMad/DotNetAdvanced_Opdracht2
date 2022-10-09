using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningC1 {
    //Een abstracte klasse Dier heeft
    abstract class Dier {
        //een publieke eigenschap (property) Gewicht
        //De Gewicht-eigenschap (int) stelt het gewicht van het dier voor.
        public int gewicht;
        //een verborgen, maar over te erven eigenschap string Uitspraak
        //Uitspraak bevat de geschreven fonetische klank van een beest
        protected string uitspraak;
        //een verborgen, maar over te erven eigenschap string Geluid
        //Geluid bevat een link naar een WAV / MP3 / ... file die het eigenlijke geluid bevat
        protected string geluid;

        //een constructor
        public Dier() {
            gewicht = 0;
            uitspraak = "";
            geluid = "";
        }

        //een methode Zegt.
        //Retourneert Uitspraak
        //De methode Zegt retourneert een string die het geluid weergeeft dat het dier maakt.
        public virtual string Zegt() {
            return "Geluid: " + this.uitspraak;
        }

        public override string ToString() {
            return "Uw " + this.GetType().Name + " weegt " + gewicht + "kg. Deze dier doet " + uitspraak
                + " qua geluid, je kan dit ook beluisteren " + geluid;
        }
    }

    //De klasse dier heeft subklassen Koe, Slang en Varken.
    class Koe : Dier {
        //De constructor geeft respectievelijk de waarden "boe", "ssj" en "groink" aan Uitspraak, en zet een juiste referentie in Geluid.
        public Koe(int gewicht) {
            this.gewicht = gewicht;
            uitspraak = "moe";
            geluid = @"C:\Users\thele\Downloads\cow - moo2.wav";
        }

        public override string Zegt() {
            return "Een koe zegt " + uitspraak;
        }
    }

    class Slang : Dier {
        public Slang(int gewicht) {
            this.gewicht = gewicht;
            uitspraak = "ssj";
            geluid = @"C:\Users\thele\Downloads\Snake Strike 01.wav";
        }

        public override string Zegt() {
            return "Een slang zegt " + uitspraak;
        }
    }

    class Varken : Dier {
        public Varken(int gewicht) {
            this.gewicht = gewicht;
            uitspraak = "groink";
            geluid = @"C:\Users\thele\Downloads\PIG.wav";
        }

        public override string Zegt() {
            return "Een varken zegt " + uitspraak;
        }
    }
}
