using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Oefening2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2 {
    abstract class Dier {
        public int gewicht;
        protected string uitspraak;
        protected System.IO.Stream geluid;

        public Dier() {
            gewicht = 0;
            uitspraak = "";
            geluid = this.geluid;
        }

        public virtual string Zegt() {
            return "Geluid: " + this.uitspraak;
        }

        public String Geluid() {
            System.Media.SoundPlayer player = new SoundPlayer(this.geluid);
            player.Play();
            return uitspraak;
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
            geluid = Properties.Resources.cow_moo2;
        }

        public override string Zegt() {
            return uitspraak;
        }
    }

    class Slang : Dier {
        public Slang(int gewicht) {
            this.gewicht = gewicht;
            uitspraak = "ssj";
            geluid = Properties.Resources.Snake_Strike_01;
        }

        public override string Zegt() {
            return uitspraak;
        }
    }

    class Varken : Dier {
        public Varken(int gewicht) {
            this.gewicht = gewicht;
            uitspraak = "groink";
            geluid = Properties.Resources.PIG;
        }

        public override string Zegt() {
            return uitspraak;
        }
    }
}
