using System;
using System.Collections.Generic;

namespace BookManager
{
    class Program
    {
        static List<Author> authors = new List<Author>();
        static List<Genre> genres = new List<Genre>();
        static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                Console.WriteLine("\nBook Manager\n");
                Console.WriteLine("1. Add an author");
                Console.WriteLine("2. Add a genre");
                Console.WriteLine("3. Add a book");
                Console.WriteLine("4. List all books");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter the number of the operation you want to perform: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddAuthor();
                        break;
                    case "2":
                        AddGenre();
                        break;
                    case "3":
                        AddBook();
                        break;
                    case "4":
                        ListAllBooks();
                        break;
                    case "5":
                        endApp = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid input. Please enter a valid number.\n");
                        break;
                }
            }
        }

        static void AddAuthor()
        {
            Console.Write("\nEnter the name of the author: ");
            string name = Console.ReadLine();
            authors.Add(new Author(name));
            Console.WriteLine("\nAuthor added successfully.\n");
        }

        static void AddGenre()
        {
            Console.Write("\nEnter the name of the genre: ");
            string name = Console.ReadLine();
            genres.Add(new Genre(name));
            Console.WriteLine("\nGenre added successfully.\n");
        }

        static void AddBook()
        {
            Console.Write("\nEnter the title of the book: ");
            string title = Console.ReadLine();

            Console.Write("\nEnter the author of the book: ");
            string authorName = Console.ReadLine();
            Author author = authors.Find(a => a.Name == authorName);
            if (author == null)
            {
                Console.WriteLine("\nThe specified author does not exist. Please add the author first.\n");
                return;
            }

            Console.Write("\nEnter the genre of the book: ");
            string genreName = Console.ReadLine();
            Genre genre = genres.Find(g => g.Name == genreName);
            if (genre == null)
            {
                Console.WriteLine("\nThe specified genre does not exist. Please add the genre first.\n");
                return;
            }

            books.Add(new Book(title, author, genre));
            Console.WriteLine("\nBook added successfully.\n");
        }

        static void ListAllBooks()
        {
            Console.WriteLine("\nBooks:");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author.Name} ({book.Genre.Name})");
            }
            Console.WriteLine();
        }
    }

    class Author
    {
        public string Name { get; set; }

        public Author(string name)
        {
            Name = name;
        }
    }

    class Genre
    {
        public string Name { get; set; }

        public Genre(string name)
        {
            Name = name;
        }
    }

    class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }

        public Book(string title, Author author, Genre genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
    }
}