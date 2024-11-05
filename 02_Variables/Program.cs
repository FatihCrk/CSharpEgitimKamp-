using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //double number = 4.82;



            Console.WriteLine("***** CSharp Hava Yolları Bilgisi ******* ");
            Console.WriteLine();


            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge;

            Console.WriteLine("Yolcu Adı");
           passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı:");
            passengerSurname = Console.ReadLine();

            Console.Write("Yolcu Yaşı");
            passengerAge = Console.ReadLine();

            Console.Write("Yaşadığı il");
            passengerCity = Console.ReadLine();

            Console.Write("Yaşadığı ilçe");
            passengerDistrict = Console.ReadLine();

            Console.WriteLine("----------");

            Console.WriteLine("Yolcu Adı Soyadı: " + passengerName, passengerSurname);
            Console.WriteLine("Yolcu Yaşı :" + passengerAge);

            Console.ReadLine();


        }
    }
}
