using System.Reflection;
using Refit;

namespace Guesty.Refit;

public class UrlParameterFormatter : IUrlParameterFormatter
{
    private readonly IUrlParameterFormatter _df = new DefaultUrlParameterFormatter();

    // Initialize the default Refit formatter

    public string? Format(object? value, ICustomAttributeProvider attributeProvider, Type type)
    {
        return value is IUrlParameterFormatter v ? v.Format(value, attributeProvider, type) : _df.Format(value, attributeProvider, type);
    }
}