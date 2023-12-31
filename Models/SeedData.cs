﻿using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "R",
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "R",
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "R",
                }
            );
            context.Client.AddRange(
                new Client
                {
                    Name = "Emerson",
                    Phone = "41995932634",
                    Address = "Rua leopold",
                },
                new Client
                {
                    Name = "Ester",
                    Phone = "41995932534",
                    Address = "Rua Gumercindo",
                }
            );
            context.Supplier.AddRange(
                new Supplier
                {
                    Name = "Alice",
                    Phone = "41995932534",
                    Email = "hagathaspumer@hotmail.com",
                    Product = "popcorn",
                    Address = "Rua carlos p de lima"
                },
                new Supplier
                {
                    Name = "Mauricio S",
                    Phone = "41995932524",
                    Email = "loreal123@hotmail.com",
                    Product = "Drinks",
                    Address = "Rua 123"
                }
            );
            context.SaveChanges();
        }
    }
}