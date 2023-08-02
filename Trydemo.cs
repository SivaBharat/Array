using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array

   {
    public class Training
    {
        public string Name { get; set; }
        public double CSharpScore { get; set; }
        public double UIScore { get; set; }
        public double AvgScore { get; set; }

        public void CalculateAvgScore()
        {
            AvgScore = (CSharpScore + UIScore) / 2;
        }
    }

    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base(message) { }
    }

    public class InvalidAvgScoreException : Exception
    {
        public InvalidAvgScoreException(string message) : base(message) { }
    }

    internal class Trydemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();
                ValidateName(name);

                Console.WriteLine("Enter the CSharp score:");
                double cSharpScore = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the UIScore:");
                double uiScore = Convert.ToDouble(Console.ReadLine());

                double avgScore = (cSharpScore + uiScore) / 2;
                ValidateAvgScore(avgScore);

                Training trainee = new Training
                {
                    Name = name,
                    CSharpScore = cSharpScore,
                    UIScore = uiScore
                };
                trainee.CalculateAvgScore();

                Console.WriteLine($"Trainee: {trainee.Name}");
                Console.WriteLine($"CSharp Score: {trainee.CSharpScore}");
                Console.WriteLine($"UI Score: {trainee.UIScore}");
                Console.WriteLine($"Average Score: {trainee.AvgScore}");
            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine($"Invalid Name: {ex.Message}");
            }
            catch (InvalidAvgScoreException ex)
            {
                Console.WriteLine($"Invalid Average Score: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void ValidateName(string name)
        {
            if (!IsValidName(name))
            {
                throw new InvalidNameException("Name can only contain characters and underscore.");
            }
        }

        static bool IsValidName(string name)
        {
            foreach (char c in name)
            {
                if (!(char.IsLetter(c) || c == '_'))
                {
                    return false;
                }
            }
            return true;
        }

        static void ValidateAvgScore(double avgScore)
        {
            if (avgScore < 70)
            {
                throw new InvalidAvgScoreException("Average Score must be greater than or equal to 70.");
            }
        }
    }
}