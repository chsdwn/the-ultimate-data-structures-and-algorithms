using System;

namespace the_ultimate_data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray numbers = new MyArray();
            numbers.insert(30);
            numbers.insert(30);
            numbers.insert(40);
            numbers.insert(50);
            numbers.insert(10);
            numbers.insertAt(20, 1);
            numbers.insertAt(00, 0);
            numbers.print();
            System.Console.WriteLine();
            numbers.removeAt(1);
            numbers.print();
            System.Console.WriteLine();
            System.Console.WriteLine(numbers.intersect());
            numbers.reverse();
            System.Console.WriteLine(numbers.max());
        }
    }
}