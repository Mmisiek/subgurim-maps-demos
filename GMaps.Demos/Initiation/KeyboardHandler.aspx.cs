using System;

namespace Demos.Initiation
{
    public partial class KeyboardHandler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.enableGKeyboardHandler = true;
        }
    }
}