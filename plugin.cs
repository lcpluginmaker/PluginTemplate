using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

// make sure the namespace is consistent over all files (don't forget the .csproj file!)
namespace LeoConsole_PluginTemplate
{

  // ----- data from running LeoConsole instance -----
  public class ConsoleData : IData
  {
    public static User _User;
    public User User { get { return _User; } set { _User = value; } }
    public static string _SavePath;
    public string SavePath { get { return _SavePath; } set { _SavePath = value; } }
    public static string _DownloadPath;
    public string DownloadPath { get { return _DownloadPath; } set { _DownloadPath = value; } }
  }
  
  // ----- main plugin class -----
  // change this to your plugin name
  public class PluginTemplate : IPlugin
  {
    // change this to your plugin name and description
    public string Name { get { return "plugin template"; } }
    public string Explanation { get { return "a template to create LeoConsole plugins more quickly"; } }
    
    private IData _data;
    public IData data { get { return _data; } set { _data = value; } }
    
    private List<ICommand> _Commands;
    public List<ICommand> Commands { get { return _Commands; } set { _Commands = value; } }
    
    public void PluginMain() {
      // --- get data from LeoConsole ---
      _data = new ConsoleData();
      
      // --- register commands ---
      _Commands = new List<ICommand>();
      // change this to your plugin name (same as in command.cs)
      _Commands.Add(new PluginTemplate());
    }
  }
}

// this tells vim to use 2 spaces instead of tabs VIM rules XD
// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
