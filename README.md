
# LeoConsole-PluginTemplate

Template repository for [LeoConsole](https://github.com/BoettcherDasOriginal/LeoConsole)
plugins. Create LeoConsole plugins more quickly!

## Getting started

 - Click [here](https://github.com/lcpluginmaker/PluginTemplate/generate)
   to generate a new repository using this template.
 - Clone your generated repository.
 - Go to `./LeoConsole-PluginTemplate.csproj` and specify the location of your
   `ILeoConsole.dll` file.
 - Check out `./plugin.cs` and `./command.cs` and change the variables/classes
   to your plugin name (the comments in the code will help you).
 - Change project info (project name, homepage, email) in `manifest.json`.
 - Compile and install your plugin by typing `apkg get-local <plugin-folder>` inside LeoConsole.
 - Restart LeoConsole
 - Test if it works.
 - Have fun developing!
 - Refer to the [LeoConsole wiki](https://github.com/BoettcherDasOriginal/LeoConsole/wiki)
   for more information about plugin writing.
 - Report any bugs or feature requests for this template in the
   [issues](https://github.com/lcpluginmaker/PluginTemplate/issues).
 - Either publish your plugin in one of the public repositories or host your own. More info can be found
   [here](https://github.com/lcpluginmaker/apkg/blob/main/docs/Repositories.md).
