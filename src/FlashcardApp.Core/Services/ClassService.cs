using FlashcardApp.Core.Data;
using FlashcardApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FlashcardApp.Core.Services;

public class ClassService
{
    AppDbContext _db;
    public ClassService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Class>> GetAll()
    {
        return await _db.Classes.ToListAsync();
    }

    public async Task<Class> Create(Class newClass)
    {
        _db.Classes.Add(newClass);
        await _db.SaveChangesAsync();
        return newClass;
    }

}