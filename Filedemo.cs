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
            
            string[] netTrainees = { "Siva", "Arun", "Srikanth", "Hemanth", "Vignesh","Harita","Yamini" };
            string[] otherTrainees = { "Karthi", "Dharsan", "Sharon", "Harsan" };
            // Write the data to a file
            string fileName = "DotNetTrainees.txt";
            string copyFile = "Copyfile.txt";
            string movefile = "MoveContent.txt";
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
            //Adding other trainee details
            try
            {
                File.AppendAllLines(fileName, otherTrainees);
                Console.WriteLine("Other trainee details added successfully.");
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error while adding the other trainee details."); 
            }
            Console.WriteLine("------------------------------------------------------");
            try
            {
                string[] readTrainees = File.ReadAllLines(fileName);
                Console.WriteLine("Reading the file after adding the other trainee details.");
                foreach(string trainee in readTrainees)
                {
                    Console.WriteLine(trainee);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error while reading the file after adding the other trainee details."+ex.Message);
            }
            Console.WriteLine("------------------------------------------------------");

            //copy one file to another file
            try
            {
                File.Copy(fileName, copyFile, true);
                Console.WriteLine("File copied successfully");
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error occured during the file copied "+ex.Message);
            }
            string[] trainees = File.ReadAllLines(copyFile);
            try
            {
                Console.WriteLine("Read the copied file");
                foreach(string item in trainees)
                {
                    Console.WriteLine(item);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error while reading the copied file"+ex.Message);
            }
            Console.WriteLine("------------------------------------------------------");
            //Move content from one file to another
            try
            {
                File.Move(fileName, movefile);
                Console.WriteLine("Content moved successfully");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error while moving the content"+ex.Message);
            }
        }
    }
}
