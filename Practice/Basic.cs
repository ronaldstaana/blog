using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Basic
    {
        //swap
        public void Exercise1()
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine()); //3
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine()); //4
            int temp = 0;

            temp = a; //3
            a = b; //4
            b = temp; //3

            Console.WriteLine("First number is: {0}", a);
            Console.WriteLine("Second number is: {0}", b);
        }

        //reverse
        public void Exercise2()
        {
            Console.WriteLine("Enter string: ");
            string word = Console.ReadLine(); //wallet
            string word2 = "";
            //tellaw

            //ctr = 5
          
            for (int ctr = word.Length-1; ctr >= 0; ctr--)
            {
                // t
                word2 += word[ctr].ToString();
            }

            Console.WriteLine(word2);
        }

        //palindrome
        public void Exercise3()
        {
            Console.WriteLine("Enter string: ");
            string word = Console.ReadLine(); //wallet
            string word2 = "";
            //tellaw

            //ctr = 5

            for (int ctr = word.Length - 1; ctr >= 0; ctr--)
            {
                // t
                word2 += word[ctr].ToString();
            }

            if (word == word2)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }

        }

        //fizzbuz
        public void Exercise4()
        {
            //1-100
            for (int ctr = 1; ctr <= 100; ctr++)
            {
                if(ctr % 3 == 0 && ctr % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (ctr % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (ctr % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(ctr);
                }
            }
        }


        //*
        //**
        //***
        //****
        //*****
        public void Exercise5()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int ctr = 1; ctr <= i; ctr++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        //*****
        //****
        //***
        //**
        //*
        public void Exercise6()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int ctr = 1; ctr <= i ; ctr++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
         
        //     *
        //    **
        //   ***
        //  ****
        // *****
        public void Exercise7()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int ctr = 1; ctr <= i; ctr++)
                {
                    Console.Write(" ");
                }
                for (int ctr2 = 5; ctr2 >=  i; ctr2--)
                {
                    Console.Write("*");
                }        
 
                Console.WriteLine();    
            }

        }
    }
}
