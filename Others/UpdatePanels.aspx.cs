using System;

namespace GMaps.Demos.Others
{
    public partial class UpdatePanels : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnTimerTick(object sender, EventArgs e)
        {
            Panel1.Update();
        }
    }
}