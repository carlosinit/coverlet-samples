#addin "nuget:?package=Cake.Coverlet&version=2.5.1"

var target = Argument("target", "SonarEnd");
var configuration = Argument("configuration", "Release");
var sonarUrl = "http://localhost:9000";
var sonarKey = "CoverletSamples";
var sonarToken = "c19e6472f483b52ff7de12ed9630261babb8aae0";

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////
Task("SonarBegin")
    .Does(()=>
{
    DotNetCoreTool(
        "sonarscanner",
        new DotNetCoreToolSettings
        {
            ArgumentCustomization = builder => builder
                .Append("begin")
                .Append($"/k:\"{sonarKey}\"")
                .Append($"/d:sonar.login=\"{sonarToken}\"")
                .Append($"/d:sonar.host.url={sonarUrl}")
                .Append("/d:sonar.cs.opencover.reportsPaths=\"**\\coverage.opencover.xml\"")
                .Append("/d:sonar.qualitygate.wait=true")
        });
});

Task("SonarEnd")
    .IsDependentOn("Test")
    .Does(()=>
{
    DotNetCoreTool(
        "sonarscanner",
        new DotNetCoreToolSettings
        {
            ArgumentCustomization = builder => builder
                .Append("end")
                .Append($"/d:sonar.login=\"{sonarToken}\"")
        });
});

Task("Build")
    .IsDependentOn("SonarBegin")
    .Does(() =>
{
    DotNetCoreBuild("./CoverletSamples.sln", new DotNetCoreBuildSettings
    {
        Configuration = configuration,
    });
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
    DotNetCoreTest("./CoverletSamples.sln", new DotNetCoreTestSettings
    {
        Configuration = configuration,
        NoBuild = true,
    }, new CoverletSettings
    {
        CollectCoverage = true,
        CoverletOutputFormat = CoverletOutputFormat.opencover
    });
});

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);