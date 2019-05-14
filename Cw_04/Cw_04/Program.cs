using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee array = new Employee();

            for (int i = 0; i < array.employeeArray.GetLength(0); i++)
            {
                for (int j = 0; j < array.employeeArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Employee posiotion: ");
                        string position = Console.ReadLine();
                        array.employeeArray[i,j] = position;  
                    }
                    else
                    {
                        Console.WriteLine("Employee houlry Rate: ");
                        string hourlyRate = Console.ReadLine();
                        array.employeeArray[i, j] = hourlyRate;
                    } 
                }
            }
            
            for (int i = 0; i < array.employeeArray.GetLength(0); i++)
            {
                for(int j = 0; j < array.employeeArray.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        Console.Write("Positon: " + array.employeeArray[i, j] + ", ");
                    }
                    else
                    {
                        Console.Write("Hours rate : " + array.employeeArray[i, j] + ", ");
                    }
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
            
        }
        
    }
}
