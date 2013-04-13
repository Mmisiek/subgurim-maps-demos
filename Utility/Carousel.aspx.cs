using System;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class Carousel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.Add(new GControl(new CarouselMapTypeControl()));
        }
    }
}