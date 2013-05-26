using System;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class MapType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GControl extMapType = new GControl(new ExtMapTypeControl(true, true, true, true, true)); 
            GMap1.Add(extMapType);

            GMap1.setCenter(new GLatLng(47, -122));
        }
    }
}