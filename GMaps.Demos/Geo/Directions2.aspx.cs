using System;
using Subgurim.Controles;

namespace Demos.Geo
{
    public partial class Directions2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GDirection direction = new GDirection();
                direction.autoGenerate = false;
                direction.buttonElementId = "bt_Go";
                direction.fromElementId = tb_fromPoint.ClientID;
                direction.toElementId = tb_endPoint.ClientID;
                direction.divElementId = "div_directions"; 
                direction.clearMap = true;
                direction.travelMode = GDirection.GTravelModeEnum.G_TRAVEL_MODE_DRIVING;

                GMap1.Add(direction);
            }
        }
    }
}