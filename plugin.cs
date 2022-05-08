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
    public static string _Version;
    public string Version { get { return _Version; } set { _Version = value; } }
    public static string _CurrentWorkingPath;
    public string CurrentWorkingPath { get { return _CurrentWorkingPath; } set { _CurrentWorkingPath = value; } }

  }
  
  // ----- main plugin class -----
  // TODO: change this to your plugin name
  public class PluginTemplate : IPlugin
  {
    // TODO: change this to your plugin name and description
    public string Name { get { return "plugin template"; } }
    public string Explanation { get { return "a template to create LeoConsole plugins more quickly"; } }
    
    private IData _data;
    public IData data { get { return _data; } set { _data = value; } }
    
    private List<ICommand> _Commands;
    public List<ICommand> Commands { get { return _Commands; } set { _Commands = value; } }
    
    // this runs as your plugin is loaded
    public void PluginInit()
    {
    }
    
    // this runs as data got registered
    public void PluginMain()
    {
      // --- get data from LeoConsole ---
      _data = new ConsoleData();
      
      // --- register commands ---
      _Commands = new List<ICommand>();
      // TODO: change this to your plugin name (same as in command.cs)
      _Commands.Add(new PluginTemplate());
    }
    
    // this runs as LeoConsole is about to shut down
    public void PluginShutdown()
    {
    }
  }
}

// this tells vim to use 2 spaces instead of tabs, otherwise it's too wide for my taste, but you can adjust it to your needs
// if you don' use vim, ignore this, but VIM rules XD
// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
