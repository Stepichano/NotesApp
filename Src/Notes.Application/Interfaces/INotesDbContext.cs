using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Notes.Domain;

namespace Notes.Application.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
