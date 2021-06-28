using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;

namespace DotVVM.Contrib.MaskMoney
{
    public static class MaskMoneyConfigurationExtensions
    {

        public static void AddContribMaskMoneyConfiguration(this DotvvmConfiguration config)
        {
            config.Markup.Controls.Add(new DotvvmControlConfiguration()
            {
                Assembly = typeof(MaskMoney).Assembly.GetName().Name,
                Namespace = typeof(MaskMoney).Namespace,
                TagPrefix = "dc"
            });

            config.Resources.Register("maskMoney", new ScriptResource()
            {
                Location = new EmbeddedResourceLocation(typeof(MaskMoney).GetTypeInfo().Assembly, $"DotVVM.Contrib.MaskMoney.Scripts.MaskMoney.MaskMoney.js"),
                Dependencies = new[] { "dotvvm" } //"jquery"
            });

            // register additional resources for the control and set up dependencies
            config.Resources.Register("dotvvm.contrib.MaskMoney", new ScriptResource()
            {
                Location = new EmbeddedResourceLocation(typeof(MaskMoney).GetTypeInfo().Assembly, "DotVVM.Contrib.MaskMoney.Scripts.DotVVM.Contrib.MaskMoney.js"),
                Dependencies = new [] { "maskMoney" }
            });


            // NOTE: all resource names should start with "dotvvm.contrib.MaskMoney"
        }

    }
}
