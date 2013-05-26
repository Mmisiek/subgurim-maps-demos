using System;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class GroundOverlay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng sw = new GLatLng(64, 20);
            GLatLng ne = new GLatLng(65, 29);

            GMap1.setCenter((sw / 2) + (ne / 2));

            GGroundOverlay groundOverlay = new GGroundOverlay("http://googlemaps.subgurim.net/images/logo.jpg", new GLatLngBounds(sw, ne));

            GMap1.Add(groundOverlay);
        }
    }
}