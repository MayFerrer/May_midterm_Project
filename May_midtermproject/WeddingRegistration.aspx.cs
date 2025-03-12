using System;
using System.Web.UI;

namespace May_midtermproject
{
    public partial class WeddingRegistration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // After clicking register, show the confirmation modal using JavaScript
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "showConfirmationModal();", true);
        }
    }
}
