using System;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class StreeViewOverlay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.Add(new GStreetviewOverlay());
            GMap1.setCenter(new GLatLng(45.511889, -122.675578), 14);
        }
    }
}