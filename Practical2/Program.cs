using System;

namespace programs.Practical2
{
    class VS
    {
        private string[] faculty = new string[5];
        private int studentNum;

        public int StudentNum
        {
            get { return studentNum; }

            private set { studentNum = value; }
        }
        public string[] Faculty
        {
            get
            {
                return faculty;
            }
            private set
            {
                faculty = value;
            }
        }

        public void Admission()
        {
            Console.WriteLine("Enter student number to admit: ");
            if (int.TryParse(Console.ReadLine(), out int add))
            {
                StudentNum += add;
                Console.WriteLine("Total number of students " + StudentNum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public void Restrict()
        {
            if (StudentNum > 0)
            {
                Console.WriteLine("Enter number to restrict: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (studentNum >= num)
                    {
                        StudentNum -= num;
                        Console.WriteLine("Total number of students is now: " + StudentNum);
                    }
                    else
                    {
                        Console.WriteLine("value cannot be grater than student");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        public void AddFaculty()
        {
            for (int i = 0; i < Faculty.Length; i++)
            {
                Console.WriteLine($"Enter faculty member {i + 1}");
                Faculty[i] = Console.ReadLine();

            }
            foreach (var facultymember in Faculty)
            {
                Console.WriteLine("faculty are " + facultymember);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VS vsObject = new VS();
            bool continueExecution = true;

            while (true)
            {
                Console.WriteLine("Enter\n 1 to admit. \n 2 to add faculty. \n 3 to restrict. \n 4 to exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            vsObject.Admission();
                            break;
                        case 2:
                            vsObject.AddFaculty();
                            break;
                        case 3:
                            vsObject.Restrict();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please select valid option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");

                }




            }
        }
    }
}



