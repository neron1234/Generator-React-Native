using System.Collections.Generic;
using System.Linq;

using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;
using Mobioos.Scaffold.Generators.Helpers;

namespace GeneratorProject.Platforms.Frontend.ReactNative
{
    [Generator(ActivityName = Constants.ModelActivityName, Order = 1)]
    public partial class DataModelTemplate : TemplateBase
    {
        private List<PropertyInfo> _superProperties { get; set; }
        private string _modelsuffix { get; set; }

        public DataModelTemplate(EntityInfo model, string appliationId, string modelsuffix) : base(model, appliationId)
        {
            _superProperties = GetSuperClassReferences(model.BaseEntity);
            _modelsuffix = TextConverter.PascalCase(modelsuffix);
        }

        private List<PropertyInfo> GetSuperClassReferences(EntityInfo entity)
        {
            List<PropertyInfo> result = new List<PropertyInfo>();
            if (entity != null)
            {
                if (entity.BaseEntity != null)
                    foreach (PropertyInfo property in GetSuperClassReferences(entity.BaseEntity).AsEnumerable())
                        result.Add(property);

                if (entity.Properties.AsEnumerable() != null)
                    foreach (PropertyInfo property in entity.Properties.AsEnumerable())
                        result.Add(property);

                if (entity.References.AsEnumerable() != null)
                    foreach (ReferenceInfo reference in entity.References.AsEnumerable())
                        result.Add(reference);
            }
            return result;
        }

        public override string OutputPath => "App\\Models";
    }
}
