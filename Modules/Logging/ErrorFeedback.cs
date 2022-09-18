using web_project;

namespace web_project.Modules.Logging;

class ErrorFeedback : Message
{
  public ErrorFeedback(string header = "ERROR") : base(ConsoleColor.Red)
  {
    Header = header;
  }
}
