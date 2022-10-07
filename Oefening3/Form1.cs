using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oefening3 {
    public partial class CurrencyConvertor : Form {
        public CurrencyConvertor() {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnConvert_Click(object sender, EventArgs e) {
            // 1 BP in USD is 1.3570 for 3/10/2022 (exchangerates.org.uk)
            // 1 EU in USD is 1.1608 for 3/10/2022 (exchangerates.org.uk)
            // 1 IR in USD is 0.013488 for 3/10/2022 (exchangerates.org.uk)
            // 1 JY in USD is 0.0090098 for 3/10/2022 (exchangerates.org.uk)
            // 1 ZF in USD is 1.0755 for 3/10/2022 (exchangerates.org.uk)
            // 1 USD in BP is 0.7369 for 3/10/2022 (exchangerates.org.uk)
            // 1 USD in EU is 0.86147 for 3/10/2022 (exchangerates.org.uk)
            // 1 USD in IR is 74.140 for 3/10/2022 (exchangerates.org.uk)
            // 1 USD in JY is 110.99 for 3/10/2022 (exchangerates.org.uk)
            // 1 USD in ZF is 0.9298 for 3/10/2022 (exchangerates.org.uk)
            
            if (!String.IsNullOrEmpty(txtBP.Text) || 
                !String.IsNullOrEmpty(txtEU.Text) || 
                !String.IsNullOrEmpty(txtIR.Text) || 
                !String.IsNullOrEmpty(txtJY.Text) || 
                !String.IsNullOrEmpty(txtUSD.Text) ||
                !String.IsNullOrEmpty(txtZF.Text)) {
                if(!String.IsNullOrEmpty(txtBP.Text)) {
                    double waardeBP = Double.Parse(txtBP.Text) * 1.3103;
                    txtUSD.Text = waardeBP.ToString();
                    txtEU.Text = (Double.Parse(txtUSD.Text) * 0.86147).ToString();
                    txtIR.Text = (Double.Parse(txtUSD.Text) * 74.140).ToString();
                    txtJY.Text = (Double.Parse(txtUSD.Text) * 110.99).ToString();
                    txtZF.Text = (Double.Parse(txtUSD.Text) * 0.9298).ToString();
                } else if (!String.IsNullOrEmpty(txtEU.Text)) {
                    double waardeEU = Double.Parse(txtEU.Text) * 1.1608;
                    txtUSD.Text = waardeEU.ToString();
                    txtBP.Text = (Double.Parse(txtUSD.Text) * 0.7369).ToString();
                    txtIR.Text = (Double.Parse(txtUSD.Text) * 74.140).ToString();
                    txtJY.Text = (Double.Parse(txtUSD.Text) * 110.99).ToString();
                    txtZF.Text = (Double.Parse(txtUSD.Text) * 0.9298).ToString();
                } else if (!String.IsNullOrEmpty(txtIR.Text)) {
                    double waardeIR = Double.Parse(txtIR.Text) * 0.013488;
                    txtUSD.Text = waardeIR.ToString();
                    txtBP.Text = (Double.Parse(txtUSD.Text) * 0.7369).ToString();
                    txtEU.Text = (Double.Parse(txtUSD.Text) * 0.86147).ToString();
                    txtJY.Text = (Double.Parse(txtUSD.Text) * 110.99).ToString();
                    txtZF.Text = (Double.Parse(txtUSD.Text) * 0.9298).ToString();
                } else if (!String.IsNullOrEmpty(txtJY.Text)) {
                    double waardeJY = Double.Parse(txtJY.Text) * 0.0090098;
                    txtUSD.Text = waardeJY.ToString();
                    txtBP.Text = (Double.Parse(txtUSD.Text) * 0.7369).ToString();
                    txtEU.Text = (Double.Parse(txtUSD.Text) * 0.86147).ToString();
                    txtIR.Text = (Double.Parse(txtUSD.Text) * 74.140).ToString();
                    txtZF.Text = (Double.Parse(txtUSD.Text) * 0.9298).ToString();
                } else if (!String.IsNullOrEmpty(txtZF.Text)) {
                    double waardeZF = Double.Parse(txtZF.Text) * 1.0755;
                    txtUSD.Text = waardeZF.ToString();
                    txtBP.Text = (Double.Parse(txtUSD.Text) * 0.7369).ToString();
                    txtEU.Text = (Double.Parse(txtUSD.Text) * 0.86147).ToString();
                    txtIR.Text = (Double.Parse(txtUSD.Text) * 74.140).ToString();
                    txtJY.Text = (Double.Parse(txtUSD.Text) * 110.99).ToString();
                } else if (!String.IsNullOrEmpty(txtUSD.Text)) {
                    txtBP.Text = (Double.Parse(txtUSD.Text) * 0.7369).ToString();
                    txtEU.Text = (Double.Parse(txtUSD.Text) * 0.86147).ToString();
                    txtIR.Text = (Double.Parse(txtUSD.Text) * 74.140).ToString();
                    txtJY.Text = (Double.Parse(txtUSD.Text) * 110.99).ToString();
                    txtZF.Text = (Double.Parse(txtUSD.Text) * 0.9298).ToString();
                }
            }
        }
    }
}