
namespace Equations_du_second_degré.Vue
{
    partial class frmResolution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblResolve = new System.Windows.Forms.Label();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.lblDelta = new System.Windows.Forms.Label();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.lblRappel = new System.Windows.Forms.Label();
            this.lblDeltaPositif = new System.Windows.Forms.Label();
            this.lblDeltaEgal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSolutions = new System.Windows.Forms.TextBox();
            this.lblSolutions = new System.Windows.Forms.Label();
            this.txtSolution2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(299, 385);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(111, 30);
            this.btnRetour.TabIndex = 15;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(104, 39);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(269, 24);
            this.lblTitre.TabIndex = 16;
            this.lblTitre.Text = "Equations du second degré";
            // 
            // lblResolve
            // 
            this.lblResolve.AutoSize = true;
            this.lblResolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolve.ForeColor = System.Drawing.Color.White;
            this.lblResolve.Location = new System.Drawing.Point(31, 92);
            this.lblResolve.Name = "lblResolve";
            this.lblResolve.Size = new System.Drawing.Size(187, 20);
            this.lblResolve.TabIndex = 17;
            this.lblResolve.Text = "Résolution de l\'équation :";
            // 
            // txtEquation
            // 
            this.txtEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquation.Location = new System.Drawing.Point(226, 92);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(160, 20);
            this.txtEquation.TabIndex = 18;
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelta.ForeColor = System.Drawing.Color.White;
            this.lblDelta.Location = new System.Drawing.Point(104, 131);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(55, 20);
            this.lblDelta.TabIndex = 19;
            this.lblDelta.Text = "Delta :";
            // 
            // txtDelta
            // 
            this.txtDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelta.Location = new System.Drawing.Point(166, 131);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(42, 20);
            this.txtDelta.TabIndex = 20;
            // 
            // lblRappel
            // 
            this.lblRappel.AutoSize = true;
            this.lblRappel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRappel.ForeColor = System.Drawing.Color.White;
            this.lblRappel.Location = new System.Drawing.Point(31, 167);
            this.lblRappel.Name = "lblRappel";
            this.lblRappel.Size = new System.Drawing.Size(68, 20);
            this.lblRappel.TabIndex = 21;
            this.lblRappel.Text = "Rappel :";
            // 
            // lblDeltaPositif
            // 
            this.lblDeltaPositif.AutoSize = true;
            this.lblDeltaPositif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeltaPositif.ForeColor = System.Drawing.Color.White;
            this.lblDeltaPositif.Location = new System.Drawing.Point(105, 191);
            this.lblDeltaPositif.Name = "lblDeltaPositif";
            this.lblDeltaPositif.Size = new System.Drawing.Size(298, 16);
            this.lblDeltaPositif.TabIndex = 22;
            this.lblDeltaPositif.Text = "Si Delta est supérieur à 0, il y a 2 solutions (x1, x2)";
            // 
            // lblDeltaEgal
            // 
            this.lblDeltaEgal.AutoSize = true;
            this.lblDeltaEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeltaEgal.ForeColor = System.Drawing.Color.White;
            this.lblDeltaEgal.Location = new System.Drawing.Point(105, 220);
            this.lblDeltaEgal.Name = "lblDeltaEgal";
            this.lblDeltaEgal.Size = new System.Drawing.Size(250, 16);
            this.lblDeltaEgal.TabIndex = 23;
            this.lblDeltaEgal.Text = "Si Delta est égal à 0, il y a 1 solutions (x1)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Si Delta est inférieur à 0, il n\'y a pas de solutions";
            // 
            // txtSolutions
            // 
            this.txtSolutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolutions.Location = new System.Drawing.Point(166, 323);
            this.txtSolutions.Name = "txtSolutions";
            this.txtSolutions.Size = new System.Drawing.Size(160, 20);
            this.txtSolutions.TabIndex = 25;
            // 
            // lblSolutions
            // 
            this.lblSolutions.AutoSize = true;
            this.lblSolutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutions.ForeColor = System.Drawing.Color.White;
            this.lblSolutions.Location = new System.Drawing.Point(31, 286);
            this.lblSolutions.Name = "lblSolutions";
            this.lblSolutions.Size = new System.Drawing.Size(217, 20);
            this.lblSolutions.TabIndex = 26;
            this.lblSolutions.Text = "L\'équation a pour solution(s) :";
            // 
            // txtSolution2
            // 
            this.txtSolution2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolution2.Location = new System.Drawing.Point(166, 359);
            this.txtSolution2.Name = "txtSolution2";
            this.txtSolution2.Size = new System.Drawing.Size(160, 20);
            this.txtSolution2.TabIndex = 27;
            // 
            // frmResolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(464, 444);
            this.Controls.Add(this.txtSolution2);
            this.Controls.Add(this.lblSolutions);
            this.Controls.Add(this.txtSolutions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeltaEgal);
            this.Controls.Add(this.lblDeltaPositif);
            this.Controls.Add(this.lblRappel);
            this.Controls.Add(this.txtDelta);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.lblResolve);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnRetour);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmResolution";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equations du second degré";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblResolve;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.Label lblRappel;
        private System.Windows.Forms.Label lblDeltaPositif;
        private System.Windows.Forms.Label lblDeltaEgal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSolutions;
        private System.Windows.Forms.Label lblSolutions;
        private System.Windows.Forms.TextBox txtSolution2;
    }
}