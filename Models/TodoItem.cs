using NuGet.Packaging.Signing;

namespace TodoApi.Models;

public class TodoItem
{
  public long Id { get; set; }
  public string? TodoText { get; set; }
  public DateTime CompletionDate { get; set; }
  public bool CompleteFlg { get; set; }
  public Timestamp? CompleteTimeStamp;
}