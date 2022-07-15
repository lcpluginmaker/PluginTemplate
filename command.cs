using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_PluginTemplate
{
  // ----- your command -----
  // TODO: change this to your plugin name
  public class PluginTemplateCommand : ICommand
  {
    // TODO: change these to your command name and description
    public string Name { get { return "plugin-template-test"; } } // this what you type into the console to run the command
    public string Description { get { return "test plugin template"; } } // this is the description in the help command
    public Action CommandFunction { get { return () => Command(); } }
    public Action HelpFunction { get { return () => Help(); } }
    private string[] _Arguments;
    public string[] _Arguments { get { return _Arguments; } set { _Arguments = value; } }
    public IData data = new ConsoleData();

    // --- this is what actually runs ---
    public void Command()
    {
      LConsole.WriteLine("§aHello world!§r"); // colored hello world
    }

    // --- your help message ---
    public void Help()
    {
      LConsole.WriteLine("§aThis plugin prints 'Hello World!'§r");
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
