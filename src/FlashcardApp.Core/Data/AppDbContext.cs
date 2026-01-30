using Microsoft.EntityFrameworkCore;
using FlashcardApp.Core.Models;

namespace FlashcardApp.Core.Data;

public class AppDbContext : DbContext 
{
    public DbSet<Flashcard> Flashcards { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=../FlashcardApp.Core/Data/flashcards.db");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}