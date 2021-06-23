using System;
using System.Linq.Expressions;
using DotVVM.Framework.Binding;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Hosting;
using DotVVM.Framework.Utils;

namespace DotVVM.Contrib.autoComplete
{
    /// <summary>
    /// Renders a ...
    /// </summary>
    public class autoComplete : TextBox
    {

        protected override void OnPreRender(IDotvvmRequestContext context)
        {
            context.ResourceManager.AddRequiredResource("dotvvm.contrib.autoComplete");

            base.OnPreRender(context);
        }
        [MarkupOptions(Required = true)]
        public string autoID
        {
            get => (string)GetValue(autoIDProperty);
            set => SetValue(autoIDProperty, value);
        }
        public static readonly DotvvmProperty autoIDProperty
         = DotvvmProperty.Register<string, autoComplete>(c => c.autoID, null);
        [MarkupOptions(Required = false)]
        public string autoValue
        {
            get => (string)GetValue(autoValueProperty);
            set => SetValue(autoValueProperty, value);
        }
        public static readonly DotvvmProperty autoValueProperty
         = DotvvmProperty.Register<string, autoComplete>(c => c.autoValue, null);



        [MarkupOptions(Required = false)]
        public string autoDeliveryDate
        {
            get => (string)GetValue(autoDeliveryDateProperty);
            set => SetValue(autoDeliveryDateProperty, value);
        }
        public static readonly DotvvmProperty autoDeliveryDateProperty
         = DotvvmProperty.Register<string, autoComplete>(c => c.autoDeliveryDate, null);


        [MarkupOptions(Required = false)]
        public string autoDeliveryTerm
        {
            get => (string)GetValue(autoDeliveryTermProperty);
            set => SetValue(autoDeliveryTermProperty, value);
        }
        public static readonly DotvvmProperty autoDeliveryTermProperty
         = DotvvmProperty.Register<string, autoComplete>(c => c.autoDeliveryTerm, null);



        protected override void AddAttributesToRender(IHtmlWriter writer, IDotvvmRequestContext context)
        {
            base.AddAttributesToRender(writer, context);

            var group = new KnockoutBindingGroup();
            {
                group.Add("autoID", this, autoIDProperty);
                group.Add("autoValue", this, autoValueProperty);
                group.Add("autoDeliveryTerm", this, autoDeliveryTermProperty);
                group.Add("autoDeliveryDate", this, autoDeliveryDateProperty);


            }
            writer.AddKnockoutDataBind("dotvvm-contrib-autoComplete", group);
        }

    }
}
