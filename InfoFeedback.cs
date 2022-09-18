using web_project;

class InfoFeedback : Message
{
  public InfoFeedback(string header = "INFO") : base(ConsoleColor.Blue)
  {
    Header = header;
  }
}
