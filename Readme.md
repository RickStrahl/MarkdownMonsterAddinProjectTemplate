# Markdown Monster New Addin Project  Templates

<img src="MarkdownMonster_Icon_256.png" width="150"/>

This project contains the source code for the **dotnet new Template** and **Visual Studio VSIX Project Template** that can be used to create your own Markdown Monster Addins using .NET code. 

To create a Markdown Monster Addin you don't need to do anything with this repository - it's provided merely as a reference or for those who want to customize the templates that are publicly available via NuGet and the Visual Studio Marketplace.

For more detailed information on how to create an addin in Markdown Monster please check the documentation:

* [Creating an Addin for Markdown Monster](https://markdownmonster.west-wind.com/docs/Creating-Markdown-Monster-Addins-with-NET/Creating-a-Markdown-Monster-Add--in.html)


## Use the Templates
The NuGet and Visual Studio templates are publicly available via their respective download sources:

* [The NuGet Project Template](https://www.nuget.org/packages/MarkdownMonster.AddinProject.Template/)
* [The Visual Studio Addin](https://marketplace.visualstudio.com/items?itemname=rickstrahl.markdownmonsteraddinproject)


Please refer to the documentation link on [creating, installing and using a Markdown Monster addin](https://markdownmonster.west-wind.com/docs/_4ne0s0qoi.htm) in the documentation.

## Requirements

### .NET 10.0 Required
Markdown Monster Addins have to be built against .NET 10.0 Windows as this is the base version that Markdown Monster is built against. The dependencies in the addin project require the same runtime version or newer in order to bind to the Markdown Monster host assembly.

The Addin automatically creates a project that is configured for the correct version required for Markdown Monster (`net10.0-windows` current for MM v4.0).

### Visual Studio Versions and Editions
This Visual Studio Extension now only works for:

* Visual Studio 2026 (x64)

Supported Visual Studio Editions:

* Community
* Professional
* Enterprise

You can find and install the Visual Studio version from the Visual Studio Extensions Manager by looking for **Markdown Monster Addin Project**.

* [VSIX and Visual Studio Gallery ](https://marketplace.visualstudio.com/vsgallery/231f13cc-2348-432c-a69f-82e7b725587e)
* [Direct VSIX download](MarkdownMonsterAddinProjectTemplate.vsix)

### Additional Resources
* [Creating a Markdown Monster Addin](https://markdownmonster.west-wind.com/docs/Creating-Markdown-Monster-Addins-with-NET/Creating-a-Markdown-Monster-Add--in.html)
* [Markdown Monster](https://github.com/rickstrahl/MarkdownMonster)
* [Markdown Monster Addin Repository](https://github.com/RickStrahl/MarkdownMonsterAddinsRegistry)
* [Markdown Monster Addin Project in the Visual Studio Gallery](https://marketplace.visualstudio.com/vsgallery/231f13cc-2348-432c-a69f-82e7b725587e)