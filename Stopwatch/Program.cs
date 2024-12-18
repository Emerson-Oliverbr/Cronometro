using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Do...");
            Thread.Sleep(2000);
            Start(time);
        }

        static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("S = Segundos,  Exemplo => 10s ou 10S = 10 Segundos");
            Console.WriteLine("M = Minutos, Exemplo => 10m ou 10M = 10 Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar ?");

            string? data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multplier = 1;    

            if(type == 'm'){
                multplier += 60;
            }
            if (type == 0) {
                System.Environment.Exit(0); 
            } 

           PreStart(time * multplier);           
        }    

        static void Start(int time)
        {
            int currentTime = 0 ;
             
            while(currentTime != time)
            {
                Console.Clear();
                currentTime +=1;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            } 
            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado");      
            Thread.Sleep(1500);
            Menu();
        }         
    }
}