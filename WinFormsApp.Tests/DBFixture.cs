using Microsoft.EntityFrameworkCore;
using System;
using WinFormsApp.ORM;

public class DatabaseFixture : IDisposable
{
    public DbContextOptions<AuthContext> Options { get; private set; }

    public DatabaseFixture()
    {
        Options = new DbContextOptionsBuilder<AuthContext>()
            .UseInMemoryDatabase(databaseName: "a")
            .Options;

        using (var context = new AuthContext(Options))
        {
            context.Database.EnsureCreated();
            SeedDatabase(context);
        }
    }

    private void SeedDatabase(AuthContext context)
    {
        context.Customers.Add(new Customers
        {
            Login = "login",
            Password = BCrypt.Net.BCrypt.HashPassword("password")
        });
        context.SaveChanges();
    }

    public void Dispose()
    {
        
    }
}

