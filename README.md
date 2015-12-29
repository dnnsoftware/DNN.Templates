# DNN8Templates
This is a temporary Home for DNN8 Templates.  These templates are in the process of being migrated to and included in [Chris Hammonds Templates](https://github.com/ChrisHammond/DNNTemplates).

## Public Nuget Server
The solution depends on following DNN Platform 8.0 nuget packages

DotNetNuke.Core

DotNetNuke.Web

DotNetNuke.Web.Mvc

The nuget packages can be downloaded from our public Nuget server (no credentials needed)

https://build.dnnsoftware.com/guestAuth/app/nuget/v1/FeedService.svc/

## Install Package Location
Once compiled in RELEASE mode, the installable packages can be obtained from [SOURCE_FOLDER]\Install folder

Following packages are created:

1. DnnSpaModule_00.00.01_Install.zip

2. DnnSpaModule_00.00.01_source.zip

3. DnnMvcModule_00.00.01_Install.zip

4. DnnMvcModule_00.00.01_source.zip


## Download Intall Packages without Compiling

You may download both the MVC and SPA install-packages without compiling from:

The zip file can be downloaded by clicking the link to zip files individually and then clicking the Raw button to download

https://github.com/dnnsoftware/DNN.Templates/tree/master/src/DnnMvcModule/install
https://github.com/dnnsoftware/DNN.Templates/tree/master/src/DnnSpaModule/install

## Download latest version of DNN Platform

You may download the latest version of DNN Platform by either

1. Going directly to the DNN's Team City build server. Login as Guest and go into Packaging step. Download the DNN_Platform_XXXX_Install.zip file from Artifact area. 

https://build.dnnsoftware.com

2. Get from nightly build 

http://www.dnnsoftware.com/platform/build/nightly-builds

DNN's build server (1 above) will get you the latest version of the installation package of DNN Platform.
