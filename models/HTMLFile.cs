namespace web_project.models;
public class HTMLFile
{
  public string Filename { get; set; } = string.Empty;
  public string Content { get; set; }
  public List<string> Lines { get; set; } = new List<string>();
  public HTMLFile(HTMLContent htmlc)
  {
    Content = htmlc.Content;
    BuildLines();
  }

  private void BuildLines()
  {
    foreach (var line in Content.Split('\n'))
    {
      Lines.Add(line);
    }
  }
}