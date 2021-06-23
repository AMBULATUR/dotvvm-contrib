using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;

namespace DotVVM.Contrib.autoComplete
{
    public static class autoCompleteConfigurationExtensions
    {

        public static void AddContribautoCompleteConfiguration(this DotvvmConfiguration config)
        {
            config.Markup.Controls.Add(new DotvvmControlConfiguration()
            {
                Assembly = typeof(autoComplete).Assembly.GetName().Name,
                Namespace = typeof(autoComplete).Namespace,
                TagPrefix = "dc"
            });

            config.Resources.Register("autoComplete", new ScriptResource()
            {
                Location = new EmbeddedResourceLocation(typeof(autoComplete).GetTypeInfo().Assembly, $"DotVVM.Contrib.autoComplete.Scripts.AutoComplete.jquery.autocomplete.js"),
                Dependencies = new[] { "dotvvm" } //"jquery"
            });
            // register additional resources for the control and set up dependencies
            config.Resources.Register("dotvvm.contrib.autoComplete", new ScriptResource()
            {
                Location = new EmbeddedResourceLocation(typeof(autoComplete).GetTypeInfo().Assembly, "DotVVM.Contrib.autoComplete.Scripts.DotVVM.Contrib.autoComplete.js"),
                Dependencies = new[] { "autoComplete" }
            });


            // NOTE: all resource names should start with "dotvvm.contrib.autoComplete"
        }

    }
}
