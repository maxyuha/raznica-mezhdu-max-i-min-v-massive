using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {
            void Zadacha38()
            {//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            Random random=new Random();
            double[] array=new double[8];
            double min=array[0];
            double max=array[0];

            for(int i=0;i<array.Length;i++)
            {
                array[i]=Math.Round(random.NextDouble()*10-5,2);
            }
            Console.WriteLine("массив");

            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]+"\t");
            }
            Console.WriteLine();

            for(int i=1;i<array.Length;i++)
            {
                if(array[i]>max)max=array[i];
                else if (array[i]<min)min=array[i];
            }
            
            Console.WriteLine();
            Console.WriteLine($"разность между максимальным значением {max} и минимальным {min} значениями массива равна {max-min}");   
            }
            Zadacha38();
        }
        
     }
    
}