using System.Linq;

namespace csharp_fundamentals.Array_Belajar
{
    public class Array_Belajar
    {
        public int SomeProperty { get; set; } = 42;

        public void ArrayMethod()
        {
            // creating the array 
            int[] nilai_kelas_a = new int[] {
            90,
            89,
            50,
            100,
            90
             };

            // display array
            foreach (int nilai in nilai_kelas_a)
            {
                Console.WriteLine(nilai);
            }

            Console.WriteLine("Setelah di sortir!");
            Array.Sort(nilai_kelas_a);
            foreach (int nilai in nilai_kelas_a)
            {
                Console.WriteLine(nilai);
            }

            // using Array method
            string[] names = new string[] { "Yaqub", "Khalid", "Karawita", "Sisha", "Kanabawi", "Sumbul" };
            Console.WriteLine(Array.Exists(names, name => name == "Kanabawi"));

            // using Linq
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            IEnumerable<int> afterLinq = numbers.Where(number => number % 2 == 0);
            IEnumerable<int> afterLinqOther = // query syntax
                from number in numbers
                where number % 2 == 0
                orderby number descending // make it descending
                select number;

            Console.WriteLine("First LINQ");
            foreach (int number in afterLinq)
            {
                Console.WriteLine($"{number}");
            }
            Console.WriteLine("Second LINQ");
            foreach (int number in afterLinqOther)
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}
