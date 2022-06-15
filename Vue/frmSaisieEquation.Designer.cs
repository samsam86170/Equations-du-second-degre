
namespace Equations_du_second_degré
{
    partial class frmSaisieEquation
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblConsigne = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblResolution = new System.Windows.Forms.Label();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.btnResoudre = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(104, 39);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(269, 24);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Equations du second degré";
            // 
            // lblConsigne
            // 
            this.lblConsigne.AutoSize = true;
            this.lblConsigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsigne.ForeColor = System.Drawing.Color.White;
            this.lblConsigne.Location = new System.Drawing.Point(31, 92);
            this.lblConsigne.Name = "lblConsigne";
            this.lblConsigne.Size = new System.Drawing.Size(247, 20);
            this.lblConsigne.TabIndex = 3;
            this.lblConsigne.Text = "Equation de la forme : ax² + bx + c";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(104, 131);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(81, 20);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "Saisir \"a\" :";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.White;
            this.lblB.Location = new System.Drawing.Point(104, 169);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(81, 20);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "Saisir \"b\" :";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(104, 207);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(80, 20);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "Saisir \"c\" :";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(191, 131);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(42, 20);
            this.txtA.TabIndex = 8;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(191, 169);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(42, 20);
            this.txtB.TabIndex = 9;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(190, 207);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(42, 20);
            this.txtC.TabIndex = 10;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(299, 249);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(111, 30);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolution.ForeColor = System.Drawing.Color.White;
            this.lblResolution.Location = new System.Drawing.Point(31, 296);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(416, 20);
            this.lblResolution.TabIndex = 12;
            this.lblResolution.Text = "Cliquer sur \"Résoudre\" pour résoudre l\'équation suivante :";
            // 
            // txtEquation
            // 
            this.txtEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquation.Location = new System.Drawing.Point(147, 327);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(160, 20);
            this.txtEquation.TabIndex = 13;
            // 
            // btnResoudre
            // 
            this.btnResoudre.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnResoudre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResoudre.ForeColor = System.Drawing.Color.White;
            this.btnResoudre.Location = new System.Drawing.Point(299, 385);
            this.btnResoudre.Name = "btnResoudre";
            this.btnResoudre.Size = new System.Drawing.Size(111, 30);
            this.btnResoudre.TabIndex = 14;
            this.btnResoudre.Text = "Résoudre";
            this.btnResoudre.UseVisualStyleBackColor = false;
            this.btnResoudre.Click += new System.EventHandler(this.btnResoudre_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiser.ForeColor = System.Drawing.Color.White;
            this.btnReinitialiser.Location = new System.Drawing.Point(35, 384);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(111, 30);
            this.btnReinitialiser.TabIndex = 15;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // frmSaisieEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(464, 444);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnResoudre);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblConsigne);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmSaisieEquation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equations du second degré";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblConsigne;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Button btnResoudre;
        private System.Windows.Forms.Button btnReinitialiser;
    }
}

