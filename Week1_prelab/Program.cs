﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_prelab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strFirst, strOperand, strNum1, strNum2;
            Int32 intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;
            Double dbResult;

            Console.WriteLine("Hello There!");

            Console.Write("Please enter the first name: ");
            strFirst = Console.ReadLine();

            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            Console.WriteLine("Hello" + strFirst + "! Let's do some math!");

            Console.Write("Please enter the math operation (PLUS, MINUS, MUTIPLY, DIVIDE");
            strOperand = Console.ReadLine();

            Console.WriteLine("Please write the second number: ");
            strNum2 = Console.ReadLine();


            intNum1 = Int32.Parse(strNum1);
            intNum2 = Convert.ToInt32(strNum2);


            switch (strOperand)
            {
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;

                case "MINUS":
                    intResult = intNum1 + intNum2;
                    break;

                case "DIVIDE":
                    intResult = intNum1 + intNum2;
                    break;

                case "MULTIPlY":
                    intResult = intNum1 + intNum2;
                    break;

            }


        }
    }
}
