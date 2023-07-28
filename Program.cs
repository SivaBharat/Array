using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get array element from the user
            int row, col, i, j;
            Console.WriteLine("Enter the number of rows in the array: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of rows in the array: ");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[row, col];
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.WriteLine($"Enter the element: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Array elements :");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
            //2d array to 1d array
            Program program = new Program();
            program.one(array, row, col);
            //jagged array
            program.jag();
            //params
            string name1 = "Siva";
            int age1 = 22;
            string mobileNo1 = "1234567890";
            string address1 = " Main Street, ngl";
            string name2 = "Karthi";
            int age2 = 21;
            string mobileNo2 = "9876543210";
            string address2 = "south street,cbe";
            DisplayTraineeDetails(name1, age1, mobileNo1, address1, name2, age2, mobileNo2, address2);


        }
        public void one(int[,] array, int row, int col)
        {
            int len = array.Length;
            int[] arr = new int[len];
            int z = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[z++] = array[i, j];
                }

            }
            Console.WriteLine("One dimension array elements: ");
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void DisplayTraineeDetails(params object[] trainees)
        {
            for (int i = 0; i < trainees.Length; i+=4)
            {
                string name = (string)trainees[i];
                int age = (int)trainees[i + 1];
                string mobileNo = (string)trainees[i + 2];
                string address = (string)trainees[i + 3];

                Console.WriteLine("Trainee Details:");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Mobile No: " + mobileNo);
                Console.WriteLine("Address: " + address);
                Console.WriteLine("-------------------------");
            }
        }
        public void jag()
        {
            int[][,] jaggedArray = new int[3][,]{
            new int[,] { {1,3}, {5,7} },
            new int[,] { {0,2}, {4,6}, {8,10} },
            new int[,] { {11,22}, {99,88}, {0,9} }
};
            Console.WriteLine("Jagged array elements: ");
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                int x=0;
                for(int j = 0; j < jaggedArray[i].GetLength(x); j++)
                {

                    for(int k = 0; k < jaggedArray[i].Rank; k++)
                    {
                        Console.WriteLine(jaggedArray[i][j, k]);
                    }
                }
                x++;
            }
        }
        
    }
}
