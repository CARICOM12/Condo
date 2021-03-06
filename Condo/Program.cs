﻿using System;

namespace Condominimum
{
    class Housing
    {
        public sbyte priceOf1stCondo = 54;
        public byte priceOf2ndCondo = 200;
        public short priceOf3rdCondo = 30000;
        public ushort priceOf4thCondo = 60000;
        public int priceOf5thCondo = 2000000;
        public uint priceOf6thCondo = 6000000;
        public long priceOf7thCondo = 8000000;
        public ulong priceOf8thCondo = 10000000;
        public float discountRate = 22.0f;

        static void Main(string[] args)
        {
            float price = 22;
            double discount = 10.3D;
            decimal amountOfMoney = 100.000M;
            char chineseName = 'L';
            bool ifAPersonHaveMoney = false;
            bool canadianCitezenship = false;
            string message = "Canada have a good housing market! ";
            string positiveAnswer = "yes";
            string negativeAnswer = "no";
            string answer;

            var instance = new Housing();

            Console.WriteLine("Welcome! Do you have a canadian passport? ");
            answer = Console.ReadLine();

            if (answer == positiveAnswer)
            {
                Console.WriteLine("Congrats you have a canadian citizenship.");
                canadianCitezenship = true;
                Console.WriteLine($"It's {canadianCitezenship} you have it!");
            }
            else if(answer == negativeAnswer)
            {
                Console.WriteLine("Unfortunately you don't have a canadian citizenship.");
                canadianCitezenship = false;
                Console.WriteLine($"Your expectations about canadian citizenship are {canadianCitezenship}.");
            }

            Console.WriteLine("Second question do you have finances? ");
            answer = Console.ReadLine();

            if (answer == positiveAnswer)
            {
                Console.WriteLine("Salutation you have a finances!");
                ifAPersonHaveMoney = true;
                Console.WriteLine($"Your dreams about condo will come {ifAPersonHaveMoney}...");
            }
            else if (answer == negativeAnswer)
            {
                Console.WriteLine("It's sad to say, but you don't have money.");
                ifAPersonHaveMoney = false;
                Console.WriteLine($"Your hopes regarding money are {ifAPersonHaveMoney}");
            }
            Console.WriteLine($"Price of a first condo is {instance.priceOf1stCondo}.");
            Console.WriteLine($"Price of a second condo is {instance.priceOf2ndCondo}.");
            Console.WriteLine($"Price of a third condo is {instance.priceOf3rdCondo}.");
            Console.WriteLine($"Price of a fourth condo is {instance.priceOf4thCondo}.");
            Console.WriteLine($"Price of a fifth condo is {instance.priceOf5thCondo}.");
            Console.WriteLine($"Price of a sixth condo is {instance.priceOf6thCondo}.");
            Console.WriteLine($"Price of a seventh condo is {instance.priceOf7thCondo}.");
            Console.WriteLine("Price of a eighth condo is {0}.", instance.priceOf8thCondo);
            Console.ReadKey();
        }
    }
}
