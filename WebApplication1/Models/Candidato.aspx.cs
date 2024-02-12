using System;
using System.Web.Configuration;

namespace NomeApplicazione
{
    public partial class Candidato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVisualizza_Click(object sender, EventArgs e)
        {
            string nomeCandidato = WebConfigurationManager.AppSettings["NomeCandidato"];
            string cognomeCandidato = WebConfigurationManager.AppSettings["CognomeCandidato"];

            lblCandidato.Text = $"Nome: {nomeCandidato}, Cognome: {cognomeCandidato}";
        }
    }
}
