
namespace Gestion_Client
{
    partial class list1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.data = new System.Windows.Forms.DataGridView();
            this.Ajt = new System.Windows.Forms.Button();
            this.identif = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.enrg = new System.Windows.Forms.Button();
            this.sup = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.ressup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(-5, 2);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(813, 307);
            this.data.TabIndex = 4;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // Ajt
            // 
            this.Ajt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ajt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ajt.Location = new System.Drawing.Point(12, 350);
            this.Ajt.Name = "Ajt";
            this.Ajt.Size = new System.Drawing.Size(147, 29);
            this.Ajt.TabIndex = 5;
            this.Ajt.Text = "Ajouter";
            this.Ajt.UseVisualStyleBackColor = false;
            this.Ajt.Click += new System.EventHandler(this.Ajt_Click);
            // 
            // identif
            // 
            this.identif.Location = new System.Drawing.Point(25, 426);
            this.identif.Name = "identif";
            this.identif.Size = new System.Drawing.Size(318, 20);
            this.identif.TabIndex = 7;
            this.identif.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(25, 470);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(177, 20);
            this.Nom.TabIndex = 8;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(224, 533);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(177, 20);
            this.ville.TabIndex = 9;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(224, 469);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(177, 20);
            this.prenom.TabIndex = 10;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(25, 533);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(177, 20);
            this.adresse.TabIndex = 11;
            // 
            // enrg
            // 
            this.enrg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enrg.Location = new System.Drawing.Point(619, 350);
            this.enrg.Name = "enrg";
            this.enrg.Size = new System.Drawing.Size(147, 29);
            this.enrg.TabIndex = 12;
            this.enrg.Text = "Enregistrer";
            this.enrg.UseVisualStyleBackColor = false;
            this.enrg.Click += new System.EventHandler(this.enrg_Click);
            // 
            // sup
            // 
            this.sup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sup.Location = new System.Drawing.Point(437, 350);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(147, 29);
            this.sup.TabIndex = 13;
            this.sup.Text = "supprimer";
            this.sup.UseVisualStyleBackColor = false;
            this.sup.Click += new System.EventHandler(this.button1_Click);
            // 
            // upd
            // 
            this.upd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.upd.Location = new System.Drawing.Point(196, 350);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(147, 29);
            this.upd.TabIndex = 14;
            this.upd.Text = "Modifier";
            this.upd.UseVisualStyleBackColor = false;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // ressup
            // 
            this.ressup.Location = new System.Drawing.Point(437, 409);
            this.ressup.Name = "ressup";
            this.ressup.Size = new System.Drawing.Size(318, 20);
            this.ressup.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(231, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(227, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(440, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Identifiant";
            // 
            // list1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ressup);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.sup);
            this.Controls.Add(this.enrg);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.identif);
            this.Controls.Add(this.Ajt);
            this.Controls.Add(this.data);
            this.Name = "list1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.list1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button Ajt;
        private System.Windows.Forms.TextBox identif;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Button enrg;
        private System.Windows.Forms.Button sup;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.TextBox ressup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

