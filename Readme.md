# Markdown Monster Addin Project Visual Studio Template

<img src="MarkdownMonster_Icon_256.png" width="150"/>

## Create new Markdown Monster Addins From Visual Studio
This project contains a Visual Studio Project Template to create a new Markdown Monster Addin. It adds a new project type to Visual Studio that lets you create a new, ready to run Markdown Monster Addin project:

![](NewVSProjectScreenShot.png)


## Extension Installation
You can install the Visual Studio Extension from:

*  [Visual Studio Extension Manager](https://marketplace.visualstudio.com/vsgallery/231f13cc-2348-432c-a69f-82e7b725587e)  
Use the built in Visual Studio Extension Manager via the **Extensions -> Manage Extension** menu. To install look for Online Extensions and install the **Markdown Monster Addin Project** Extension.

* [Download and Install the VSIX](https://github.com/RickStrahl/MarkdownMonsterAddinProjectTemplate/raw/master/MarkdownMonsterAddinProjectVsix/bin/Release/MarkdownMonsterAddinProjectTemplate.vsix)    
You can also download and install the VSIX directly from the Git repository. Click the link to download the VSIX file, and execute `MarkdownMonsterAddinProjectTemplate.vsix` from Explorer by double clicking.


## Requirements

### .NET 4.7.2 Project Required
Markdown Monster Addins have to be built against .NET 4.7.2 or newer, as 4.7.2 is the base version that Markdown Monster is built against. The dependencies in the addin project require the same runtime version or newer in order to bind to the Markdown Monster host assembly.

The Addin automatically creates a project that is configured for the correct version required for Markdown Monster (4.7.2 currently).

### Visual Studio Versions and Editions
This Visual Studio Extension works for:

* Visual Studio 2019 
* Visual Studio 2017 

Supported Visual Studio Editions:

* Community
* Professional
* Enterprise

### Additional Resources
* [Creating a Markdown Monster Addin](http://markdownmonster.west-wind.com/docs/_4ne0s0qoi.htm)
* [Markdown Monster](https://github.com/rickstrahl/MarkdownMonster)
* [Markdown Monster Addin Repository](https://github.com/RickStrahl/MarkdownMonsterAddinsRegistry)
* [Markdown Monster Addin Project in the Visual Studio Gallery](https://marketplace.visualstudio.com/vsgallery/231f13cc-2348-432c-a69f-82e7b725587e)

