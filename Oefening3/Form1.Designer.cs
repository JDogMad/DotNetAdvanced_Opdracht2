namespace Oefening3
{
    partial class CurrencyConvertor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtZF = new System.Windows.Forms.TextBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.txtEU = new System.Windows.Forms.TextBox();
            this.txtJY = new System.Windows.Forms.TextBox();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOtherValues = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtZF
            // 
            this.txtZF.Location = new System.Drawing.Point(213, 395);
            this.txtZF.Name = "txtZF";
            this.txtZF.Size = new System.Drawing.Size(125, 27);
            this.txtZF.TabIndex = 0;
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(213, 102);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(125, 27);
            this.txtBP.TabIndex = 1;
            // 
            // txtEU
            // 
            this.txtEU.Location = new System.Drawing.Point(213, 176);
            this.txtEU.Name = "txtEU";
            this.txtEU.Size = new System.Drawing.Size(125, 27);
            this.txtEU.TabIndex = 2;
            // 
            // txtJY
            // 
            this.txtJY.Location = new System.Drawing.Point(213, 247);
            this.txtJY.Name = "txtJY";
            this.txtJY.Size = new System.Drawing.Size(125, 27);
            this.txtJY.TabIndex = 3;
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(213, 38);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(125, 27);
            this.txtUSD.TabIndex = 4;
            // 
            // txtIR
            // 
            this.txtIR.Location = new System.Drawing.Point(213, 321);
            this.txtIR.Name = "txtIR";
            this.txtIR.Size = new System.Drawing.Size(125, 27);
            this.txtIR.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "U. S. Dollars";
            // 
            // labelOtherValues
            // 
            this.labelOtherValues.AutoSize = true;
            this.labelOtherValues.Location = new System.Drawing.Point(31, 109);
            this.labelOtherValues.Name = "labelOtherValues";
            this.labelOtherValues.Size = new System.Drawing.Size(101, 20);
            this.labelOtherValues.TabIndex = 7;
            this.labelOtherValues.Text = "British Pounds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Euro\'s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Japense Yen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Indiaanse Rupees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Zwitserse Franken";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(594, 208);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 29);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // CurrencyConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOtherValues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIR);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.txtJY);
            this.Controls.Add(this.txtEU);
            this.Controls.Add(this.txtBP);
            this.Controls.Add(this.txtZF);
            this.Name = "CurrencyConvertor";
            this.Text = "Currency Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtZF;
        private TextBox txtBP;
        private TextBox txtEU;
        private TextBox txtJY;
        private TextBox txtUSD;
        private TextBox txtIR;
        private Label label1;
        private Label labelOtherValues;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnConvert;
    }
}