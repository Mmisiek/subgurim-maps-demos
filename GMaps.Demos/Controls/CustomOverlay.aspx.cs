using System;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class CustomOverlay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.Add(new GCustomOverlay(GCustomOverlay.Overlay.Rectangle));
        }
    }
}