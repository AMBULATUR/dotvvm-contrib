using System;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Hosting;

namespace DotVVM.Contrib
{
    /// <summary>
    /// Renders a ...
    /// </summary>
    public class Chartist : HtmlGenericControl
    {

        public Chartist() : base("div")
        {
        }

        protected override void OnPreRender(IDotvvmRequestContext context)
        {
            context.ResourceManager.AddRequiredResource("dotvvm.contrib.Chartist");

            base.OnPreRender(context);
        }		
		
    }
}
