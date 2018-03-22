# CdaMobileApp

This is a basic template for creating apps themed for the [Xamarin CDAs]().

This repo contains an extension for VS for Mac and a NuGet for use with `dotnet new`.

**To use with Visual Studio for Mac**

* Build the ./VsMacExtension/CdaMobileApp.VsMacExtension.sln project in Release mode, or download the latest [release](https://github.com/jimbobbennett/CdaMobileApp-Template/releases).
* From Visual Studio for Mac, select Visual Studio->Extensions..., Click the __Install from file...__ button then select the mpack file.

After installation you can create a new project from File->New, then select Other->General->CDA Mobile App.

**To use with dotnet new**

The CreateNugets.sh script will build the relevant NuGet package and install it into the dotnet templates.
Once installed you can create a new project using:

```bash
dotnet new CdaMobileApp -o <Your project name>
```