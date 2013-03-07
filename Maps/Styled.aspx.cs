using System;
using System.Collections.Generic;
using System.Drawing;
using Subgurim.Controles;

namespace Demos.Maps
{
    public partial class Styled : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.setCenter(new GLatLng(40.639722, -73.778889), 12);

            var uiOptions = new GMapUIOptions()
                                {
                                    controls_maptypecontrol = true,
                                };

            
            GMap1.Add(new GMapUI(uiOptions));

            var styledMapOptions = new GStyledMapOptions("Styled");

            var redStyler = new GMapTypeStyler(Color.Red)
                                {
                                    Gamma = 0.9,
                                };

            var blueStyler = new GMapTypeStyler(Color.Blue)
                                 {
                                     Weight = 5
                                 };

            var styles = new List<GMapTypeStyle>()
                             {
                                 new GMapTypeStyle(GMapTypeStyleElementType.Geometry, GMapTypeStyleFeatureType.Transit__Station__Airport, redStyler),
                                 new GMapTypeStyle(GMapTypeStyleElementType.Geometry__Stroke, GMapTypeStyleFeatureType.Road, blueStyler)
                             };

            var styledMap = new GStyledMapType(styledMapOptions, styles);
            
            GMap1.Add(styledMap, true);
        }
    }
}