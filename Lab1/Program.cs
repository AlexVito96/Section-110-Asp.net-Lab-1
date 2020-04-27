using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var p = new Program();
            p.Test();

            string full = p.FullName("Alex", "Vito");
            Console.WriteLine(full);

            p.Exc1();

        }

        void Exc1(){
            var numbers = new List <int>();
            // 10 20 .. 1000
            for(int i = 1; i < 101; i++){
                numbers.Add(i*10);
            }
            System.Console.WriteLine(numbers);

            var sum = 0;
            foreach(int num in numbers){
                if(num > 40) {
                    sum += num;
                }
            }
            //for(int j=0; j < numbers.Count; j++){
            //    sum += numbers[j];
            //}
            System.Console.WriteLine("Total: " + sum);

            NoReturns();

        }

        void NoReturns(){
            System.Console.WriteLine("test");

            // Variables types
            string name = "Alex";
            int age = 99;
            bool found = false;
            float f = 123.23f;
            decimal d = 123.123m;

            string[] names = new string[100];
            names[0] = "asd";
            names[1] = "123123";
            names[6] = "ajklasl";

            //string[][] cube = new string[99][];

            List <string> list = new List<string>();
            list.Add("asdasd");

            System.Console.WriteLine("From array: " + name[0]);
            System.Console.WriteLine("From list: " + list[0]);

        }

        string FullName(string first, string last){
           return first + " " + last;
        }

        int Test() {
            Console.WriteLine("First method");
            return 1;
        }

    }
}
