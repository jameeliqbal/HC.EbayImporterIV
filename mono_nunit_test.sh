#!/usr/bin/env bash
#
# Generated by: https://github.com/swagger-api/swagger-codegen.git
#

wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mozroots --import --sync

echo "[INFO] remove bin/Debug/SwaggerClientTest.dll"
rm src/EBay.OAS3v1IV.Test/bin/Debug/EBay.OAS3v1IV.Test.dll 2> /dev/null

echo "[INFO] install NUnit runners via NuGet"
wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mozroots --import --sync
mono nuget.exe install src/EBay.OAS3v1IV.Test/packages.config -o packages

echo "[INFO] Install NUnit runners via NuGet"
mono nuget.exe install NUnit.Runners -Version 2.6.4 -OutputDirectory packages 

echo "[INFO] Build the solution and run the unit test"
xbuild EBay.OAS3v1IV.sln && \
    mono ./packages/NUnit.Runners.2.6.4/tools/nunit-console.exe src/EBay.OAS3v1IV.Test/bin/Debug/EBay.OAS3v1IV.Test.dll
