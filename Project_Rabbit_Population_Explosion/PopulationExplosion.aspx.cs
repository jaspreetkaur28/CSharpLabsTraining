using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Rabbit_Population_Explosion
{
    public partial class PopulationExplosion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = null;
            Label2.Text += $"\n\nIt takes 12 seconds to teach a population limit of {TextBox1.Text}.";
        }
    }
}