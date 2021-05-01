namespace IHM
{
    partial class IHM
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelTaille = new System.Windows.Forms.Label();
            this.labelPoids = new System.Windows.Forms.Label();
            this.labelSexe = new System.Windows.Forms.Label();
            this.labelIMC = new System.Windows.Forms.Label();
            this.labelValeur = new System.Windows.Forms.Label();
            this.labelCatégorie = new System.Windows.Forms.Label();
            this.labelIdéal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTaille = new System.Windows.Forms.TextBox();
            this.textBoxPoids = new System.Windows.Forms.TextBox();
            this.textBoxValeur = new System.Windows.Forms.TextBox();
            this.textBoxCatégorie = new System.Windows.Forms.TextBox();
            this.textBoxIdeal = new System.Windows.Forms.TextBox();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonFemme = new System.Windows.Forms.Button();
            this.buttonHomme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelTitre.Location = new System.Drawing.Point(29, 9);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(281, 18);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Calcul de vos IMC et poids idéal";
            // 
            // labelTaille
            // 
            this.labelTaille.AutoSize = true;
            this.labelTaille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaille.ForeColor = System.Drawing.Color.Teal;
            this.labelTaille.Location = new System.Drawing.Point(19, 64);
            this.labelTaille.Name = "labelTaille";
            this.labelTaille.Size = new System.Drawing.Size(123, 20);
            this.labelTaille.TabIndex = 1;
            this.labelTaille.Text = "Votre Taille (cm)";
            // 
            // labelPoids
            // 
            this.labelPoids.AutoSize = true;
            this.labelPoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoids.ForeColor = System.Drawing.Color.Teal;
            this.labelPoids.Location = new System.Drawing.Point(19, 102);
            this.labelPoids.Name = "labelPoids";
            this.labelPoids.Size = new System.Drawing.Size(124, 20);
            this.labelPoids.TabIndex = 2;
            this.labelPoids.Text = "Votre Poids (Kg)";
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexe.ForeColor = System.Drawing.Color.Black;
            this.labelSexe.Location = new System.Drawing.Point(92, 149);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(145, 20);
            this.labelSexe.TabIndex = 3;
            this.labelSexe.Text = "Precisez votre sexe";
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.BackColor = System.Drawing.SystemColors.Control;
            this.labelIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMC.ForeColor = System.Drawing.Color.Gray;
            this.labelIMC.Location = new System.Drawing.Point(126, 216);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(66, 16);
            this.labelIMC.TabIndex = 4;
            this.labelIMC.Text = "Votre IMC";
            // 
            // labelValeur
            // 
            this.labelValeur.AutoSize = true;
            this.labelValeur.BackColor = System.Drawing.SystemColors.Control;
            this.labelValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValeur.ForeColor = System.Drawing.Color.Black;
            this.labelValeur.Location = new System.Drawing.Point(48, 262);
            this.labelValeur.Name = "labelValeur";
            this.labelValeur.Size = new System.Drawing.Size(47, 16);
            this.labelValeur.TabIndex = 5;
            this.labelValeur.Text = "Valeur";
            // 
            // labelCatégorie
            // 
            this.labelCatégorie.AutoSize = true;
            this.labelCatégorie.BackColor = System.Drawing.SystemColors.Control;
            this.labelCatégorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatégorie.ForeColor = System.Drawing.Color.Black;
            this.labelCatégorie.Location = new System.Drawing.Point(213, 262);
            this.labelCatégorie.Name = "labelCatégorie";
            this.labelCatégorie.Size = new System.Drawing.Size(67, 16);
            this.labelCatégorie.TabIndex = 6;
            this.labelCatégorie.Text = "Catégorie";
            // 
            // labelIdéal
            // 
            this.labelIdéal.AutoSize = true;
            this.labelIdéal.BackColor = System.Drawing.SystemColors.Control;
            this.labelIdéal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdéal.ForeColor = System.Drawing.Color.Gray;
            this.labelIdéal.Location = new System.Drawing.Point(126, 344);
            this.labelIdéal.Name = "labelIdéal";
            this.labelIdéal.Size = new System.Drawing.Size(76, 16);
            this.labelIdéal.TabIndex = 7;
            this.labelIdéal.Text = "Poids Idéal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(213, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kg";
            // 
            // textBoxTaille
            // 
            this.textBoxTaille.Location = new System.Drawing.Point(168, 64);
            this.textBoxTaille.Name = "textBoxTaille";
            this.textBoxTaille.Size = new System.Drawing.Size(34, 20);
            this.textBoxTaille.TabIndex = 9;
            // 
            // textBoxPoids
            // 
            this.textBoxPoids.Location = new System.Drawing.Point(168, 102);
            this.textBoxPoids.Name = "textBoxPoids";
            this.textBoxPoids.Size = new System.Drawing.Size(34, 20);
            this.textBoxPoids.TabIndex = 10;
            // 
            // textBoxValeur
            // 
            this.textBoxValeur.Location = new System.Drawing.Point(32, 281);
            this.textBoxValeur.Name = "textBoxValeur";
            this.textBoxValeur.Size = new System.Drawing.Size(83, 20);
            this.textBoxValeur.TabIndex = 11;
            // 
            // textBoxCatégorie
            // 
            this.textBoxCatégorie.Location = new System.Drawing.Point(184, 281);
            this.textBoxCatégorie.Name = "textBoxCatégorie";
            this.textBoxCatégorie.Size = new System.Drawing.Size(124, 20);
            this.textBoxCatégorie.TabIndex = 12;
            this.textBoxCatégorie.Text = " ";
            // 
            // textBoxIdeal
            // 
            this.textBoxIdeal.Location = new System.Drawing.Point(124, 376);
            this.textBoxIdeal.Name = "textBoxIdeal";
            this.textBoxIdeal.Size = new System.Drawing.Size(83, 20);
            this.textBoxIdeal.TabIndex = 13;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(263, 472);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 14;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(182, 472);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 15;
            this.buttonNew.Text = "Nouveau";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonFemme
            // 
            this.buttonFemme.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonFemme.Location = new System.Drawing.Point(32, 184);
            this.buttonFemme.Name = "buttonFemme";
            this.buttonFemme.Size = new System.Drawing.Size(120, 23);
            this.buttonFemme.TabIndex = 16;
            this.buttonFemme.Text = "Femme";
            this.buttonFemme.UseVisualStyleBackColor = false;
            this.buttonFemme.Click += new System.EventHandler(this.buttonFemme_Click);
            // 
            // buttonHomme
            // 
            this.buttonHomme.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonHomme.Location = new System.Drawing.Point(190, 184);
            this.buttonHomme.Name = "buttonHomme";
            this.buttonHomme.Size = new System.Drawing.Size(120, 23);
            this.buttonHomme.TabIndex = 17;
            this.buttonHomme.Text = "Homme";
            this.buttonHomme.UseVisualStyleBackColor = false;
            this.buttonHomme.Click += new System.EventHandler(this.buttonHomme_Click);
            // 
            // IHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 507);
            this.Controls.Add(this.buttonHomme);
            this.Controls.Add(this.buttonFemme);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.textBoxIdeal);
            this.Controls.Add(this.textBoxCatégorie);
            this.Controls.Add(this.textBoxValeur);
            this.Controls.Add(this.textBoxPoids);
            this.Controls.Add(this.textBoxTaille);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIdéal);
            this.Controls.Add(this.labelCatégorie);
            this.Controls.Add(this.labelValeur);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.labelSexe);
            this.Controls.Add(this.labelPoids);
            this.Controls.Add(this.labelTaille);
            this.Controls.Add(this.labelTitre);
            this.Name = "IHM";
            this.Text = "Imc et poids idéal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelTaille;
        private System.Windows.Forms.Label labelPoids;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.Label labelIMC;
        private System.Windows.Forms.Label labelValeur;
        private System.Windows.Forms.Label labelCatégorie;
        private System.Windows.Forms.Label labelIdéal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTaille;
        private System.Windows.Forms.TextBox textBoxPoids;
        private System.Windows.Forms.TextBox textBoxValeur;
        private System.Windows.Forms.TextBox textBoxCatégorie;
        private System.Windows.Forms.TextBox textBoxIdeal;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonFemme;
        private System.Windows.Forms.Button buttonHomme;
    }
}

