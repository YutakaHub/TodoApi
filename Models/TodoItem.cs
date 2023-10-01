using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

public class TodoItem
{
  public long Id { get; set; }

  [Required]
  [StringLength(100)]
  public string? TodoText { get; set; }
  public DateTime? CompletionDate { get; set; }
  public bool CompleteFlg { get; set; }
  public DateTime? CompleteDateTime { get; set; }
}