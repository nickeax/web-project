namespace web_project.Modules;
public class Configuration
{
  private List<string> _configurationTypes = new List<string>();
  private Dictionary<string, string> Configurations { get; set; } = new Dictionary<string, string>();

  public Configuration(string filename)
  {
    _configurationTypes.Add("BasePath");
    string fileText = string.Empty;
    if (File.Exists(filename))
      try
      {
        fileText = File.ReadAllText(filename);
      }
      catch (System.Exception ex)
      {
        throw (ex);
      }

    BuildConfigs(fileText);
  }
  private void BuildConfigs(string fromFile)
  {
    var fileLines = fromFile.Split('\n');

    if (fileLines.Length < 1)
    {
      throw (new Exception("The confifuration file contains no data."));
    }

    foreach (var fileLine in fileLines)
    {
      var splitVals = fileLine.Split('|');
      if (splitVals.Count() < 2)
      {
        throw (new Exception("The configuration file is corrupted or contains incorrect data."));
      }

      Configurations.Add(splitVals[0], splitVals[1]);
    }

  }

  public string GetConfig(string config)
  {
    if (Configurations.ContainsKey(config))
    {
      return Configurations[config];
    }
    else throw (new Exception($"{config} is not contained in the configuration file."));
  }
}