using System;
using Microsoft.EntityFrameworkCore;
using TodoApi.Entities;

namespace TodoApi.EntityFramework
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        { }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>(entity =>
            {
                entity.HasOne(x=>x.person).WithMany(p => p.TodoItems).HasForeignKey(d => d.PersonId).OnDelete(DeleteBehavior.SetNull);
            });
            /*   modelBuilder.Entity<TodoItem>().HasData(
                        new TodoItem
                        {
                            ItemId=1,
                            Title="Send Email to Mark",
                            Description="Please send the work email to Mark",
                            Pers=new Person { PersonId=1}
                        },
                      new TodoItem
                          {
                              ItemId = 2,
                              Title = "Contact James",
                              Description = "Please contact James for XYZ reasons",
                              Person = new Person { PersonId = 1 }
                      },
                       new TodoItem
                          {
                              ItemId = 3,
                              Title = "Contact James",
                              Description = "Please contact James for XYZ reasons",
                              Person = new Person { PersonId = 2 }
                       },
                       new TodoItem
                       {
                           ItemId = 4,
                           Title = "Please pick up Task2",
                           Description = "Please pick up Task2",
                           Person = new Person { PersonId = 2 }
                       }
                        );
                    modelBuilder.Entity<Person>().HasData(
                        new Person
                        {
                            PersonId = 1,
                            Name = "John Drew",
                            Designation = "Clerk"
                        },
                          new Person
                          {
                              PersonId = 2,
                              Name = "James Dave",
                              Designation = "Engineer"
                          }
                        );*/

        }
    }
}
