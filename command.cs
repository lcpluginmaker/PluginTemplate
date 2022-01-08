using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_apkg
{
  // ----- your command -----
  // change this to your plugin name
  public class PluginTemplateCommand : ICommand
  {
    // change these to your command name and description
    public string Name { get { return "plugin-template-test"; } } // this what you type into the console to run the command
    public string Description { get { return "test plugin template"; } } // this is the description in the help command
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }
    public IData data = new ConsoleData();

    // --- this is what actually runs ---
    public void Command() {
      Console.WriteLine("hello world");
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
