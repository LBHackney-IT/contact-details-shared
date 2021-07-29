# Hackney.Shared.ContactDetails
At Hackney, we have created the NuGet Package to prevent the duplication of common code when implementing our APIs.
Hence this NuGet package will store the shared contact details code that can then be used in the relevant projects. 

#### CircleCI Pipeline - Versioning
At present the pipeline does not automatically update the package version number.

**This means that for the NuGet Push command to work when code is merged to the release branch 
you must change the version number in the .csproj file according to the type of change you are making.**

The new version number should use the following format.

    A specific version number is in the form Major.Minor.Patch[-Suffix], where the components have the following meanings:

    Major: Breaking changes
    Minor: New features, but backward compatible
    Patch: Backwards compatible bug fixes only
    Suffix (optional): a hyphen followed by a string denoting a pre-release version

## Using the package
For full details on how to use the package(s) within this repository please read 
[this wiki page](https://github.com/LBHackney-IT/lbh-core/wiki/Using-the-package(s)-from-the-Hackney.Core-repository).

## Features

The following features are implemented within this package.
* [Sns](#Sns)
  * [Sns Gateway](#Sns-Gateway)

### Sns
#### Sns Gateway
The `SnsGateway` implementation of the `ISnsGateway` interface allows the easy publishing of an event message to an Sns topic.
The `ISnsGateway` interface is made available by using the `AddSnsGateway()` extension method during your application start-up.

