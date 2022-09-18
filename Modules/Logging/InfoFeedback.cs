using web_project;

namespace web_project.Modules.Logging;

class InfoFeedback : Message
{
  public InfoFeedback(string header = "INFO") : base(ConsoleColor.Blue)
  {
    Header = header;
  }
}
