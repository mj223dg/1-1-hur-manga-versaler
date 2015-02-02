using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountCapitals.Models;

namespace CountCapitals
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int Capitals = TextAnalyzer.GetNumberOfCapitals(TextBox.Text);

                Result.Text = "Antalet versaler: " + Capitals;
                TextBox.Enabled = false;
                SendButton.Visible = false;
            }
        }
    }
}