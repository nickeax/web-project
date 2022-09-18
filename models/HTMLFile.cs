namespace web_project.models
{
  public class HTMLFile
  {
    public string Filename { get; set; } = string.Empty;
    public string Content { get; set; }
    public HTMLFile()
    {
      Content = @"
            <html></html>
            ";
    }
  }
}