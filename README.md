# Podcast Player of Choice .NET port

## Overview

This is a partial implementation of the [Podcast Player of Choice API backend](https://github.com/will-head/ppoc) using .NET Core.

## Setup

Ensure you have [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core) installed.

If you don't already have SpecFlow+ account, when you first run `dotnet test` you'll be prompted to follow a link to activate an account. More info here: [Executing SpecFlow+ Runner the first time](https://docs.specflow.org/projects/specflow/en/latest/Getting-Started/Getting-Started-With-An-Example.html#executing-specflow-runner-the-first-time)

## Testing

To run SpecFlow use:  

```bash
$ dotnet test
```

[StyleCop Analyzer](https://github.com/DotNetAnalyzers/StyleCopAnalyzers) is included in the build stage, and will raise warnings for any violations.

## Usage

Only a partial implementation of the FeedTranslator class is currently supported. This be run from the command line as follows:

```bash
$ dotnet run -p Ppoc/Ppoc.csproj
```

This will prompt for a podcast feed and the format for it to be translated into to. Formats currently supported are:

```
feed
itpc
podcast
downcast
pcast
```

On success, the output will appear as follows:

```bash
$ dotnet run -p Ppoc/Ppoc.csproj

Enter a feed:
http://example.com/feed

Enter a feed format:
pcast  

Your translated feed is:
pcast://example.com/feed
```
