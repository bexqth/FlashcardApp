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
    
}