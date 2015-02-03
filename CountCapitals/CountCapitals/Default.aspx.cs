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

            if (TextBox.Text.Length > 0)
                {
                    int Capitals = TextAnalyzer.GetNumberOfCapitals(TextBox.Text);

                    Result.Text = "Antalet versaler: " + Capitals;
                    TextBox.Enabled = false;
                    SendButton.Text = "Rensa";
                    SendButton.Visible = false;
                    ResetButton.Visible = true;
                }
        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            if (ResetButton.Visible == true)
            {
                Server.Transfer("Default.aspx", true);
            }
        }
    }
}