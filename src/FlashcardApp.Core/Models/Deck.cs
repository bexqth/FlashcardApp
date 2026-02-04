using System;

namespace FlashcardApp.Core.Models;

public class Deck
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string DeckName { get; set; } = string.Empty;
    public string HexColor { get; set; } = string.Empty;
    public Guid ClassId;

    public required Class Class;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}