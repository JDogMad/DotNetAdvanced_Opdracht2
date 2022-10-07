namespace Oefening1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            //Maak een console applicatie Huisdieren.  Schrijf de klasse Dier en de drie subklassen. 
            //Maak objecten koe, slang en varken uit de drie klassen en gebruik hun properties en methoden.  Laat de informatie zien in de console.
            Koe bertha = new Koe(640);
            Slang sacha = new Slang(59);
            Varken liva = new Varken(250);

            txtDier.Text = bertha.ToString();
            txtDier2.Text = sacha.ToString();
            txtDier3.Text = liva.ToString();
        }

        private void txtDier_TextChanged(object sender, EventArgs e)
        {

        }
    }
}