 namespace programs.Practical3.Inheritance{

class DVD : LibraryItem
    {
        public string Director { get; set; }
        public int Duration { get; set; }

        public DVD(int id, string title, string director, int duration) : base(id, title)
        {
            Director = director;
            Duration = duration;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Duration: {Duration} minutes");
        }
    }}