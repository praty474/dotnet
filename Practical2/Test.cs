namespace programs.Practical2
{



    using System;

    class Test
    {
        static void Main()
        {

            Console.Write("Enter the number of students: ");
            int numberOfStudents = GetValidIntegerInput();

            // Initialize jagged array
            double[][] grades = new double[numberOfStudents][];

            // Step 2: Allow the user to input the number of subjects and grades for each student
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter the number of subjects for Student {i + 1}: ");
                int numberOfSubjects = GetValidIntegerInput();

                // Initialize inner array for each student based on the number of subjects
                grades[i] = new double[numberOfSubjects];

                // Input grades for each subject
                for (int j = 0; j < numberOfSubjects; j++)
                {
                    Console.Write($"Enter the grade for Subject {j + 1} for Student {i + 1}: ");
                    grades[i][j] = GetValidDoubleInput();
                }
            }

            // Step 3: Calculate and display the average grade for each student
            Console.WriteLine("\nAverage Grades for Each Student:");
            for (int i = 0; i < numberOfStudents; i++)
            {
                double average = CalculateAverage(grades[i]);
                Console.WriteLine($"Student {i + 1}: Average Grade = {average:F2}");
            }

            // Step 4: Determine and display the highest average among all students
            double highestAverage = 0;
            int studentWithHighestAverage = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double average = CalculateAverage(grades[i]);
                if (average > highestAverage)
                {
                    highestAverage = average;
                    studentWithHighestAverage = i + 1;
                }
            }

            Console.WriteLine($"\nStudent {studentWithHighestAverage} has the highest average grade: {highestAverage:F2}");
        }

        // Function to calculate the average of an array of grades
        static double CalculateAverage(double[] grades)
        {
            if (grades.Length == 0)
                return 0;

            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }

            return sum / grades.Length;
        }

        // Function to get valid integer input from the user
        static int GetValidIntegerInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
            {
                Console.Write("Invalid input. Please enter a valid positive integer: ");
            }
            return input;
        }

        // Function to get valid double input from the user
        static double GetValidDoubleInput()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Invalid input. Please enter a valid numeric value: ");
            }
            return input;
        }
    }

}