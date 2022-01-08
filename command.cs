using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_apkg
{
  // change this to your plugin name
  public class PluginTemplateCommand : ICommand
  {
    // change these to your command name and description
    public string Name { get { return "plugin-template-test"; } }
    public string Description { get { return "test plugin template"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }
    public IData data = new ConsoleData();

    public void Command() {
      // this is what runs if you run the command
      Console.WriteLine("hello world");
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
