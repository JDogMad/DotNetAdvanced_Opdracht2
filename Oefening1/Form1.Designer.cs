namespace Oefening1
{
    partial class Form1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtDier = new System.Windows.Forms.TextBox();
            this.txtDier2 = new System.Windows.Forms.TextBox();
            this.txtDier3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(308, 267);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(158, 29);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtDier
            // 
            this.txtDier.Location = new System.Drawing.Point(12, 72);
            this.txtDier.Name = "txtDier";
            this.txtDier.Size = new System.Drawing.Size(755, 27);
            this.txtDier.TabIndex = 1;
            this.txtDier.TextChanged += new System.EventHandler(this.txtDier_TextChanged);
            // 
            // txtDier2
            // 
            this.txtDier2.Location = new System.Drawing.Point(12, 137);
            this.txtDier2.Name = "txtDier2";
            this.txtDier2.Size = new System.Drawing.Size(755, 27);
            this.txtDier2.TabIndex = 2;
            // 
            // txtDier3
            // 
            this.txtDier3.Location = new System.Drawing.Point(12, 208);
            this.txtDier3.Name = "txtDier3";
            this.txtDier3.Size = new System.Drawing.Size(755, 27);
            this.txtDier3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDier3);
            this.Controls.Add(this.txtDier2);
            this.Controls.Add(this.txtDier);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerate;
        private TextBox txtDier;
        private TextBox txtDier2;
        private TextBox txtDier3;
    }
}