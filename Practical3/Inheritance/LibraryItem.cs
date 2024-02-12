using System;
namespace programs.Practical3
{
    class LibraryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCheckedOut { get; set; }

        public LibraryItem(int id, string title)
        {
            Id = id;
            Title = title;
            IsCheckedOut = false;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Is Checked Out: {IsCheckedOut}");
        }

        public void CheckOut()
        {
            IsCheckedOut = true;
            Console.WriteLine($"{Title} has been checked out.");
        }

        public void Return()
        {
            IsCheckedOut = false;
            Console.WriteLine($"{Title} has been returned.");
        }
    }}