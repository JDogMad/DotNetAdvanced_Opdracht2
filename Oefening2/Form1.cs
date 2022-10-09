using System.Drawing;
using System;
using System.Media;

namespace Oefening2 {
    public partial class Form1 : Form {
        //Maak vervolgens een Windows Form applicaties, voorzie 3 "checkbox"-en(of evenwaardig) die overeenkomen met telkens een object van de drie subklassen.
        //Voorzie een Button "Laat horen" die in een MessageBox de telkens Uitspraak toont, maar ook Geluid afspeelt van de aangevinkte objecten.
        //Als geen enkel object werd aangevinkt, verschijnt er geen MessageBox en wordt er geen geluid afgespeeld.
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            Koe bertha = new Koe(640);
            Slang sacha = new Slang(59);
            Varken liva = new Varken(250);

            if (ckUitspraakKoe.Checked) {
                txtKoe.Text = bertha.Zegt();
            } else if (ckUitspraakSlang.Checked) {
                txtSlang.Text = sacha.Zegt();
            } else if (ckUitspraakVarken.Checked) {
                txtVarken.Text = liva.Zegt();
            } else if (!ckUitspraakKoe.Checked) {
                txtKoe.Text = " ";
            } else if (!ckUitspraakSlang.Checked) {
                txtSlang.Text = " ";
            } else if (!ckUitspraakVarken.Checked) {
                txtVarken.Text = " ";
            }


            if (ckGeluidKoe.Checked) {
                bertha.Geluid();
            } else if (ckGeluidSlang.Checked) {
                sacha.Geluid();
            } else if (ckGeluidVarken.Checked) {
                liva.Geluid();
            }
        }
    }

     
}