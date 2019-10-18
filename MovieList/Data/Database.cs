using System.Collections.Generic;
using System.Threading.Tasks;
using MovieList.Models;
using SQLite;

namespace MovieList.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Note>().Wait();
        }

        //public Task<List<Movie>> GetMoviesAsync()
        //{
        //    return _database.Table<Movie>().ToListAsync();
        //}

        //public Task<Movie> GetMovieAsync(int id)
        //{
        //    return _database.Table<Movie>()
        //                    .Where(i => i.ID == id)
        //                    .FirstOrDefaultAsync();
        //}

        //public Task<int> SaveMovieAsync(Movie movie)
        //{
        //    if (movie.ID != 0)
        //    {
        //        return _database.UpdateAsync(movie);
        //    }
        //    else
        //    {
        //        return _database.InsertAsync(movie);
        //    }
        //}

        //public Task<int> DeleteMovieAsync(Movie movie)
        //{
        //    return _database.DeleteAsync(movie);
        //}

        //public Task<List<Credit>> GetCreditsAsync()
        //{
        //    return _database.Table<Credit>().ToListAsync();
        //}
        
        //public Task<Credit> GetCreditAsync(int id)
        //{
        //    return _database.Table<Credit>()
        //                    .Where(i => i.ID == id)
        //                    .FirstOrDefaultAsync();
        //}

        //public Task<int> SaveCreditAsync(Credit credit)
        //{
        //    if (credit.ID != 0)
        //    {
        //        return _database.UpdateAsync(credit);
        //    }
        //    else
        //    {
        //        return _database.InsertAsync(credit);
        //    }
        //}

        //public Task<int> DeleteCreditAsync(Credit credit)
        //{
        //    return _database.DeleteAsync(credit);
        //}

        public Task<List<Note>> GetNotesAsync()
        {
            return _database.Table<Note>().ToListAsync();
        }

        public Task<int> SaveNoteAsync(Note note)
        {
            if (note.ID != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(Note note)
        {
            return _database.DeleteAsync(note);
        }
    }
}
