using web_project;

namespace web_project.Modules.Logging;
class WarningFeedback : Message
{
  public WarningFeedback(string header = "WARNING") : base(ConsoleColor.Yellow)
  {
    Header = header;
  }
}
