using Microsoft.EntityFrameworkCore;
using BlazorTodo.Model;

namespace BlazorTodo.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Model.Task> Tasks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public AppDbContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=postqwerty");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Model.Task>(builder =>
        //    {
        //        builder.ToTable("Tasks");

        //        builder.Property(task => task.TaskId)
        //        .HasColumnName("TaskId")
        //        .UseSerialColumn()
        //        .UseIdentityColumn()
        //        .UseSequence();
        //    });
        //}
    }
}
