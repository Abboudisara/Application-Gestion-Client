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

        private void button1_Click(object sender, EventArgs e)
        {

        }
         
        private void list1_Load(object sender, EventArgs e)

        {
           // cnx.Open(); //ouverture d une base données
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM client", cnx); //pour données une commande 
            adapter.Fill(ds, "client");// pour remplir une base données virtuelle travailler avec la methode fill(Nom bd virtuelle,Nom de table)
            data.DataSource = ds.Tables["client"];// remplire le datagreedvue  avec le contenu de Datasource
           // cnx.Close();// fermeture une base données
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
