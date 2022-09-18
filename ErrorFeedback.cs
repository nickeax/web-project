using web_project;

class ErrorFeedback : Message
{
  public ErrorFeedback(string header = "ERROR") : base(ConsoleColor.Red)
  {
    Header = header;
  }
}
