using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace w14_1
{
    public partial class Create : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString.ToString();
                    SqlConnection conn2 = new SqlConnection(connectionString);
                    SqlCommand cmd2 = new SqlCommand("select * from Dipendente WHERE IdDipendenti=@id", conn2);
                    cmd2.Parameters.AddWithValue("id", Request.QueryString["ID"]);
                    conn2.Open();
                    SqlDataReader sqlreader2;
                    sqlreader2 = cmd2.ExecuteReader();
                    while (sqlreader2.Read())
                    {
                        Nome.Text = sqlreader2["Nome"].ToString();
                        Cognome.Text = sqlreader2["Cognome"].ToString();
                        Indirizzo.Text = sqlreader2["Indirizzo"].ToString();
                        CodiceFiscale.Text = sqlreader2["CodiceFiscale"].ToString().ToUpper();
                        if (sqlreader2["IsSposato"] == "True")
                        {
                            IsSposato.Checked = true;
                        }
                        else
                        {
                            IsSposato.Checked = false;
                        }
                        NfigliCarico.Text = sqlreader2["NFigliCarico"].ToString();
                        Mansione.Text = sqlreader2["Mansione"].ToString();

                    }
                    conn2.Close();
                }
            }
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
          .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Dipendente VALUES(@nome,@cognome,@indirizzo,@codiceFiscale,@isSposato,@nFigliCarico,@mansione)";
                cmd.Parameters.AddWithValue("nome", Nome.Text);
                cmd.Parameters.AddWithValue("cognome", Cognome.Text);
                cmd.Parameters.AddWithValue("indirizzo", Indirizzo.Text);
                cmd.Parameters.AddWithValue("codiceFiscale", CodiceFiscale.Text);
                cmd.Parameters.AddWithValue("isSposato", IsSposato.Checked);
                cmd.Parameters.AddWithValue("nFigliCarico", NfigliCarico.Text);
                cmd.Parameters.AddWithValue("mansione", Mansione.Text);

                int inserimentoEffettuato = cmd.ExecuteNonQuery();

                if (inserimentoEffettuato > 0)
                {
                    Response.Write("Inserimento effettuato con successo");
                }

            }
            catch (Exception ex) { Response.Write(ex.Message); }
            finally { conn.Close(); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
         .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Pagamenti VALUES(@data,@importo,@stipendio,@acconto,@idDipendente)";
                cmd.Parameters.AddWithValue("data", data.Text);
                cmd.Parameters.AddWithValue("importo", importo.Text);
                cmd.Parameters.AddWithValue("stipendio", stipendio.Checked);
                cmd.Parameters.AddWithValue("acconto", acconto.Checked);
                cmd.Parameters.AddWithValue("idDipendente", idDipendente.Text);
                

                int inserimentoEffettuato = cmd.ExecuteNonQuery();

                if (inserimentoEffettuato > 0)
                {
                    Response.Write("Inserimento effettuato con successo");
                }

            }
            catch 
            {
                Label1.Visible = true;
                Label1.Text = "Alcuni campi sono sbagliati o vuoti riprovare";
            }
            finally { conn.Close(); }

        }

        protected void Modifica_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString.ToString();
                SqlConnection conn2 = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Dipendente where IdDipendenti=@id ", conn2);
            cmd.Parameters.AddWithValue("id", Request.QueryString["ID"]);

            SqlDataReader sqlreader;
            conn2.Open();
         
            sqlreader = cmd.ExecuteReader();

            while (sqlreader.Read())
            {
           
                //Nome.Text = sqlreader["Nome"].ToString();
                //Cognome.Text = sqlreader["Cognome"].ToString();
                //CodiceFiscale.Text = sqlreader["CodiceFiscale"].ToString().ToUpper();
                //Indirizzo.Text = sqlreader["Indirizzo"].ToString();
                //IsSposato.Checked = Convert.ToBoolean(sqlreader["IsSposato"]);
                //NfigliCarico.Text = sqlreader["NFigliCarico"].ToString();
                //Mansione.Text = sqlreader["Mansione"].ToString();
              

            }
            conn2.Close();


            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = conn2;
                cmd2.CommandText = "UPDATE Dipendente SET Nome=@nome, Cognome=@cognome, Indirizzo=@indirizzo, CodiceFiscale=@codiceFiscale,IsSposato=@isSposato,NFigliCarico=@nfigliCarico, Mansione=@mansione where IdDipendenti=@id";
                cmd2.Parameters.AddWithValue("nome", Nome.Text);
                cmd2.Parameters.AddWithValue("cognome", Cognome.Text);
                cmd2.Parameters.AddWithValue("indirizzo", Indirizzo.Text);
                cmd2.Parameters.AddWithValue("codiceFiscale", CodiceFiscale.Text);
                cmd2.Parameters.AddWithValue("isSposato", IsSposato.Checked);
                cmd2.Parameters.AddWithValue("nfigliCarico", NfigliCarico.Text);
                cmd2.Parameters.AddWithValue("mansione", Mansione.Text);

                cmd2.Parameters.AddWithValue("id", Request.QueryString["ID"]);


                conn2.Open();

                cmd2.ExecuteNonQuery();

                conn2.Close();
            Response.Redirect(Request.RawUrl);

        }

    }
}