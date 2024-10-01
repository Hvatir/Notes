using Microsoft.EntityFrameworkCore;
namespace Notes.Data;

public class NotesDbContext : DbContext
{
    public DbSet<Note> Notes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=NotesDB;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
    }
}
