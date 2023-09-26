using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w14_1
{
    public partial class Dettagli : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
                   .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select IdDipendenti, Nome,Data,Importo,IsStipendio,IsAcconto from Dipendente INNER JOIN Pagamenti ON Dipendente.IdDipendenti=Pagamenti.IdDipendente where Pagamenti.IdDipendente = @id ", conn);
            SqlDataReader sqlreader;
            conn.Open();
            List<Dipendente> listaPersone = new List<Dipendente>();

            cmd.Parameters.AddWithValue("id", Request.QueryString["Id"]);
            sqlreader = cmd.ExecuteReader();

            while (sqlreader.Read())
            {
                Dipendente dipendente = new Dipendente();
                dipendente.Nome = sqlreader["Nome"].ToString();
                dipendente.Data = Convert.ToDateTime(sqlreader["Data"]).ToShortDateString();
                dipendente.Importo = sqlreader["Importo"].ToString();
                dipendente.IsStipendio = sqlreader["IsStipendio"].ToString();
                dipendente.IsAcconto = sqlreader["IsAcconto"].ToString();

                dipendente.IdDipendenti = Convert.ToInt32(sqlreader["IdDipendenti"]);
                listaPersone.Add(dipendente);



            }
            GridView1.DataSource = listaPersone;
            GridView1.DataBind();
            conn.Close();


            SqlCommand cmd1 = new SqlCommand("select * from Dipendente where IdDipendenti=@id", conn);
            SqlDataReader sqlreader1;
            conn.Open();


            List<Dipendente> Person = new List<Dipendente>();
            cmd1.Parameters.AddWithValue("id", Request.QueryString["Id"]);
            sqlreader1 = cmd1.ExecuteReader();
            cmd1.Parameters.AddWithValue("id", Request.QueryString["Id"]);
            while (sqlreader1.Read())
            {
                Dipendente dipendente1 = new Dipendente();
                dipendente1.IdDipendenti = Convert.ToInt32(sqlreader1["IdDipendenti"]);
                dipendente1.Nome = sqlreader1["Nome"].ToString();
                dipendente1.Cognome = sqlreader1["Cognome"].ToString();
                dipendente1.Indirizzo = sqlreader1["Indirizzo"].ToString();
                dipendente1.IdDipendenti = Convert.ToInt32(sqlreader1["IdDipendenti"]);


                Person.Add(dipendente1);

            }



            Repeater.DataSource = Person;
            Repeater.DataBind();
            conn.Close();
        }
         

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
           .ConnectionString.ToString();
                SqlConnection conn = new SqlConnection(connection);

            SqlCommand cmd2 = new SqlCommand("select * from Dipendente where IdDipendenti=@id", conn);
            SqlDataReader sqlreader1;
            conn.Open();


            List<Dipendente> Person = new List<Dipendente>();
            cmd2.Parameters.AddWithValue("id", Request.QueryString["Id"]);
            sqlreader1 = cmd2.ExecuteReader();
       
            while (sqlreader1.Read())
            {
                Dipendente dipendente1 = new Dipendente();
                dipendente1.IdDipendenti = Convert.ToInt32(sqlreader1["IdDipendenti"]);
                dipendente1.Nome = sqlreader1["Nome"].ToString();
                dipendente1.Cognome = sqlreader1["Cognome"].ToString();
                dipendente1.Indirizzo = sqlreader1["Indirizzo"].ToString();
                dipendente1.IdDipendenti = Convert.ToInt32(sqlreader1["IdDipendenti"]);


                Person.Add(dipendente1);

            }
            conn.Close();

         

            SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 cmd.CommandText = "DELETE FROM Pagamenti where IdDipendente=@id";
                cmd.Parameters.AddWithValue("id", Request.QueryString["Id"]);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();



            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "DELETE FROM Dipendente where IdDipendenti=@id";
            cmd1.Parameters.AddWithValue("id", Request.QueryString["Id"]);

            conn.Open();

            cmd1.ExecuteNonQuery();

            conn.Close();

            Response.Redirect(Request.RawUrl);

        }
    }
}