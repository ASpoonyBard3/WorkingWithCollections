﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car1.Make = "Oldsmobile";
            Car1.Model = "Cutlas supreme";

            Car Car2 = new Car();
            Car2.Make = "Geo";
            Car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-000000-0";
            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(Car1);
            myArrayList.Add(Car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
                Console.ReadLine();
            }
            */
            //List<T>
            List<Car> myList = new List<Car>();
            myList.Add(Car1);
            myList.Add(Car2);
            //myList.Add(b1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
                Console.ReadLine();
            }

        }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }
}
