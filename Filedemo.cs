using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Filedemo
    {
        static void Main()
        {

            string[] netTrainees = { "Siva", "Arun", "Srikanth", "Hemanth", "Vignesh", "Harita", "Yamini" };
            string[] otherTrainees = { "Karthi", "Dharsan", "Sharon", "Harsan" };

            // a)Write the data to a file
            string fileName = "DotNetTrainees.txt";
            string copyFile = "Copyfile.txt";
            string movefile = "MoveContent.txt";
            string exist = "file.txt";
            try
            {
                File.WriteAllLines(fileName, netTrainees);
                Console.WriteLine("Data written to the file successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error while writing to the file: " + ex.Message);
            }
            Console.WriteLine("------------------------------------------------------");
            // Read the data from the file
            try
            {
                string[] readTrainees = File.ReadAllLines(fileName);
                Console.WriteLine("Data read from the file after adding the DotNet trainee details:");
                foreach (string trainee in readTrainees)
                {
                    Console.WriteLine(trainee);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error while reading from the file: " + ex.Message);
            }
            Console.WriteLine("------------------------------------------------------");
            //b)Adding other trainee details
            try
            {
                File.AppendAllLines(fileName, otherTrainees);
                Console.WriteLine("Other trainee details added successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error while adding the other trainee details.");
            }
            Console.WriteLine("------------------------------------------------------");
            try
            {
                string[] readTrainees = File.ReadAllLines(fileName);
                Console.WriteLine("Reading the file after adding the other trainee details.");
                foreach (string trainee in readTrainees)
                {
                    Console.WriteLine(trainee);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error while reading the file after adding the other trainee details." + ex.Message);
            }
            Console.WriteLine("------------------------------------------------------");

            //c)copy one file to another file
            try
            {
                File.Copy(fileName, copyFile, true);
                Console.WriteLine("File copied successfully");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error occured during the file copied " + ex.Message);
            }
            string[] trainees = File.ReadAllLines(copyFile);
            try
            {
                Console.WriteLine("Read the copied file");
                foreach (string item in trainees)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error while reading the copied file" + ex.Message);
            }
            Console.WriteLine("------------------------------------------------------");
            //d)Move content from one file to another
            try
            {
                File.Move(fileName, movefile);
                Console.WriteLine("Content moved successfully");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error while moving the content" + ex.Message);
            }
            //e)if file exists delete the file
            try
            {
                if (File.Exists(exist))
                {
                    File.Delete(exist);
                    Console.WriteLine("File deleted");
                }
                else
                {
                    File.WriteAllText(exist, "New file created successfully!");
                }
                string content = File.ReadAllText(exist);
                Console.WriteLine($"File contents: {content}");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //f)Employee Report
            string[] emp = { "Siva,20000", "Arun,22000", "Srikanth,23000", "Hemanth,25000" };
            string empReport = "empReport.csv";
            try
            {
                File.WriteAllLines(empReport, emp);
                Console.WriteLine("Data written in the CSV file successfully");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
        { 
            string[] readEmployees = File.ReadAllLines(empReport);
            Console.WriteLine("Employee report:");
            foreach (string employee in readEmployees)
            {
                string[] employeeData = employee.Split(',');
                string name = employeeData[0];
                double salary = double.Parse(employeeData[1]);
                double bonus = CalculateBonus(salary);
                Console.WriteLine($"Name: {name}, Salary: {salary}, Bonus: {bonus}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error while reading from the file: " + ex.Message);
        }
}
        static double CalculateBonus(double salary)
        {
            if (salary > 20000)
            {
                return salary * 0.1;
            }
            else
            {
                return 0;
            }
        }
    }

}