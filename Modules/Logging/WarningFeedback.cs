using web_project;

class WarningFeedback : Message
{
  public WarningFeedback(string header = "WARNING") : base(ConsoleColor.Yellow)
  {
    Header = header;
  }
}
