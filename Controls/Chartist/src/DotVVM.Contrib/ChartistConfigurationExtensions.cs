using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;

namespace DotVVM.Contrib
{
    public static class ChartistConfigurationExtensions
    {

        public static void AddContribChartistConfiguration(this DotvvmConfiguration config)
        {
            config.Markup.Controls.Add(new DotvvmControlConfiguration()
            {
                Assembly = typeof(Chartist).Assembly.GetName().Name,
                Namespace = typeof(Chartist).Namespace,
                TagPrefix = "dc"
            });

            // register additional resources for the control and set up dependencies
            config.Resources.Register("dotvvm.contrib.Chartist", new ScriptResource()
            {
                Location = new EmbeddedResourceLocation(typeof(Chartist).GetTypeInfo().Assembly, "DotVVM.Contrib.Scripts.DotVVM.Contrib.Chartist.js"),
                Dependencies = new [] { "dotvvm", "dotvvm.contrib.Chartist.css" }
            });
            config.Resources.Register("dotvvm.contrib.Chartist.css", new StylesheetResource()
            {
                Location = new EmbeddedResourceLocation(typeof(Chartist).GetTypeInfo().Assembly, "DotVVM.Contrib.Styles.DotVVM.Contrib.Chartist.css")
            });

            // NOTE: all resource names should start with "dotvvm.contrib.Chartist"
        }

    }
}
