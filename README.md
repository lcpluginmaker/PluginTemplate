
# LeoConsole-PluginTemplate

Template repository for [LeoConsole](https://github.com/BoettcherDasOriginal/LeoConsole)
plugins. Create LeoConsole plugins more quickly!

## Getting started

 - Click [here](https://github.com/alexcoder04/LeoConsole-PluginTemplate/generate)
   to generate a new repository using this template.
 - Clone your generated repository.
 - Go to `./LeoConsole-PluginTemplate.csproj` and specify the location of your
   `ILeoConsole.dll` file.
 - Check out `./plugin.cs` and `./command.cs` and change the variables/classes
   to your plugin name (the comments in the code will help you).
 - Change project info (project name, homepage, email) in `manifest.json`.
 - Compile your plugin with `dotnet build` (or use Visual Studio's tools) to generate
   the `.dll`-file for testing, use [apkg-builder](https://github.com/alexcoder04/LeoConsole-apkg-builder)
   to generate an installable `.lcp` package archive.
 - Copy the `.dll` file into your LeoConsole's `data/plugins` folder.
 - Test if it works.
 - Have fun developing!
 - Refer to the [LeoConsole wiki](https://github.com/BoettcherDasOriginal/LeoConsole/wiki)
   for more information about plugin writing.
 - Report any bugs or feature requests for this template in the
   [issues](https://github.com/alexcoder04/LeoConsole-PluginTemplate/issues).
 - Either publish your plugin in one of the public repositories or host your own. More info can be found
   [here](https://github.com/alexcoder04/LeoConsole-apkg/blob/main/docs/Repositories.md).
