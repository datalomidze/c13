using System;

namespace CarProject
{
    // მანქანის კლასი
    public class Car
    {
        public string Brand { get; set; }       // ბრენდი
        public string Model { get; set; }       // მოდელი
        public int Age { get; set; }            // წლოვანება (რამდენი წლისაა)
        public double EngineVolume { get; set; }// ძრავის მოცულობა
        public string Color { get; set; }       // ფერი

        // კონსტრუქტორი მნიშვნელობების მისანიჭებლად
        public Car(string brand, string model, int age, double engineVolume, string color)
        {
            Brand = brand;
            Model = model;
            Age = age;
            EngineVolume = engineVolume;
            Color = color;
        }

        // 1. მეთოდი, რომელიც გამოთვლის რომელ წელს არის მანქანა გამოშვებული
        public int GetManufactureYear()
        {
            int currentYear = DateTime.Now.Year; // მიმდინარე წელი (2026)
            return currentYear - Age;
        }

        // 2. მეთოდი, რომელიც დაბეჭდავს მანქანის ყველა მახასიათებელს
        public void PrintCarInfo()
        {
            Console.WriteLine($"ბრენდი: {Brand}");
            Console.WriteLine($"მოდელი: {Model}");
            Console.WriteLine($"წლოვანება: {Age} წლის");
            Console.WriteLine($"გამოშვების წელი: {GetManufactureYear()}");
            Console.WriteLine($"ძრავის მოცულობა: {EngineVolume}");
            Console.WriteLine($"ფერი: {Color}");
            Console.WriteLine("-------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ვქმნით მანქანის ობიექტს
            Car myCar = new Car("BMW", "E39", 27, 2.5, "შავი");

            // ვბეჭდავთ მონაცემებს
            myCar.PrintCarInfo();
        }
    }
}