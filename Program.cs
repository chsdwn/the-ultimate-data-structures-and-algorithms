using System;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Array numbers = new Array(3);
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);
            System.Console.WriteLine(numbers.indexOf(10));
            System.Console.WriteLine(numbers.indexOf(50));
            numbers.print();
        }
    }
}