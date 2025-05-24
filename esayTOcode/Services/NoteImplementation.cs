using esayTOcode.Data;
using esayTOcode.Models;
using Microsoft.EntityFrameworkCore;

namespace esayTOcode.Services
{
    public class NoteImplementation : INotesInterface
    {
        private readonly ApplicationDbContext _ApplicationDbContext;

        public NoteImplementation(ApplicationDbContext DbContext)
        {
            _ApplicationDbContext = DbContext;
        }

        public async Task<List<Note>> CreateNote(Note note)
        {
            if (note != null)
            {
                note.NoteDate = DateTime.Now;
                await _ApplicationDbContext.AddAsync(note);
                await _ApplicationDbContext.SaveChangesAsync();
                return [note]; // Fixed the syntax error here
            }

            // Return an empty list if the input note is null
            return [];
        }

        public async Task DeleteNote(int id)
        {
            var note = await _ApplicationDbContext.Notes.FindAsync(id);
            if (note != null)
            {
                _ApplicationDbContext.Notes.Remove(note);
                await _ApplicationDbContext.SaveChangesAsync();
            }
        }
        public async Task<Note?> GetNoteByIdAsync(int id)
        {
            return await _ApplicationDbContext.Notes.FindAsync(id);
        }

        public async Task EditNoteAsync(Note note)
        {
            note.NoteDate = DateTime.Now;
            _ApplicationDbContext.Notes.Update(note);
            await _ApplicationDbContext.SaveChangesAsync();
        }

        
        public async Task<List<Note>> GetNotesAsync()
        {
            return await _ApplicationDbContext.Notes.ToListAsync();
        }
    }
}
