
namespace test
{
    partial class btnlist
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
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sup = new System.Windows.Forms.Button();
            this.cherche = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.Auteur = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.nbrpage = new System.Windows.Forms.TextBox();
            this.categorie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.resup = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvB
            // 
            this.dgvB.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(30, 236);
            this.dgvB.Name = "dgvB";
            this.dgvB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvB.Size = new System.Drawing.Size(734, 248);
            this.dgvB.TabIndex = 0;
            this.dgvB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "list books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sup
            // 
            this.sup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sup.Location = new System.Drawing.Point(609, 63);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(75, 23);
            this.sup.TabIndex = 5;
            this.sup.Text = "supprimer";
            this.sup.UseVisualStyleBackColor = false;
            this.sup.Click += new System.EventHandler(this.sup_Click);
            // 
            // cherche
            // 
            this.cherche.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cherche.Location = new System.Drawing.Point(702, 63);
            this.cherche.Name = "cherche";
            this.cherche.Size = new System.Drawing.Size(75, 23);
            this.cherche.TabIndex = 6;
            this.cherche.Text = "recherche";
            this.cherche.UseVisualStyleBackColor = false;
            this.cherche.Click += new System.EventHandler(this.cherche_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Modifier.Location = new System.Drawing.Point(185, 9);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 7;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(676, 207);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "sauvegarder";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(93, 41);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(188, 20);
            this.ID.TabIndex = 0;
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(329, 73);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(188, 20);
            this.prix.TabIndex = 2;
            // 
            // Auteur
            // 
            this.Auteur.Location = new System.Drawing.Point(331, 39);
            this.Auteur.Name = "Auteur";
            this.Auteur.Size = new System.Drawing.Size(188, 20);
            this.Auteur.TabIndex = 1;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(93, 73);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(188, 20);
            this.Nom.TabIndex = 3;
            // 
            // nbrpage
            // 
            this.nbrpage.Location = new System.Drawing.Point(93, 141);
            this.nbrpage.Name = "nbrpage";
            this.nbrpage.Size = new System.Drawing.Size(188, 20);
            this.nbrpage.TabIndex = 4;
            // 
            // categorie
            // 
            this.categorie.FormattingEnabled = true;
            this.categorie.Location = new System.Drawing.Point(93, 180);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(176, 21);
            this.categorie.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Auteur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "prix";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nombre page";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "category";
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ajouter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ajouter.Location = new System.Drawing.Point(93, 9);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 25;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // resup
            // 
            this.resup.Location = new System.Drawing.Point(595, 119);
            this.resup.Name = "resup";
            this.resup.Size = new System.Drawing.Size(182, 20);
            this.resup.TabIndex = 26;
            // 
            // btnlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(839, 566);
            this.Controls.Add(this.resup);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categorie);
            this.Controls.Add(this.nbrpage);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Auteur);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.cherche);
            this.Controls.Add(this.sup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvB);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "btnlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sup;
        private System.Windows.Forms.Button cherche;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.TextBox Auteur;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox nbrpage;
        private System.Windows.Forms.ComboBox categorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TextBox resup;
    }
}

