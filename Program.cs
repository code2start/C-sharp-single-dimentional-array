using System;

namespace singledimentionalarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 5;
           /* int[] numbers;//array declaration
           numbers = new int[3];//array instantiation(instance)
           //initialize array
           numbers[1] = 3;
           numbers[2] = 22;
           numbers[0] = 10; */
           //int[] numbers = new int[4];//declaration and instantiation
           //int[] numbers = new int[]{4,2,1};//declaration, instantiation, initialization
            /* int[] numbers = {4,6,9,1};
           //declaration and instantiation
           foreach(int number in numbers){
               Console.WriteLine(number);
           } */
           string[] products = {"Product 1","Product 2","Product 3"};
           foreach(string product in products){
               Console.WriteLine(product);
           }

        }
    }
}
