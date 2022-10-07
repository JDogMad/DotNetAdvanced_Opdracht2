using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2 {
    abstract class Dier {
        public int gewicht;
        protected string uitspraak;
        protected string geluid;

        public Dier() {
            gewicht = 0;
            uitspraak = "";
            geluid = "";
        }

        public virtual string Zegt() {
            return "Geluid: " + this.uitspraak;
        }

        public override string ToString() {
            return "Uw " + this.GetType().Name + " weegt " + gewicht + "kg. Deze dier doet " + uitspraak
                + " qua geluid, je kan dit ook beluisteren " + geluid;
        }
    }

    class Koe : Dier {
        public Koe(int gewicht) {
            this.gewicht = gewicht;
            uitspraak = "moe";
            geluid = @"C:\Users\thele\Downloads\cow - moo2.wav";
        }

        public override string Zegt() {
            return uitspraak;
        }
    }

    class Slang : Dier {
        public Slang(int gewicht) {
            this.gewicht = gewicht;
            uitspraak = "ssj";
            geluid = @"C:\Users\thele\Downloads\Snake Strike 01.wav";
        }

        public override string Zegt() {
            return uitspraak;
        }
    }

    class Varken : Dier {
        public Varken(int gewicht) {
            this.gewicht = gewicht;
            uitspraak = "groink";
            geluid = @"C:\Users\thele\Downloads\PIG.wav";
        }

        public override string Zegt() {
            return uitspraak;
        }
    }
}
