namespace web_project.Modules.Logging
{
  public class Message : IFeedback
  {
    public Message(ConsoleColor color)
    {
      DisplayColour = color;
    }
    public ConsoleColor DisplayColour { get; set; }
    public List<LogMessage> Messages { get; set; } = new List<LogMessage>();
    public string Header { get; set; } = string.Empty;
    public void Display()
    {
      ConsoleColor defaultColor = Console.ForegroundColor;
      foreach (var msg in Messages)
      {
        Console.ForegroundColor = DisplayColour;
        System.Console.WriteLine($"{Header}{msg.Display()}");
        Console.ForegroundColor = defaultColor;
      };
    }

    public void LogMessage(string msg)
    {
      Messages.Add(new LogMessage(msg));
    }
  }
}