
namespace P50
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtk = new System.Windows.Forms.TextBox();
            this.btcalcola = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "K";
            // 
            // txtk
            // 
            this.txtk.Location = new System.Drawing.Point(72, 10);
            this.txtk.Name = "txtk";
            this.txtk.Size = new System.Drawing.Size(100, 20);
            this.txtk.TabIndex = 1;
            // 
            // btcalcola
            // 
            this.btcalcola.Location = new System.Drawing.Point(178, 8);
            this.btcalcola.Name = "btcalcola";
            this.btcalcola.Size = new System.Drawing.Size(75, 23);
            this.btcalcola.TabIndex = 2;
            this.btcalcola.Text = "Calcola";
            this.btcalcola.UseVisualStyleBackColor = true;
            this.btcalcola.Click += new System.EventHandler(this.btcalcola_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(72, 36);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(100, 20);
            this.txtOut.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btcalcola);
            this.Controls.Add(this.txtk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtk;
        private System.Windows.Forms.Button btcalcola;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label2;
    }
}

