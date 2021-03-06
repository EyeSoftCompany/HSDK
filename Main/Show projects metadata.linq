<Query Kind="Program">
  <NuGetReference>ByteDev.DotNet</NuGetReference>
  <Namespace>ByteDev.DotNet.Project</Namespace>
</Query>

void Main()
{
	new DirectoryInfo(@"D:\Github\Es.HSDK\Main")
		.GetFiles("*.csproj", SearchOption.AllDirectories)
		.Where(x => x.Directory.GetFiles("*.nupkg", SearchOption.AllDirectories).Any())
		.Select(x => new { x.Name, Project = DotNetProject.Load(x.FullName) })
		.Select(x => new { x.Name, x.Project, x.Project.AssemblyInfo, x.Project.NugetMetaData })
		.Dump();
}