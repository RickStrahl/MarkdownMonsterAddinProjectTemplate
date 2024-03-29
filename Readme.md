# Markdown Monster New Addin Project  Templates

<img src="MarkdownMonster_Icon_256.png" width="150"/>

This project contains the source code for the **dotnet new Template** and **Visual Studio VSIX Project Template** that can be used to create your own Markdown Monster Addins using .NET code. 

To create a Markdown Monster Addin you don't need to do anything with this repository - it's provided merely as a reference or for those who want to customize the templates that are publicly available via NuGet and the Visual Studio Marketplace.

For more detailed information on how to create an addin in Markdown Monster please check the documentation:

* [Creating an Addin for Markdown Monster](https://markdownmonster.west-wind.com/docs/_4nb0se717.htm)

## Use the Templates
The NuGet and Visual Studio templates are publicly available via their respective download sources:

* [The NuGet Project Template](https://www.nuget.org/packages/MarkdownMonster.AddinProject.Template/)
* [The Visual Studio Addin](https://marketplace.visualstudio.com/items?itemname=rickstrahl.markdownmonsteraddinproject)


Please refer to the documentation link on [creating, installing and usaging a Markdown Monster addin](https://markdownmonster.west-wind.com/docs/_4ne0s0qoi.htm) in the documentation.

## Requirements

### .NET 7.0 Required
Markdown Monster Addins have to be built against .NET 7.0 Windows as this is the base version that Markdown Monster is built against. The dependencies in the addin project require the same runtime version or newer in order to bind to the Markdown Monster host assembly.

The Addin automatically creates a project that is configured for the correct version required for Markdown Monster (`net7.0-windows` current).

### Visual Studio Versions and Editions
This Visual Studio Extension now only works for:

* Visual Studio 2022 (x64)

Supported Visual Studio Editions:

* Community
* Professional
* Enterprise

### Additional Resources
* [Creating a Markdown Monster Addin](http://markdownmonster.west-wind.com/docs/_4ne0s0qoi.htm)
* [Markdown Monster](https://github.com/rickstrahl/MarkdownMonster)
* [Markdown Monster Addin Repository](https://github.com/RickStrahl/MarkdownMonsterAddinsRegistry)
* [Markdown Monster Addin Project in the Visual Studio Gallery](https://marketplace.visualstudio.com/vsgallery/231f13cc-2348-432c-a69f-82e7b725587e)