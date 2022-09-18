using web_project.Modules.Logging;

namespace web_project
{
  public class ProjectManager
  {
    private string _configFilename = ".config.txt";
    public ProjectManager(string[] commandLine, Message infoLog, Message warningLog, Message errorLog)
    {
      Config = new Configuration(_configFilename);
      CommandLine = commandLine;
      InfoLog = infoLog;
      WarningLog = warningLog;
      ErrorLog = errorLog;
      try
      {
        BaseDirectory = Config.GetConfig("BasePath");
      }
      catch (System.Exception ex)
      {
        ErrorLog.LogMessage(ex.Message);
      }
    }

    #region props
    public string[] CommandLine { get; } = { };
    public string BaseDirectory { get; set; } = string.Empty;
    public string ProjectDirectory { get; set; } = string.Empty;
    public Configuration Config { get; set; }
    public IFeedback InfoLog { get; }
    public IFeedback WarningLog { get; }
    public IFeedback ErrorLog { get; }
    #endregion

    public bool CreateDirectories()
    {
      bool ret = true;
      if (CommandLine.Count() > 0 && CommandLine != null)
      {
        try
        {
          ProjectDirectory = CommandLine[0];
          if (Directory.Exists(Path.Combine(BaseDirectory, ProjectDirectory)))
          {
            throw new Exception($"Directory '{Path.Combine(BaseDirectory, ProjectDirectory)}' already exists!");
          }
          Directory.CreateDirectory(Path.Combine(BaseDirectory, ProjectDirectory));
        }
        catch (System.Exception ex)
        {
          ErrorLog.LogMessage($"An error occured: {ex.Message}");
          return false;
        }
        InfoLog.LogMessage($"Created directory: {Path.Combine(BaseDirectory, ProjectDirectory)}");

      }
      else
      {
        BaseDirectory = "./";
      }

      return ret;
    }
  }
}