Open-XML-SDK
============

[![NuGet](https://img.shields.io/nuget/v/DocumentFormat.OpenXml.svg)]()
[![Downloads](https://img.shields.io/nuget/dt/DocumentFormat.OpenXml.svg)]()
[![master](https://img.shields.io/appveyor/ci/openxmlsdk/Open-XML-SDK/master.svg)]()

The Open XML SDK provides tools for working with Office Word, Excel, and PowerPoint documents. It supports scenarios such as:

- High-performance generation of word-processing documents, spreadsheets, and presentations.
- Populating content in Word files from an XML data source.
- Splitting up (shredding) a Word or PowerPoint file into multiple files, and combining multiple Word/PowerPoint files into a single file.
- Extraction of data from Excel documents.
- Searching and replacing content in Word/PowerPoint using regular expressions.
- Updating cached data and embedded spreadsheets for charts in Word/PowerPoint.
- Document modification, such as removing tracked revisions or removing unacceptable content from documents.

The Release Package on Nuget.org
================================
The official release NuGet packages for Open XML SDK are available on Nuget.org at https://www.nuget.org/packages/DocumentFormat.OpenXml. 

The Latest Builds
=================

## Where to get the NuGet packages of the latest builds?
The NuGet package for the latest builds of the Open XML SDK is available as a custom feed on MyGet. You can trust this package source, since the custom feed is locked and only this project feeds into the source.

## Support platforms
This library supports many platforms. There are builds for .NET 3.5, .NET 4.0, .NET 4.6, and .NET Standard 1.3. The following platforms are currently supported:

|    Platform     | Minimum Version |
|-----------------|-----------------|
| .NET Framework  | 3.5             |
| .NET Core       | 1.0             |
| UWP             | 10.0            |
| Mono            | 3.5             |
| Xamarin.iOS     | 10.0            |
| Xamarin.Mac     | 3.0             |
| Xamarin.Android | 7.0             |

## WindowsBase or System.IO.Packaging
There is a known issue in WindowsBase that causes crashes when handling large data sources. This is fixed in later versions of the library, based on the platform availability of the `System.IO.Packaging` package. When possible, we use this package instead of WindowsBase. This not only fixes the crash seen by some users, but is available cross platform. However, it is only available on .NET Standard 1.3+ and .NET Framework 4.6+. For this reason, the NuGet package has multiple targets to bring in this when possible. The targets (which are determined by NuGet at installation and build time) are:

| Platform      | System.IO.Packing Source | Tested by     |
| --------      | ------------------------ | ------------- |
| .NET 3.5      | WindowsBase              | N/A           |
| .NET 4.0      | WindowsBase              | .NET 4.5.2    |
| .NET 4.6      | NuGet                    | .NET 4.6      |
| .NET Standard | NuGet                    | .NET Core 1.0 |

Keep in mind, though, that the System.IO.Packaging on .NET 4.6+ is simply a facade over WindowsBase, and thus everything running on .NET 4.6 will use WindowsBase instead of the newer implementation.

## How to install the NuGet package?
The package you want to install is DocumentFormat.OpenXml. 

NuGet packages are available for [release builds](https://www.nuget.org/packages/DocumentFormat.OpenXml) or [CI Builds](https://dotnet.myget.org/gallery/open-xml-sdk) and follow [semantic versioning](http://www.semver.org/).

The package feed or the package source is specified by the feed URL. Depending on your version of Visual Studio, choose the appropriate feed URL from the table below. 

Table 1: The latest builds are available via a MyGet feed

| Client | Feed URL |
| ------ | -------- |
| NuGet V3 (Visual Studio 2015+) | https://dotnet.myget.org/F/open-xml-sdk/api/v3/index.json |
| NuGet V2 (Visual Studio 2012+) | https://dotnet.myget.org/F/open-xml-sdk/api/v2 |

The **Install-Package** command considers the package source either via configuration or argument. Also the package version can vary. For the latest version info, see https://dotnet.myget.org/feed/open-xml-sdk/package/nuget/DocumentFormat.OpenXml 

- To specify the package source via a configuration option, see https://docs.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior. Note that usually a NuGet.config file is placed in the directory and the configuration options are added there to ensure the sources are persisted in the version control.

	```
	PM> Install-Package DocumentFormat.OpenXml -Version <version retrieved from the web>
	```

- To pass the feed URL as an argument, here is an example for Visual Studio 2015 and later. 

	```
	PM> Install-Package DocumentFormat.OpenXml -Version <version retrieved from the web> -Source https://dotnet.myget.org/F/open-xml-sdk/api/v3/index.json 
	```

**Note**:  If you have trouble installing the package, try restarting Visual Studio. Package sources could be cached, and changes you've made to any NuGet.config files may not be detected.

Having Problems?
================

If you want to report a problem (bug, behavior, build, distribution, feature request, etc... ) with the SDK built by this repository, please feel free to post a new issue and the someone will try to help out.

If you have "how-to" questions please post to one of the following resources: 

- https://social.msdn.microsoft.com/Forums/office/en-US/home?forum=oxmlsdk
- http://stackoverflow.com (tags: "openxml" or "openxml-sdk")

Known Issues
==========
- On Mono platforms that use the System.IO.Package NuGet package (ie Xamarin), opening some documents will fail due to an [issue](https://github.com/dotnet/corefx/issues/24822) in System.IO.Packaging. For now, you must manually set the environment variable as described at the [Mono description](http://www.mono-project.com/docs/faq/known-issues/urikind-relativeorabsolute/)
- On .NET Core, zip packages do not have a way to stream data. Thus, the working set can explode in certain situations. This is a [known issue](https://github.com/dotnet/corefx/issues/24457)
- On .NET Framework, an IsolatedStorageException may be thrown under certain circumstances, generally when manipulating a large document in an environment with an AppDomain that does not have enough evidence.
- Out of the box, the library will not compile on .NET Native. This [issue](https://github.com/OfficeDev/Open-XML-SDK/issues/181) is tracking this

Once System.IO.Packaging on .NET Core has feature parity with WindowsBase (ie streaming support), we can investigate using the new .NET Core on .NET Framework

Change Log
==========

Version 2.8.0 : *In development*
- Added default runtime directive for better .NET Native support
- Fixed exceptions thrown when errors are encountered while opening packages to be consistent across platforms
- Fixed issue on Mono platforms using System.IO.Packaging NuGet package (Xamarin, etc) when creating a document
- Fixed manual saving of a package when autosave is false
- Fixed schema constraint data and standardized serialization across platforms
- Upgraded to System.IO.Packaging 4.4.0 which fixes some consistency with .NET Framework in opening packages
 
Version 2.7.2 : June 6, 2017
- Fixed issue where assembly version wasn't set in assembly
- Added support for .NET 3.5 and .NET 4.0

Version 2.7.1 : January 31, 2017
- Fixed crash when validation is invoked on .NET Framework with strong-naming enforced

Version 2.7.0 : January 24, 2017
- Added support for .NET Standard 1.3
- Moved to using System.IO.Packaging from dotnet/corefx for .NET Standard 1.3 and WindowsBase for .NET 4.5
- Cleaned up project build system to use .NET CLI

Version 2.6.1 : January 15, 2016
- Added hundreds of XUnit tests.  There are now a total of 1333 tests.  They take about 20 minutes to run, so be patient.

Version 2.6.0 : June 29, 2015
- The big feature in 2.6 is the inclusion of a replacement for System.IO.Packaging, which has a serious bug that causes it (albeit rarely and in specific circumstances) to throw exceptions (ObjectDisposedException and NullReferenceException).  You can find out more about this bug and whether it affects you in [the blog post that announces the release of the new System.IO.Packaging] (http://openxmldeveloper.org/blog/b/openxmldeveloper/archive/2015/06/29/announcing-the-release-of-a-new-system-io-packaging-implementation.aspx).


Documentation
=============

The functionality of the specific classes in Open XML SDK Version 2.7.0 is similar to version 2.5, therefore the documentation available on MSDN is still accurate.

[Open XML SDK 2.5 for Office](http://msdn.microsoft.com/en-us/library/office/bb448854.aspx)

In addition to open sourcing of the SDK, Microsoft has opened up the conceptual documentation for public review / contributions.  A copy of the documentation is [now in GitHub](https://github.com/OfficeDev/office-content) for you to edit and review.

Build Instructions
==================

This project uses the new csproj format and the release versions of the tooling in Visual Studio 2017. For more information on how to use this project type to build your project, see the release notes for Visual Studio 2017: https://www.visualstudio.com/en-us/news/releasenotes/vs2017-relnotes#dotnetcore. Other editors that support the latest .NET project files include VS Code, VS for Mac, or .NET CLI. See https://www.microsoft.com/net/download/core for details.

To build the Open XML SDK:
- Clone the repo at https://github.com/OfficeDev/Open-XML-SDK
- Open the solution with an editor that supports the latest .NET project files
- Build the solution (using either Debug or Release configuration)
- Run the Xunit tests to verify the installation

If you want to use a command line approach:
- Go to the directory the solution is in
- Run `dotnet restore` in the directory
- Run `dotnet test DocumentFormat.OpenXml.Tests` to run the tests
- Run `dotnet pack DocumentFormat.OpenXml` to generate a nupkg

Related tools
====

- **Open XML Powertools**: This is available on [Github](https://github.com/OfficeDev/Open-Xml-PowerTools) and provides example code and guidance for implementing a wide range of Open XML scenarios.
