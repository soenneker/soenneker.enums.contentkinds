[![](https://img.shields.io/nuget/v/soenneker.enums.contentkinds.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.contentkinds/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.contentkinds/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.contentkinds/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.contentkinds.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.contentkinds/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.contentkinds/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.contentkinds/actions/workflows/codeql.yml)

# Soenneker.Enums.ContentKinds

Classifies payload content by the parsing strategy required to process it.

## Install

```bash
dotnet add package Soenneker.Enums.ContentKinds
```

## What you get

- `ContentKind` — Classifies payload content by the parsing strategy required to process it.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `ContentKind.Json` | JavaScript Object Notation (JSON) content. | JavaScript Object Notation (JSON) content. |
| `ContentKind.Binary` | Binary content that should not be decoded as text. | Binary content that should not be decoded as text. |
| `ContentKind.Unknown` | Content whose format could not be determined. | Content whose format could not be determined. |
