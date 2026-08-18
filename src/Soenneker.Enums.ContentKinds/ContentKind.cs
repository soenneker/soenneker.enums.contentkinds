using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.ContentKinds;

/// <summary>
/// Classifies payload content by the parsing strategy required to process it.
/// </summary>
[EnumValue<string>]
public sealed partial class ContentKind
{
    /// <summary>
    /// JavaScript Object Notation (JSON) content.
    /// </summary>
    public static readonly ContentKind Json = new(nameof(Json));

    /// <summary>
    /// XML or HTML markup content.
    /// </summary>
    public static readonly ContentKind XmlOrHtml = new(nameof(XmlOrHtml));

    /// <summary>
    /// Plain textual content.
    /// </summary>
    public static readonly ContentKind Text = new(nameof(Text));

    /// <summary>
    /// Binary content that should not be decoded as text.
    /// </summary>
    public static readonly ContentKind Binary = new(nameof(Binary));

    /// <summary>
    /// Content whose format could not be determined.
    /// </summary>
    public static readonly ContentKind Unknown = new(nameof(Unknown));
}
