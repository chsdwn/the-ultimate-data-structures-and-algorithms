using System;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray numbers = new MyArray(3);
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);
            numbers.insert(50);
            numbers.print();
            Console.WriteLine(numbers.indexOf(10));
            Console.WriteLine(numbers.indexOf(20));
            Console.WriteLine(numbers.indexOf(1));
        }
    }
}