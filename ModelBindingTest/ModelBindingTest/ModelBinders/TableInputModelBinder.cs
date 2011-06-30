using System;
using System.Web.Mvc;

namespace ModelBindingTest.ModelBinders
{
    public class TableInputModelBinder : DefaultModelBinder
    {
        protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
        {
            var typeValue = bindingContext.ValueProvider.GetValue(bindingContext.ModelName + ".TableInputModelTypeName");
            string typeAndNS = modelType.Namespace + "." + typeValue.AttemptedValue;
            var type = Type.GetType(typeAndNS, true);
            var model = Activator.CreateInstance(type);
            bindingContext.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(() => model, type);
            return model;
        }
    }
}


