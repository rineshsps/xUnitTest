dotnet add package  coverlet.collector
dotnet add package coverlet.msbuild
dotnet add package dotnet add package coverlet.msbuild
dotnet tool install -g dotnet-reportgenerator-globaltool

dotnet test
##dotnet test /p:CollectCoverage=true /p:CoverletOutput=TestResults/ /p:CoverletOutputFormat=lcov
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:Exclude="[xunit*]\*" /p:CoverletOutput="./TestResults/"
ReportGenerator.exe -reports:testresults\coverage.cobertura.xml -targetdir:coveragereport



    <PackageReference Include="ReportGenerator" Version="4.5.8" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.5.0" />
    <PackageReference Include="MSTest.TestAdapter" Version="2.1.0" />
    <PackageReference Include="MSTest.TestFramework" Version="2.1.0" />
    <PackageReference Include="coverlet.collector" Version="1.2.1">
    <PackageReference Include="coverlet.msbuild" Version="2.8.1">

https://gunnarpeipman.com/aspnet-core-code-coverage/
https://www.tonyranieri.com/blog/2019/07/31/Measuring-.NET-Core-Test-Coverage-with-Coverlet/