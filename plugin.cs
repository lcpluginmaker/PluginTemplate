using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

// change this to your plugin name
namespace LeoConsole_PluginTemplate
{

  public class ConsoleData : IData
  {
    public static User _User;
    public User User { get { return _User; } set { _User = value; } }
    public static string _SavePath;
    public string SavePath { get { return _SavePath; } set { _SavePath = value; } }
    public static string _DownloadPath;
    public string DownloadPath { get { return _DownloadPath; } set { _DownloadPath = value; } }
  }
  
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
      // get data from LeoConsole
      _data = new ConsoleData();
      
      // register commands
      _Commands = new List<ICommand>();
      // change this to your plugin name
      _Commands.Add(new PluginTemplate());
    }
  }
}

// this says vim to use 2 spaces instead of tabs
// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
