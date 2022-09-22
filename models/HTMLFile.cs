namespace web_project.models;
public class HTMLFile
{
  private string[] boilerPlate = { "DOCTYPE", "HTML", "HEAD", "META", "TITLE", "BODY" };
  public string Filename { get; set; } = string.Empty;
  public string Content { get; set; }
  public List<FileLine> Lines { get; set; } = new List<FileLine>();
  public HTMLFile(HTMLContent htmlc)
  {
    Content = htmlc.Content;
    BuildLines();
  }

  private void BuildLines()
  {
    foreach (var line in Content.Split('\n'))
    {
      var c = ClassifyLine(line);

      if (Lines.Find(l => l.LineClassification.ToUpper().Equals(c.ToUpper())) == null)
      {
        Lines.Add(new FileLine(c));
      }
    }
  }
  private string ClassifyLine(string line)
  {
    foreach (var bp in boilerPlate)
    {
      if (line.ToUpper().IndexOf(bp.ToUpper()) != -1)
      {
        return bp;
      }
    }

    return string.Empty;
  }
}
