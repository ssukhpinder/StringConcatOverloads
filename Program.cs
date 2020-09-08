using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StringConcatOverloads
{
    class Program
    {
        public class Vehicle
        {
            public string Cost;
            public string Engine;

            public Vehicle(string cost, string engine)
            {
                this.Engine = engine;
                this.Cost = cost;
            }

            public override string ToString()
            {
                return this.Cost;
            }
        }

        static void Main(string[] args)
        {
            //TestOverloadExample1();
            //TestOverloadExample2();
            TestIEnumerableConcat();
        }

        static void TestIEnumerableConcat()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle vehicle1 = new Vehicle("10000 Rs", "V2");
            Vehicle vehicle2 = new Vehicle("30000 Rs", "V9");
            Vehicle vehicle3 = new Vehicle("20000 Rs", "V6");

            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(vehicle3);

            var output = String.Concat(vehicles.Where(x => x.Engine == "V9"));
            System.Console.WriteLine("Vehicle Cost {0}", output);
        }

        static void TestOverloadExample1()
        {
            string[] wordsArray = { "test", "horn", "arts", "core" };
            foreach (string word in wordsArray)
            {
                var letters = word.ToCharArray();
                string fourLetters = String.Concat(letters[3], letters[2], letters[1], letters[0]);
                string threeLetters = String.Concat(letters[3], letters[2], letters[1]);
                string twoLetters = String.Concat(letters[3], letters[2]);

                Console.WriteLine("Concat 4 letters {0} --> {1}", word, fourLetters);
                Console.WriteLine("Concat 3 letters {0} --> {1}", word, threeLetters);
                Console.WriteLine("Concat 2 letters {0} --> {1}", word, twoLetters);
            }
        }

        static void TestOverloadExample2()
        {
            int i = -1;
            Object obj = i;
            Object[] objs = new Object[] { 100, 200, 300 };

            Console.WriteLine("Concatenate 1, 2, and 3 objects:");
            Console.WriteLine("Concat 1 object {0}", String.Concat(obj));
            Console.WriteLine("Concat 2 objects {0}", String.Concat(obj, obj));
            Console.WriteLine("Concat 3 objects {0}", String.Concat(obj, obj, obj));

            Console.WriteLine("\nConcatenate 4 objects and a variable length parameter list:");
            Console.WriteLine("Concat 4 objects {0}", String.Concat(obj, obj, obj, obj));
            Console.WriteLine("Concat 5 objects {0}", String.Concat(obj, obj, obj, obj, obj));

            Console.WriteLine("\nConcatenate a 3-element object array:");
            Console.WriteLine("Concat 3 object array {0}", String.Concat(objs));
        }
    }
}
