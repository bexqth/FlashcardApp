using Microsoft.EntityFrameworkCore;
using FlashcardApp.Core.Models;

namespace FlashcardApp.Core.Data;

public class AppDbContext : DbContext 
{
    public DbSet<Flashcard> Flashcards { get; set; } = null!;
    public DbSet<Class> Classes {get;set;} = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        
    }

    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlite("Data Source=../FlashcardApp.Core/Data/flashcards.db");

        return new AppDbContext(optionsBuilder.Options);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=../FlashcardApp.Core/Data/flashcards.db");
        }
    }

    
}