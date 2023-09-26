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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
 string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
          .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);



            SqlCommand cmd = new SqlCommand("select * from Dipendente ", conn);

            SqlDataReader sqlreader;
            conn.Open();
            List<Dipendente> listaPersone = new List<Dipendente>();
            sqlreader = cmd.ExecuteReader();

            while (sqlreader.Read())
            {
                Dipendente dipendente = new Dipendente();
                     
                dipendente.Nome = sqlreader["Nome"].ToString();
                dipendente.Cognome = sqlreader["Cognome"].ToString();
                dipendente.CodiceFiscale = sqlreader["CodiceFiscale"].ToString().ToUpper();
                dipendente.Indirizzo = sqlreader["Indirizzo"].ToString();
                dipendente.IsSposato =Convert.ToBoolean( sqlreader["IsSposato"]);
                dipendente.NFigliCarico =Convert.ToInt16( sqlreader["NFigliCarico"]);
                dipendente.Mansione= sqlreader["Mansione"].ToString();      
                dipendente.IdDipendenti =Convert.ToInt32( sqlreader["IdDipendenti"]);
                listaPersone.Add(dipendente);

            }
            GridView1.DataSource = listaPersone;
            GridView1.DataBind();
            conn.Close();
        }
            
          
    }

    public class Dipendente
    {
        public int IdDipendenti { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string CodiceFiscale { get; set; }
        public bool IsSposato { get; set; }
        public int NFigliCarico { get; set; }

        public string Mansione { get; set; }

        public int IdDipendente { get; set; }
        public string Data { get; set; }
        public string Importo { get; set; }
        public string IsStipendio { get; set; }
        public string IsAcconto { get; set; }
      }
    }

