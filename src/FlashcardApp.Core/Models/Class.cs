using System;

namespace FlashcardApp.Core.Models;

public class Class
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string ClassName { get; set; } = string.Empty;
    public string HexColor { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}