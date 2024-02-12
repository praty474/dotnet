 
 namespace programs.Practical3.Inheritance{
 class Book : LibraryItem
    {
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book(int id, string title, string author, int pages) : base(id, title)
        {
            Author = author;
            Pages = pages;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Pages: {Pages}");
        }
    }}
