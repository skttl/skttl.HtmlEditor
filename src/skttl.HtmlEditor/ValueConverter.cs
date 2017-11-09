using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace skttl.HtmlEditor
{
	[PropertyValueType(typeof(IHtmlString))]
	[PropertyValueCache(PropertyCacheValue.All, PropertyCacheLevel.ContentCache)]
	public class ValueConverter : IPropertyValueConverter
	{
		public object ConvertDataToSource(PublishedPropertyType propertyType, object source, bool preview)
		{
			return new HtmlString(source.ToString());
		}

		public object ConvertSourceToObject(PublishedPropertyType propertyType, object source, bool preview)
		{
			return new HtmlString(source.ToString());
		}

		public object ConvertSourceToXPath(PublishedPropertyType propertyType, object source, bool preview)
		{
			return source.ToString();
		}

		public bool IsConverter(PublishedPropertyType propertyType)
		{
			return propertyType.PropertyEditorAlias == "skttl.HtmlEditor";
		}
	}
}
