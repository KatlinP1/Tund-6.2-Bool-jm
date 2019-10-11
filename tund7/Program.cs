using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tund7
{
    class Program
    {
        static void Main(string[] args)
        {
            // korrutustabel 
            /*int userNumber;
            Console.WriteLine("Please enter the number");
            userNumber = int.Parse(Console.ReadLine());

            for(int i= 1; i <=10; i++)
            {
                Console.WriteLine($"{userNumber} x {i} = {userNumber * i}");
            }

            Console.ReadLine();*/

            //Sõnapikkuse programm (length kasutamata)
            /*string userWord;
            Console.WriteLine("Enter any word:");
            userWord = Console.ReadLine();

            int counter =0;
            
            foreach(char letter in userWord)
            {
                counter++;
            }

            Console.WriteLine($"Your word is {counter} letters long");

            Console.ReadLine();*/

            //kontorlli kas kasutaja nime sees on a täht

            /*string name;
            Console.WriteLine(" Please, enter your name:");
            name = Console.ReadLine();

            bool letterFound = false;
            
            foreach(char letter in name)
            {
                if (letter == 'a')
                {
                    letterFound = true;
                    Console.WriteLine("Letter a was found");
                    
                }
                else
                {
                    Console.WriteLine("Letter a was not found");
                }
            }
            


            Console.ReadLine();*/

            /*if (letterFound == true)
            {
                Console.WriteLine("Letter a was found");
            }
            else
            {
                Console.WriteLine("Letter a was not found");
            }/*

            Console.ReadLine();

            //turneriga 
            /*string result = letterFound ? "Includes an A" : "Dosent include an a";
            Console.WriteLine(result);*/

            // loe mitu a tähte on sõnas
            /*int aTotal = 0;
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            for(int i=0; i< name.Length; i++)
            {
                if (name[i] == 'a')
                {
                    aTotal++;
                }
            }

            Console.WriteLine($"There are {aTotal} \"A\" letter in your name");
            Console.ReadLine(); */

            // characters separeted in string
            /*string askedWord;
            Console.WriteLine("Enter one word");
            askedWord = Console.ReadLine();*/

            //foreach variant 1
            /*foreach (char letter in askedWord)
            {
                Console.Write($"{letter} ");
            }*/

            // forloop variant 2
            /*for(int i = 0; i < askedWord.Length; i++)
            {
                if(i==askedWord.Length-1)
                {
                    Console.Write($"{askedWord[i]}#");
                    break;
                }
                Console.Write($"{askedWord[i]}*");
            }*/

            //While loop variant 3- kodus  

            //prindime välja numbrid 1-10ni (while loop)
            /*int i = 1;

            while( i<= 10)
            {
                Console.WriteLine(i);
                i++;
            }*/

            //while loop loeks smt
            string hello = "hello";
            int i = 0;

            while(i < hello.Length)
            {
                Console.WriteLine($"{hello[i]}*");
                i++;
            }

            Console.ReadLine();






















        }
    }
}
