﻿using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5; // 1 byte    
            sbyte c = 5; // 1 byte  

            short s = 5; // 2 byte 
            ushort us = 5; // 2 byte   

            Int16 i16 = 2; // 2byte
            int i = 2;  // 4byte
            Int32 i32 = 2;  // 4byte
            Int64 i64 = 2; // 8 byte

            uint ui = 2; // 4 byte
            long l = 4; // 8 byte
            ulong ul = 4; // 8 byte

            //reel sayılar
            float f = 5; // 4 byte
            double d = 5; // 8 byte
            decimal de = 5; //16 byte

            char ch = '2';    // 2 byte
            string str = "Bahar"; // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'c';
            object o3 = 4;
            object o4 = 4.3;


            //String ifadeler

            string str1 = string.Empty; // can be replaced with null or ""
            str1 = "Bahar Sezin";
            string ad = "Bahar";
            string soyad = "Sezin";
            string tamIsim = ad + " " + soyad;


            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;


            //boolean

            bool bool1 = 10 > 2;

            // Degisken Donusumleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString(); //Conversion an integer to a string value
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20); //Conversion a string to an integer value
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20); //Another  method for string to int conversion, but using only for string variables
            Console.WriteLine(int22);

            //datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy"); // the format can be adjusted as wanted
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy"); // the format can be adjusted as wanted
            Console.WriteLine(datetime2);

            //hour 
            string hour = DateTime.Now.ToString("HH:mm"); // the format can be adjusted as hour
            Console.WriteLine(hour);



        }
    }
}
