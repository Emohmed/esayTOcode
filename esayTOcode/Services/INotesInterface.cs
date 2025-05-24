using esayTOcode.Models;

namespace esayTOcode.Services
{
    public interface INotesInterface
    {
        public Task<List<Note>> GetNotesAsync();
        public Task<List<Note>> CreateNote(Note note);
        public Task DeleteNote(int Id);

        public Task<Note?> GetNoteByIdAsync(int id);
        public Task EditNoteAsync(Note note);
            // باقي الدوال...
        
    }
}

