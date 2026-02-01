using FlashcardApp.Core.Data;
using FlashcardApp.Core.Models;

namespace FlashcardApp.Core.Services;

public class ClassService
{
    AppDbContext _db;
    public ClassService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<Class> Create(Class newClass)
    {
        _db.Classes.Add(newClass);
        await _db.SaveChangesAsync();
        return newClass;
    }

}