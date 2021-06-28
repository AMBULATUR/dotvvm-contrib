using System;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Hosting;

namespace DotVVM.Contrib.MaskMoney
{
    /// <summary>
    /// Renders a ...
    /// </summary>
    public class MaskMoney : TextBox
    {
        protected override void OnPreRender(IDotvvmRequestContext context)
        {
            context.ResourceManager.AddRequiredResource("dotvvm.contrib.MaskMoney");
            base.OnPreRender(context);
        }

        protected override void AddAttributesToRender(IHtmlWriter writer, IDotvvmRequestContext context)
        {
            base.AddAttributesToRender(writer, context);

            writer.AddKnockoutDataBind("dotvvm-contrib-MaskMoney", this, TextProperty, renderEvenInServerRenderingMode: true);
        }

    }
}
