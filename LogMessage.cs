using System;

namespace web_project
{
  public class LogMessage
  {
    public LogMessage(string msg)
    {
      Message = msg;
      MessageTime = DateTime.Now;
    }
    public Guid Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime MessageTime { get; set; }
    public string Display()
    {
      return $"[{MessageTime.ToString("m")}] {Message}";
    }
  }
}