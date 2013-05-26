using System;
using Subgurim.Controles;

namespace Demos.Others
{
    public partial class AdsManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GAdsManagerOptions options = new GAdsManagerOptions(1, 30);
            options.style = GAdsManagerOptions.GAdsManagerStyleEnum.adunit;
            GMap1.Add(new GAdsManager("YourPublisherID", GAdsManager.HelpSubgurimEnum.FullHelp, options));
        }
    }
}