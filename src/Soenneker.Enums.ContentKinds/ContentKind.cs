using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.ContentKinds;

/// <summary>
/// An enum for various content types.
/// </summary>
[EnumValue<string>]
public sealed partial class ContentKind
{
    /// <summary>
    /// The json.
    /// </summary>
    public static readonly ContentKind Json = new(nameof(Json));

    /// <summary>
    /// The xml or html.
    /// </summary>
    public static readonly ContentKind XmlOrHtml = new(nameof(XmlOrHtml));

    /// <summary>
    /// The text.
    /// </summary>
    public static readonly ContentKind Text = new(nameof(Text));

    /// <summary>
    /// The binary.
    /// </summary>
    public static readonly ContentKind Binary = new(nameof(Binary));

    /// <summary>
    /// The unknown.
    /// </summary>
    public static readonly ContentKind Unknown = new(nameof(Unknown));
}