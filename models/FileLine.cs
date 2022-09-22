namespace web_project.models;

public class FileLine
{
  public string LineClassification { get; set; }
  public FileLine(string classification)
  {
    LineClassification = classification;
  }
}