using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    #region task14
    //public class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Score { get; set; }
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //var result = from num in numbers
            //             where num % 2 == 0
            //             select num;


            //Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are: ");
            //foreach (var num in result)
            //{
            //    Console.Write(num);
            //}
            #endregion

            #region task2
            //List<int> numbers = new List<int> { -3, -2, -1, 1, 3, 6, 9, 10, 11, -11 };


            //var result = from num in numbers
            //             where num > 0 && num <= 11
            //             select num;


            //Console.WriteLine("The numbers within the range of 1 to 11 are:");
            //foreach (var num in result)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion

            #region task3
            //int[] numbers = { 1, 2, 3, 4, 5 };


            //var result = from num in numbers
            //             select new { Number = num, SqrNo = num * num };

            //foreach (var item in result)
            //{
            //    Console.WriteLine("{ Number = " + item.Number + ", SqrNo = " + item.SqrNo + " }");
            //}
            #endregion

            #region task4
            //int[] numbers = { 1, 1, 2, 3, 2, 3, 13, 13, 1 };


            //var result = from num in numbers
            //             group num by num into numGroup
            //             select new { Number = numGroup.Key, Frequency = numGroup.Count() };


            //Console.WriteLine("The number and the Frequency are:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine("Number " + item.Number + " appears " + item.Frequency + " times");
            //}
            #endregion

            #region task5

            //string word = "Carr";

            //var result = from letter in word
            //             group letter by letter into charGroup
            //             select new { Character = charGroup.Key, Frequency = charGroup.Count() };


            //Console.WriteLine("Characters and their frequencies:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine("Character " + item.Character + " appears " + item.Frequency + " times");
            //}

            #endregion

            #region task6

            //string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satuday" };

            //var result = from day in daysOfWeek
            //             select day;

            //Console.WriteLine("The names of the days of the week are:");
            //foreach (var day in result)
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region task7

            //int[] numbers = { 1, 2, 2, 3, 4, 6, 7, 4, 3, 3, 6, 7, 13, 7, 13 };

            //var result = from num in numbers
            //             group num by num into numGroup
            //             select new
            //             {
            //                 Number = numGroup.Key,
            //                 Frequency = numGroup.Count(),
            //                 Product = numGroup.Key * numGroup.Count()
            //             };

            //Console.WriteLine("Number" + " " + "Number*Frequency" + " " + "Frequency");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Number}\t{item.Product}\t\t{item.Frequency}");
            //}
            #endregion

            #region task8
            //string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            //Console.WriteLine("Input starting character for the string");
            //char startChar = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //Console.WriteLine("Input ending character for the string");
            //char endChar = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //var result = from city in cities
            //             where city.StartsWith(startChar.ToString()) &&
            //                   city.EndsWith(endChar.ToString())
            //             select city;

            //Console.WriteLine("The matching cities are:");
            //foreach (var city in result) 
            //{
            //    Console.WriteLine(city);
            //}
            #endregion

            #region task9

            //int[] numbers = { 3, 13, 133, 333, 33333 };

            //var result = numbers.Where(num => num > 80);

            //Console.WriteLine("The numbers greater than 80 are :");
            //foreach ( int number in result ) 
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region task11

            //List<int> numbers = new List<int> { 3, 13, 33, 53, 5, 55, 31, 32 };

            //Console.Write("How many records you want to display ?: ");
            //int n = int.Parse(Console.ReadLine());

            //List<int> topRecords = numbers.OrderByDescending(num => num).Take(n).ToList();

            //Console.WriteLine("The top {0} records from the list are :", n);
            //foreach (int item in topRecords)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task12

            //Console.Write("Input the string: ");
            //string inputString = Console.ReadLine();

            //string[] words = inputString.Split(' ');

            //var result = words.Where(word => word == word.ToUpper());

            //Console.WriteLine("The UPPER CASE words are:");
            //foreach (string word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region task13
            //Console.Write("Input number of strings to store in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //string[] stringArray = new string[n];

            //Console.WriteLine("Input {0} strings for the array:", n);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element[{0}]: ", i);
            //    stringArray[i] = Console.ReadLine();
            //}

            //string result = string.Join(", ", stringArray.Select(s => s));

            //Console.WriteLine("Here is the string below created with elements of the above array:");
            //Console.WriteLine(result);
            #endregion

            #region task14

            //List<Student> students = new List<Student>
            //{
            //    new Student { Id = 1, Name = "Ali", Score = 750 },
            //    new Student { Id = 2, Name = "Mahir", Score = 690 },
            //    new Student { Id = 3, Name = "Nihat", Score = 650 },
            //    new Student { Id = 4, Name = "Hesen", Score = 590 },
            //    new Student { Id = 5, Name = "Tahir", Score = 700 }
            //};

            //Console.Write("What maximum price point do you want to find?: ");
            //int n = int.Parse(Console.ReadLine());

            //var result = students.OrderByDescending(s => s.Score).Take(n);

            //Console.WriteLine("Expected Result:");
            //foreach (var student in result)
            //{
            //    Console.WriteLine("İd : {0}, Ad : {1}, Grade Score obtained : {2}", student.Id, student.Name, student.Score);
            //}
            #endregion

            #region task16
            //int[] fileSizes = { 1, 2, 3, 4, 5, 3 }; 

            //double averageSize = fileSizes.Average();

            //Console.WriteLine("The Average file size is {0} MB", averageSize);
            #endregion

            #region task17

            //List<char> letters = new List<char>() { 'm', 'n', 'o', 'p', 'q' };

            //Console.WriteLine("Here is the list of items:");
            //foreach (char item in letters)
            //{
            //    Console.WriteLine("Char: " + item);
            //}


            //char itemToRemove = 'o';
            //letters = letters.Where(c => c != itemToRemove).ToList();

            //Console.WriteLine("\nHere is the list after removing the item '{0}' from the list:", itemToRemove);
            //foreach (char item in letters)
            //{
            //    Console.WriteLine("Char: " + item);
            //}
            #endregion

            #region task18
            //List<char> letters = new List<char>() { 'm', 'n', 'o', 'p', 'q' };

            //Console.WriteLine("Here is the list of items:");
            //foreach (char item in letters)
            //{
            //    Console.WriteLine("Char: " + item);
            //}

            //char itemToRemove = 'p';
            //letters = letters.Where(c => c != itemToRemove).ToList();

            //Console.WriteLine("\nHere is the list after removing the item '{0}' from the list:", itemToRemove);
            //foreach (char item in letters)
            //{
            //    Console.WriteLine("Char: " + item);
            //}
            #endregion

            #region task19
            //List<char> letters = new List<char>() { 'm', 'n', 'o', 'p', 'q' };

            //Console.WriteLine("Here is the list of items:");
            //foreach (char item in letters)
            //{
            //    Console.WriteLine("Char: " + item);
            //}


            //letters.RemoveAll(item => item == 'q');

            //Console.WriteLine("\nHere is the list after removing item 'q' from the list:");
            //foreach (char item in letters)
            //{
            //   Console.WriteLine("Char: " + item);
            //} 
            #endregion

            #region task20
            //List<char> letters = new List<char>() { 'm', 'n', 'o', 'p', 'q' };

            //Console.WriteLine("Here is the list of items:");
            //foreach (char item in letters)
            //{
            //    Console.WriteLine("Char: " + item);
            //}

            //int itemIndexToRemove = 3;
            //letters.RemoveAt(itemIndexToRemove);

            //Console.WriteLine("\nHere is the list after removing item index {0} from the list:", itemIndexToRemove);
            //foreach (char item in letters)
            //{
            //    Console.WriteLine("Char: " + item);
            //}
            #endregion

            #region task21
            //List<char> letters = new List<char>() { 'm', 'n', 'o', 'p', 'q' };

            //Console.WriteLine("Here is the list of items:");
            //foreach (char item in letters)
            //{
            //    Console.WriteLine("Char: " + item);
            //}

            //int startIndex = 1;
            //int countToRemove = 3;
            //letters.RemoveRange(startIndex, countToRemove);

            //Console.WriteLine("\nHere is the list after removing the three items starting from the item index {0} from the list:", startIndex);
            //foreach (char item in letters)
            //{
            //    Console.WriteLine("Char: " + item);
            //}
            #endregion

            #region task28
            //string[] items = { "BMW", "MERCEDES", "DODGE", "NISSAN", "CORVETTE" };


            //var sortedItems = items.OrderBy(item => item.Length).ThenBy(item => item);


            //Console.WriteLine("Sorted list of items:");
            //foreach (var item in sortedItems)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task30
            //List<int> numbers = new List<int>() { 5, 2, 8, 3, 1, 4, 6, 7 };

            //var distinctNumbers = numbers.Distinct().OrderBy(num => num);

            //Console.WriteLine("Distinct elements in ascending order:");
            //foreach (var num in distinctNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
        }
    }
}
