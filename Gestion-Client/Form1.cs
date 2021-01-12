using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Client
{
    public partial class list1 : Form
    {

        public list1()
        {
            InitializeComponent();
            // connectionStrings
        }
        SqlConnection cnx = new SqlConnection(" Data Source=DESKTOP-IIVAD0V;Initial Catalog = GestionClient;Integrated Security=true");// connexion avec la base données
        DataSet ds = new DataSet();// collection pour prendre un copie avant de l ajoute a un base données
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int cpt = -1; // indice
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["client"].Rows.Count; i++) // loup sur la collection
            {
                if (ressup.Text == ds.Tables["client"].Rows[i][0].ToString()) //linput qui reçois la recherche+ la table+la colone et ligne+changer string
                {
                    cpt = i; // indice=i
                    break;
                }

            }
            if (cpt == -1) // indice non trouvable
            {
                MessageBox.Show("Ce Client ne Pas Trouver");
            }

            else// trouver une enrg
            {
                ds.Tables["client"].Rows[cpt].Delete();
                MessageBox.Show("le client a bient supprimer");
                cpt = -1;
            }
        }

        private void list1_Load(object sender, EventArgs e)

        {
            cnx.Open(); //ouverture d une base données
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM client", cnx); //pour données une commande 
            adapter.Fill(ds, "client");// pour remplir une base données virtuelle travailler avec la methode fill(Nom bd virtuelle,Nom de table)
            data.DataSource = ds.Tables["client"];// remplire le datagreedvue  avec le contenu de Datasource
            cnx.Close();// fermeture une base données
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ajt_Click(object sender, EventArgs e)
        {
            DataRow ligne;// précicer que le travailler dans les lignes;
            ligne = ds.Tables["client"].NewRow();  // creation dune ligne dans la table client 
            ligne["id"] = identif.Text;// ajouter une entrez dans le champ id à laide à linput identif
            ligne["nom"] = Nom.Text;
            ligne["prenom"] = prenom.Text;
            ligne["adresse"] = adresse.Text;
            ligne["ville"] = ville.Text;
            ds.Tables["client"].Rows.Add(ligne);

        }

        private void upd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["client"].Rows.Count; i++) // loup sur la collection
            {
                if (identif.Text == ds.Tables["client"].Rows[i][0].ToString()) //linput qui reçois la recherche+ la table+la colone et ligne+changer string
                {
                    cpt = i; // indice=i
                    break;
                }

            

            if (cpt == -1) // indice non trouvable
            {
                MessageBox.Show("Ce Client ne Pas Trouver");
            }

            else // trouver une enrg lancemant des modification sur input
            {
                ds.Tables["client"].Rows[cpt][1] = Nom.Text;
                ds.Tables["client"].Rows[cpt][2] = prenom.Text;
                ds.Tables["client"].Rows[cpt][3] = adresse.Text;
                ds.Tables["client"].Rows[cpt][4] = ville.Text;
            }


        } 
        }

        private void enrg_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM client ", cnx);// Adaptation des données de  dv avec db
            SqlCommandBuilder enrg = new SqlCommandBuilder(adapter); // lançement communication avec db
            adapter.Update(ds, "client"); // enregistrer les changemant
        }
    }
}
