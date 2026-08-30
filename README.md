[![](https://img.shields.io/nuget/v/soenneker.enums.contentkinds.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.contentkinds/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.contentkinds/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.contentkinds/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.contentkinds.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.contentkinds/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.contentkinds/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.contentkinds/actions/workflows/codeql.yml)

# Soenneker.Enums.ContentKinds

A string-backed content classification that lets callers choose an appropriate parser without coupling the payload model to a MIME-type library.

## Install

```bash
dotnet add package Soenneker.Enums.ContentKinds
```

## Usage

```csharp
using Soenneker.Enums.ContentKinds;

ContentKind kind = ContentKind.Json;

if (!ContentKind.TryFromValue(input, out ContentKind? parsed))
    parsed = ContentKind.Unknown;
```

Available values:

- `Json` for JSON text
- `XmlOrHtml` for markup
- `Text` for other plain text
- `Binary` for bytes that should not be decoded as text
- `Unknown` when no classification is available

The serialized strings exactly match those names. `System.Text.Json` writes the underlying string and rehydrates the shared static instance. Use `TryFromValue` for untrusted input; `FromValue` throws when the value is not defined. Name-based `FromName` and `TryFromName` methods are generated as well.

`ContentKind` does not inspect bytes, validate syntax, distinguish XML from HTML, map MIME types, or choose a character encoding. The producer or consuming application is responsible for assigning the classification and applying size limits before parsing.
