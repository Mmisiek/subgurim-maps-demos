using System;
using Subgurim.Controles;

namespace Demos.Maps
{
    public partial class Mars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMarsMap1.Add(new GControl(GControl.preBuilt.MapTypeControl));
        }
    }
}