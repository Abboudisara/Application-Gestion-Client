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

namespace test
{
    public partial class btnlist : Form
    {
        public btnlist()
        {
            InitializeComponent();
        }

        bool btnModifier = false;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifier = true;
            int CurentLigne = this.dgvB.CurrentRow.Index;
            this.ID.Text = Ado.Dtbooks.Rows[CurentLigne][0].ToString();
            this.Nom.Text = Ado.Dtbooks.Rows[CurentLigne][1].ToString();
            this.Auteur.Text = Ado.Dtbooks.Rows[CurentLigne][2].ToString();
            this.prix.Text = Ado.Dtbooks.Rows[CurentLigne][3].ToString();
            this.nbrpage.Text = Ado.Dtbooks.Rows[CurentLigne][4].ToString();
            this.categorie.SelectedValue = Ado.Dtbooks.Rows[CurentLigne][5].ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        AdoNet Ado = new AdoNet();
        //private object ID;

        private void btnlist_Load(object sender, EventArgs e)
        {
            /*  Ado.Command.CommandText = " SELECT *FROM category;";
              Ado.Command.Connection = Ado.Connection;
              Ado.Connection.Open();
              Ado.Reader = Ado.Command.ExecuteReader();

              while (Ado.Reader.Read())
              {
                  this.categorie.Items.Add(Ado.Reader[1]);
              }
              Ado.Connection.Close();*/


            Ado = new AdoNet();
            // debut de communication avec la base données
            string Query = string.Empty + "GetbooksCat";
            Ado.Command.CommandText = Query;
            Ado.Command.CommandType = CommandType.StoredProcedure;
            Ado.Command.Connection = Ado.Connection;
            Ado.Adapter.SelectCommand = Ado.Command;
            Ado.Adapter.Fill(Ado.Ds);
            // fin de communication avec la base données
            Ado.Dtbooks = Ado.Ds.Tables[1];
            Ado.DtCat = Ado.Ds.Tables[0];
            Ado.Dtbooks.TableName = "Books";
            Ado.DtCat.TableName = "Categorie";

            this.dgvB.DataSource = Ado.Dtbooks; //affichage dans la liste
                                                //  this.dgvB.DataSource = Ado.Ds.Tables[1];
            this.categorie.DataSource = Ado.DtCat;
            this.categorie.DisplayMember = Ado.DtCat.Columns[1].ColumnName;
            this.categorie.ValueMember = Ado.DtCat.Columns[0].ColumnName;
            this.categorie.SelectedIndex = -1;
        }

       

        private void ajouter_Click(object sender, EventArgs e)
        {
           
            {
                DataRow book = Ado.Dtbooks.NewRow();
                book[0] = this.ID.Text.Trim();
                book[1] = this.Nom.Text.Trim();
                book[2] = this.Auteur.Text.Trim();
                book[3] = this.prix.Text.Trim();
                book[4] = this.nbrpage.Text.Trim();
                book[5] = this.categorie.SelectedValue.ToString();
                Ado.Dtbooks.Rows.Add(book);
                MessageBox.Show("donnée bien affectéer");
            }
           

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                // save dans database
                SqlCommandBuilder builder = new SqlCommandBuilder(Ado.Adapter);
                Ado.Adapter.Update(Ado.Ds, "books");
                MessageBox.Show("mise a jour bien effactuer");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sup_Click(object sender, EventArgs e)
        {
            if (this.resup.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Donnez l id de livre","information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.resup.Focus();
                return;
            }

            int id;
            bool isInteger = int.TryParse(this.resup.Text.Trim(), out id);
            if (!isInteger)
            {
                MessageBox.Show("tapez un nombre!!");
            }
            else
            {
                bool find = false;
                foreach(DataRow row in Ado.Dtbooks.Rows)
                {
                    if (row[0].ToString().Equals(id.ToString()))
                    {
                        find = true;
                        DialogResult res = MessageBox.Show("vouillez vous supprimer?" ,"Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            row.Delete();
                            MessageBox.Show("bien supprimer");
                            return;
                        }
                        break;
                    }
                    if (find == false)
                    {
                        MessageBox.Show($"lid {id}est introuvable");
                    }
                }
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (btnModifier = true)
            {
                foreach(DataRow item in Ado.Dtbooks.Rows)
                {
                    if (item[0].ToString() == this.ID.Text)
                    {
                        item[1] = this.Nom.Text.Trim();
                        item[2] = this.Auteur.Text.Trim(); 
                        item[3] = this.prix.Text.Trim();
                        item[4] = this.nbrpage.Text.Trim();
                        item[5] = this.categorie.SelectedValue;
                        MessageBox.Show("le livre bien modifier");
                        break;
                    }
                }
            }
        }

        private void cherche_Click(object sender, EventArgs e)
        {
            if (this.resup.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Donnez l id de livre", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.resup.Focus();
                return;
            }

            int id;
            bool isInteger = int.TryParse(this.resup.Text.Trim(), out id);
            if (!isInteger)
            {
                MessageBox.Show("tapez un nombre (ID) .");
            }
            else
            {
               
                foreach(DataRow item in Ado.Dtbooks.Rows)
                {
                  
                    if (item[0].ToString().Equals(id.ToString()))
                    {
                        MessageBox.Show("livre est trouvez+\n" + item[0] + "\n" + item[1] + "\n" + item[2] + "\n" + item[3] + "\n" + item[4] + "\n" + item[5],"information",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                }
              
                
                    MessageBox.Show("le livre introuvable");
                
            }
        }
    }
  }
